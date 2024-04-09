using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaActivos.Common.Model;
using SistemaActivos.Entities.Entities;
using SistemaDeActivos.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SistemasActivos.API.Controllers
{
    [ApiController]
    [Route("/API/[controller]")]
    public class RoleController : Controller
    {
        private readonly AccesoService _accesoService;
        private readonly IMapper _mapper;

        public RoleController(AccesoService accesoService, IMapper mapper)
        {
            _accesoService = accesoService;
            _mapper = mapper;
        }

        [HttpGet("Listado")]
        public IActionResult Index()
        {
            var listado = _accesoService.ListRoles();
            return Ok(listado);
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            var listado =  _accesoService.ListPant(0);
            if (listado.Success)
            {
                return Ok(listado);
            }
            else
            {
                return StatusCode(500, new { message = listado.Message });
            }

            
        }

        [HttpGet("PantallasPorRoles")]
        public IActionResult CreateParo()
        {
            var listado2 = _accesoService.ListPantRole(0);
            if (listado2.Success)
            {
                return Ok(listado2);
            }
            else
            {
                return StatusCode(500, new { message = listado2.Message });
            }
        }

        [HttpPost("Create")]
        public  IActionResult Create(RolesViewModel item)
        {
            var model = _mapper.Map<RolesViewModel>(item);
            var modelo = new tbRoles()
            {
                Role_Descripcion = item.Role_Descripcion,
                Role_UsuarionCreacion = 1,
                Role_FechaCreacion = DateTime.Now
            };
            (var list, int RolID)  = _accesoService.InsertarRol(modelo);
            list.Message = RolID.ToString();
                
            return Ok(list);

        }

        [HttpGet("Actualizar")]
        public IActionResult Editar()
        {

            var listadoPantallas = _accesoService.ListPant(1);
            var listadoPant = _mapper.Map<IEnumerable<PantallasViewModel>>(listadoPantallas);
            ViewBag.ConsultaPantalla = listadoPant.ToList();
            int roleID = 0;
            var listadoPantallasRoles = _accesoService.ListPantRole(roleID);
            var listadoPantRoles = _mapper.Map<IEnumerable<PantallasPorRolesViewModel>>(listadoPantallasRoles);
            ViewBag.ConsultaPantallaPorRoles = listadoPantRoles.ToList();
            return Ok();
        }

        [HttpPut("Actualizar")]
        public IActionResult Editar(RolesViewModel item)
        {
            int RolID = item.Role_Id;
            var model = _mapper.Map<tbRoles>(item);
            var modelo = new tbRoles()
            {
                Role_Id = RolID,
                Role_Descripcion = item.Role_Descripcion,
                Role_UsuarioModificacion = 1,
                Role_FechaModificacion = DateTime.Now
            };

            var list = _accesoService.ActualizarRol(modelo);
            //if (!String.IsNullOrEmpty(mensaje))
            //{
            //    TempData["Error"] = "El Registro ya existe";

            //}
            //else
            //{
            //    TempData["Exito"] = "Actualizado con exito";

            //}

            var listadoPantallas = _accesoService.ListPant((int)RolID);
            var listadoPant = _mapper.Map<IEnumerable<PantallasViewModel>>(listadoPantallas);
            ViewBag.ConsultaPantalla = listadoPant.ToList();
            var listadoPantallasRoles = _accesoService.ListPantRole((int)RolID);
            var listadoPantRoles = _mapper.Map<IEnumerable<PantallasPorRolesViewModel>>(listadoPantallasRoles);
            ViewBag.ConsultaPantallaPorRoles = listadoPantRoles.ToList();
            //if (!String.IsNullOrEmpty(mensaje))
            //    ModelState.AddModelError("", mensaje);-
            //else
            //    return RedirectToAction("Index");

            return Ok(list);
        }

        [HttpDelete("/Roles/{Role_Id}")]
        public IActionResult Eliminar(int Role_Id)
        {
            var List = _accesoService.EliminarRol(Role_Id);
            
            return Ok(List);
        }
    }
}
