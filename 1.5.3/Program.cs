// See https://aka.ms/new-console-template for more information
Console.WriteLine("Как Вас зовут?");
string name = Console.ReadLine();
Console.WriteLine("Сколько Вам лет?");
string age = Console.ReadLine();
Console.WriteLine("Откуда вы?");
string city = Console.ReadLine();

Console.WriteLine("Здравствуйте, {0}", name);
Console.WriteLine("Вам {0} лет", age);
Console.WriteLine("Вы из города {0}", city);
