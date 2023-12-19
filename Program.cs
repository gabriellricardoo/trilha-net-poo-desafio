using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"123456", modelo: "Modelo 1",  imei: "111111111", memoria: 64);
Console.WriteLine($"O número da linha é: {nokia.Numero}");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.Numero = "654321";
Console.WriteLine($"Número da linha alterado para: {nokia.Numero}");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero:"4987", modelo: "Modelo 2",  imei: "222222222", memoria: 128);
Console.WriteLine($"O número da linha é: {iphone.Numero}");
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.Numero = "7894";
Console.WriteLine($"Número da linha alterado para: {iphone.Numero}");