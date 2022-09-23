// void Zadanie1 ()
// {
// Console.WriteLine("Введите трехзначное число: ");
// int x = int.Parse(Console.ReadLine());
// }
void Ex1()
{
    Console.WriteLine("Введите трехзначное число: ");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine(x / 10 % 10);
}


void Ex2()
{
    Console.WriteLine("Введите число: ");
    int x =  int.Parse (Console.ReadLine());
    if (x < 100)
    {
        Console.WriteLine("Третьей цифры в данном числе нет");
    }
    else if (x > 99)
    {
        Console.WriteLine(x.ToString()[2]);
    }

}

 




void Ex3()
{
    Console.WriteLine("Сегодня выходной? ");
    Console.WriteLine("Введите число от 1 до 7: ");
    int x = int.Parse(Console.ReadLine());
    if (x > 5)
    {
        Console.WriteLine("да");
    }
    else if (x < 6)
    {
         Console.WriteLine("нет");
         
    }

   

    }


//Ex1();
Ex2();
//Ex3();