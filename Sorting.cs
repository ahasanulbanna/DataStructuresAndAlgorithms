using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithmsPractices
{
    public class Sorting
    {
        public void arraySort()
        {
            int[] arr = new int[] {4,3,1,2 };
            int team=0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        team = arr[i];
                        arr[i] = arr[j];
                        arr[j] = team;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.Read();
        }
    }
}
