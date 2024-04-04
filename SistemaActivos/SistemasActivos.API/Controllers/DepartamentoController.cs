using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaActivos.DataAccess;
using SistemaDeActivos.BusinessLogic;
using AutoMapper;
using SistemaActivos.Entities.Entities;
using SistemasActivos.API.Model;

namespace SistemasActivos.API.Controllers
{
    [ApiController]
    public class DepartamentoController : Controller
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public DepartamentoController(GeneralServices generalService, IMapper mapper)
        {
            _generalServices = generalService;
            _mapper = mapper;
        }

        [HttpGet("Listado")]

        public IActionResult Index()
        {
            var listado = _generalServices.ListadoDepto1();

            return Ok(listado);
        }


        [HttpPost("Insert")]
        public IActionResult Insert(DepartamentosViewmodel item)
        {
            var model = _mapper.Map<tbDepartamentos>(item);
            var modelo = new tbDepartamentos()
            {
                Depa_Codigo = item.Depa_Codigo,
                Depa_Descripcion = item.Depa_Descripcion,
                Depa_UsuarioCreacion = item.Depa_UsuarioCreacion,
                Depa_FechaCreacion = item.Depa_FechaCreacion

            };
            var list = _generalServices.InsertarDepto(modelo);
            return Ok(list);
        }

        [HttpPost("Actualizar")]
        public IActionResult Update (DepartamentosViewmodel item)
        {
            var model = _mapper.Map<tbDepartamentos>(item);
            var modelo = new tbDepartamentos()
            {
                Depa_Codigo = item.Depa_Codigo,
                Depa_Descripcion = item.Depa_Descripcion,
                Depa_UsuarioModificacion = item.Depa_UsuarioModificacion,
                Depa_FechaModificacion = item.Depa_FechaModificacion

            };
            var list = _generalServices.ActualizarDepto(modelo);
            return Ok(list);
        }

        [HttpPost("Departamento/LlenarDepartamentos/{Depa_Codigo}")]
        public IActionResult LlenarDeptos(string Depa_Codigo)
        {
            string error;
            var llenar = _generalServices.BuscarDepto(Depa_Codigo).ToList();
            //HttpContext.Session("id", Carg_Id);
            var descripcion = llenar.FirstOrDefault()?.Depa_Descripcion;
            return Json(new { success = true, descripcion });
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete (DepartamentosViewmodel item)
        {
            var modelo = item.Depa_Codigo;

            var depa_codigo = modelo.ToString();
            var list = _generalServices.EliminarDepartamento(depa_codigo);

            return Ok(list);

        }
    }
}
