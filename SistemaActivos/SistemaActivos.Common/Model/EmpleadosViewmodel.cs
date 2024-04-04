using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaActivos.Common.Model
{
    public class EmpleadosViewmodel
    {
        [Display(Name = "ID")]
        public int Empl_Id { get; set; }
        [NotMapped]
        public string nombre { get; set; }
        public string Empl_DNI { get; set; }
        public string Empl_PNombre { get; set; }
        public string Empl_SNombre { get; set; }
        public string Empl_PApellido { get; set; }
        public string Empl_SApellido { get; set; }
        public string Empl_Sexo { get; set; }
        public int? EstD_Id { get; set; }
        public string Depa_Codigo { get; set; }
        public string Muni_Codigo { get; set; }
        public string Empl_DireccionE { get; set; }
        public int? Empl_UsuarioCreacion { get; set; }
        public DateTime? Empl_FechaCreacion { get; set; }
        public int? Empl_UsuarioModificacion { get; set; }
        public DateTime? Empl_FechaModificacion { get; set; }




    }
}