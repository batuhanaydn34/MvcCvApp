using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using MvcCv.Models.Entity;

namespace MvcCv.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        DbCvEntities db = new DbCvEntities();

        //Listeleme
        public List<T> List()
        {
            return db.Set<T>().ToList();
        }

         //Ekleme
        public void Tadd(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges();

        }

        //Silme
        public void TDelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }

        //ID e Göre Getirme
        public T TGet(int id) 
        {
            return db.Set<T>().Find(id);
        
        }

        //Update
        public void TUpdate(T p) 
        {
            db.SaveChanges();
        
        }

        public T Find(Expression<Func<T,bool>> where) 
        {
            return db.Set<T>().FirstOrDefault(where);
        }



    }
}