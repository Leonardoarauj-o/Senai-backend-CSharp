using System;

namespace aula_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chamamos nossa primeira função
            Console.WriteLine( BomDia() );

            //Chamamos a função do tipo VOID (sem retorno)
            ImprimeDatahora();

            // Chamamos nossa função que calcula a media
            double[] numeros = { 2 , 5 , 2 };
            Console.WriteLine (CalculaMedia(numeros) );
        }

        /// <summary>
        /// Função que escreve Bom Dia para o usuario
        /// </summary>
        /// <returns>Retorna Olá! Bom Dia!</returns>
        static string BomDia(){
            return "olá bom dia!";
        }

        /// <summary>
        /// Função que mostra uma saudação  de acordo com o horario atual
        /// </summary>
        /// <param name="saudacao">um texto qualquer (sobrecarga de metodo)</param>
        /// <returns></returns> 
        static string BomDia(string saudacao){

            int hora = DateTime.Now.Hour;

            if(hora <= 11 && hora >= 6){
                saudacao = "Bom dia";
            }else if (hora > 12 && hora <= 18){
                saudacao = "bom tarde";
            }else{
                saudacao = "Boa noite";
            }

            return saudacao;
        }

        static void ImprimeDatahora(){
            Console.WriteLine(DateTime.Now.ToShortDateString() );
            Console.WriteLine(DateTime.Now.ToString());
        }

        /// <summary>
        /// Função que calcula a media de um vetor
        /// </summary>
        /// <param name="valores">Vetor com valores</param>
        /// <returns>Media dos valores</returns>
      
        /// <summary>
        /// calcula a soma de um vetor
        /// </summary>
        /// <param name="valores">vetor de doubles</param>
        /// <returns></returns>      
        static double CalculaSoma( double[] valores){

            double resultado = 0;

            for(int i = 0; i <= valores.Length; i++ ){

                resultado += valores[i];
            }


            resultado = resultado / valores.Length;

            return resultado;
        }

    }
}
