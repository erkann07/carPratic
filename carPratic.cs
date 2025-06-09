using ConsoleApp18;

car araba = new car();
Console.Write("Aracınızın markasını giriniz : ");
araba.Marka = Console.ReadLine();
Console.Write("Aracınızın modelini giriniz : ");
araba.Model = Console.ReadLine();
Console.Write("Aracınızın rengini giriniz : ");
araba.Renk = Console.ReadLine();
Console.Write("Aracınızın kapı sayısını giriniz (2 veya 4): ");
araba.doorsNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Aracınızın bilgileri aşağıdadır...");
araba.PrintInfo(); 