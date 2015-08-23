namespace MobilePhone
{
    using System;
    using MobilePhone;

    public class GSMTest
    {
        public static void GSMTesting()
        {
            GSM test1 = new GSM("6303", "Nokia", 80, "Ivan");
            GSM test2 = new GSM("CoreDuos", "Samsung", 360, "Koicho");
            GSM test3 = new GSM("WildFire", "HTC", 150, "Ivan", new Battery(BatteryType.LiIon));
            GSM test4 = new GSM("A60", "Siemens", 18, "Stamat", new Battery(BatteryType.NiCd, 72, 4));

            GSM[] tests = { test1, test2, test3, test4 };

            foreach (var item in tests)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            Console.WriteLine(GSM.IPhone4S);
        }

        public static void GSMCallHistoryTest()
        {
            GSM testCalls = new GSM("WildFire", "HTC", 150, "Ivan", new Battery(BatteryType.LiIon));

            testCalls.AddCall(new DateTime(2015, 7, 26, 15, 15, 26), "+359889653420", 88);
            testCalls.AddCall(new DateTime(2015, 7, 26, 16, 16, 16), "+359824568420", 64);
            testCalls.AddCall(new DateTime(2015, 7, 26, 15, 31, 59), "+359862487258", 1360);
            testCalls.AddCall(new DateTime(2015, 7, 26, 16, 0, 10), "+359883426864", 366);

            Console.WriteLine("Call history");

            foreach (var item in testCalls.CallHistory)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Total price for all calls:{0}", testCalls.CallPrice((decimal)0.37));
            Console.WriteLine();
            Console.WriteLine("After removing the longest call...");

            int longestIndex = 0;
            int time = 0;

            for (int i = 0; i < testCalls.CallHistory.Count; i++)
            {
                if (testCalls.CallHistory[i].Time > time)
                {
                    time = testCalls.CallHistory[i].Time;
                    longestIndex = i;
                }
            }

            testCalls.DeleteCall(longestIndex);

            foreach (var item in testCalls.CallHistory)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Total price of call history:{0}", testCalls.CallPrice(0.37m));
            Console.WriteLine("Deleting the call history...");
            testCalls.CallHistoryClear();
            Console.WriteLine();
            Console.WriteLine("Call history:");

            foreach (var item in testCalls.CallHistory)
            {
                Console.WriteLine(item);
            }
        }
    }
}