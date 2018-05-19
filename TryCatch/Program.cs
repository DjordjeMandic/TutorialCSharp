using System;

namespace TryCatch
{
    internal class Program
    {
        private static int[] brojevi = { 5, 0 };

        private static void Main(string[] args)
        {
            try
            {
                try // pokusavanje
                {
                    Console.WriteLine(brojevi[0] / brojevi[1]);
                }
                catch (Exception ex) // hvatanje greske
                {
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine("Pokusavam obrnuto deljenje.");
                    try // pokusavenje
                    {
                        Console.WriteLine(brojevi[1] / brojevi[0]);
                    }
                    catch (Exception ex1)
                    {
                        Console.WriteLine(ex1);
                    }
                }
                throw new Exception("Ovo je greska koju smo sami izazvali");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}