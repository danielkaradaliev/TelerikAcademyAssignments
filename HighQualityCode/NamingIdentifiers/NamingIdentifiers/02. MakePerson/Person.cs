namespace _02.MakePerson
{
    public class Person
    {
        public Gender Gender { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void MakePerson(int age)
        {
            var newPerson = new Person();
            newPerson.Age = age;

            if (age % 2 == 0)
            {
                newPerson.Name = "Batkata";
                newPerson.Gender = Gender.Male;
            }
            else
            {
                newPerson.Name = "Maceto";
                newPerson.Gender = Gender.Female;
            }
        }
    }
}
