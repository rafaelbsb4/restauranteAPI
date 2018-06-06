using ProjetoNovo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace ProjetoNovo.Controllers
{
    [EnableCors("*", "*", "*")]
    public class RestauranteController : ApiController
    {
        private RestauranteRepository _RestauranteRepository;

        private Restaurante entity;
        public RestauranteRepository RestauranteRepository
        {
            get
            {
                if (_RestauranteRepository == null)
                    _RestauranteRepository = new RestauranteRepository();
                return _RestauranteRepository;
            }
            set { _RestauranteRepository = value; }
        }

        public List<Restaurante> Get()
        {
            List<Restaurante> lista = new List<Restaurante>();
            lista = RestauranteRepository.GetAll();
            return lista;
        }

        public Restaurante Get(int id)
        {
            return RestauranteRepository.GetById(id);
        }

        public Boolean Post(Restaurante entity)
        {
            try
            {
                RestauranteRepository.Create(entity);
                return true;
            } catch(Exception ex) {
                return false;
            }
        }

        public Boolean Put(int id, Restaurante entity)
        {
            try
            {
                RestauranteRepository.Update(id, entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Boolean Delete(int id)
        {
            try
            {
                entity = RestauranteRepository.GetById(id);
                RestauranteRepository.Delete(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
 }
