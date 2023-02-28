using Exemplo_Explorando.Models;


Pessoa p1 = new Pessoa(nome: "Jhony",sobrenome: "Tormes da Silva",idade: 28);
Pessoa p2 = new Pessoa(nome: "Jean",sobrenome: "Pinto de Moura",idade: 28);
Pessoa p3 = new Pessoa(nome: "Gustavo",sobrenome: "Florence de Souza",idade: 24);

Curso cursoDeIngles  = new Curso();
cursoDeIngles.NomeDoCurso = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ListarAlunos();

Console.WriteLine($"Quantidade de alunos matriculados: {cursoDeIngles.ObterQuantidadeDeAlunosMatriculados()}");
