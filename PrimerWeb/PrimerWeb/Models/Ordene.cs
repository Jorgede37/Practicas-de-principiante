using System;
using System.Collections.Generic;

namespace PrimerWeb.Models;

//Desoues de haber creado la conexion a la base de datos con Entity framework, se generó un mapeo de las tablas de la base de datos como clases C#. Esta es la clase de la tabla Ordene.
public partial class Ordene
{
    public int Id { get; set; }

    public int UsuarioId { get; set; }

    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    public DateOnly Fecha { get; set; }

    public virtual Producto Producto { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
