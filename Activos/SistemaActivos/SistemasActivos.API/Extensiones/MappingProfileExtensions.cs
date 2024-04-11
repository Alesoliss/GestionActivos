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
            CreateMap<ActivosViewmodel, tbActivos>().ReverseMap();
            CreateMap<CategoriasViewmodel, tbCategorias>().ReverseMap();
            CreateMap<UsuariosViewmodel, tbUsuario>().ReverseMap();
            CreateMap<VidaUtilViewmodel, tbVidaUtil>().ReverseMap();
            CreateMap<RolesViewModel, tbRoles>().ReverseMap();
            CreateMap<PantallasViewModel, tbPantallas>().ReverseMap();
            CreateMap<PantallasPorRolesViewModel, tbPantallasPorRoles>().ReverseMap();
            CreateMap<CargosViewModel, tbCargos>().ReverseMap();
            CreateMap<EstadosCivilesViewModel, tbEstadosCiviles>().ReverseMap();
            CreateMap<MunicipiosViewModel, tbMunicipios>().ReverseMap();
            CreateMap<SucursalesViewModel, tbSucursales>().ReverseMap();
        }
    }
}