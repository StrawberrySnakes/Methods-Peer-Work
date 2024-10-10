/* This code creates , methods for addition and subtraction
authors: Dessa Shapiro and Colin Moore  
Class:IGME.201.01 - Interac Des & Alg Prob Sol III
Due Date: 10/13/2024
*/
namespace MethodsTeam
{
    internal class Program
    {
        /// <summary>
        /// This Function Adds two parameters together
        /// </summary>
        /// <param int="a"></param>
        /// <param int="b"></param>
        /// <returns>a + b</returns>
        static int Add(int a, int b) {
            return a + b;
        }
        static void Main(string[] args)
        {
            int dessaFavoriteNumber;
            string dessaName = "Dessa";
            int colinFavoriteNumber;
            string firsttName = "Colin";

            //initalize
            dessaFavoriteNumber = 307;
            colinFavoriteNumber = 6;

            int Subtract(int a, int b)
            {
                return a - b;
            }

            //start of our actual program
            Console.WriteLine("Partner A is "+dessaName+ " and her favoite number is: "+dessaFavoriteNumber);
            Console.WriteLine("Partner B is " + firsttName + " and his favorite number is: "+ colinFavoriteNumber);

            //make var into addition of two numbers
            int addedNums = Add(dessaFavoriteNumber, colinFavoriteNumber);
            Console.WriteLine("When we add our favorite numbers together we get: " + addedNums);

            //Subtract numbers
            int subtractNum = Subtract(dessaFavoriteNumber,colinFavoriteNumber);
            Console.WriteLine("When we subtract our favorite numbers from each other we get: " + subtractNum);

        }
    }
}
