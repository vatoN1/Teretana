using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public interface IDaoCrud<T>
    {
        long create(T entity);
        T read(T entity);
        T update(int i, T entity);
        void delete(T entity);
        T getById(long id);
        List<T> GetAll();
        List<T> getByExample(string name, string values);
    }
}
