//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoWascar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trabajador
    {
        public int Idtrabajador { get; set; }
        public string Nombre { get; set; }
        public string Apellidor { get; set; }
        public string Sexo { get; set; }
        public Nullable<System.DateTime> Fecha_nacimiento { get; set; }
        public string Num_documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Acceso { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
    }
}