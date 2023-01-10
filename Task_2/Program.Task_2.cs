Console.Clear();
Console.WriteLine("Введите число: ");
string N = Console.ReadLine();

try
{
    Console.WriteLine($"Третьей цифрой числа является: {N[2]}.");
}
catch (System.Exception)
{
   Console.WriteLine("Число не имеет третьей цифры!");

}
