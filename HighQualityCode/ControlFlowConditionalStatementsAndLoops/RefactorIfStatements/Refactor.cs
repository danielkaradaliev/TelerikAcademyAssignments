namespace RefactorIfStatements
{
    using System;

    public class Refactor
    {
        public const double MIN_X = 1;
        public const double MAX_X = 10;
        public const double MIN_Y = 1;
        public const double MAX_Y = 10;

        public static void Main()
        {
            bool peeled = true;
            bool rotten = true;

            // if (potato != null)
            //    if (!potato.HasNotBeenPeeled && !potato.IsRotten)
            //        Cook(potato);
            if (IsPotatoForCooking(peeled, rotten))
            {
                Console.WriteLine("Potato is ready for cooking");
            }
            else
            {
                Console.WriteLine("Potato is either missing, not peeled, or rotten!");
            }

            // if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && !shouldNotVisitCell)))
            // {
            //    VisitCell();
            // }
            double x = 5;
            double y = 1.1;
            bool shoudVisitCell = true;

            if (shoudVisitCell && InRange(x, y))
            {
                VisitCell();
            }
        }

        public static bool IsPotatoForCooking(bool peeled, bool rotten)
        {
            if (peeled && !rotten)
            {
                return true;
            }

            return false;
        }

        public static bool InRange(double x, double y)
        {
            if (MIN_X <= x && x <= MAX_X &&
                MIN_Y <= y && y <= MAX_Y)
            {
                return true;
            }

            return false;
        }

        public static void VisitCell()
        {
            Console.WriteLine("Congratulations! You have found a hidden treasure on this cell!");
        }
    }
}
