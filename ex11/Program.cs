int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void PrintData(string prefix, string value)
 {
    Console.WriteLine(prefix + value);
 }

 int number = ReadData("Введите число более 99: ");
  if (number < 100)
   {     
    PrintData("Вы ввели число менее 100 и третьей цифры в числе нет", ""); 
    } 
else
{
int num3=0;
while (number>1000)
{
    number=number/10;
}
    num3=number%10;
    PrintData("Третья цифра в числе: ", num3.ToString());
}

