using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using ClassLibraryDados.Entities;
using ClassLibraryDados.Repositories;
using WebPlanoSaude.Models;

namespace WebPlanoSaude.Controllers
{
    public class DependenteController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(DependenteCadastroModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var dependente = Mapper.Map<Dependente>(model);

                    var repository = new DependenteRepository();
                    repository.Insert(dependente);

                    return Request.CreateResponse(HttpStatusCode.OK, "Dependente cadastrado com sucesso");
                }
                catch (Exception e)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Ocorreu erro de validação");
            }


        }

        [HttpPut]
        public HttpResponseMessage Put(DependenteEdicaoModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var dependente = Mapper.Map<Dependente>(model);

                    var repository = new DependenteRepository();
                    repository.Update(dependente);

                    return Request.CreateResponse(HttpStatusCode.OK, "Dependente editado com sucesso");
                }
                catch (Exception e)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Ocorreu erro de validação");
            }

        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var repository = new DependenteRepository();
                repository.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }


        }

        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {

                var repository = new DependenteRepository();
                var model = repository.SelectAllDependente();//.Select(p => new DependenteConsultaModel()

                var lista = Mapper.Map<List<DependenteConsultaModel>>(model);

                //{
                //    IdDependente = p.IdDependente,
                //    Nome = p.Nome,
                //    Contrato = p.Contrato,
                //    Cpf = p.Cpf,
                //    IdTitular = p.IdTitular,
                //
                //    titular = new TitularConsultaModel()
                //    {
                //        Cpf = p.Titular.Cpf,
                //        Nome = p.Titular.Nome,
                //        Contrato = p.Titular.Contrato,
                //        IdTitular = p.Titular.IdTitular
                //
                //    }
                //
                //});




                return Request.CreateResponse(HttpStatusCode.OK, lista);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [HttpGet]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var repository = new DependenteRepository();
                var dependente = repository.SelectByIdDependente(id);

                var model = Mapper.Map<DependenteConsultaModel>(dependente);


                //var model = new DependenteConsultaModel();
                //
                //model.IdDependente = dependente.IdDependente;
                //model.Nome = dependente.Nome;
                //model.Contrato = dependente.Contrato;
                //model.Cpf = dependente.Cpf;
                //model.IdTitular = dependente.IdTitular;
                //
                //model.titular = new TitularConsultaModel()
                //{
                //    IdTitular = dependente.Titular.IdTitular,
                //    Nome = dependente.Titular.Nome,
                //    Contrato = dependente.Titular.Contrato,
                //    Cpf = dependente.Titular.Cpf,
                //
                //
                //};


                return Request.CreateResponse(HttpStatusCode.OK, model);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }

        }

    }
}
