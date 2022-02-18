using System;

namespace Exercicio2EsquerdaVolver
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string opcao = "";
            while (opcao != "S")
            {
                

                
                Console.WriteLine("Digite a direção inicial que o batalhão está virado");                
                Console.WriteLine("Exemplo N ou S ou L ou O");

                string[] strposicao = new string[3];
                strposicao = Console.ReadLine().Split(' ');

                string direcao = "N"; 
                Console.Clear();

                Console.WriteLine("E para GIRAR para a esquerda");
                Console.WriteLine("D para GIRAR para a direita");                

                string strmovimento = Console.ReadLine();
                char[] movimento = strmovimento.ToCharArray();

                for (int i = 0; i < movimento.Length; i++)
                {
                    if (direcao == "N" || direcao == "S" || direcao == "L" || direcao == "O")
                    {
                        if (movimento[i] == 'E')
                        {
                            if (direcao == "N")
                            {
                                direcao = "O";
                            }
                            else if (direcao == "L")
                            {
                                direcao = "N";
                            }
                            else if (direcao == "S")
                            {
                                direcao = "L";
                            }
                            else if (direcao == "O")
                            {
                                direcao = "S";
                            }
                        }


                        if (movimento[i] == 'D')
                        {
                            if (direcao == "N")
                            {
                                direcao = "L";
                            }
                            else if (direcao == "L")
                            {
                                direcao = "S";
                            }
                            else if (direcao == "S")
                            {
                                direcao = "O";
                            }
                            else if (direcao == "O")
                            {
                                direcao = "N";
                            }
                        }                          
                    }

                }


                Console.WriteLine(" "  + direcao);
            }   
        }
    }
}
