﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DolganovAA.Sprint4.Task1.V7.Lib
{
    public class DataService : ISprint4Task1V7
    {
        public int Calculate(int[] array)
        {
            int s = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    s += array[i];
                }
            }
            return s;
        }
    }
}
