﻿
namespace ArborGVT
{
    public class ArborEdge
    {
        public ArborNode Source;
        public ArborNode Target;

        public double Length;
        public double Stiffness;
        public bool Directed;

        public ArborEdge(ArborNode src, ArborNode tgt, double len, double stiffness)
            : this(src, tgt, len, stiffness, false)
        {
        }

        public ArborEdge(ArborNode src, ArborNode tgt, double len, double stiffness, bool directed)
        {
            this.Source = src;
            this.Target = tgt;
            this.Length = len;
            this.Stiffness = stiffness;
            this.Directed = directed;
        }
    }
}
