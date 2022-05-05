using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Lab3DimensionalArray.OY
{
    public class SpaceYSortingOrder : SpaceSortingOrder
    {
        protected override Position TransformPosition(int z, int y, int x)
        {
            return new Position(z, x, y);
        }
    }
}
