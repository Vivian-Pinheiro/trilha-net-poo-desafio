using DesafioPOO.Models;

// Desafio 2 concluído com sucesso.

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "81125776", modelo: "A", imei: "123ABC", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("IPhone:");
Smartphone iphone = new Iphone(numero: "86110560", modelo: "B", imei: "123XYZ", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
