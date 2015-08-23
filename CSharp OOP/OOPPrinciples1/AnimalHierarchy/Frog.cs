namespace AnimalHierarchy
{
    class Frog : Animal
    {
        //Constructor
        public Frog(int age, string name, Gender gender)
            : base(age, name, gender)
        {
            this.Type = Type.Frog;
        }

        public override string MakeSound()
        {
            return string.Format("{0} {1} says \"Kvak kvak!\"", this.Type, this.Name);
        }
    }
}
