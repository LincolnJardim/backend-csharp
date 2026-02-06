using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Lincoln", sobrenome: "Jardim");
Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

// Pessoa p1 = new Pessoa();
// p1.Nome = "Lincoln";
// p1.Sobrenome = "Jardim";
// p1.Idade = 27;
// p1.Apresentar();