using exemplofundamentos.Models;


int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda?  {possivelVenda}");

if (possivelVenda)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}





// string a = "15";

// int.TryParse(a, out int b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");


//double a = 4 / (2 + 2);

//Console.WriteLine(a);


//int a = 5;
//double b = a


// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);


// Cast - Casting
//int a = Convert.ToInt32("5");
// int a = int.Parse("5");

// Console.WriteLine(a);



// int a = 10;
// int b = 20;

// int c = a + b;

//c = c + 5;

// c += 5;

// Console.WriteLine(c);


// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));



// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Lincoln";
// pessoa1.Idade = 27;
// pessoa1.Apresentar();

// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condição: " + condicao);