﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EcoS.DAL.Infrastructure.Contract
{
    public interface IBaseRepository<T>
    {

      
        T SingleOrDefault(Expression<Func<T, bool>> whereCondition);

      
        IEnumerable<T> GetAll();

      
        IEnumerable<T> GetAll(Expression<Func<T, bool>> whereCondition);

       
        T Insert(T entity);

        
        void Update(T entity);

        
        void UpdateAll(IList<T> entities);

        
        void Delete(Expression<Func<T, bool>> whereCondition);

        
        bool Exists(Expression<Func<T, bool>> whereCondition);

    }

}

