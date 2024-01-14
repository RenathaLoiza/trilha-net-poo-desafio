using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("smartphone Nokia");
Smartphone nokia = new Nokia( numero:"123123123",modelo: "Model 1", imei:"234234234" ,  memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("facebook");

Console.WriteLine("smartphone Iphone");
Smartphone Iphone = new Iphone( numero:"3446123123",modelo: "Model 2", imei:"004234234" ,  memoria: 64);
Iphone.Ligar();
Iphone.InstalarAplicativo("instagran");

