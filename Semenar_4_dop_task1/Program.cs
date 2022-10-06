using HelpNS;
/*Задача 1. На вход подаётся натуральное десятичное число. 
Проверьте, является ли оно палиндромом в двоичной записи.
*/
 
char[] text3 = DecToBinCL.DecToBin();
for (int i = 0; i < text3.Length; i++)
{
    Console.Write(text3[i]);
}
int count = 0;
int j = 1;
for (int i = 0; i < text3.Length/2; i++)
{
   if ( text3[i] == text3[text3.Length - j]) {
    count++;
    j++;
   }
}
Console.WriteLine();
if (count == text3.Length/2) Console.WriteLine( "введенное число палиндром в двоичной записи");
else Console.WriteLine("введенное число не палиндром в двоичной записи");

