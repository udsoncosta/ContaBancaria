using System;

namespace ContaBancaria
{
    public class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int opcao;

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("*************************************************");
                Console.WriteLine("                                                 ");
                Console.WriteLine("                    BANCO UDBANK                 ");
                Console.WriteLine("                                                 ");
                Console.WriteLine("*************************************************");
                Console.WriteLine("                                                 ");
                Console.WriteLine("           1 - Criar Conta                       ");
                Console.WriteLine("           2 - Listar todas as contas            ");
                Console.WriteLine("           3 - Buscar conta por número           ");
                Console.WriteLine("           4 - Atualizar dados da conta          ");
                Console.WriteLine("           5 - Apagar conta                      ");
                Console.WriteLine("           6 - Sacar                             ");
                Console.WriteLine("           7 - Depósitar                         ");
                Console.WriteLine("           8 - Transferir valores entre contas   ");
                Console.WriteLine("           9 - Sair                              ");
                Console.WriteLine("                                                 ");
                Console.WriteLine("*************************************************");
                Console.WriteLine("                                                 ");
                Console.ResetColor();
                Console.WriteLine("                                                 ");
                Console.WriteLine("Digite a opção desejada:                         ");
                Console.WriteLine("                                                 ");
                
                Console.WriteLine("                                                 ");

                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 9)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Obrigado por usar o Banco Udbank");
                    Sobre();
                    Console.ResetColor();
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;

                        Console.WriteLine("Criar Conta: ");

                        Console.ResetColor();

                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Listar todas as Contas");
                        Console.ResetColor();


                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Consultar dados da Conta - por número");
                        Console.ResetColor();

                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Atualizar dados da Conta");
                        Console.ResetColor();

                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Apagar a Conta");
                        Console.ResetColor();

                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Saque");
                        Console.ResetColor();

                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Depósito");
                        Console.ResetColor();

                        break;
                    case 8:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Transferência entre Contas");
                        Console.ResetColor();

                        Sobre();

                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção Inválida!");
                        Console.ResetColor();
                        break;
                }
            }


        }
        static void Sobre()

        {

            Console.WriteLine("*********************************************************");
            Console.WriteLine("        Projeto Desenvolvido por: Udson Costa            ");
            Console.WriteLine("             udsoncostasantana@gmail.com      ");
            Console.WriteLine("            Github: github.com/udsoncosta                ");
            Console.WriteLine("*********************************************************");


        }
        static void KeyPress()
        {
            do
            {
                Console.WriteLine("Pressione enter se deseja continuar: ");
                consoleKeyInfo = Console.ReadKey();
            }
            while (consoleKeyInfo.Key != ConsoleKey.Enter);

        }


    }
}


