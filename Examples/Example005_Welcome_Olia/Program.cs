Console.WriteLine("Введите Ваше имя: ");
string UserName = Console.ReadLine();
if (UserName.ToLower() == "Оля")
    {
        Console.WriteLine("Это же Оленька, как твои дела ? ");
        Console.ReadLine();
        Console.WriteLine("Очень рад тебя видеть");
    }
    else
    {
        Console.Write("Привет,");
        Console.Write(UserName);
        Console.Write("!");
        
    }




