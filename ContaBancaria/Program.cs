using ContaBancaria.model;
using System;

namespace ContaBancaria
{
    public class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int opcao;

            Conta c1 = new Conta(1, 123, 1, "Udson", 1000000.0M);


            c1.Visualizar();
            c1.SetNumero(345);
            c1.Visualizar();

            c1.Sacar(1000);

            c1.Visualizar();

            c1.Depositar(5000);

            c1.Visualizar();


            while (true)
            {

                Console.ForegroundColor = ConsoleColor.DarkBlue;
       
                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                Console.WriteLine("                BANCO UDBANK                         ");
                Console.WriteLine("                                                     ");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                Console.WriteLine("           1 - Criar Conta                           ");
                Console.WriteLine("           2 - Listar todas as contas                ");
                Console.WriteLine("           3 - Buscar conta por número               ");
                Console.WriteLine("           4 - Atualizar dados da conta              ");
                Console.WriteLine("           5 - Apagar conta                          ");
                Console.WriteLine("           6 - Sacar                                 ");
                Console.WriteLine("           7 - Depositar                             ");
                Console.WriteLine("           8 - Transferir valores entre contas       ");
                Console.WriteLine("           9 - Sair                                  ");
                Console.WriteLine("                                                     ");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                Console.ResetColor();
                Console.WriteLine("                                                     ");
                Console.WriteLine("Digite a opção desejada:                             ");
                Console.WriteLine("                                                     ");
                

                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 9)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("                           Obrigado por usar o Banco Udbank");
                    Sobre();
                    Console.ResetColor();
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("/nCriar Conta: ");
                        Console.ResetColor();
                        KeyPress();

                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("/nListar todas as Contas");
                        Console.ResetColor();

                        KeyPress();


                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("\nConsultar dados da Conta - por número");
                        Console.ResetColor();

                        KeyPress();

                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("\nAtualizar dados da Conta");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("\nApagar a Conta");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("\nSaque");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("\nDepósito");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 8:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("\nTransferência entre Contas");
                        Console.ResetColor();

                        KeyPress();
                        Sobre();

                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOpção Inválida!");
                        Console.ResetColor();

                        KeyPress();
                        break;
                }
            }


        }
        static void Sobre()

        {

            Console.WriteLine("*********************************************************************");
            Console.WriteLine("                    Projeto Desenvolvido por: Udson Costa ");
            Console.WriteLine("                         udsoncostasantana@gmail.com");
            Console.WriteLine("                        Github: github.com/udsoncosta");
            Console.WriteLine("*********************************************************************");


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


