Console.Write("Введите номер дня недели ");
int ndw = int.Parse(Console.ReadLine());
if ( ndw < 1 || ndw >7)
{
    Console.WriteLine("Не корректный номер!!!");
}
else if ( ndw < 6)
{
    Console.WriteLine("Будний день");
}
else
{
    Console.WriteLine("Выходной");
}