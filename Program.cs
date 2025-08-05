using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone iphone = new Iphone(numero: "998887777", modelo: "T5-0", imei: "444", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instalando Whatsapp...");

Smartphone nokia = new Nokia(numero: "977774444", modelo: "XEE", imei: "5555", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instalando Linkedin...");