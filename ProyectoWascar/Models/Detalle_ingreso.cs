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
    
    public partial class Detalle_ingreso
    {
        public int Iddetalle_ingreso { get; set; }
        public Nullable<int> Idingreso { get; set; }
        public Nullable<int> Idarticulo { get; set; }
        public Nullable<decimal> Precio_compra { get; set; }
        public Nullable<decimal> Precio_venta { get; set; }
        public Nullable<int> Stock_inicial { get; set; }
        public Nullable<int> Stock_actual { get; set; }
        public Nullable<System.DateTime> Fecha_produccion { get; set; }
        public Nullable<System.DateTime> Fecha_vencimiento { get; set; }
    }
}