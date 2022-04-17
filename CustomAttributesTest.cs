/*2)	Define a SoftwareAttribute which is having its base class as “Attribute” with following private members:
	String ProjectName.
	String Description.
	String ClientName.
	String StartedDate.
	String EndDate.
a)	Write properties for all these members
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Project8
{
    public class CustomAttributesTest
    {
        static void Main()
        {
            
            var types = from t in Assembly.GetExecutingAssembly().GetTypes()
                        where t.GetCustomAttributes<ClientAttribute>().Count() > 0
                        select t;
                
            foreach(var  type in types)
            {
                //Name Of the class
                Console.WriteLine(type.Name);
                //Getting Properties List 
                foreach (var t in type.GetProperties())
                {
                    Console.WriteLine("These  are properties present in the classs : {0}",t.Name);
                }
            }
        }
    }
     [AttributeUsage(AttributeTargets.Class)]
     /*CustomAttribute*/
    public class ClientAttribute : Attribute
    {
        private string ProjectName { get; set; }
        private string Descripition { get; set; }
    }
    
    [Client]
    public class SoftwareAttributes
    {
       
        public string ProjectName { get; set; }
        public string Descripition { get; set; }
        public string ClientName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
