Console.Clear();
Console.Write("Введите целое число N: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
for(int i=1; i<=userNumber; i++)
if(i % 2 == 0){
        Console.WriteLine(i + "");}