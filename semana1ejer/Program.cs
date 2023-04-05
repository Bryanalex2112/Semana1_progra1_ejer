// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//creacion de objetos
using semana1ejer.entidades;
using semana1ejer.negocio;

Operaciones operacione = new Operaciones();
ClsOperaciones clsOperaciones = new ClsOperaciones();

//ToInt32 sirve para convertir datos de cadena de caracteres tipo string, a datos enteros tipo int

Console.WriteLine("ingresa el primer dato");
operacione.Dato1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo dato");
operacione.dato2 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("el esultado de la opeacion es");
Console.WriteLine(clsOperaciones.Suma(operacione));