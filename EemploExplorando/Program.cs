using EemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText(path: "Arquivos/venda.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach(Venda venda in listaVenda)
{
    Console.WriteLine(value: $"Id: {venda.Id}, Produto: {venda.Produto}," + 
                    $"Preço: {venda.Preco}, Data: {venda.Data}");
}














/*
DateTime data = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(id: 1, produto: "Material para escritório", preco: 300.99M, data);
Venda v2 = new Venda(id: 2, produto: "Licença de software", preco: 150.99M, data);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

Console.WriteLine(serializado);

File.WriteAllText(path: "Arquivos/venda.json", serializado);
*/












/*int numero = 12;

bool ehPar = numero % 2 == 0;
Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));//IF ternário
*/
















/*
Pessoa p1 = new Pessoa(nome: "Walisson", sobrenome: "Ferraz");

(string nome, string sobrenome) = p1;

Console.WriteLine(value: $"{nome} {sobrenome}");
*/
















/*LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhas, _) = arquivo.LerAquivo(caminho: "Arquivo/arquivoLeitura.txt"); //Estou colocando o retorno do meu método em uma nova tupla que não tem nome.

if (sucesso)
{
    //Console.WriteLine("Quantidade de linhas do arquivo: "+ quantidadeLinhas);
    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine(value: "Não foi possível ler o arquivo.");
}
*/











/*(int Id, string Nome, decimal Altura) tupla = (1, "Walisson", 1.7M);// Forma mais legível

//ValueTuple<int, string, decimal> tupla2 = (1, "Walisson", 1.7M);
//var tupla3 = Tuple.Create(item1: 1, item2: "Walisson", item3: 1.70M);

Console.WriteLine(tupla.Id);
Console.WriteLine(tupla.Nome);
Console.WriteLine(tupla.Altura);*/




















//DICTIONARY
/*Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add(key: "SP", value: "São Paulo");
estados.Add(key: "BA", value: "Bahia");
estados.Add(key: "MT", value: "Mato Grosso");*/

/*foreach(KeyValuePair<string, string> e in estados)
//foreach(var e in estados)
{
    Console.WriteLine(e);
}
estados.Remove(key: "BA");

Console.WriteLine(value: "Item removido");*/

//foreach(KeyValuePair<string, string> e in estados)
/*estados["SP"] = "São Paulo - Valor alterado";

foreach(var e in estados)
{
    Console.WriteLine($"{e.Key} - {e.Value}");
}*/



/*string chave = "BA";

if(estados.ContainsKey(key: chave)){
    Console.WriteLine(value: $"O dicionário contém {chave}.");
}
else
{
    Console.WriteLine(value: $"O dicionário não contém {chave}");
}*/










//LIFO
/*Stack<int> pilha = new Stack<int>();
pilha.Push(item: 4);
pilha.Push(item: 6);
pilha.Push(item: 2);
pilha.Push(item: 12);
pilha.Push(item: 32);
pilha.Push(item: 9);

foreach (int p in pilha)
{
    Console.WriteLine(p);
}

Console.WriteLine(value: $"Item removida da pilha {pilha.Pop()}");

foreach (int p in pilha)
{
    Console.WriteLine(p);
}*/














//FIFO
/*Queue<int> fila = new Queue<int>();
fila.Enqueue(item: 45);
fila.Enqueue(item: 83);
fila.Enqueue(item: 78);
fila.Enqueue(item: 12);

foreach (int f in fila)
{
    Console.WriteLine(f);
}

Console.WriteLine(value: $"Item removido da fila: {fila.Dequeue()}");

foreach (int f in fila)
{
    Console.WriteLine(f);
}

Console.WriteLine(value: $"Item removida da fila: {fila.Dequeue()}");

foreach (int f in fila)
{
    Console.WriteLine(f);
}

fila.Enqueue(item: 34);
fila.Enqueue(item: 45);
fila.Enqueue(item: 90);

Console.WriteLine(value: $"Três itens foram adicionados a fila.");

foreach (int f in fila)
{
    Console.WriteLine(f);
}*/








// new ExemploExcesao().Metodo1();










//string[] linhas2 = File.ReadAllLines(path: "Arquivos/SubpastaArquivos/arquivo2.txt");

/*try//Tenta executar o bloco
{
    string[] linhas = File.ReadAllLines(path: "Arquivos/arquivo-Leitura.txt");//O ReadAllLines pode retornar uma exceção que não consegue tratar
    foreach (string l in linhas)
    {
        Console.WriteLine(l);
    }
}
catch (FileNotFoundException excecao)
{
    Console.WriteLine($"Não foi possível encontrar o arquivo especificado. {excecao.Message}");
}

catch (DirectoryNotFoundException excecao)
{
    Console.WriteLine($"Não foi possível encontrar um diretório especificado. {excecao.Message}");
}

catch (Exception excecao)//Captura a exceção que tenha ocorrido no bloco de código do try
{
    Console.WriteLine($"Ocorreu uma exceção genérica: {excecao.Message}");
}
Console.WriteLine("O programa chegou até aqui.");*/


/*Console.WriteLine("-----------------------------");
foreach(string l in linhas2)
{
    Console.WriteLine(l);
}*/












/*DateTime data = DateTime.Now;
Console.WriteLine(data.ToString(format: "dd/MM/yy HH:mm"));
DateTime data2 = DateTime.Parse(s: "27/10/22 16:00");
Console.WriteLine(data2);
string dataString = "2022-10-28 16:61";
DateTime.TryParseExact(dataString, format: "yyyy-MM-dd HH:mm", 
                    CultureInfo.InvariantCulture, DateTimeStyles.None, 
                    out DateTime data3);

Console.WriteLine(data3);*/








//FORMATAÇÃO DE VALORES MONETÁRIOS
/*CultureInfo.DefaultThreadCurrentCulture = new CultureInfo(name: "en-US");

decimal valorMonetario = 1780.70M; //O "M" converte double para decimal
Console.WriteLine(valorMonetario.ToString(format: "C", CultureInfo.CreateSpecificCulture(name: "pt-BR")));
Console.WriteLine(valorMonetario.ToString(format: "C4"));

double porcentagem = .74387;// Precisa ser do tipo ponto flutuante.
int numero = 982374824;

Console.WriteLine(porcentagem.ToString(format: "P"));//Formatação de percentagem.
Console.WriteLine(numero.ToString(format: "##/##/##/"));//Formatação personalizada.*/













/*string n1 = "10";
int n2 = 20;

string resultado = n1 + n2;//n2 convertido implicitamente para string. O contrário não ocorre.*/







/*Pessoa p1 = new Pessoa(nome: "Walisson",sobrenome: "Rodrigues");

Pessoa p2 = new Pessoa();
p2.Nome = "Pedro";
p2.Sobrenome = "Calabrez";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();*/