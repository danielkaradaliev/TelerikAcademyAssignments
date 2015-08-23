namespace ClassSizeInCSharp
{
    using System;

    public class Size
    {
        private double width;
        private double heigth;

        public Size(double width, double heigth)
        {
            this.Width = width;
            this.Heigth = heigth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.width = value;
            }
        }

        public double Heigth
        {
            get
            {
                return this.heigth;
            }

            set
            {
                this.heigth = value;
            }
        }

        public static Size GetRotatedFigure(Size s, double angleOfTheFigure)
        {
            var rotatedWidth = (Math.Abs(Math.Cos(angleOfTheFigure)) * s.width) +
                    (Math.Abs(Math.Sin(angleOfTheFigure)) * s.heigth);

            var rotatedHeigth = (Math.Abs(Math.Sin(angleOfTheFigure)) * s.width) +
                    (Math.Abs(Math.Cos(angleOfTheFigure)) * s.heigth);

            return new Size(rotatedWidth, rotatedHeigth);
        }
    }
}
