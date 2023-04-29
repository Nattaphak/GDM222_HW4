class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<int> nodes = new List<int>();
        for(int i = 0; i <= 0; )
        {
            int node1 = int.Parse(Console.ReadLine());
            if(node1 >= n || node1 < 0)
            {
                i++;
            }
            int node2 = int.Parse(Console.ReadLine());
            if(node2 >= n || node2 < 0)
            {
                break;
            }
            if(node1 == node2)
            {
                i++;
            }
            else
            {
                nodes.Add(node1);
                nodes.Add(node2);
            }
        }

        HashSet<int> Check = new HashSet<int>();
        foreach (int node in nodes) 
        {
            Check.Add(node % n);
        }
        int Symbols = Check.Count - 2;
        Console.WriteLine("Ans: {0}",Symbols);
    }
}
