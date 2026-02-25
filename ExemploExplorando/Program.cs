using ExemploExplorando.Models;
using System.ComponentModel;
using System.Globalization;







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