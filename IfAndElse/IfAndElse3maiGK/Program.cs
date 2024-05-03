namespace IfAndElse3maiGK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis on sinu nimi?");

            string name = Console.ReadLine();

            //! e hüüumärk tähendab eitust
            //null tähendab tühja väärtust e mitte midagi
            if (name != null)
            {
                Console.WriteLine("Sisestasid enda nime:");
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("ei sisestanud enda nime");
            }
        }
    }
}
