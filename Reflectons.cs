/*1)Write a console based application to dynamically load an assembly. 
 * Display the available types and their members. Prompt the user to invoke any method at runtime.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Project8
{
    public class Reflections
    {
      public  static void Main()
        {
            Type type = Type.GetType("Project8.Customer");
            Console.WriteLine("FUll NAME OF THE CLASS WITH NAMESPACE : {0} ", type.FullName);
            Console.WriteLine("");
            Console.WriteLine("NAME OF THE CLASS:{0}", type.Name);

            Console.WriteLine("Display the List Of Properties");
            Console.WriteLine("");
            PropertyInfo[] propertyInfos = type.GetProperties();
            foreach(var i in propertyInfos)
            {
                Console.WriteLine("Property Name :{0}",i.Name);
            }

            Console.WriteLine("Display the List Of Methods");
            Console.WriteLine("");
            MethodInfo[] methodInfos = type.GetMethods();
            foreach (var i in methodInfos)
            {
                Console.WriteLine("Method Name :{0}", i.Name);
            }

            Console.WriteLine("Display the List Of Constructors");
            Console.WriteLine("");
            ConstructorInfo[] constructorInfos= type.GetConstructors();
            foreach (var i in constructorInfos)
            {
                Console.WriteLine("Constructors Name :{0}", i.ToString());
            }
        }

    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer(int _Id,string _Name)
        {
            this.Id = _Id;
            this.Name = _Name;
        }
        public Customer()
        {
            this.Id = 101;
            this.Name ="Saikrishna";
        }
        public void PrintId()
        {
            Console.WriteLine("Customer ID {0}:", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Customer Name {0}:", this.Name);
        }
    }
}
