using System;
using static System.Math;

namespace Graph_Algorithms
{
    class Vector
    {
        int i; //horizontal
        int j; //vertical

        public Vector(int i, int j)
        {
            this.i = i;
            this.j = j;
        }

        public double Distance()
        {
            double x = Math.Pow(this.i, 2) + Math.Pow(this.j, 2);
            double distance = Math.Sqrt(x);
            return distance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector vec1 = new Vector(2, 4);
            Console.WriteLine(vec1.Distance());
        }
    }
}
