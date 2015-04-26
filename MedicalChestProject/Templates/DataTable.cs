using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalChestProject.Templates
{
    public class DataTable<TTable> : ICollection<TTable>
    {
        public event Action<TTable> ItemAdded;
        public event Action<TTable> ItemDeleted;
        public event Action<TTable> ItemUpdated;
        List<TTable> data;
        public DataTable()
        {
            data = new List<TTable>();
        }
        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(TTable item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(TTable[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(TTable item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<TTable> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(TTable item)
        {
            throw new NotImplementedException();
        }
    }
}
