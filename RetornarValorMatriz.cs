using System;
using System.Globalization;
using System.Collections.Generic;

namespace MeuPrograma
{
    class Programa
    {
        static void Main(string[] args)
        {   

            string[] line = Console.ReadLine().Split(' ');
            int linhas = int.Parse(line[0]);
            int colunas = int.Parse(line[1]);

            int[,] matriz = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++) {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++) {
                    if (matriz[i, j] == n) {
                        Console.WriteLine("Posição " + i + "," + j + ":");
                        if (j > 0) {
                            Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Acima: " + matriz[i - 1, j]);
                        }
                        if (j < colunas - 1) {
                            Console.WriteLine("Direita: " + matriz[i, j + 1]);
                        }
                        if (i < linhas - 1) {
                            Console.WriteLine("Abaixo: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}