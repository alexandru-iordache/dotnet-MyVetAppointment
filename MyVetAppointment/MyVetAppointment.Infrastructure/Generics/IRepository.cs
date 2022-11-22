﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VetAppointment.Infrastructure.Generics
{
    public interface IRepository<T>
    {
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void SaveChanges();
    }
}
