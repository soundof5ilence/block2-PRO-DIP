using System;
using Name;
namespace scopes
{
    class Program
    {
        static void Main(string[] args)
        {
           class1 objectX = new class1();
           objectX.tekstOpenbaar += "gello there";
           class2 objectY = new class2(); 
            objectY.OpenbareFunctie();
            Console.WriteLine("variable in een namespace van een class " +objectY.getalOpenbaar);
            Console.WriteLine(objectX.tekstOpenbaar);
            objectY.varvoid();
            objectX.farfeched();
            
        }
    }
}
