using System;

namespace atividade_2_3
{
    class Program
    {
        static void Main(string[] args)
        {

        //deixamos declarada falsa por padrão
        bool entrada = false;
        int idade;
        string retorno = "entrada não permitida";

         Console.Write("digite a sua idade: ");
         idade = int.Parse( Console.ReadLine() );

        //como ja atribuimos anteriormente, mudamos o
        //estado da variavel para verdadeira caso
        //entre nessa condição  
         if(idade > 17){
             entrada = true;
         }

         if( entrada == true){
             retorno = "entrada permitida!!!";

         }else{
             retorno = "entrada não permitida";
         }

         Console.WriteLine(retorno);


        }
    }
}
