using AutoMapper;
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

       [HttpPost("Create")]
        public  IActionResult Insert(RolesViewModel item)
        {
            var model = _mapper.Map<RolesViewModel>(item);
            var modelo = new tbRoles()
            {
                Role_Descripcion = item.Role_Descripcion,
                Role_UsuarionCreacion = 1,
                Role_FechaCreacion = DateTime.Now
            };
            var list  = _accesoService.InsertarRol(modelo);
            //if (!String.IsNullOrEmpty(resultado))
            //{
            //    TempData["Error"] = "El Registro ya existe";

            //}
            //else
            //{
            //    TempData["Exito"] = "Insertado con exito";

            //}
            //HttpContext.Session.SetString("RolID", RolID.ToString());
            //var listadoPantallas = _accesoServices.ListPant(RolID);
            //var listadoPant = _mapper.Map<IEnumerable<PantallasViewModel>>(listadoPantallas);
            //ViewBag.ConsultaPantalla = listadoPant.ToList();
            //var listadoPantallasRoles = _accesoServices.ListPantRole(RolID);
            //var listadoPantRoles = _mapper.Map<IEnumerable<PantallasPorRolesViewModel>>(listadoPantallasRoles);
            //ViewBag.ConsultaPantallaPorRoles = listadoPantRoles.ToList();
            return Ok(list);

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

            //var listadoPantallas = _accesoServices.ListPant((int)RolID);
            //var listadoPant = _mapper.Map<IEnumerable<PantallasViewModel>>(listadoPantallas);
            //ViewBag.ConsultaPantalla = listadoPant.ToList();
            //var listadoPantallasRoles = _accesoServices.ListPantRole((int)RolID);
            //var listadoPantRoles = _mapper.Map<IEnumerable<PantallasPorRolesViewModel>>(listadoPantallasRoles);
            //ViewBag.ConsultaPantallaPorRoles = listadoPantRoles.ToList();
            //if (!String.IsNullOrEmpty(mensaje))
            //    ModelState.AddModelError("", mensaje);
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
