using ExemploPOO.Models;


// using ExemploPOO.Interfaces;
// // nao da pra instanciar interface, mas instancia a classe calculadora implementada pela interface.
// ICalculadora calc = new Calculadora();
// Console.WriteLine(calc.Multiplicar(3,9));
// O que tiver na interface, a classe que a implementar tera todos os metodos da interface.
// metodos que tem corpo na interface, se torna opcional colocar na classe.
// interface(implementar, contrato, tudo que quiser que uma classe implenta a classe implementa, pode implementar outras classes)

//Classe selada(nao pode ser herdada de nenhum jeito)
// sealed(ponto final, nao usa mais as classes filhas)

// construtor por heranca
// Pessoa p1 = new Pessoa("lucas");
// Aluno a1 = new Aluno("matheus");
// a1.Apresentar();


//classe abstrata
// Corrente c = new Corrente();
// c.Creditar(500);
// c.ExibirSaldo();
// // protected as classes filhas podem acessar
// private somente as classes pai podem acessar

// Polimorfismo(override)
// Aluno a1 = new Aluno();
// a1.Nome = "Lucas";
// a1.Idade = 28;
// a1.Email = "lucas@aluno.lucasgmail.com";
// a1.Nota = 10;
// a1.Apresentar();

// Professor p1 = new Professor();
// p1.Nome = "Jorge";
// p1.Idade = 55;
// p1.Email = "jorge@jorgegmail.com";
// p1.Salario = 10000;
// p1.Apresentar();


// Heranca
// Aluno a1 = new Aluno();
// a1.Nome = "Lucas";
// a1.Idade = 28;
// a1.Email = "lucas@aluno.lucasgmail.com";
// a1.Nota = 10;
// a1.Apresentar();

// Professor p1 = new Professor();
// p1.Nome = "Jorge";
// p1.Idade = 55;
// p1.Email = "jorge@jorgegmail.com";
// p1.Salario = 10000;
// p1.Apresentar();




// encapsulamento
// ContaCorrente c1 = new ContaCorrente(123, 1000);

// c1.ExibirSaldo();
// c1.Sacar(500);
// c1.ExibirSaldo();



// abstracao
// Pessoa p1 = new Pessoa();
// p1.Nome = "Lucas Matheus";
// p1.Idade = 28;

// p1.Apresentar();