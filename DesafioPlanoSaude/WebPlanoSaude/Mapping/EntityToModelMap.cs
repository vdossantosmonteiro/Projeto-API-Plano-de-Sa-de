using AutoMapper;
using ClassLibraryDados.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebPlanoSaude.Models;

namespace WebPlanoSaude.Mapping
{
    public class EntityToModelMap : Profile
    {
        public EntityToModelMap()
        {
            CreateMap<Titular, TitularConsultaModel>()
            .ForMember(depentente => depentente.dependentes,
                d => d.MapFrom(m => m.Dependentes));


            CreateMap<Dependente, DependenteConsultaModel>().ForMember(titular => titular.titular, 
                d => d.MapFrom(m => m.Titular));
        }
    }
}