using System;

namespace Lab3.Model
{
    public class CommonTimeCartModel : CartModel, ITimeCartModel
    {
        public int times { get; set; }

        public CommonTimeCartModel()
        {
        }

    
        public override void Withdraw()
        {
            if (this.HasAccess())
            {
                this.passAmount++;
                this.times--;
            }
            else
            {
                this.declineAmount++;
            }
        }

        public override bool HasAccess()
        {
            return this.times > 0 && base.blocked == false;
        }
    }
}
