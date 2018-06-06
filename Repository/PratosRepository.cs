using ProjetoNovo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoNovo.Repository
{
    public class PratosRepository : BaseRepository
    {
        private Pratos prat;
        public Pratos GetById(int id)
        {
            return db.Pratos.FirstOrDefault(r => r.idPrato == id);
        }

        public List<Pratos> GetAll()
        {
            return db.Pratos.OrderBy(r => r.nomePrato).ToList();
        }

        public List<Pratos> GetByIdRestaurante(int id)
        {
            return db.Pratos.Where(x => x.idRestaurante == id).ToList();
        }

        public void Create(Pratos entity)
        {
            db.Pratos.Add(entity);
            db.SaveChanges();
        }

        public void Update(int id, Pratos entity)
        {
            prat = this.GetById(id);
            prat.nomePrato = entity.nomePrato;
            prat.valorPrato = entity.valorPrato;
            prat.idRestaurante = entity.idRestaurante;
            db.Entry(prat).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Pratos entity)
        {
            db.Pratos.Remove(entity);
            db.SaveChanges();
        }
    }
}