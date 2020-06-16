using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpGenericsAndCollections._Generics
{
    public class Repository<T> where T : BaseModel, new()
    {
        private List<T> database = new List<T>();

        public void Insert(T newValue)
        {
            database.Add(newValue);
        }

        public IEnumerable<T> GetAll()
        {
            return database;
        }

        public T GetById(int id)
        {
            return database.FirstOrDefault(x => x.Id == id);
        }
    }
}
