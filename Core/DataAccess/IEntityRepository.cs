using Core.Entities;
using System.Linq.Expressions;

namespace Core.DataAccess       //Core katmanı kesinlikle diğer katmanları referans almaz.
{
    //generic constraint
    //class: referans tip demek
    //IEntity: sadece IEntity ve onun implementlerinden olabilir.
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
