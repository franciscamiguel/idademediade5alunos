using System;

namespace idademediade5alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal media;
            decimal idade1;
            decimal idade2;
            decimal idade3;
            decimal idade4;
            decimal idade5;
            Console.WriteLine("programa calcule a idade media de 5 alunos");
            Console.Write("informe a idade do 1° aluno:");
            idade1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("informe a idade do 2° aluno :");
            idade2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("informe a idade do 3° aluno :");
            idade3 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("informe a idade do 4° aluno :");
            idade4 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("informe a idade do 5° aluno :");
            idade5 = Convert.ToDecimal(Console.ReadLine());
            media = (idade1 + idade2 + idade3 + idade4 + idade5)/ 5;
            Console.WriteLine(" A idade média dos alunos é " + media);
            Console.ReadKey();
        }
    }
}
