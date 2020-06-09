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
    public class TitularController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(TitularCadastroModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var titular = Mapper.Map<Titular>(model);

                    var repository = new TitularRepository();
                    repository.Insert(titular);

                    return Request.CreateResponse(HttpStatusCode.OK, "Titular cadastrado com sucesso");
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
        public HttpResponseMessage Put(TitularEdicaoModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var titular = Mapper.Map<Titular>(model);

                    var repository = new TitularRepository();
                    repository.Update(titular);


                    return Request.CreateResponse(HttpStatusCode.OK, "Titular editado com sucesso");
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
                var repository = new TitularRepository();
                repository.Delete(id);

                return Request.CreateResponse(HttpStatusCode.OK, "Titular excluído com sucesso");
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [HttpGet]
        public HttpResponseMessage GetAll(int quantidadeRegistro, int quantidadePularRegistro)
        {
            try
            {
                var repository = new TitularRepository();
                var titular = repository.SelectAllTitular(quantidadeRegistro, quantidadePularRegistro);

                var model = Mapper.Map<List<TitularConsultaModel>>(titular);


                return Request.CreateResponse(HttpStatusCode.OK, model);
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
                var repository = new TitularRepository();
                var titular = repository.SelectByIdTitular(id);

                var model = Mapper.Map<TitularConsultaModel>(titular);


                return Request.CreateResponse(HttpStatusCode.OK, model);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }
}
