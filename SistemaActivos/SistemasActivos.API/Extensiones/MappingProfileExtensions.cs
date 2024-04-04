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
            CreateMap<EmpleadosViewmodel, tbDepartamentos>().ReverseMap();

        }
    }
}
