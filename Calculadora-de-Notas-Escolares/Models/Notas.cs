using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora_de_Notas_Escolares.Models
{
    public class Notas 
    {
        protected decimal notaPort;
        protected decimal notaMat;
        protected decimal notaHist;
        protected decimal notaGeog;
        protected decimal notaFis;
        protected decimal notaQuim;
        protected decimal notaLit;
        protected decimal notaIng;

        public void AplicarTodasAsNotasDeUmaVez()
        {
            List<string> materias = new List<string>();

            materias = ["Português", "Matemática", "História", "Geografia", "Física", "Química", "Literatura", "Inglês"];
            try
            {
                for(int index = 0; index < materias.Count(); index ++)
                {
                    if(materias[index] == "Português")
                    {
                        Console.WriteLine(materias[index]);
                        notaPort = CalculoMedia();
                    }
                    else if(materias[index] == "Matemática")
                    {
                        Console.WriteLine(materias[index]);
                        notaMat = CalculoMedia();
                    }
                    else if(materias[index] == "História")
                    {
                        Console.WriteLine(materias[index]);
                        notaHist = CalculoMedia();
                    }
                    else if(materias[index] == "Geografia")
                    {
                        Console.WriteLine(materias[index]);
                        notaGeog = CalculoMedia();
                    }
                    else if(materias[index] == "Física")
                    {
                        Console.WriteLine(materias[index]);
                        notaFis = CalculoMedia();
                    }
                    else if(materias[index] == "Química")
                    {
                        Console.WriteLine(materias[index]);
                        notaQuim = CalculoMedia();
                    }
                    else if(materias[index] == "Literatura")
                    {
                        Console.WriteLine(materias[index]);
                        notaLit = CalculoMedia();
                    }
                    else if(materias[index] == "Inglês")
                    {
                        Console.WriteLine(materias[index]);
                        notaIng = CalculoMedia();
                    }
                }
            }
            catch(System.FormatException)
            {
                Console.WriteLine("O formato digitado não é aceito!");
                Console.WriteLine("Tente novamente digitando números válido!.");
            }
        } 


        private decimal PegarNotasEConverter()
        {
            decimal notaUnidade = 0;
            notaUnidade = Convert.ToDecimal(Console.ReadLine());
            //return notaUnidade;

            if(notaUnidade <= 10 && notaUnidade > 0)
            {
                return notaUnidade;
                
            }
            else
            {
                Console.WriteLine("Erro! Valor não aceito.");
                Console.WriteLine("Digite um número de 0 a 10.");
                Console.WriteLine("Valor retornado: 0");
                return 0;
            }
        }


        private decimal CalculoMedia()
        {
            decimal somaDasUnidades = 0;

            Console.WriteLine("AV 1:");
            somaDasUnidades += PegarNotasEConverter();

            Console.WriteLine("AV 2:");
             somaDasUnidades += PegarNotasEConverter();

            Console.WriteLine("AV 3:");
             somaDasUnidades += PegarNotasEConverter();

            Console.WriteLine("AV 4:");
             somaDasUnidades += PegarNotasEConverter();

            decimal media = somaDasUnidades / 4;
            return media;
        }
    }
}