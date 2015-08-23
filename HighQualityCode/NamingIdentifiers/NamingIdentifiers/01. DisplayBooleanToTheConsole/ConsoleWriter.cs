namespace _01.DisplayBooleanToTheConsole
{
    using System;

    class ConsoleWriter
    {
        public void WriteBooleanToTheConsole(bool variable)
        {
            string variableAsString = variable.ToString();
            Console.WriteLine(variableAsString);
        }
    }
}
