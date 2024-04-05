using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "190258", modelo: "Modelo 1", imei: "1321651561", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "5874692", modelo: "Modelo 2", imei: "1321638264", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
