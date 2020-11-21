using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alunos = new string[10];
            float[] nota1 = new float[10];
            float[] nota2 = new float[10];
            float[] nota3 = new float[10];
            float[] nota4 = new float[10];
            float[] mediaAluno = new float[10];
            float mediaGeral;

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira o nome dos alunos:");
                alunos[i] = Console.ReadLine();
                Console.Write("Insira a 1ª nota: ");
                nota1[i] = float.Parse(Console.ReadLine());
                Console.Write("Insira a 2ª nota: ");
                nota2[i] = float.Parse(Console.ReadLine());
                Console.Write("Insira a 3ª nota: ");
                nota3[i] = float.Parse(Console.ReadLine());
                Console.Write("Insira a 4ª nota: ");
                nota4[i] = float.Parse(Console.ReadLine());

                mediaAluno[i] = (nota1[i]+nota2[i]+nota3[i]+nota4[i])/4;
                Console.WriteLine("Aluno(a): "+alunos[i]);
                Console.WriteLine("1ª Nota: "+nota1[i]);
                Console.WriteLine("2ª Nota: "+nota2[i]);
                Console.WriteLine("3ª Nota: "+nota3[i]);
                Console.WriteLine("4ª Nota: "+nota4[i]);
                Console.WriteLine("Média: "+mediaAluno[i]);

            }

            for (var i = 0; i < 10; i++)
            {
                int contadorR = 0;
                int contadorP = 0;
             
             if (mediaAluno[i] >= 7)
             {
                contadorP++;
             }
             else
             {
                 contadorR++;
             }

             Console.WriteLine(contadorP+" Passaram");
             Console.WriteLine(contadorR+" Reprovaram");
            }

            mediaGeral = (mediaAluno[0]+mediaAluno[1]+mediaAluno[2]+mediaAluno[3]+mediaAluno[4]+mediaAluno[5]+mediaAluno[6]+mediaAluno[7]+mediaAluno[8]+mediaAluno[9])/10;
            Console.WriteLine("A média geral foi de: "+mediaGeral);
        }
    }
}
