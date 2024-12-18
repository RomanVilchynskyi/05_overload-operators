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

        public static explicit operator double(Vector v)
        {
            return v.Length; 
        }

        public static implicit operator Vector(double value)
        {
            return new Vector(value, 0); 
        }

        public static Vector operator -(Vector v)
        {
            return new Vector(-v.X, -v.Y);
        }

        public static Vector operator ++(Vector a)
        {
            return new Vector(a.X + 1, a.Y + 1);
        }

        public static Vector operator --(Vector a)
        {
            return new Vector(a.X - 1, a.Y - 1);
        }

        public static bool operator true(Vector a)
        {
            return a.X != 0 || a.Y != 0;
        }

        public static bool operator false(Vector a)
        {
            return a.X == 0 && a.Y == 0;
        }


    }
}
