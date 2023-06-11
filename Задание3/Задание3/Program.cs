Console.Clear();
Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
if(userNumber % 2 == 0){
    Console.WriteLine($" Число {userNumber} чётное");}
    else{
        Console.WriteLine($" Число {userNumber} нечётное");}