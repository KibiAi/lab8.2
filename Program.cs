using lab8._2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть тип графіка (Line, Bar, Pie):");
        string graphType = Console.ReadLine();

        GraphFactory factory;
        switch (graphType)
        {
            case "Line":
                factory = new LineGraphFactory();
                break;
            case "Bar":
                factory = new BarGraphFactory();
                break;
            case "Pie":
                factory = new PieChartFactory();
                break;
            default:
                Console.WriteLine("Невідомий тип графіка");
                return;
        }

        Graph graph = factory.CreateGraph();
        graph.Draw();
    }
}