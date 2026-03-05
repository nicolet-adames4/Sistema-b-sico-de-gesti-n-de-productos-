using System;
using System.Collections.Generic;

class Producto
{
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public Producto(int codigo, string nombre, double precio)
    {
        Codigo = codigo;
        Nombre = nombre;
        Precio = precio;
    }

    public void Mostrar()
    {
        Console.WriteLine($"Código: {Codigo} | Nombre: {Nombre} | Precio: {Precio}");
    }
}


class Almacen
{
    private List<Producto> productos = new List<Producto>();