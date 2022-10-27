using funcamentos_de_c_.Model;
 








































// TERCEIRO DESAFIO DE CÓDIGO
/*int n = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 1; i <= n; i++) {
// TODO: Crie as outras condições necessárias para a resolução do desafio:
    if (n % i == 0) {
        count++;
    }
}
    Console.WriteLine($"{count == 3} e count = {count}");
*/
















// SEGUNDO DESAFIO DE CÓDIGO
int amountTest = int.Parse(Console.ReadLine());
string a = "", b = "";
char[] charA = new char[5];
char[] charB = new char[5];
int count = 0, countA = 0, countB = 0;

// TODO: Crie as outras condições necessárias para a resolução do desafio:
for (int i = 0; i < amountTest; i++)
{
    a = Console.ReadLine();
    b = Console.ReadLine();
    Array.Resize(ref charA, a.Length);
    Array.Resize(ref charB, b.Length);
    charA = a.ToCharArray();
    charB = b.ToCharArray();
    count = countA = countB = 0;

    if(charA.Length >= charB.Length)
    {
        if(charA.Length <= 1000 && charB.Length <= 1000)
        {
            for(int k = 0; k < charA.Length; k++)
            {
                if(charA[k].Equals("0") || charA[k].Equals("1") || charA[k].Equals("2") || charA[k].Equals("3") || charA[k].Equals("4") || charA[k].Equals("5") || charA[k].Equals("6") || charA[k].Equals("7") || charA[k].Equals("8") || charA[k].Equals("9"))
                {
                    countA++;
                    k = charA.Length;
                }
                if(k < charB.Length)
                {
                    if(charB[k].Equals("0") || charB[k].Equals("1") || charB[k].Equals("2") || charB[k].Equals("3") || charB[k].Equals("4") || charB[k].Equals("5") || charB[k].Equals("6") || charB[k].Equals("7") || charB[k].Equals("8") || charB[k].Equals("9"))
                    {
                        countB++;
                        k = charA.Length;
                    }
                }  
            }
            
            if(countA == charA.Length && countB == charB.Length)
            {
                Array.Reverse(charA,0,charA.Length);
                Array.Reverse(charB,0,charB.Length);
                for(int j = 0; j < charA.Length; j++)
                {
                    if(j <= charA.Length - 1 && j <= charB.Length - 1)
                    {
                        if(charA[j] != charB[j])
                        {
                            j =  charA.Length;
                        }
                        else
                        {
                            count++;
                        }
                    }
                    else
                    {
                        j =  charA.Length;
                    }
                }

                if (a.Equals("") || b.Equals(""))
                    Console.WriteLine("nao encaixa");
                else if (count > 0)
                    Console.WriteLine("encaixa");
                else
                    Console.WriteLine("nao encaixa");  
            }
            else
                Console.WriteLine("nao encaixa");
        }
        else
            Console.WriteLine("nao encaixa");
    }
    else
        Console.WriteLine("nao encaixa");
}
















/*// SEGUNDO DESAFIO DE CÓDIGO: ENCAIXA OU NÃO ENCAIXA?
int qt = int.Parse(Console.ReadLine());
string a = "";
string b = "";
char[] charA = new char[10];
char[] charB = new char[10];
int coube = 0;
// TODO: Crie as outras condições necessárias para a resolução do desafio:
for (int i = 0; i < qt; i++)
{
    a = Console.ReadLine();
    b = Console.ReadLine();
    
    Array.Resize(ref charA, a.length);
    Array.Resize(ref charB, b.length);
    charA = a.ToCharArray(a);
    charB = b.ToCharArray(b);
    Array.Reverse(charA);
    Array.Reverse(charB);

    for(int i = 0; i <= a.length - 1; i++)
    {
        if(charA[i] != charB[i]){
            break;
        }
        coube++;
    }

    if (coube > 0)
        Console.WriteLine("encaixa");
    else if (charA[0].Equals("") || charB[0].Equals(""))
        Console.WriteLine("nao encaixa");
    else
        Console.WriteLine("nao encaixa");
}
*/
















// SEGUNDO DESAFIO DE CÓDIGO: ENCAIXA OU NÃO ENCAIXA? 

// !!! Forma de resolver não aceita pelo testador da DIO !!!
// int qt = int.Parse(Console.ReadLine());
// string a = "";
// string b = "";
// // TODO: Crie as outras condições necessárias para a resolução do desafio:
// for (int i = 0; i < qt; i++)
// {
//     a = Console.ReadLine();
//     b = Console.ReadLine();
    

//     if (!a.Equals("") && !b.Equals("") && a.EndsWith(b))
//         Console.WriteLine("encaixa");
//     else if (a.Equals("") || b.Equals(""))
//         Console.WriteLine("nao encaixa");
//     else
//         Console.WriteLine("nao encaixa");

// }







































// // PRIMEIRO DESAFIO DE CÓDIGO

// int n = int.Parse(Console.ReadLine());
// int p = 1, s = 0;
// while (n > 0){
//     int l = n % 10;
//     if(n >= 1 && n <= 100000){
//         p *= l;
//         s += l;
//         n /= 10;
//     }
    
// }
// Console.WriteLine(p-s);
   


// PRIMEIRO DESAFIO DE CÓDIGO QUE MELHOREI

// Console.WriteLine("Entre com um número entre 1 e 100.000.");
// string entrada = Console.ReadLine();
// int n = 0;

// int.TryParse(entrada, out n);
// int p = 1, s = 0;
    
// if(n >= 1 && n <= Math.Pow(10,5))
// {
//     while (n > 0)
//     {
//     int l = n % 10;
//     p *= l;
//     s += l;
//     n /= 10;
//     }
//     Console.WriteLine(p-s);
// }
// else
// {
//     Console.WriteLine("Valor inválido!");
// }


// int n = 1, l = 1;
// l = n % 10;
// n /= 10;


// Console.WriteLine($"{n} - {l}");

















// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1- Cadastrar cliente");
//     Console.WriteLine("2- Buscar cliente");
//     Console.WriteLine("3- Apagar cliente");
//     Console.WriteLine("4- Encerrar programa");
    
//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1": 
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2": 
//             Console.WriteLine("Busca de cliente");
//             break;
//         case "3": 
//             Console.WriteLine("Exclusão de cliente");
//             break;
//         case "4": 
//             Console.WriteLine("Programa encerrado");
//             exibirMenu = false;
//             //Environment.Exit(0);
//             break;
//         default:
//             Console.WriteLine("Opção inválida!");
//             break;

//     }
// }
// Console.WriteLine("O programa encerrou-se"); //Parte não executada pelo programa, pois não sai do meu loop. Para resolver isso é necessário realizar uma refatoração.


















































// int numero = 0, soma = 0;


// do{
//     Console.WriteLine("Digite um número");
//     numero = Convert.ToInt32(Console.ReadLine());
//     soma += numero;
// }while(numero != 0);


// Console.WriteLine($"Soma dos valores digitados: {soma}");


// string opcao;

// while(true)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1- Cadastrar cliente");
//     Console.WriteLine("2- Buscar cliente");
//     Console.WriteLine("3- Apagar cliente");
//     Console.WriteLine("4- Encerrar programa");
    
//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1": 
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2": 
//             Console.WriteLine("Busca de cliente");
//             break;
//         case "3": 
//             Console.WriteLine("Exclusão de cliente");
//             break;
//         case "4": 
//             Console.WriteLine("Programa encerrado");
//             Environment.Exit(0);
//             break;
//         default:
//             Console.WriteLine("Opção inválida!");
//             break;

//     }
// }
// Console.WriteLine("O programa encerrou-se"); //Parte não executada pelo programa, pois não sai do meu loop. Para resolver isso é necessário realizar uma refatoração.




























// int contador = 0;
// int numero = 7;

// while(contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;

//     if(contador == 6)
//         break;
// }























// int numero = 4;

// for(int i = 0; i <= 10; i++)
// {
//     Console.WriteLine($"{numero} x {i} = {numero * i}");
// }
































// Calculadora calculo = new Calculadora();

// calculo.RaizQuadrada(81);

















// calculo.Seno(30);
// calculo.Coseno(30);
// calculo.Tangente(30);









// calculo.Somar(48,96);
// calculo.Subtrair(45,59);
// calculo.Multiplicacao(6,9);
// calculo.Divisao(58,0);




















// bool choveu = false;
// bool estaTarde = false;

// if(!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar!");
// }
// else
// {
//     Console.WriteLine("Vou pedalar num outro dia...");
// }



































// bool possuiPresencaMinima = false;
// double media = 9;

// if(possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else 
// {
//     Console.WriteLine("Reprovado!");
// }





























// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Walisson";
// pessoa1.Idade = 22;
// pessoa1.Apresentar();

// int a = int.Parse(null);
// int a = Convert.ToInt32(null);

// double a = double.MaxValue;
// long b = Convert.ToInt64(a);

// string a = "15-";
// // int b = 0;
// int.TryParse(a, out int b);
// Console.WriteLine(b);

// Console.WriteLine("Digite uma letra: ");
// string letra = "p";

// switch(letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }



/*if(letra == "a" || 
   letra == "e" ||
   letra == "i" ||
   letra == "o" ||
   letra == "u")
{
    Console.WriteLine("Vogal");
}
else{
    Console.WriteLine("Não é uma vogal");
}
*/



// if(letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if(letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if(letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if(letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if(letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }

// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = true;

// if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada autorizada.");
// }
// else
// {
//     Console.WriteLine("Entrada não autorizada.");
// }

