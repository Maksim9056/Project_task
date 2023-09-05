using System.Numerics;
using System.Net.Sockets;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {

        static Dictionary<string, Action<GlobalClass>> FDictCommands = new Dictionary<string, Action<GlobalClass>>();




        

        static void RegisterCommands()
        {
            try
            {
                Command command = new Command();
                FDictCommands.Add("001", new Action<GlobalClass>(command.CommandThefirst));
                FDictCommands.Add("002", new Action<GlobalClass>(command.CommandTheSecond));
                FDictCommands.Add("003", new Action<GlobalClass>(command.CommandTheFourth));
                FDictCommands.Add("004", new Action<GlobalClass>(command.CommandthedDouble));
                FDictCommands.Add("005", new Action<GlobalClass>(command.CommandTheFifth));
                FDictCommands.Add("006", new Action<GlobalClass>(command.CommandTheSixth));
                FDictCommands.Add("007", new Action<GlobalClass>(command.CommandthedSeventh));
                FDictCommands.Add("008", new Action<GlobalClass>(command.CommandthedEighth));
                FDictCommands.Add("009", new Action<GlobalClass>(command.CommandthedNinth));
                FDictCommands.Add("010", new Action<GlobalClass>(command.CommandthedTenth));
                //FDictCommands.Add("011", new Action<GlobalClass>(command.Registration_users));
                //FDictCommands.Add("012", new Action<GlobalClass>(command.Registration_users));
                //FDictCommands.Add("013", new Action<GlobalClass>(command.Registration_users));
                //FDictCommands.Add("014", new Action<GlobalClass>(command.Registration_users));
                //FDictCommands.Add("015", new Action<GlobalClass>(command.Registration_users));

            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }


        static void HandleCommand(string aCommand, GlobalClass cls)
        {
            Action<GlobalClass> actionCommand;
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            if (FDictCommands.TryGetValue(aCommand, out actionCommand)) actionCommand(cls);
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            else
            {
                Console.WriteLine($"Такой команды нет !");
                Console.WriteLine();
                Console.WriteLine($"Начать заново Y да N - нет");

                var Символ =Convert.ToChar(Console.ReadLine());

                switch (Символ)
                {
                    case 'Y':
                        Console.Clear();
                        ClientProcessing();

                        break;

                    case 'N':
                        Console.WriteLine($"Досвидания !");

                       Environment.Exit(0);

                        break;

                }

            }
        }

        static void Main(string[] args)
        {
            RegisterCommands();
            ClientProcessing();


        }

        public static void ClientProcessing()
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    GlobalClass command = new GlobalClass();
                    command.Print();

                    Console.WriteLine($"Введите команду !");
                    string Command = Console.ReadLine();
                    if (string.IsNullOrEmpty(Command))
                    {
                        // Handle empty command case
                        Console.WriteLine($"Ввели пусто  !");
                        Reset();


                    }
                    else
                    {
                        HandleCommand(Command, command);

                    }
                    Reset();
                }
            
            }
            catch(Exception e) 
            {

                Console.WriteLine(e.Message.ToString());
            }
        }

        public static void Reset()
        {
            Console.WriteLine();
            Console.WriteLine($"Начать заново Y да N - нет");

            var Символ = Convert.ToChar(Console.ReadLine());

            switch (Символ)
            {
                case 'Y':
                    Console.Clear();
                   ClientProcessing();

                    break;

                case 'N':
                    Console.WriteLine($"Досвидания !");
                    Console.ReadLine();
                    Environment.Exit(0);

                    break;

                default:

                    Console.WriteLine($"Не известный символ !");
                    Console.WriteLine($"Досвидания !");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
        }

    }
}