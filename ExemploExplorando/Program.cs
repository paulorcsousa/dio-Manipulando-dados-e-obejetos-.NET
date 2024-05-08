using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Paulo",sobrenome: "Renan");
Pessoa p2 = new Pessoa(nome: "Renan",sobrenome: "Silva");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();











// Pessoa p1 = new Pessoa();
// p1.Nome = "Paulo";
// p1.Sobrenome = "Renan";
// p1.Idade = 36;
// p1.Apresentar();