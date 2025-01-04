using AULA001;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

// regions 1 e 2
string abcptx = "ABCPTX";
bool existePtx = true;
if (abcptx.Contains("PTX"))
{
    existePtx = true;
}
else
{
    existePtx = false;
}
Console.Write("Printando se existe PTX na string: ");
Console.Write(existePtx);

int indexPtx = abcptx.IndexOf("PTX");
Console.Write("\nPrintando o índice que inicia a string PTX: ");
Console.Write(indexPtx);
string parte1Abcptx = abcptx.Substring(0, indexPtx);
string parte2Abcptx = abcptx.Substring(indexPtx + 1);
string parte2Abcptxlist = abcptx.Substring(indexPtx);
List<string> listAbcptx = new List<string>() { parte1Abcptx, parte2Abcptxlist };
Console.Write("\nSeparando tudo antes e depois do índice encontrado: ");
Console.Write(string.Join(" ", listAbcptx));


Console.WriteLine("\nLoop para cada caractere e depois printado: ");

foreach (var caractere in abcptx)
{
    Console.WriteLine(caractere);
}


Console.Write("Printando sem o X: ");
int indexToRemove = abcptx.IndexOf('X');
string modified = abcptx.Remove(indexToRemove, 1) + abcptx.Substring(indexToRemove + 1);
Console.Write(modified + "\n");


listAbcptx = listAbcptx.OrderBy(x => x).ToList();

foreach (var item in listAbcptx)
{
    Console.WriteLine(item);
}


//region 4 - rever
string valorString = "5";
Console.WriteLine(ConversaoInt(valorString));
Console.WriteLine(ConversaoDouble(valorString));
Console.WriteLine(ConversaoDecimal(valorString));
Console.WriteLine(ConversaoFloat(valorString));

decimal valorDecimal2 = 3.14M;
float valorFloat2 = 3.14F;
double valorDouble2 = 3.14;
Console.WriteLine($"Decimal: {valorDecimal2} Float: {valorFloat2} Double: {valorDouble2}");

//region 6
int ConversaoInt(string valorString)
{
    int ValorInt = int.Parse(valorString);
    return ValorInt;
}

double ConversaoDouble(string valorString)
{
    double ValorDouble = double.Parse(valorString);
    return ValorDouble;
}

decimal ConversaoDecimal(string valorString)
{
    decimal ValorDecimal = decimal.Parse(valorString);
    return ValorDecimal;
}

float ConversaoFloat(string valorString)
{
    float ValorFloat = float.Parse(valorString);
    return ValorFloat;
}

//region 7
List<Classe_1> lista = new List<Classe_1>();
lista.Add(new Classe_1 { ValorString = "10", ValorDecimal = 10M, ValorDouble = 10, ValorFloat = 10F, ValorInt = 10 });
Console.WriteLine("Printando os itens da lista com foreach: ");
foreach (var item in lista)
{
    Console.WriteLine(item.ValorString + item.ValorDecimal + item.ValorDouble + item.ValorFloat + item.ValorInt);
}

Console.WriteLine("Printando os itens da lista com for: ");
for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i].ValorString + lista[i].ValorDecimal + lista[i].ValorDouble + lista[i].ValorFloat + lista[i].ValorInt);
}

Console.WriteLine("Printando os itens da lista com while: ");

int contador = 0;
while (contador < lista.Count)
{
    Console.WriteLine(lista[contador].ValorString + lista[contador].ValorDecimal + lista[contador].ValorDouble + lista[contador].ValorFloat + lista[contador].ValorInt);
    contador++;
}

//region 9
Console.WriteLine("Printando o enum");

ClasseTeste teste = new ClasseTeste();
Console.WriteLine(teste.Str);
ClasseTeste teste2 = new ClasseTeste("QWE", "STR", "TESTE");
Console.WriteLine(teste2.Str);


teste2.PrintarEnum(EnumTeste.PrimeiraStr);
teste2.PrintarEnum(EnumTeste.SegundaStr);
teste2.PrintarEnum(EnumTeste.TerceiraStr);

