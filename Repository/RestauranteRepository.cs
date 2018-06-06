using ProjetoNovo.Migrations;
using ProjetoNovo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoNovo.Repository
{
    public class RestauranteRepository : BaseRepository
    {
        private Restaurante rest;
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

        public Restaurante GetById(int id)
        {
            return db.Restaurante.FirstOrDefault(r => r.idRestaurante == id);
        }

        public List<Restaurante> GetAll()
        {
            return db.Restaurante.OrderBy(r => r.nomeRestaurante).ToList();
        }

        public void Create(Restaurante entity)
        {
            db.Restaurante.Add(entity);
            db.SaveChanges();
        }

        public void Update(int id, Restaurante entity)
        {
            rest = this.GetById(id);
            rest.nomeRestaurante = entity.nomeRestaurante;
            db.Entry(rest).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Restaurante entity) 
        {
            List<Pratos> lista = new List<Pratos>();
            lista = PratosRepository.GetByIdRestaurante(entity.idRestaurante);
                
            foreach (Pratos p in lista)
            {
                PratosRepository.Delete(p);
            }

            db.Restaurante.Remove(entity);
            db.SaveChanges();
        }

    }
}