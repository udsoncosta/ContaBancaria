using ContaBancaria.Controller;
using ContaBancaria.model;
using System;

namespace ContaBancaria
{
    public class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int opcao, agencia, tipo, aniversario, numero;
            string? titular;
            decimal saldo, limite;

            ContaController contas = new ();

            ContaCorrente cc1 = new ContaCorrente(contas.GerarNumero(), 345, 1, "Joao", 10000000.00M, 1000.00M);
            contas.Cadastrar(cc1);

            ContaPoupanca cp1 = new ContaPoupanca(contas.GerarNumero(), 123, 2, "Laura", 10000000.00M, 30);
            contas.Cadastrar(cp1);


            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                
                Console.WriteLine("******************************************************");
                Console.WriteLine("$                                                    $");
                Console.WriteLine("$                BANCO UDBANK                        $");
                Console.WriteLine("$                                                    $");
                Console.WriteLine("******************************************************");
                Console.WriteLine("$                                                    $");
                Console.WriteLine("$           1 - Criar Conta                          $");
                Console.WriteLine("$           2 - Listar todas as contas               $");
                Console.WriteLine("$           3 - Buscar conta por número              $");
                Console.WriteLine("$           4 - Atualizar dados da conta             $");
                Console.WriteLine("$           5 - Apagar conta                         $");
                Console.WriteLine("$           6 - Sacar                                $");
                Console.WriteLine("$           7 - Depositar                            $");
                Console.WriteLine("$           8 - Transferir valores entre contas      $");
                Console.WriteLine("$           9 - Sair                                 $");
                Console.WriteLine("$                                                    $");
                Console.WriteLine("******************************************************");
                Console.WriteLine("                                                      ");
                Console.ResetColor();
                Console.WriteLine("                                                     ");
                Console.WriteLine("Digite a opção desejada:");
                Console.WriteLine("                                                     ");

                //Tratamento de exceção para impedir a digitação de strings
                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) 
                { 
                Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Digite um valor inteiro entre 1 e 9.");
                    opcao = 0;
                    Console.ResetColor();
                }

                if (opcao == 9)
                {
                  
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("            Obrigado por usar o Banco Udbank");
                    Sobre();
                    Console.ResetColor();
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nCriar Conta:\n\n ");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número da agência: ");
                        agencia = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o nome do titular: ");
                        titular = Console.ReadLine();

                        titular ??= string.Empty;

                        do
                        {
                            Console.WriteLine("Digite o tipo da conta:  \n 1 - Conta Corrente \n 2 - Conta Poupança ");
                            tipo = Convert.ToInt32(Console.ReadLine());

                        } while (tipo != 1 && tipo != 2);

                        Console.WriteLine("Digite o saldo da conta: ");
                        saldo = Convert.ToDecimal(Console.ReadLine());

                        switch (tipo)
                        {
                            case 1:
                                Console.WriteLine("Digite o limite da conta: ");
                                limite = Convert.ToDecimal(Console.ReadLine());

                                contas.Cadastrar(new ContaCorrente(contas.GerarNumero(), agencia, tipo, titular, saldo, limite));
                                break;

                            case 2:
                                Console.WriteLine("Digite dia do aniversário da conta: ");
                                aniversario = Convert.ToInt32(Console.ReadLine());


                                contas.Cadastrar(new ContaPoupanca(contas.GerarNumero(), agencia, tipo, titular, saldo, aniversario));
                                break;
                        }

                        KeyPress();
                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("/nListar todas as Contas");
                        Console.ResetColor();

                        contas.ListarTodas();

                        KeyPress();
                        break;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nConsultar dados da Conta por número");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número da Conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        contas.ProcurarPorNumero(numero);

                        KeyPress();
                        break;
                    case 4:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nAtualizar dados da Conta");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número da Conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());


                        var conta = contas.BuscarNaCollection(numero);

                        if (contas.BuscarNaCollection(numero) is not null)
                        {

                            Console.WriteLine("Digite o número da agência: ");
                            agencia = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Digite o nome do titular: ");
                            titular = Console.ReadLine();

                            titular ??= string.Empty;

                            do
                            {
                                Console.WriteLine("Digite o tipo da conta:  \n 1 - Conta Corrente \n 2 - Conta Poupança ");
                                tipo = Convert.ToInt32(Console.ReadLine());

                            } while (tipo != 1 && tipo != 2);

                            Console.WriteLine("Digite o saldo da conta: ");
                            saldo = Convert.ToDecimal(Console.ReadLine());

                            tipo = conta.GetTipo();

                            switch (tipo)
                            {
                                case 1:
                                    Console.WriteLine("Digite o limite da conta: ");
                                    limite = Convert.ToDecimal(Console.ReadLine());

                                    contas.Atualizar(new ContaCorrente(numero, agencia, tipo, titular, saldo, limite));
                                    break;

                                case 2:
                                    Console.WriteLine("Digite dia do aniversário da conta: ");
                                    aniversario = Convert.ToInt32(Console.ReadLine());


                                    contas.Atualizar(new ContaPoupanca(numero, agencia, tipo, titular, saldo, aniversario));
                                    break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"A Conta número {numero} não foi encontrada!");
                            Console.ResetColor();
                        }

                        KeyPress();
                        break;
                    case 5:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nApagar a Conta");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número da conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        KeyPress();
                        break;
                    case 6:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nSaque");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 7:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nDepósito");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 8:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
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
            Console.WriteLine("********************************************************");
            Console.WriteLine("           Projeto Desenvolvido por: Udson Costa        ");
            Console.WriteLine("               udsoncostasantana@gmail.com              ");
            Console.WriteLine("              Github: github.com/udsoncosta             ");
            Console.WriteLine("********************************************************");
            Console.WriteLine("                                              ");
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


