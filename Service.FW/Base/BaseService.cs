using Core.FW.CoreEntity;
using Core.FW.CoreService;
using Model.FW.Context;
using Model.FW.DesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.FW.Base
{

    public abstract class BaseService<T> : ICoreService<T> where T : BaseEntity
    {

        AppDbContext db = Singleton.Context;
     

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Any(exp);
        }

        public string Create(T model)
        {
            try
            {
                model.ID = Guid.NewGuid();
                db.Set<T>().Add(model);
                db.SaveChanges();
                return $"kayıt işlemi başarılı.";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Create(List<T> model)
        {
            try
            {
                foreach (T item in model)
                {
                    item.ID = Guid.NewGuid();
                    db.Set<T>().Add(item);
                    db.SaveChanges();


                }
                return $"liste kaydetme işlemi başarılı.";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public T GetById(Guid ID)
        {
            return db.Set<T>().Find(ID);
        }

        public List<T> GetDefault(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Where(exp).ToList();
        }

        public List<T> GetList()
        {
            return db.Set<T>().ToList();
        }

        public void RemoveForce(T model)
        {
            try
            {
                if(model.ID!=null)
                {
                    T deleted = GetById(model.ID);
                    db.Set<T>().Remove(deleted);
                    db.SaveChanges();
                }

            }
            catch (Exception)
            {

                return;
            }
        }

        public string Update(T model)
        {
            try
            {
                T entity = GetById(model.ID);
                var entry = db.Entry(entity);
                return "veri güncelleme işlemi başarılı";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

    }
}
