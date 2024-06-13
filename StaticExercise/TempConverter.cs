using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    static  class TempConverter
    {
        public static double FarenheittoCelsius(double numbers) 
        {

            return (numbers - 32) / 1.8;



        }
        public static double CelsiusToFahrenheit(double numbers) 
        {


            return numbers * 1.8 + 32;


        }


    }
}
