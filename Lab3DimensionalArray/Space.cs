using System;
using System.Collections.Generic;
using Task1.LabMatrix;

namespace Task1.Lab3DimensionalArray
{
    public class Space
    {
        public readonly List<Matrix> Matrices = new();

        public Space(int size)
        {
            for (int i = 0; i < size; ++i)
            {
                Matrices.Add(new Matrix(size));
            }
        }

        public void FillWithRandom() => Matrices.ForEach(matrix => matrix.FillWithRandom());

        public void Show() => Matrices.ForEach(matrix => matrix.ShowAll());
    }
}
