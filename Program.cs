using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"345", modelo:"Advence", imei:"819456781", memoria: 45);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero:"356", modelo:"A5 PLUS", imei: "978458792", memoria: 146);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");