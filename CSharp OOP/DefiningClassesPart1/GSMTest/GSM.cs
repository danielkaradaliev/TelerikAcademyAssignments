namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GSM
    {
        private static readonly GSM iPhone4S = new GSM("IPhone4S", "Apple", 1000, "Petko", new Battery(BatteryType.LiIon, 20, 16), new Display(3.5, 16));
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery)
            : this(model, manufacturer, price, owner)
        {
            this.Battery = battery;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner, battery)
        {
            this.Display = display;
            this.callHistory = new List<Call>();
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }

        public string Model
        {
            get 
            { 
                return this.model; 
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name length must be longer than 0");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get 
            { 
                return this.manufacturer;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name length must be longer than 0");
                }

                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get 
            {
                return this.price; 
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price must be bigger than 0");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public Battery Battery
        {
            get { return this.battery; }
            private set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public override string ToString()
        {
            return string.Format(
                "Model:{0}\n" +
                "Manufacutrer:{1}\n" +
                "Price:{2}\nOwner:{3}\n" +
                "Battery:\n{4}\n" +
                "Display:\n{5}",
                 this.model,
                 this.manufacturer,
                 this.price,
                 this.owner,
                 this.battery,
                 this.display);
        }

        public void AddCall(DateTime datetime, string phoneNumber, int time)
        {
            this.CallHistory.Add(new Call(datetime, phoneNumber, time));
        }

        public void DeleteCall(int position)
        {
            this.callHistory.RemoveAt(position);
        }

        public void CallHistoryClear()
        {
            this.callHistory.Clear();
        }

        public decimal CallPrice(decimal pricePerMinute)
        {
            int priceCalls = 0;

            foreach (var item in this.callHistory)
            {
                priceCalls += item.Time;
            }

            return (priceCalls / 60) * pricePerMinute;
        }
    }
}
