using System.Collections;
using System.Net.Http.Headers;
using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Exceptions;
using bytebank_ATENDIMENTO.bytebank.Util;
using bytebank_ATENDIMENTO.bytebankAtendimento;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

new BytebankAtendimento().AtendimentoCliente();

//#region EXEMPLOS ARRAYS EM C#
//void TestaArrayInt()
//{
//    int[] idades = new int[5];
//    idades[0] = 30;
//    idades[1] = 40;
//    idades[2] = 17;
//    idades[3] = 21;
//    idades[4] = 18;

//    int contador = 0;

//    for (int i = 0; i < idades.Length; i++)
//    {
//        int idade = idades[i];
        
//        Console.WriteLine($"indice {i}, idade: {idades[i]}");
//        contador += idade;
//    }
//    int media = contador / idades.Length;
//    Console.WriteLine($"media: {media}");
//}

//// TestaArrayInt();

//void TestaBuscaPalavra()
//{
//    string[] arrayDePalavras = new string[5];

//    for (int i = 0; i < arrayDePalavras.Length; i++)
//    {
//        Console.WriteLine($"Digite {i+1}a Palavra: ");
//        arrayDePalavras[i] = Console.ReadLine();
//    }
//    Console.WriteLine("Digite a palavra a ser encontrada: ");
//    var busca = Console.ReadLine();

//    foreach (string palavra in arrayDePalavras)
//    {
//        if (palavra.Equals(busca))
//        {
//            Console.WriteLine($"Palavra encontrada = {busca}");
//            break; 
//        }
//    }
//}
//// TestaBuscaPalavra();

//Array amostra = new double[5];
//amostra.SetValue(5.9,0);
//amostra.SetValue(1.8,1);
//amostra.SetValue(7.1,2);
//amostra.SetValue(10,3);
//amostra.SetValue(6.9,4);

//// TestaMediana(amostra);

//void TestaMediana(Array array)
//{
//    if ((array == null) || (array.Length == 0)) {
//        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo");
//    }

//    double[] numerosOrdenados = (double[])array.Clone();
//    Array.Sort(numerosOrdenados);

//    int tamanho = numerosOrdenados.Length;
//    int meio = tamanho / 2;
//    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
//                                         (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

//    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
//}

//// TestaMediana(amostra);


//void TestaArrayDeContaCorrentes()
//{
//    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();

//    listaDeContas.Adicionar(new ContaCorrente(874, "222222222"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
//    listaDeContas.Adicionar(new ContaCorrente(822, "222222222"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));

//    var contaDoAndre = new ContaCorrente(963, "123456-x");
//    listaDeContas.Adicionar(contaDoAndre);
//    //listaDeContas.ExibeLista();
//    //Console.WriteLine("=================");
//    //listaDeContas.Remover(contaDoAndre);
//    //listaDeContas.ExibeLista();

//    for (int i = 0; i < listaDeContas.Tamanho; i++)
//    {
//        ContaCorrente conta = listaDeContas[i];
//        Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia}");
//    }
//}

//// TestaArrayDeContaCorrentes();
//#endregion

////1 - cadastrar contas
////2 - listar contas
////3 - remover contas
////4 - ordenar contas
////5 - pesquisar contas
////6 - sair do sistema





////#region generica
////Generica<int> teste1 = new Generica<int>();
////teste1.MostrarMensagem(10);


////public class Generica<T>
////{
////    public void MostrarMensagem(T t)
////    {
////        Console.WriteLine($"Exibindo: {t}");
////    }
////}
////#endregion

