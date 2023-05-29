namespace ConsoleApp40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 5;
            string commandCloseProgram = "exit";
            string userInput;

            for (int i = 0; i < tryCount; i++)
            {
                Console.WriteLine("Команда для зыкрытия программы - \"exit\"");
                Console.Write("Введите команду для закрытия программы:");
                userInput = Console.ReadLine();

                if (commandCloseProgram == userInput)
                {
                    break;
                }
                else
                {
                    tryCount++;
                    Console.WriteLine("Попробуйте снова");
                }
            }
        }
    }
}