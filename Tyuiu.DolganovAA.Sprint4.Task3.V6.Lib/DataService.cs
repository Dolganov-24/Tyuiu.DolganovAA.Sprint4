using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DolganovAA.Sprint4.Task3.V6.Lib

{
    public class DataService : ISprint4Task3V6
    {
        public int Calculate(int[,] array)
        {
            int MaxNum = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                if (array[1, i] > MaxNum)
                {
                    MaxNum = array[1, i];
                }
            }
            return MaxNum;
        }
    }
}