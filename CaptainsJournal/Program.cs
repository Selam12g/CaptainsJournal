using System;
using System.IO;

namespace CaptainsJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            string filename = DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
            StreamWriter writer = new StreamWriter(filename);

            
                Console.WriteLine("Enter 'start' to begin writing in the Captain's journal.");
            line = Console.ReadLine();
            while (line != "start")
            {
                line = Console.ReadLine();
            }

            Console.WriteLine("Enter your lines of text. Enter 'stop' to end.");
            line = Console.ReadLine();
            while (line != "stop")
            {
                writer.WriteLine(line);
                line = Console.ReadLine();
            }

            writer.WriteLine("Captain's log");
            writer.WriteLine("Stardate " + DateTime.Now.ToString("dd-MM-yyyy"));
            writer.WriteLine("Jean-Luc Picard");
            writer.Close();

            Console.WriteLine("The Captain's journal has been saved as " + filename);
        }
    }
}



