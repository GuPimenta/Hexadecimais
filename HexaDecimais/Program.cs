//Declaração de variáveis

char[] Alfabeto = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
//Alfabeto, array de caracteres, representa o alfabeto Hexadecimal

string Valor;   //Valor, variável string responsável por armazenar o valor que queremos verificar se é Hexa ou não
bool Resultado = true;  //Resultado, variável booleana utilizada para validar um If no final do código

Console.WriteLine("Identificador de Hexadecimais");
Console.Write("Informe um valor (Letras MAIÚSCULAS): ");
Valor = Console.ReadLine();    //Valor recebe o que for escrito no console
char[] Comparador = Valor.ToCharArray();    //Converte a string Valor em char e armazena eles no array Comparador

foreach(var C in Comparador)    //Percorrerá cada item (C) do array Comparador
{
    if (Alfabeto.Contains(C) == false)  //Verifica se C NÃO está contido no Alfabeto
    {
        Console.WriteLine($"O valor {Valor} NÃO é um Hexadecimal");
        Resultado = false;  //Se C NÃO está contido em Alfabeto, Resultado recebe false. Portanto, Valor NÃO é Hexadecimal
        break;  //Encerra o loop do foreach
    }

}

if (Resultado)  //Se Resultado não receber false durante o foreach, Valor é um Hexadecimal
{
    Console.WriteLine($"O valor {Valor} é um Hexadecimal");
}

