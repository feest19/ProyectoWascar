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
    
    public partial class Articulo
    {
        public int Idarticulo { get; set; }
        public string codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public Nullable<int> Idcategoria { get; set; }
        public Nullable<int> Idpresentacion { get; set; }
    }
}
