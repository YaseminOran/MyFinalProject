using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    //class:referans tip
    //ientity:ientity olabilir ya da ientity'yi implemente eden bir nesne olabilir
    //new(): new'lenebilir olmalı
   public interface IEntityRepository <T> where T:class,IEntity
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
       
    }
}
