// See https://aka.ms/new-console-template for more information

using Ejercicios12122021;
using Newtonsoft.Json;
using System;

string ruta = @"D:\mtiexe\Natalia\Datos.csv"; 
String [] datos=File.ReadAllLines(ruta);
foreach (String dato in datos)
{ 
    Console.WriteLine(dato);
    Item item=BuildItem(dato);
    Console.WriteLine(JsonConvert.SerializeObject(item));
}

static Item BuildItem(String dato)
{
    try
    {
        String[] valores = dato.Split(';');
        return new Item { Cantidad = Convert.ToInt32(valores[1]), FechaRegistro = Convert.ToDateTime(valores[0]) };
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        return new Item { Cantidad = -1, FechaRegistro = DateTime.MinValue };
    }    
}
