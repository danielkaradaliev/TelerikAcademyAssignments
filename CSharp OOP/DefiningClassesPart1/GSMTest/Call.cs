namespace MobilePhone
{
    using System;

    public class Call
    {
        private DateTime dateTime;
        private string phoneNumber;
        private int time;

        public Call(DateTime dateTime, string phoneNumber, int time)
        {
            this.DateTime = dateTime;
            this.PhoneNumber = phoneNumber;
            this.Time = time;
        }

        public DateTime DateTime
        {
            get { return this.dateTime; }
            set { this.dateTime = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public int Time
        {
            get { return this.time; }
            set { this.time = value; }
        }
       
        public override string ToString()
        {
            return string.Format(
                "DateTime:{0}\n" +
                "Phone number:{1}\n" +
                "Talk duration:{2}",
                this.dateTime,
                this.phoneNumber, 
                this.time);
        }
    }
}
