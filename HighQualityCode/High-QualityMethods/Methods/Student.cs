namespace Methods
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string otherInfo;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.NameValidator(value, "First Name ");

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.NameValidator(value, "Last Name ");

                this.lastName = value;
            }
        }

        public string OtherInfo
        {
            get
            {
                return this.otherInfo;
            }

            set
            {
                this.otherInfo = value;
            }
        }

        public bool IsOlderThan(Student anotherStudent)
        {
            DateTime firstDate =
                DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
            DateTime secondDate =
                DateTime.Parse(anotherStudent.OtherInfo.Substring(anotherStudent.OtherInfo.Length - 10));

            bool output = firstDate > secondDate;

            return output;
        }

        private void NameValidator(string value, string field)
        {
            if (value == null)
            {
                throw new ArgumentNullException(string.Format("{0} cannot be null", field));
            }

            if (value.Length <= 3)
            {
                throw new ArgumentOutOfRangeException(string.Format("{0} should contain more than 3 symbols", field));
            }
        }
    }
}
