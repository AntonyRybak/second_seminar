Console.Clear();
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(number == 6 || number == 7 ? "Да" : "Нет");