﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaActivos.Entities
{
    public partial class tbPantallas
    {
        public tbPantallas()
        {
            tbPantallasPorRoles = new HashSet<tbPantallasPorRoles>();
        }

        public int Pant_Id { get; set; }
        public string Pant_Descripcion { get; set; }

        public virtual ICollection<tbPantallasPorRoles> tbPantallasPorRoles { get; set; }
    }
}