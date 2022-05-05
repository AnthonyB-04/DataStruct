using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.LabMatrix.A
{
    public class AMatrixSortingOrder : IMatrixSortingOrder
    {
        void IMatrixSortingOrder.Order(Matrix matrix)
        {
            matrix.Elements.First().Sort();
            matrix.Elements[1].Sort();

            matrix.Elements.Last().Sort();
        }
    }
}
