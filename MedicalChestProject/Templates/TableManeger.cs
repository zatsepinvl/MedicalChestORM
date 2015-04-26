using System;
using System.Collections.Generic;
using LinqToDB.Data;
using LinqToDB;

namespace MedicalChestProject
{
    public abstract class TableManeger<TDatabase, TTable> : ErrorMessageLogger<string>
        where TDatabase : DataConnection, new()
    {
        public DataCollection<TTable> Data { get; set; }
        protected List<TTable> UpdateList { get; set; }
        protected List<TTable> InsertList { get; set; }
        protected List<TTable> DeleteList { get; set; }
        
        public bool DataLoaded { get; protected set; }

        public virtual DataCollection<TTable> GetData()
        {
            if (!DataLoaded)
            {
                LoadAll();
            }
            return Data;
        }

        protected virtual void Init()
        {
            Data = new DataCollection<TTable>();
            UpdateList = new List<TTable>();
            InsertList = new List<TTable>();
            DeleteList = new List<TTable>();
        }

        public abstract void LoadAll();
        public virtual void SaveChanges()
        {
            Update();
            Delete();
            Insert();
        }
        public virtual void Update()
        {
            ExecuteQuery((database) =>
            {
                foreach (TTable u in Data)
                {
                    database.Update(u);
                }
                DeleteList.Clear();
            });
        }
        public virtual void Delete()
        {
            ExecuteQuery((database) =>
            {
                foreach (TTable u in DeleteList)
                {
                    database.Delete(u);
                }
                DeleteList.Clear();
            });
        }
        public virtual void Insert()
        {
            ExecuteQuery((database) =>
            {
                foreach (TTable u in InsertList)
                {
                    database.Insert(u);
                }
                InsertList.Clear();
            });
        }
        public virtual void Clear()
        {
            Data.Clear();
            InsertList.Clear();
            DeleteList.Clear();
            UpdateList.Clear();
        }
        public virtual void Reload()
        {
            Clear();
            LoadAll();
        }


        protected virtual void ExecuteQuery(Action<TDatabase> query)
        {
            using (var database = new TDatabase())
            {
                try
                {
                    query(database);
                }
                catch (Exception ex)
                {
                    SendError(ex.Message);
                }
            }
        }
        protected virtual void ExecuteQuery(Action<TDatabase, object[]> query, object[] args)
        {
            using (var database = new TDatabase())
            {
                try
                {
                    query(database, args);
                }
                catch (Exception ex)
                {
                    SendError(ex.Message);
                }
            }
        }


    }
}
