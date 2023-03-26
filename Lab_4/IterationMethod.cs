using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class IterationMethod
    {
        public double[,] SystemMatrix { get; set; }
        public double[] FreeMembersColumn { get; set; }
        public IterationMethod(double[,] systemMatrix, double[] freeMembersColumn)
        {
            SystemMatrix = systemMatrix;
            FreeMembersColumn = freeMembersColumn;
        }
        public double[] GetResult()
        {
            double[] result = { 0, 0, 0 };

            for (int i = 0; i < 3; i++)
            {
                double[] result_new = new double[3];

                for (int j = 0; j < 3; j++)
                {
                    double s = 0;

                    for (int k = 0; k < 3; k++)
                    {
                        if (j != k)
                        {
                            s += SystemMatrix[j, k] * result[k];
                        }
                    }

                    result_new[j] = (FreeMembersColumn[j] - s) / SystemMatrix[j, j];
                }

                result = result_new;
            }

            return result;
        }
    }
}
