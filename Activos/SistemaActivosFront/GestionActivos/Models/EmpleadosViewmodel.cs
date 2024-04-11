using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionActivos.Models
{
    public class EmpleadosViewmodel
    {
        [Display(Name = "ID")]
        [Required(ErrorMessage = "El campo {0} es requerido")]

        public int Empl_Id { get; set; }
        [NotMapped]
        public string nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]

        public string Empl_DNI { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]

        public string Empl_PNombre { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Empl_SNombre { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Empl_PApellido { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Empl_SApellido { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Empl_Sexo { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int? EstD_Id { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Depa_Codigo { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Muni_Codigo { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Empl_DireccionE { get; set; }
        
        public int? Empl_UsuarioCreacion { get; set; }
        public DateTime? Empl_FechaCreacion { get; set; }
        public int? Empl_UsuarioModificacion { get; set; }
        public DateTime? Empl_FechaModificacion { get; set; }

        [Display(Name = "Usuario Creacion")]
        [NotMapped]
        public string Uuno { get; set; }
        [Display(Name = "Usuario Modificacion")]
        [NotMapped]
        public string Udos { get; set; }


        [NotMapped]
        public string Acti_Descripcion { get; set; }
        [NotMapped]
        public string Cate_Descripcion { get; set; }
        [NotMapped]
        public string Acti_NoSerio { get; set; }
        [NotMapped]
        public DateTime Acti_FechaAdquisicion { get; set; }
        [NotMapped]
        public decimal Acti_Precio { get; set; }
        [NotMapped]
        public decimal VidU_VidaEstimada { get; set; }
        [NotMapped]
        public decimal ValorResidual { get; set; }
        [NotMapped]
        public decimal CostoDepreciable { get; set; }

        [NotMapped]
        public decimal TasaResidualPorcentaje { get; set; }
        [NotMapped]
        public decimal TasaAnual { get; set; }
        [NotMapped]
        public decimal PeriodoAnios { get; set; }
        [NotMapped]
        public decimal Enero { get; set; }
        [NotMapped]
        public decimal Febrero { get; set; }
        [NotMapped]
        public decimal Marzo { get; set; }
        [NotMapped]
        public decimal Abril { get; set; }
        [NotMapped]
        public decimal Mayo { get; set; }
        [NotMapped]
        public decimal Junio { get; set; }
        [NotMapped]
        public decimal Julio { get; set; }
        [NotMapped]
        public decimal Agosto { get; set; }
        [NotMapped]
        public decimal Septiembre { get; set; }
        [NotMapped]
        public decimal Octubre { get; set; }
        [NotMapped]
        public decimal Noviembre { get; set; }
        [NotMapped]
        public decimal Diciembre { get; set; }
        [NotMapped]
        public decimal DepreciacionPeriodo { get; set; }
        [NotMapped]
        public decimal DepreciacionAcumulada { get; set; }
        [NotMapped]
        public decimal ValorEnLibros { get; set; }
        [NotMapped]
        public decimal TotalCostoOriginal { get; set; }
        [NotMapped]
        public decimal TotalValorResidual { get; set; }
        [NotMapped]
        public decimal TotalCostoDepreciable { get; set; }
        [NotMapped]
        public decimal TotalDepreciacionMensual { get; set; }
        [NotMapped]
        public decimal TotalDepreciacionPeriodo { get; set; }
        [NotMapped]
        public decimal TotalDepreciacionAcumulada { get; set; }
        [NotMapped]
        public decimal TotalValorEnLibros { get; set; }
        [NotMapped]
        public decimal TasaResidual { get; set; }
        [NotMapped]
        public decimal TasaDepreciacion { get; set; }
        [NotMapped]
        public DateTime FechaInicio { get; set; }
        [NotMapped]
        public DateTime FechaFinal { get; set; }
        public IEnumerable<EmpleadosViewmodel> Empleados { get; set; }

    }
}