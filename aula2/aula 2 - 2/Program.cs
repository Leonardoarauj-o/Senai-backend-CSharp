using System;

namespace aula_2___2
{
    class Program
    {
        static void Main(string[] args)
        {
           //definimos as variaveis que utilizamos para fazer o calculo
           float nota1, nota2, nota3, media;
           string resultado;

           Console.Write("digite sua primeira nota: ");
           nota1 = float.Parse(Console.ReadLine() );

           Console.Write("digite sua segunda nota: ");
           nota2 = float.Parse(Console.ReadLine() );

           Console.Write("digite sua terceira nota: ");
           nota3 = float.Parse(Console.ReadLine() );


           media = (nota1 + nota2 + nota3) / 3;

           if(media >= 6){
               resultado = "aprovado";

           }else if(media < 6 && media >=4 ){
               resultado = "recuperação";

           }else{
               resultado = "reprovado";
           }

           Console.WriteLine($"media : {media} - aluno{resultado} ");




        }
    }
}
