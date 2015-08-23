namespace DevelopmentToolsDemos
{
    using System;
    using log4net;
    using log4net.Config;

    public class MainMethod
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(MainMethod));

        public static void Main()
        {
            XmlConfigurator.Configure();
            Log.Info("Info");


            int result = 0;

            for (int i = 0; i < 100000000; i++)
            {
                result += i;
            }

            Log.Info("Loop Compleated!");

            result = 0;
            int expectedResult = 5;
            
            while (result < expectedResult)
            {
                result++;
            }

            Log.Info("Operation compleated!");
            Log.InfoFormat("Expected result: {0}", expectedResult);
            Log.InfoFormat("Actual result: {0}", result);

            result = 0;
            int invalidDivider = 0;
            int someValue = 5;

            try
            {
                result = someValue / invalidDivider;
            }
            catch
            {
                Log.Error("Error!");
            }
            finally
            {
                int validDivider = invalidDivider + 1;
                result = someValue / validDivider;

                Log.Info("Error handled!");
            }
        }
    }
}
