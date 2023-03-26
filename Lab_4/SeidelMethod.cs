using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class SeidelMethod
    {
        public double[,] SystemMatrix { get; set; }
        public double[] FreeMembersColumn { get; set; }
        public SeidelMethod(double[,] systemMatrix, double[] freeMembersColumn)
        {
            SystemMatrix = systemMatrix;
            FreeMembersColumn = freeMembersColumn;
        }
        public double[] GetResult()
        {
            double[] result = { 0, 0, 0 };

            for (int k = 1; k <= 3; k++)
            {
                for (int i = 0; i < 3; i++)
                {
                    double sum = 0;

                    for (int j = 0; j < 3; j++)
                    {
                        if (j != i)
                        {
                            sum += SystemMatrix[i, j] * result[j];
                        }
                    }

                    result[i] = (FreeMembersColumn[i] - sum) / SystemMatrix[i, i];
                }
            }

            return result;
        }
    }
}
