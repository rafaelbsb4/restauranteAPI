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
    public class PratosController : ApiController
    {
        private PratosRepository _PratosRepository;
        private Pratos entity;
        public PratosRepository PratosRepository
        {
            get
            {
                if (_PratosRepository == null)
                    _PratosRepository = new PratosRepository();
                return _PratosRepository;
            }
            set { _PratosRepository = value; }
        }

        public List<Pratos> Get()
        {
            List<Pratos> lista = new List<Pratos>();
            lista = PratosRepository.GetAll();
            return lista;
        }

        public Pratos Get(int id)
        {
            return PratosRepository.GetById(id);
        }

        public Boolean Post(Pratos entity)
        {
            try
            {
                PratosRepository.Create(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Boolean Put(int id, Pratos entity)
        {
            try
            {
                PratosRepository.Update(id, entity);
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
                entity = PratosRepository.GetById(id);
                PratosRepository.Delete(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

    


    
