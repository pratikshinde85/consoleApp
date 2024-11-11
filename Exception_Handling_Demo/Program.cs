using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace  Exception_Handling_Demo
{


    public class Program{
        public static void Main(string[] args){


            int a , b ,c;
            try{

            
            Console.WriteLine("Enter the Number :");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number :");
            b=Convert.ToInt32(Console.ReadLine()) ;

            c = a/b;

            Console.WriteLine($"{a}+{b}={c}");
            }

            // catch(FormatException ex){
            //     Console.WriteLine(ex.Message);
            // }
            // catch(OverflowException ex){
            //     Console.WriteLine(ex.Message);
            // }
            catch(Exception ex){
                Console.WriteLine("Meassae : "+ex.Message);
                Console.WriteLine("Source: "+ex.Source);
                Console.WriteLine("StackTrace: "+ex.StackTrace);
                Console.WriteLine("target Site: "+ex.TargetSite);
            }

            finally{
                Console.WriteLine("This is Finally block : Tata BYE BYE");
            }
        }
    }
    
}