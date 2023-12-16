using Indexer.Models;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt list = new ListInt();
            list.Add(1,2,3,4);

            list.ForeachList();


        }
    }
}