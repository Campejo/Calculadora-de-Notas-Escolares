using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora_de_Notas_Escolares.Models
{
    public class Aluno : Notas
    {
        public Aluno(string nome, int idade, string serie)
        {
            Nome = nome;
            Idade = idade;
            Serie = serie;
        }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Serie { get; set; }

        public void Apresetar()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Série: {Serie}");
        }
        private void MostraBoletim()
        {
             Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Série: {Serie}");
            Console.WriteLine("");
            Console.WriteLine("NOTAS:");
            Console.WriteLine($"Português: {notaPort}");
            Console.WriteLine($"Matemática: {notaMat}");
            Console.WriteLine($"História: {notaHist}");
            Console.WriteLine($"Geografia: {notaGeog}");
            Console.WriteLine($"Física: {notaFis}");
            Console.WriteLine($"Química: {notaQuim}");
            Console.WriteLine($"Literatura: {notaLit}");
            Console.WriteLine($"Inglês: {notaIng}");
        
        }

        public void MenuDoAluno()
        {
            List<string> materiasEscolares = new List<string>();

            materiasEscolares = ["Português", "Matemática", "Inglês", "Geografia", "História", "Química", "Física"];

            bool exibirMenu = true;

            while(exibirMenu)
            {
                Console.Clear();
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Idade: {Idade}");
                Console.WriteLine($"Série: {Serie}");
                Console.WriteLine("");
                Console.WriteLine("1 - Matérias");
                Console.WriteLine("2 - Inserir notas");
                Console.WriteLine("3 - Boletim");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("");
                
                switch(Console.ReadLine())
                {
                    case "1":
                    foreach(string i in materiasEscolares)
                        Console.WriteLine(i);
                        break;
                
                    case "2":
                        AplicarTodasAsNotasDeUmaVez();
                        break;
                    
                    case "3":
                        MostraBoletim();
                        break;
                    
                    case "4":
                        exibirMenu = false;
                        break;
                    
                    default:
                        Console.WriteLine("Dígito incorreto!");
                        break;
                        
                        
                }
                Console.WriteLine("");
                Console.WriteLine("Aperte 'Enter' para continuar.");
                Console.ReadLine();
            }
                    }
                }

}