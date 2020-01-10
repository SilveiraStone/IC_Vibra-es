﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IcVibrations.Core.Calculator.ArrayOperations
{
    public class ArrayOperation : IArrayOperation
    {
        public double[] AddValues(double[] array, int[] position, double[] value)
        {
            for (int i = 0; i < position.Length; i++)
            {
                array[position[i]] = value[i];
            }

            return array;
        }

        public double[] Create(double value, int size)
        {
            double[] newArray = new double[size];

            for (int i = 0; i < size; i++)
            {
                newArray[i] = value;
            }

            return newArray;
        }

        public double[,] InverseMatrix(double[,] matrix)
        {
            if(matrix.GetLength(0) != matrix.GetLength(1))
            {
                throw new Exception("It is just possible to inverse a qudratic matrix.");
            }

            int n = matrix.GetLength(0);
            double[,] matrizInv = new double[n, n];
            double pivot, p;
            int i, j, k, l;

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        matrizInv[i, j] = 1;
                    }
                    else
                    {
                        matrizInv[i, j] = 0;
                    }
                }
            }

            // Triangularization
            for (i = 0; i < n; i++)
            {
                pivot = matrix[i, i];

                for (l = 0; l < n; l++)
                {
                    matrix[i, l] = matrix[i, l] / pivot;
                    matrizInv[i, l] = matrizInv[i, l] / pivot;
                }

                for (k = i + 1; k < n; k++)
                {
                    p = matrix[k, i];

                    for (j = 0; j < n; j++)
                    {
                        matrix[k, j] = matrix[k, j] - (p * matrix[i, j]);
                        matrizInv[k, j] = matrizInv[k, j] - (p * matrizInv[i, j]);
                    }
                }
            }

            // Retrosubstitution
            for (i = n - 1; i >= 0; i--)
            {
                for (k = i - 1; k >= 0; k--)
                {
                    p = matrix[k, i];

                    for (j = n - 1; j >= 0; j--)
                    {
                        matrix[k, j] = matrix[k, j] - (p * matrix[i, j]);
                        matrizInv[k, j] = matrizInv[k, j] - (p * matrizInv[i, j]);
                    }
                }
            }

            return matrizInv;
        }

        public double[,] Multiply(double[,] array1, double[,] array2)
        {
            int rows1 = array1.GetLength(0);
            int columns1 = array1.GetLength(1);
            int rows2 = array2.GetLength(0);
            int columns2 = array2.GetLength(1);

            if(columns1 != rows2)
            {
                throw new Exception("Error in multiplication operation.");
            }

            double[,] arrayMultiplication = new double[rows1, columns2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < columns1; j++)
                {
                    double sum = 0;

                    for (int k = 0; k < columns1; k++)
                    {
                        sum += array1[i, k] * array2[k, j];
                    }

                    arrayMultiplication[i, j] = sum;
                }
            }

            return arrayMultiplication;
        }

        public double[,] Subtract(double[,] array1, double[,] array2)
        {
            int rows1 = array1.GetLength(0);
            int columns1 = array1.GetLength(1);
            int rows2 = array2.GetLength(0);
            int columns2 = array2.GetLength(1);

            if(rows1 != rows2 || columns1 != columns2)
            {
                throw new Exception("Can't subtract matrixes with differents sizes.");
            }

            double[,] arraySubtraction = new double[rows1, columns1];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < columns1; j++)
                {
                    arraySubtraction[i, j] = array1[i, j] - array1[i, j];
                }
            }

            return arraySubtraction;
        }

        public double[,] Sum(double[,] array1, double[,] array2)
        {
            int rows1 = array1.GetLength(0);
            int columns1 = array1.GetLength(1);
            int rows2 = array2.GetLength(0);
            int columns2 = array2.GetLength(1);

            if (rows1 != rows2 || columns1 != columns2)
            {
                throw new Exception("Can't sum matrixes with differents sizes.");
            }

            double[,] arraySum = new double[rows1, columns1];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < columns1; j++)
                {
                    arraySum[i, j] = array1[i, j] + array1[i, j];
                }
            }

            return arraySum;
        }
    }
}