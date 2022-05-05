using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.LabArrays.B
{
    public class WaveArraySorting : IArraySortingOrder
    {
        void IArraySortingOrder.Order(List<int> array)
        {
            var sortedArray = new List<int>(array);
            sortedArray.Sort();

            for (int i = 0, back = array.Count - 1, start = 0; i < array.Count; ++i)
            {
                bool isEven = i % 2 == 0;
                int j = isEven ? back : start;

                if (isEven)
                {
                    back--;
                }
                else
                {
                    start++;
                }

                array[i] = sortedArray[j];
            }
        }
    }
}
