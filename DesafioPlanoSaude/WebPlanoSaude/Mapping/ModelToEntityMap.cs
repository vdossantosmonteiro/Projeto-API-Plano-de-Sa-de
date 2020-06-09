using AutoMapper;
using ClassLibraryDados.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebPlanoSaude.Models;

namespace WebPlanoSaude.Mapping
{
    public class ModelToEntityMap : Profile
    {
        public ModelToEntityMap()
        {
            CreateMap<TitularCadastroModel, Titular>();
            CreateMap<TitularEdicaoModel, Titular>();

            CreateMap<DependenteCadastroModel, Dependente>();
            CreateMap<DependenteEdicaoModel, Dependente>();
        }
    }
}