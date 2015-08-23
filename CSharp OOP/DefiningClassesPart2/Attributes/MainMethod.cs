//Problem 11. Version attribute
//Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds
//a version in the format major.minor (e.g. 2.11).
//Apply the version attribute to a sample class and display its version at runtime.

namespace Attributes
{
    using System;
    using System.Reflection;

    [VersionAttribute(0, 9)]
    public class MainMethod
    {
        [VersionAttribute(1, 1)]
        public static void Main()
        {
            GetAttribute(typeof(MainMethod));
        }

        [VersionAttribute(2, 1)]
        public static void GetAttribute(Type t)
        {
            VersionAttribute att;

            att = (VersionAttribute)Attribute.GetCustomAttribute(t, typeof(VersionAttribute));

            if (att == null)
            {
                Console.WriteLine("No attribute in class {0}.\n", t.ToString());
            }
            else
            {
                Console.WriteLine("The version of the class {0} is {1}.{2}", t.ToString(), att.Major, att.Minor);
            }

            MemberInfo[] MyMemberInfo = t.GetMethods();

            for (int i = 0; i < MyMemberInfo.Length; i++)
            {
                att = (VersionAttribute)Attribute.GetCustomAttribute(MyMemberInfo[i], typeof(VersionAttribute));
                if (att == null)
                {
                    Console.WriteLine("No attribute in member function {0}.\n", MyMemberInfo[i].ToString());
                }
                else
                {
                    Console.WriteLine("The version of the method {0} is {1}.{2}",
                        MyMemberInfo[i].ToString(), att.Major, att.Minor);
                }
            }
        }
    }
}
