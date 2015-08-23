namespace MobilePhone
{
    using System;

    public class Battery
    {
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType type;

        public Battery()
        {
        }

        public Battery(BatteryType type)
        {
            this.type = type;
        }

        public Battery(BatteryType type, int hoursIdle, int hoursTalk)
        {
            this.type = type;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public int HoursIdle
        {
            get 
            { 
                return this.hoursIdle;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours idle must be over or equal to 0");
                }

                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get 
            { 
                return this.hoursTalk;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours talk must be over or equal to 0");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public override string ToString()
        {
            return string.Format(
                "Battery type:{0}\n" +
                "Hours idle:{1}\n" +
                "Hours talk:{2}",
                this.type,
                this.hoursIdle, 
                this.hoursTalk);
        }
    }
}