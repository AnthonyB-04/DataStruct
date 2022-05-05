﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.LabMatrix
{

    public class MatrixLab : ILab
    {
        private readonly IMatrixSortingOrder _matrixSortingOrder;

        public MatrixLab(IMatrixSortingOrder matrixSortingOrder)
        {
            _matrixSortingOrder = matrixSortingOrder;
        }

        void ILab.Start()
        {
            var matrix = new Matrix(7);
            var minMaxAlgorithm = new MinMaxAlgorithm();

            matrix.FillWithRandom();
            matrix.ShowAll();

            _matrixSortingOrder.Order(matrix);
            MinMax minMax = minMaxAlgorithm.Evaluate(matrix);

            Console.WriteLine($"{minMax.Min} {minMax.Max}\n");
            matrix.ShowAll();
        }
    }
}
