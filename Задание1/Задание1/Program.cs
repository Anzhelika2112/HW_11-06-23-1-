Console.Clear();
Console.Write("Введите первое целое число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
Console.Write("Введите второе целое число: ");
string userInput1= Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);
if(userNumber > userNumber1){
    Console.WriteLine($"max = {userNumber} min = {userNumber1}");} 
if(userNumber1 > userNumber){
    Console.WriteLine($"max = {userNumber1} min = {userNumber}");
}