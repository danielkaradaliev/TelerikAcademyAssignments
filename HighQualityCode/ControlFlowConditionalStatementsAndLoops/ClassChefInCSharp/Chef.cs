namespace ClassChefInCSharp
{
    using System;
    using System.Threading;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);

            Carrot carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);

            Bowl bowl = this.GetBowl();
            bowl.AddVegetable(potato);
            bowl.AddVegetable(carrot);

            Thread.Sleep(1000);
            Console.WriteLine("Cooking...");
            Thread.Sleep(5000);
            Console.WriteLine("Lunch is ready! Bon Appetit!");
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private void Cut(Vegetable vegetable)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Vegetable is cut!");
        }

        private void Peel(Vegetable vegetable)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Vegetable is peeled!", vegetable.GetType());
        }
    }
}
