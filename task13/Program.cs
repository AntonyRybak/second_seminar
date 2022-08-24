Console.Clear();
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
string s = Convert.ToString(number);
if (s.Length <= 2){
    Console.WriteLine("Третьей цифры нет");
}
else Console.WriteLine(s[2]);