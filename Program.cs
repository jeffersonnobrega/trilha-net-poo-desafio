using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("995598","Nokia","IKJ123",256);

Console.WriteLine("CELULAR [NOKIA]");
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine();

Console.WriteLine("CELULAR [IPHONE]");
Smartphone iphone = new Iphone(numero: "999854", modelo: "Iphone 13", imei: "111111111", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");