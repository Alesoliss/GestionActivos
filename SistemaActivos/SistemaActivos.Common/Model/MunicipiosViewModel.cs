﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActivos.Common.Model
{
    public class MunicipiosViewModel
    {
        public string Muni_Codigo { get; set; }
        public string Depa_Codigo { get; set; }
        public string Muni_Descripcion { get; set; }
        public int? Muni_UsuarioCreacion { get; set; }
        public DateTime? Muni_FechaCreacion { get; set; }
        public int? Muni_UsuarioModificacion { get; set; }
        public DateTime? Muni_FechaModificacion { get; set; }
    }
}