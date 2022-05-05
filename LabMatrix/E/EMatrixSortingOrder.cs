using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.LabMatrix.E
{
    public class EMatrixSortingOrder : IMatrixSortingOrder
    {
        void IMatrixSortingOrder.Order(Matrix matrix)
        {
            matrix.Elements[0].Sort();
            matrix.Elements[1] = matrix.Elements[1].OrderByDescending(x => x).ToList();
            matrix.Elements[2].Sort();
            matrix.Elements[3] = matrix.Elements[1].OrderByDescending(x => x).ToList();
        }
    }
}
