﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DolganovAA.Sprint4.Task6.V2.Lib
{
    public class DataService : ISprint4Task6V0
    {
        public int Calculate(string[] array)
        {

            string[] mas = Array.FindAll(array, x => x.Length == 4);
            return mas.Length;
        }
    }
}