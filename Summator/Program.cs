namespace Summator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1test) =>
            //Console.WriteLine("Сумата е равна на: " + Summator.Sum(new int[] { 1, 2, 3 }));
            //We call the class Summator to test the method Sum with new integer numbers (those in the array-{ 1, 2, 3 });


            //2test) => 
            //Summator.Test_SumTwoNumbers();
            //Calls class Summator and tests 

            //3tets => method Avarage
            Console.WriteLine("The average is:" + Summator.Average(new int[] { 4, 5, 7 }));

          




        }
    }
}