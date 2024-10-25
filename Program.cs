// See https://aka.ms/new-console-template for more information

using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /* byte number = 2;
             int count = 10;
             float totalPrice = 20.95f;
             char character = 'A';
             string firstName = "max";
            bool isWorking = true;*/

            // const float pi = 3.14f;
            /*  try 
            {

              var number = "12345";
              byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
             {
            Console.WriteLine("the number could not be converted");
            }
            // Console.WriteLine("number");
            // Console.WriteLine("count");
            // Console.WriteLine("totalPrice");
            // Console.WriteLine("character");
            // Console.WriteLine("firstName");
            // Console.WriteLine("isWorking");
            // Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            // Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            */
            var a = 2;
            var b = 3;
            var c = 4;
            Console.WriteLine((a + b ) * c);
             Console.WriteLine(a < b);
             Console.WriteLine(a > b);
             Console.WriteLine(a == b);
             Console.WriteLine(a <= b);
             Console.WriteLine(a >= b);
             Console.WriteLine(a !< b);
             Console.WriteLine(c > b && c > a);
             Console.WriteLine(c > b && c == a);
             Console.WriteLine(c > b || c == a);
             Console.WriteLine(!(c > b || c == a));

            
            
        }
        
    }
}
