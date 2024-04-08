using AutoMapper;
using SistemaActivos.Common.Model;
using SistemaActivos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemasActivos.API.Extensiones
{
    public class MappingProfileExtensions : Profile
    {
        public MappingProfileExtensions()
        {
            CreateMap<DepartamentosViewmodel, tbDepartamentos>().ReverseMap();
            CreateMap<EmpleadosViewmodel, tbEmpleados>().ReverseMap();
            CreateMap<RolesViewModel, tbRoles>().ReverseMap();
            CreateMap<PantallasViewModel, tbPantallas>().ReverseMap();
            CreateMap<PantallasPorRolesViewModel, tbPantallasPorRoles>().ReverseMap();
            CreateMap<UsuariosViewModel, tbUsuario>().ReverseMap();
            CreateMap<CargosViewModel, tbCargos>().ReverseMap();
            CreateMap<EstadosCivilesViewModel, tbEstadosCiviles>().ReverseMap();
            CreateMap<MunicipiosViewModel, tbMunicipios>().ReverseMap();
            CreateMap<SucursalesViewModel, tbSucursales>().ReverseMap();
        }
    }
}