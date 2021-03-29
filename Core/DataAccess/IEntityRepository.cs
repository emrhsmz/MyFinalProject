using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // Generic constraint // generic kısıt // sadece db-entities class gelebilir.
    // class: referans tip
    // T referans tip olmalı ya IEntity olabilir yada IEntity implamente etmiş class-nesne olabilir.
    // new() : new'lenebilir
    public interface IEntityRepository<T> where T:class,IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}