using AutoMapper;
using SistemaActivos.Entities.Entities;
using SistemasActivos.API.Model;
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
        }
    }
}
