using System;
using System.Collections.Generic;

namespace PrimerWeb.Models;
//Desoues de haber creado la conexion a la base de datos con Entity framework, se generó un mapeo de las tablas de la base de datos como clases C#. Esta es la clase de la tabla Usuario.
public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Ciudad { get; set; }

    public DateOnly FechaRegistro { get; set; }

    public virtual ICollection<Ordene> Ordenes { get; set; } = new List<Ordene>();
}
