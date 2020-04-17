using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DesafioFord
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            List<int> total = new List<int>();
            List<int> resposta = new List<int>();

            // Path do arquivo txt.
            string fileName = @"C:\Users\Lucas\source\repos\DesafioFord\DesafioFord\input.txt";

            // Cria o arquivo de saída
            string destPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            if (File.Exists("output.txt"))
            {
                File.Delete("output.txt");
            }
            File.Create(@"C:\Users\Lucas\source\repos\DesafioFord\DesafioFord\output.txt");

            // Lê o arquivo .txt e converte para uma lista de inteiros.
            var lines = File.ReadAllLines(fileName);

            List<int> vetorDeNs = new List<int>();

            for (int i = 0; i < lines.Length; i++)
            {
                vetorDeNs.Add(Int32.Parse(lines[i]));
            }

            // Injeta cada valor de uma lista de N's e testa qual é o menor M para aquele determinado N
            foreach (int item in vetorDeNs)
            {
                var n = Enumerable.Range(1, item).ToList();
                if (n.Count > 13)
                {
                    int countM = 2;
                    do
                    {
                        resposta.Clear();
                        total = resolveRecursivamente(0, n, countM, resposta);
                        countM++;
                    }
                    while (total[total.Count - 1] != 13);

                    Console.WriteLine($"N:{n.Count} M:{countM} Último valor:{total[total.Count - 1]} ");
                    File.AppendAllText("output.txt", $"N:{n.Count}\tM:{countM - 1 }" + Environment.NewLine);
                }
                else {
                    Console.WriteLine($"N:{item}    M:1");
                    File.AppendAllText("output.txt", $"N:{n.Count}\tM:1" + Environment.NewLine);
                }
            }
            Console.WriteLine("Pressione uma tecla para encerrar a execução");
            Console.ReadKey();
        }

        /// <summary>
        /// Resolve recursivamente o número de regiões a partir de um determinado m
        /// </summary>
        /// <param name="resto">Offset de index</param>
        /// <param name="n">Vetor de números de regiões</param>
        /// <param name="m">O número m a ser testado</param>
        /// <param name="resposta">Lista com as regiões ordenadas a partir de determinado m</param>
        /// <returns>Lista com a ordem das cidades</returns>
        public static List<int> resolveRecursivamente(int resto, List<int>  n, int m, List<int> resposta)
        {
            if (n.Count == 1)
            {
                resposta.Add(n[0]);
                return resposta;
            }
            while(resto < n.Count)
            {
                resposta.Add(n[resto]);
                resto += m;
            }
            resto -= n.Count;

            List<int> novoN = new List<int>();

            novoN = n.Except(resposta).ToList();

            return resolveRecursivamente(resto, novoN, m, resposta);
        }





    }
}
