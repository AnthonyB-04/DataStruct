using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.LabArrays.A
{
    public class ArraySortingFromCentreByAscending : ArraySortingFromCentre
    {
        protected override int GetOrderedValue(List<int> sortedArray, int i)
        {
            return sortedArray[i];
        }
    }
}
