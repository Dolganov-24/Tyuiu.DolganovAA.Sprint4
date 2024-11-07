using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DolganovAA.Sprint4.Task0.V27.Lib
{
    public class DataService : ISprint4Task0V27
    {
        public int GetMultOddArrEl(int[] array)
        {
            int product = 1;
            bool Odd = false;

            foreach (int number in array)
            {
                if (number % 2 != 0)
                {
                    product *= number;
                    Odd = true; 
                }
            }

            return Odd ? product : 0;
        }
    }
}
