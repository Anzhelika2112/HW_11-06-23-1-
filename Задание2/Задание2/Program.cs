Console.Clear();
Console.Write("Введите первое целое число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
Console.Write("Введите второе целое число: ");
string userInput1= Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);
Console.Write("Введите третье целое число: ");
string userInput2 = Console.ReadLine() ?? "";
int userNumber2 = int.Parse(userInput2);
int max = userNumber;
if(max < userNumber1) max = userNumber1;
if(max < userNumber2) max = userNumber2;{
    Console.WriteLine($"max = {max}");
}
