/*2b)	Design a simple Console Application for testing refection concept of .NET Framework:
	Define SoftwareAttribute as Custom Attribute
	Write two classes HDFCAccount, ICICIAccount Apply
SoftwareAttribute to these classes.
	Write Test class which will read attributes applied on each classes using reflection technique.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Project8
{
    public class BankingUsingReflection
    {
        static void Main()
        {

            var types = from t in Assembly.GetExecutingAssembly().GetTypes()
                        where t.GetCustomAttributes<ClientAttribute>().Count() > 0
                        select t;

            foreach (var type in types)
            {
                /*Name Of the class*/
                Console.WriteLine("This is the {0} Bank Class : ",type.Name);

                /*Getting Properties List */
                foreach (var t in type.GetProperties())
                {
                    Console.WriteLine("These  are properties present in the {1} classs : {0}", t.Name,type.Name);
                }
            }
        }
    }
    [AttributeUsage(AttributeTargets.Class)]

    /*CustomAttribute*/
    public class CustomAttribute : Attribute
    {
        private string ProjectName { get; set; }
        private string Descripition { get; set; }
    }
    [Custom]
    public class Hdfc
    {

        public string Hdfc_Id { get; set; }
        public string Hdfc_AccountNumber { get; set; }
        public string Location { get; set; }
        public string Hdfc_AccountBalance { get; set; }
    }
    [Custom]
    public class Icici
    {
        public string Icici_Id { get; set; }
        public string Icici_AccountNumber { get; set; }
        public string Location { get; set; }
        public string Icici_AccountBalance { get; set; }
    }
}
