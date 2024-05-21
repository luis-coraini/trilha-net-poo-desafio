using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia("1234312", "Modelo 1", "111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Iphone iphone = new Iphone("43653121", "Modelo 2", "2222222222", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

