//Declaração de variáveis
string Hexadecimal, Binario; 
int Decimal;

Console.WriteLine("Conversor de Hexadecimal para Decimal e Binário");
Console.Write("Informe o valor a ser convertido (Letras MAIÚSCULAS): ");
Hexadecimal = Console.ReadLine();   // Hexadecimal recebe o valor a ser convertido

Decimal = Convert.ToInt32(Hexadecimal, 16); //Toint32 converte uma string pra int de base 10 e Decimal recebe esse valor
Binario = Convert.ToString(Decimal, 2); //ToString converte um int para uma string na base especificada e Binario recebe esse valor

Console.WriteLine($"\n{Hexadecimal} convertido em decimal = {Decimal}");    //Impressão da conversão pra Decimal
Console.WriteLine($"\n{Hexadecimal} convertido em binario = {Binario}");    //Impressão da conversão pra Binario