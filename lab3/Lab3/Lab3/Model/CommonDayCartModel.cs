using System;

namespace Lab3.Model
{
    public class CommonDayCartModel : CartModel, IDayCartModel
    {
        public int amountDays { get; set; }
        public DateTime startDayTime { get; set; }

        public CommonDayCartModel()
        {
            this.startDayTime = DateTime.Now; 
        }

        public override void Withdraw()
        {
            if (this.HasAccess())
            {
                this.passAmount++;
            }
            else
            {
                this.declineAmount++;
            }
        }

        public override bool HasAccess()
        {
            if (this.blocked == true)
            {
                return false;
            }

            DateTime currentDayTime = DateTime.Now;
            DateTime endDayTime = this.startDayTime.AddDays(this.amountDays);
            int result = DateTime.Compare(endDayTime, currentDayTime);
            return result > 0;
        }
    }
}
