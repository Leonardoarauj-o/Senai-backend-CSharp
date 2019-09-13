
using System;

namespace Aula_01
{
    class Program
    {
        static void Main(string[] args)
        {
        //somente declaramos, sem atribuir valor
         int num1;


         //Declaramos atribundo um valor
         int num2 = 5;


         //declamos diversas variaveis de mesmo tipo  
         int num3, num4, num5 =60;



        //variavel do tipo decimal (real)
         float media;



        //variavel do tipo logico (booleana)
        bool resultado = false;



        //variavel do tipo texto (caracteres)
        string nomeAluno;

        //quebra linha
        Console.WriteLine();


        Console.WriteLine(num2 + num5);

        
        //Escreva em uma linha quebrando-a 
        Console.WriteLine("Bem vindos a nossa primeira aplicação!");


        //Continua escrevendo na mesma linha
        Console.Write("Digite seu nome");
        Console.Write(" seu nome: ");

       
        //captudo o dado digitando pelo usuario e salvo na variavel
        nomeAluno = Console.ReadLine();


        //Concatenação
        Console.WriteLine(nomeAluno + ", Agora digite sua primeira nota ");


        num3 = int.Parse(Console.ReadLine());


        //Interpolação

        Console.WriteLine( $"Sua primeira nota é {num3} ");



        Console.WriteLine("Digite sua segunda nota");
        num4 = int.Parse(Console.ReadLine() );


        Console.WriteLine("Terceira nota: ");
        num5 = int.Parse(Console.ReadLine() );


        media = (num3 + num4 + num5) /3;

        Console.WriteLine("sua media é: " + media);
        




        }
    }
}
