using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ht_and_practise_job
{
    internal class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector() 
            : this(0, 0) { }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public double Length
        {
            get { return Math.Sqrt(X * X + Y * Y); }
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + a.X, b.Y + b.Y);
        }
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - a.X, b.Y - b.Y);
        }

        public static Vector operator *(Vector v, double num)
        {
            return new Vector(v.X * num, v.Y * num);
        }

        public static double operator *(Vector a, Vector b) 
        {
            return a.X * b.X + a.Y * b.Y;
        }

        public static bool operator ==(Vector a, Vector b)
        {
            return a.X == b.X && a.Y == b.Y;
        }

        public static bool operator !=(Vector a, Vector b)
        {
            return !(a == b);
        }

         
    }
}
