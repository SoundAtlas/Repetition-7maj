using System;
using System.Collections.Generic;
using System.Text;

namespace Repetition_7_5
{
    public interface IRepository<T> where T : IHasId
    {
        void Add(T item);
        bool Remove(int id);
        T? GetById(int id);
        IEnumerable<T> GetAll();
        void Save();
    }
}
