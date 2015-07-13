using System;
using System.Collections.Generic;

namespace MedicalChestProject
{
    public interface ITableManeger<TTableItem>
    {
        void Load();
        void Add(TTableItem item);
        void Remove(TTableItem item);
        void Update(TTableItem oldItem, TTableItem newItem);
        void SaveChanges();
        void Clear();
        void Reload();
        List<TTableItem> GetData();
    }
}
