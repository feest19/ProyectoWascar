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
    
    public partial class Ingreso
    {
        public int Idingreso { get; set; }
        public Nullable<int> Idtrabajador { get; set; }
        public Nullable<int> Idproveedor { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Tipo_comprovante { get; set; }
        public string Serie { get; set; }
        public string Correlativo { get; set; }
        public Nullable<decimal> Itbis { get; set; }
        public string Estado { get; set; }
    }
}