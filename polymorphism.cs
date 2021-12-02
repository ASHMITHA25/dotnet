using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Myprogram
{
    class program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.display();
            obj.display("Method overloading");
            obj.display("Ashmitha,20");
            obj.display("20,Ashmitha");
        }
    }
    // creating a new class
    class MyClass
    {
        public void display()
        {
            Console.WriteLine("polymorphism");
        }
        // we can differentiate with passing data type as parameter
        public void display(string value)
        {
            Console.WriteLine(value);
        }
        // we can differentiate with no. of prameters
        public void display(string name, int age)
        // string int 
        {
            Console.WriteLine("I am" +name+" and my age is "+age);
        }
        /* we can differentiate with swapping the data type in parameters*/
        public void display(int age, string name)
        // int string
        {
            Console.WriteLine("I am" + age + " years old and my name is" +name);
        }
    }
}