using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("data.txt");
            int dim = int.Parse(lines[0]);
            double[] vec = Array.ConvertAll(lines[1].Split(' '), double.Parse);
            double[,] matrix = new double[dim, dim];
            for (int i = 0; i < dim; i++)
            {
                string[] row = lines[i + 2].Split(' ');
                for (int j = 0; j < dim; j++)
                {
                    matrix[i, j] = double.Parse(row[j]);
                }
            }
                
        }
    }
}
