using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._2
{
    public abstract class Graph
    {
        public abstract void Draw();
    }

    public class LineGraph : Graph
    {
        public override void Draw()
        {
            Console.WriteLine("Візуалізація лінійного графіка");
        }
    }

    public class PostGraph : Graph
    {
        public override void Draw()
        {
            Console.WriteLine("Візуалізація стовпчикового графіка");
        }
    }

    public class CircleChart : Graph
    {
        public override void Draw()
        {
            Console.WriteLine("Візуалізація кругової діаграми");
        }
    }

    public abstract class GraphFactory
    {
        public abstract Graph CreateGraph();
    }

    public class LineGraphFactory : GraphFactory
    {
        public override Graph CreateGraph()
        {
            return new LineGraph();
        }
    }

    public class BarGraphFactory : GraphFactory
    {
        public override Graph CreateGraph()
        {
            return new PostGraph();
        }
    }

    public class PieChartFactory : GraphFactory
    {
        public override Graph CreateGraph()
        {
            return new CircleChart();
        }
    }

}
