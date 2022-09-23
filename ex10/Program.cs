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
int number=ReadData("Введите трехзначное число: ");
int num2=(number/10)%10;
PrintData("Вторая цифра в этом числе: ", num2.ToString());
 
