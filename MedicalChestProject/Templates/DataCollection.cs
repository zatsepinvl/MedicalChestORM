using System;
using System.Collections.Generic;

namespace MedicalChestProject
{
    public class DataCollection<T> : ICollection<T>
    {
        public event Action<T> ItemAdded;
        public event Action<T> ItemRemoved;
        public event Action<T> ItemUpdated;
        List<T> data;
        public DataCollection()
        {
            data = new List<T>();
        }

        public void Clear()
        {
            data.Clear();
        }
        public bool Contains(T item)
        {
            return data.Contains(item);
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            data.CopyTo(array, arrayIndex);
        }
        public int Count
        {
            get { return data.Count; }
        }
        public bool IsReadOnly
        {
            get { return false; }
        }
        public virtual bool Remove(T item)
        {
            if (data.Contains(item))
            {
                data.Remove(item);
                OnItemRemoved(item);
                return true;
            }
            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return data.GetEnumerator();
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return data.GetEnumerator();
        }

        public virtual void Add(T item)
        {
            data.Add(item);
            OnItemAdded(item);
        }
        public virtual bool Update(T oldItem, T newItem)
        {
            if(data.Contains(oldItem))
            {
                data[data.IndexOf(oldItem)] = newItem;
                OnItemUpdate(newItem);
                return true;
            }
            return false;
        }

        public T this[int index]
        {
            get { return data[index]; }
        }
        protected virtual void OnItemAdded(T item) { if (ItemAdded != null) { ItemAdded(item); } }
        protected virtual void OnItemRemoved(T item) { if (ItemRemoved != null) { ItemRemoved(item); } }
        protected virtual void OnItemUpdate(T item) { if (ItemUpdated != null) { ItemUpdated(item); } }

        public void LoadData(List<T> data)
        {
            this.data = data;
        }

    }
}
