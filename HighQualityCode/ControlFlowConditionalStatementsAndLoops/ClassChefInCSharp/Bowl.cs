namespace ClassChefInCSharp
{
    using System.Collections.Generic;

    public class Bowl
    {
        private List<Vegetable> vegetables = new List<Vegetable>();

        public Bowl()
        {
            this.vegetables = new List<Vegetable>();
        }

        public List<Vegetable> Vegetables
        {
            get
            {
                return this.vegetables;
            }
        }

        public void AddVegetable(Vegetable vegetable)
        {
            this.Vegetables.Add(vegetable);
        }

        public override string ToString()
        {
            string result = "Used vegetables: " + string.Join(", ", this.vegetables) + ";";

            return result;
        }
    }
}
