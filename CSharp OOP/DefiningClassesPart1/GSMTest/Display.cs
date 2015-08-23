namespace MobilePhone
{
    using System;

    public class Display
    {
        private double sizeInInches;
        private int numberOfColours;

        public Display()
        {
        }

        public Display(double size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColours = numberOfColors;
        }

        public double Size
        {
            get
            { 
                return this.sizeInInches; 
            }

            set
            {
                if (this.sizeInInches < 0)
                {
                    throw new ArgumentException("Size must be greater than 0");
                }

                this.sizeInInches = value;
            }
        }

        public int NumberOfColours
        {
            get
            {
                return this.numberOfColours; 
            }

            set
            {
                if (this.numberOfColours < 0)
                {
                    throw new ArgumentException("Number of colours must be greater than 0");
                }

                this.numberOfColours = value;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "Size:{0} inches\n" +
                "Number of colours:{1}",
                this.sizeInInches, 
                this.numberOfColours);
        }
    }
}
