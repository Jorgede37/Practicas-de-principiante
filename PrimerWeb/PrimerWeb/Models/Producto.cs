using System;
using System.Collections.Generic;

namespace PrimerWeb.Models;

//Desoues de haber creado la conexion a la base de datos con Entity framework, se generó un mapeo de las tablas de la base de datos como clases C#. Esta es la clase de la tabla Producto.

public partial class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Categoria { get; set; }

    public decimal Precio { get; set; }

    public int Stock { get; set; }

    public virtual ICollection<Ordene> Ordenes { get; set; } = new List<Ordene>();
}
