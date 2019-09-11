using System;
using System.Collections.Generic;
using System.Text;

namespace SolarCalc
{
    public class Calc
    {
        public static double rad(double degree)
        {
            double rad = Math.PI * degree / 180.0;

            return rad;
        }


        public static double degree(double rad)
        {
            double degree = rad * 180.0 / Math.PI;

            return degree;
        }

        public static string compare (string longNum, string shortNum)
        {
            for (int i = 0; i < shortNum.Length;) 
            {
                if (shortNum[i] == longNum[i])
                {
                    i++;
                }
                else
                {
                    return longNum;
                }
            }

            longNum = shortNum;

            return longNum;
        }
    }
}
