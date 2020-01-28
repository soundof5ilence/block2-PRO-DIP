//parent.cs\
using System; 
namespace classAssignment{
    public class Parent : Person
    {
         public Parent(string name, string message) : base(name){
           
            Console.WriteLine("Your the parent of " + message);
        }
    }
 }