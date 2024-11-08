namespace Kingmaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string[]> buildings = FileReader.ReadFiles("C:\\Users\\perse\\Documents\\PersonalProjects\\Kingmaker\\Kingmaker_Buildings.txt");
            Console.WriteLine(buildings[0][0]);
            
            foreach (string[] building in buildings) 
            {

                Console.WriteLine(building);
                foreach (string line in building)
                {
                    Console.WriteLine(line);
                } 
                
            }
        }
    }
}
