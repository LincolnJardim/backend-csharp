using ExemploExplorando.Models;
using System.ComponentModel;
using System.Globalization;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;


Desafio desafio = new Desafio();








// int numero = 20;
// bool par = false;

// // IF Ternário 
// par = numero.EhPar();

// string mensagem = "O número " + numero + " " + "é " + (par ? "par" : "ímpar");
// Console.WriteLine(mensagem);  




// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(30);

// Console.WriteLine(arrayInteiro[0]);

// MeuArray<string> arrayString = new MeuArray<string>();

// arrayString.AdicionarElementoArray("teste");

// Console.WriteLine(arrayString[0]);



// dynamic variavelDinamica = 4;

// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = true;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");



// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);


// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach(var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }






// var tipoAnonimo = new { Nome = "Lincoln", Sobrenome = "Alves", Altura = 1.89 };

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);








// bool? desejaReceberEmail = true;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuário optou por receber e-mail.");
// }
// else
// {
//     Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail.");
// }



// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}, Desconto: {(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
// }



// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);




// int numero = 10;
// bool ehPar = false;

// // IF Ternário
// ehPar = numero % 2 == 0;

// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));

// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é ímpar");
// }



// Pessoa p1 = new Pessoa("Lincoln", "Jardim");

// (string nome, string sobrenome) = p1;


// Console.WriteLine($"{nome} {sobrenome}");


// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     // Console.WriteLine("Quantidade de linhas d arquivo:" + quantidadeLinhas);
//     foreach(string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }







// (int Id, string Nome, string Sobrenome) tupla = (1 , "Lincoln", "Alves");
// ValueTuple<int, string, string> outroExemploTupla = (1 , "Lincoln", "Alves");

// Console.WriteLine($"Id: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");




// static void Main()
//     {
//         string linhaDeNomes = Console.ReadLine();

//         // Separa os nomes e remove espaços extras
//         List<string> nomes = linhaDeNomes
//             .Split(',')
//             .Select(nome => nome.Trim())
//             .ToList();

//         char letraFiltro = char.Parse(Console.ReadLine());

//         // TODO: Filtre a lista de nomes que começam com a letra (ignore maiúsculas/minúsculas):
//         List<string> filtrados = new List<string>();
//         foreach (string nome in nomes)
//         {
//             if (nome.StartsWith(letraFiltro))
//             {
//                 filtrados.Add(nome);
//             }
//         }

//         // TODO: Retorne o resultado e implemente a condição if para retornar 'Nenhum nome encontrado' e exiba o resultado: 
        
        
//         else
//         {
//             foreach (var nome in filtrados)
//             {
//                 Console.WriteLine(nome);
//             }
//         }
//     }




    // static void Main()
    // {
    //     int quantidade = int.Parse(Console.ReadLine());
    //     List<int> despesas = new List<int>();

    //     for (int i = 0; i < quantidade; i++)
    //     {
    //         int valor = int.Parse(Console.ReadLine());
    //         // TODO: Adicione o valor à lista somente se for maior que zero
    //         if (valor > 0)
    //         {
    //           despesas.Add(valor);
    //         }

    //     }
    // }

    // if (despesas.Count == 0)
    //     {
    //         Console.WriteLine("Sem despesas validas");
    //     }
    //     else
    //     {
    //         // TODO: Imprima cada valor da lista de despesas válidas
    //         foreach (int valor in despesas)
    //         {
    //           Console.WriteLine(valor);
    //         }

    //     }


// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");


// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.key}, Valor: {item.Value}");
// }

// estados.Remove("BA");



// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.Contains(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Vão não existe, É seguro adicionar a chave; {chave}");
// }



// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Rmovendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }



// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removiendo o elemento: {fila.Dequeue()}");

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }


// try
// {
//     string [] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
// }
// } catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }







// string dataString = "2022-04-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }


// DateTime data = DateTime.Parse(dataString);







// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.42M;

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// double porcetagem = .3421;
// Console.WriteLine(porcetagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));


// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);





// Pessoa p1 = new Pessoa(nome: "Lincoln", sobrenome: "Jardim");
// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();

// Pessoa p1 = new Pessoa();
// p1.Nome = "Lincoln";
// p1.Sobrenome = "Jardim";
// p1.Idade = 27;
// p1.Apresentar();