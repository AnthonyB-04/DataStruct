using System;
using Task1.Extensions;
using Task1.LabArrays;
using Task1.LabArrays.A;
using Task1.LabArrays.B;
using Task1.LabArrays.C;
using Task1.LabMatrix;
using Task1.LabMatrix.A;
using Task1.LabMatrix.B;
using Task1.LabMatrix.C;
using Task1.LabMatrix.D;
using Task1.LabMatrix.E;
using Task1.LabMatrix.F;
using Task1.Lab3DimensionalArray;
using Task1.Lab3DimensionalArray.OX;
using Task1.Lab3DimensionalArray.OY;
using Task1.Lab3DimensionalArray.OZ;
//using Task1.LabArrayManipulations;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ILab[] labs =
            {
                new ArraysLab(new ArraySortingFromCentreByAscending()),
                new ArraysLab(new ArraySortingFromCentreByDescending()),
                new ArraysLab(new WaveArraySorting()),
                new ArraysLab(new EvenIndexArraySorting()),

                new MatrixLab(new AMatrixSortingOrder()),
                new MatrixLab(new BMatrixSortingOrder()),
                new MatrixLab(new CMatrixSortingOrder()),
                new MatrixLab(new DMatrixSortingOrder()),
                new MatrixLab(new EMatrixSortingOrder()),
                new MatrixLab(new FMatrixSortingOrder()),

                new SpaceLab(new SpaceXSortingOrder()),
                new SpaceLab(new SpaceYSortingOrder()),
                new SpaceLab(new SpaceZSortingOrder()),
                
                new LabArrayManipulations()
            };

            labs.ForEach(lab => lab.Start());

            Console.ReadKey();
        }
    }
}
