using System;


namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.add("A");
            list.add("B");
            list.add("C");
            list.add("D");
            list.add("E");
            list.add("F");
            list.add("G");

            Node node = list.getRoot();
            for (int i = 0; i < list.getSize(); i++)
            {
                Console.Write(node.getValue());
                node = node.getNext();
            }

            Console.Write("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
