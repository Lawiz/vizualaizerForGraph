/*
 *  ArborGVT - a graph vizualization toolkit
 *
 *  Physics code derived from springy.js, copyright (c) 2010 Dennis Hotson
 *  JavaScript library, copyright (c) 2011 Samizdat Drafting Co.
 *
 *  Fork and C# implementation, copyright (c) 2012,2016 by Serg V. Zhdanovskih.
 *  Fork and Java implementation, copyright (c) 2016 by Serg V. Zhdanovskih.
 */
package arborgvt;

/**
 *
 * @author Serg V. Zhdanovskih
 */
public class ArborEdge
{
    public ArborNode Source;
    public ArborNode Target;

    public double Length;
    public double Stiffness;
    public boolean Directed;

    public ArborEdge(ArborNode src, ArborNode tgt, double len, double stiffness)
    {
        this.Source = src;
        this.Target = tgt;
        this.Length = len;
        this.Stiffness = stiffness;
    }

    public ArborEdge(ArborNode src, ArborNode tgt, double len, double stiffness, boolean directed)
    {
        this(src, tgt, len, stiffness);
        this.Directed = directed;
    }
}
