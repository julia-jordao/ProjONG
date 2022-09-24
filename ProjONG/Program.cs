using System;
using System.Threading;

namespace ProjONG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            do
            {
                Header();
                Console.WriteLine("Bem vindo(a) ao projeto de adoção!");
                Console.WriteLine("");
                Console.WriteLine("Escolha uma opção: \n01.Registrar \n02.Atualizar \n03.Consultar\n00.Sair");
                int opcao = int.Parse(Console.ReadLine());

                while (opcao < 0 || opcao > 3)
                {
                    Console.WriteLine("Opção inválida, digite novemente!");
                    opcao = int.Parse(Console.ReadLine());
                }
                switch (opcao)
                {
                    case 1:
                        bool volta = false;
                        do
                        {
                            Console.Clear();
                            Header();
                            Console.WriteLine("Registre: \n01.Voltar \n02.Mãe/Pai de Pet \n03.Pet");
                            int op1 = int.Parse(Console.ReadLine());
                            while (op1 < 0 || op1 > 3)
                            {
                                Console.WriteLine("Opção inválida, digite novemente!");
                                op1 = int.Parse(Console.ReadLine());
                            }
                            switch (op1)
                            {
                                case 1:
                                    volta = true;
                                    Console.Clear();
                                    break;
                                case 2:

                                    Console.Clear();
                                    break;
                                case 3:

                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida!");
                                    break;
                            }
                        } while (!volta);
                        break;
                    case 2:
                        bool volta2 = false;
                        do
                        {
                            Console.Clear();
                            Header();
                            Console.WriteLine("Atualize: \n01.Voltar \n02.Mãe/Pai de Pet \n03.Pet");
                            int op2 = int.Parse(Console.ReadLine());
                            while (op2 < 0 || op2 > 3)
                            {
                                Console.WriteLine("Opção inválida, digite novemente!");
                                op2 = int.Parse(Console.ReadLine());
                            }
                            switch (op2)
                            {
                                case 1:
                                    volta2 = true;
                                    Console.Clear();

                                    break;
                                case 2:

                                    Console.Clear();
                                    break;
                                case 3:

                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida!");
                                    break;
                            }
                        } while (!volta2);
                        break;
                    case 3:
                        bool volta3 = false;
                        do
                        {
                            Console.Clear();
                            Header();
                            Console.WriteLine("Consulte: \n01.Voltar \n02.Mãe/Pai de Pet \n03.Pet");
                            int op3 = int.Parse(Console.ReadLine());
                            while (op3 < 0 || op3 > 3)
                            {
                                Console.WriteLine("Opção inválida, digite novemente!");
                                op3 = int.Parse(Console.ReadLine());
                            }
                            switch (op3)
                            {
                                case 1:
                                    volta3 = true;
                                    Console.Clear();

                                    break;
                                case 2:

                                    Console.Clear();
                                    break;
                                case 3:

                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida!");
                                    break;
                            }
                        } while (!volta3);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (true);
        }

        private static void Header()
        {
            Console.WriteLine("ONG ABRAÇA VIDAS");
            Console.WriteLine("");
        }
    }
}
