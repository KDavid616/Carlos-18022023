// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using actividad_asincrona.entidades;
using actividad_asincrona.negocio;

datos datos = new datos();
cls_datos dato = new cls_datos();

Console.WriteLine("Escriba una palabra");
string palabra = Console.ReadLine();
Console.WriteLine("El numero de caracteres en la palabra que escribio son: ");


datos.palabra = palabra;

int Res = dato.Conteo(datos);
Console.WriteLine(Res);