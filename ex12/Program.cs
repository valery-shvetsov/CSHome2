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

 int number = ReadData("Введите номер дня недели (от 1 до 7): "); 
 
 if (number>=1 && number<=7)
{
    if (number>=6 && number<=7)
    {
       PrintData("выходной", "");  
    }
    else
    {
        PrintData("рабочий", "");
    }
}
else
{    
    PrintData("Номер дня недели должен быть от 1 до 7", ""); 
}