using Core.FW.CoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.FW.CoreService
{
    public interface ICoreService<T> where T : BaseEntity
    {
        //ekleme
        string Create(T model);

        //listeye ekleme
        string Create(List<T> model);

        //getirme
        T GetById(Guid ID);

        //liste getirme

        List<T> GetList();

        //güncelleme
        string Update(T model);

        //silme
        void RemoveForce(T model);

        //any
        bool Any(Expression<Func<T, bool>> exp);
        List<T> GetDefault(Expression<Func<T, bool>> exp);


    }
}
