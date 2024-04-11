using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SistemaActivos.Common.Model;
using SistemaActivos.Entities.Entities;
using SistemaDeActivos.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemasActivos.API.Controllers
{
    [ApiController]
    [Route("/API/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly ActiveService _activeService;
        private readonly IMapper _mapper;

        public UsuarioController(ActiveService activeService, IMapper mapper)
        {
            _activeService = activeService;
            _mapper = mapper;
        }

        [HttpGet("Listado")]
        public IActionResult Index()
        {
            var listado = _activeService.ListadoUsuario();

            return Ok(listado);
        }



        [HttpPost("CreateUsuario")]
        public IActionResult Insert(UsuariosViewmodel item)
        {
            var model = _mapper.Map<tbUsuario>(item);
            var modelo = new tbUsuario()
            {
                Usua_Nombre = item.Usua_Nombre,
                Usua_Contra = item.Usua_Contra,
                Empl_Id = item.Empl_Id,
                Role_Id = item.Role_Id,
                Usua_Admin = item.Usua_Admin,
                Usua_UsuarionCreacion = 1,
                Usua_FechaCreacion = DateTime.Now,
                

            };
            var list = _activeService.InsertaUsuario(modelo);
            if (list.Success)
            {
                return Ok(list);
            }
            else
            {
                return Problem(list.Message);
            }
        }




        [HttpPut("ActualizarUsuario")]
        public IActionResult Update(UsuariosViewmodel item)
        {

            var model = _mapper.Map<tbUsuario>(item);
            var modelo = new tbUsuario()
            {
                Usua_Id = item.Usua_Id,
                Usua_Nombre = item.Usua_Nombre,
                Empl_Id = item.Empl_Id,
                Role_Id = item.Role_Id,
                Usua_Admin = item.Usua_Admin,
                Usua_UsuarionModificacion = 1,
                Usua_FechaModificacion = DateTime.Now,

            };
            var list = _activeService.ActualizarUsuario(modelo);
            if (list.Success)
            {
                return Ok(list);
            }
            else
            {
                return Problem(list.Message);
            }
        }






        [HttpGet("LlenarUsuario/{Usua_Id}")]
        public IActionResult LlenarUsuario(int Usua_Id)
        {
            var llenar = _activeService.BuscarUsuario(Usua_Id).ToList();
            var id = llenar.FirstOrDefault()?.Usua_Id;
            var nombre = llenar.FirstOrDefault()?.Usua_Nombre;
            var contra = llenar.FirstOrDefault()?.Usua_Contra;
            var empleado = llenar.FirstOrDefault()?.Empleado;
            var rol = llenar.FirstOrDefault()?.Rol;
            var admin = llenar.FirstOrDefault()?.Usua_Admin;
            var idRol = llenar.FirstOrDefault()?.Role_Id;
            var idEmpl = llenar.FirstOrDefault()?.Empl_Id;



            return Json(new { success = true, id, nombre, contra, empleado, rol, admin, idRol, idEmpl });
        }


        [HttpDelete("EliminarUsuario/{Usua_Id}")]
        public IActionResult Delete(int Usua_Id)
        {

            var list = _activeService.EliminarUsuario(Usua_Id);

            if (list.Success)
            {
                return Ok(list);
            }
            else
            {
                return Problem(list.Message);
            }

        }

        [HttpGet("DetallesUsuario")]
        public IActionResult Details(int Usua_Id)
        {
            var list = _activeService.BuscarDetalleUsuario(Usua_Id);

            return Ok(list);
        }





        //ddl
        [HttpGet("listadoRoles")]
        public async Task<IActionResult> ListadoRoles()
        {
            var result = await _activeService.ObtenerRoles();

            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return StatusCode(500, new { message = result.Message });
            }
        }


    }
}
