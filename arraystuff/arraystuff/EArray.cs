using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraystuff
{
    class EArray
    {
        private double[] numericValue;


        public void Add(double n)
        {
            // 1. check if numrecValue has any elements. 
            // if yes
                  // a. create new array with size = numercicValue.Lenght + 1
                  // b. copy all elements from numericValue to new array
                  // c. put n in the last spot
             // if no
                  // a. instantiate numericValues with size 1
                  // b. add n to numericValues first spot

            if (this.numericValue == null)
            {
                numericValue = new double[1];
                numericValue[0] = n; 
            } else
            {
                double[] newArray = new double[numericValue.Length + 1];
                for (int i = 0; i < numericValue.Length; i++)
                {
                    newArray[i] = numericValue[i];
                }
                newArray[newArray.Length - 1] = n;
                numericValue = newArray;
            }
        }

        public void Delete(int ind)
        {
            double[] newArray = new double[numericValue.Length - 1];
            for (int i = 0; i < numericValue.Length; i++)
            {

                if (i < ind)
                {
                    newArray[i] = numericValue[i];
                } else if (i > ind)
                {
                    newArray[i - 1] = numericValue[i];
                }
            }

            numericValue = newArray;

        }

        public void PrintArray()
        {
            for (int i = 0; i < numericValue.Length; i++)
            {
                Console.WriteLine(numericValue[i]);
            }
        }
    }
}
