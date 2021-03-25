using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithmsPractices
{
    public class DuplicateChecker
    {
        public void arrDuplicateChecker()
        {
            string[] arr = new string[] { "a", "a", "d", "b" };
            int resultIndex = 0;
            int duplicateCount = 0;
            bool isDuplicate = false;

            for (int i = 0; i < arr.Length; i++)
            {
                isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        duplicateCount++;
                        break;
                    }
                }

                if (isDuplicate == false)
                {
                    arr[resultIndex] = arr[i];
                    resultIndex++;
                }
            }

            for (int i = 1; i <= duplicateCount; i++)
            {
                arr[arr.Length - i] = "0";
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
