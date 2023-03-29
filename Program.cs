using ExemplosExplorando.Models;


Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Jorgin";
pessoa1.Idade = 23;

pessoa1.Apresentar();



 Pessoa pessoa2 = new Pessoa();
 pessoa2.Nome = "Galeguin Safado";
 pessoa2.Idade = 23; 

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.adicionarAluno(pessoa1);
cursoDeIngles.adicionarAluno(pessoa2);
cursoDeIngles.ListarAlunos();



