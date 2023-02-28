using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Explorando.Models
{
    public class Curso
    {
        public string NomeDoCurso { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            return Alunos.Count;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
           return Alunos.Remove(aluno);
               
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {NomeDoCurso}");

            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = "Nº" + (count + 1) + " - " + Alunos[count].NomeCompleto;
                Console.WriteLine(texto);

            }
        }
    }
}
