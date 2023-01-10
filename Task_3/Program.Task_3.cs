/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.*/

Console.Clear();
Console.WriteLine("Введите цифру:  ");
int day = Convert.ToInt32(Console.ReadLine());
if(day % 8 >= 6)
{
Console.WriteLine("Да! Это выходной день");
}
else
{
    Console.WriteLine("Нет! Это рабочий день");
}
