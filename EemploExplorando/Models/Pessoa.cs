using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa() //Primeiro construtor
        {

        }

        public Pessoa(string nome, string sobrenome)//Segundo construtor
        {
            Nome = nome; //A PROPRIEDADE recebe o valor da VARIÁVEL
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome; //A VARIÁVEL recebe o valor da PROPRIEDADE
            sobrenome = Sobrenome;
        }
        private string _nome; //Chama-se "campo"
        private int _idade;
        public string Nome {
             get => _nome.ToUpper(); //"=>" é um operador de retorno.
             set
             {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }
                _nome = value;
             } 
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        
        public int Idade 
        { 
            get => _idade;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero.");
                }
                _idade = value;
            } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Hello, my name is {NomeCompleto} and have {Idade} years old.");
        }
    }
}