using System;



namespace Exemplo_Explorando.Models
{

    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); 

        //Exemplos de validações das propriedades
        public string Nome
        {
            get => _nome.ToUpper();
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        
        }

        public int Idade
        {
            get
            {
                return _idade;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Idade não pode ser menor que 0");
                }
                _idade = value;
            }
        }



        //Exemplos construtores com overload
        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Idade = idade;
            this.Sobrenome = sobrenome;
        }

      public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }

}