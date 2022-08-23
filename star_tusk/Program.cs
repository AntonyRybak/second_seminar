Console.Clear();
Console.Write("Введите первое число ");
int numberone = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int numbertwo = int.Parse(Console.ReadLine());
Console.Write("Введите третье число ");
int numberthree = int.Parse(Console.ReadLine());
int count = 3;
int avg = 0;
int min_digit = 0;
avg = (numberone + numbertwo + numberthree) / count;
int avg_last = avg % 10;
int firstdigit_numberone = numberone / 100;
int firstdigit_numbertwo = numbertwo / 100;
int firstdigit_numberthree = numberthree / 100;
if (firstdigit_numberone < firstdigit_numbertwo){
    min_digit = firstdigit_numberone;
}
else min_digit = firstdigit_numbertwo;
if (firstdigit_numberthree < min_digit){
    min_digit = firstdigit_numberthree;
}
if (avg_last > min_digit){
    Console.WriteLine("да");
}
if(avg_last < min_digit){
    Console.WriteLine("Нет");
}
if(avg_last == min_digit){
    Console.WriteLine("Цифры равны");
}