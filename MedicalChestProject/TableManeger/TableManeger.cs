using System;
using System.Collections.Generic;
using LinqToDB.Data;
using LinqToDB;

namespace MedicalChestProject
{
    public abstract class TableManeger<TDatabase, TTable> : ErrorMessageLogger<string>, ITableManeger<TTable>
        where TDatabase : DataConnection, new()
    {
        protected const string somethingWentWrong = "Что-то пошло не так...";
        protected const string changesSavedSuccessful = "Изменения cохранены успешно.";

        protected List<TTable> Data { get; set; }
        protected List<TTable> UpdateList { get; set; }
        protected List<TTable> InsertList { get; set; }
        protected List<TTable> DeleteList { get; set; }

        public bool NeedSaveChanges { get; protected set; }
        public bool DataLoaded { get; protected set; }

        public virtual List<TTable> GetData()
        {
            if (!DataLoaded)
            {
                Load();
            }
            return Data;
        }

        protected virtual void Init()
        {
            Data = new List<TTable>();
            UpdateList = new List<TTable>();
            InsertList = new List<TTable>();
            DeleteList = new List<TTable>();
        }

        protected virtual bool Update()
        {
            return (ExecuteQuery((database) =>
            {
                foreach (TTable u in UpdateList)
                {
                    database.Update(u);
                }
                UpdateList.Clear();
            }));
        }
        protected virtual bool Delete()
        {
            return (ExecuteQuery((database) =>
             {
                 foreach (TTable u in DeleteList)
                 {
                     database.Delete(u);
                 }
                 DeleteList.Clear();
             }));
        }
        protected virtual bool Insert()
        {
            return (ExecuteQuery((database) =>
            {
                foreach (TTable u in InsertList)
                {
                    database.Insert(u);
                }
                InsertList.Clear();
            }));
        }
        protected bool ExecuteQuery(Action<TDatabase> query)
        {
            using (var database = new TDatabase())
            {
                try
                {
                    query(database);
                    return true;
                }
                catch (Exception ex)
                {
                    SendMessage(ex.Message);
                    SendError(ex.Message);
                    return false;
                }
            }
        }
        protected bool ExecuteQuery(Action<TDatabase, object[]> query, object[] args)
        {
            using (var database = new TDatabase())
            {
                try
                {
                    query(database, args);
                    return true;
                }
                catch (Exception ex)
                {
                    SendMessage(ex.Message);
                    SendError(ex.Message);
                    return false;
                }
            }
        }

        public virtual void Clear()
        {
            Data.Clear();
            InsertList.Clear();
            DeleteList.Clear();
            UpdateList.Clear();
            DataLoaded = false;
            NeedSaveChanges = false;
        }
        public virtual void Reload()
        {
            Clear();
            Load();
        }
        public virtual void SaveChanges()
        {
            if (NeedSaveChanges)
            {
                bool error = false;
                if (!Update()) { error = true; }
                if (!Insert()) { error = true; }
                if (!Delete()) { error = true; }
                if (!error) { SendMessage(changesSavedSuccessful); }
                Reload();
            }
        }
        public abstract void Load();
        public void Add(TTable item)
        {
            Data.Add(item);
            InsertList.Add(item);
            NeedSaveChanges = true;
        }
        public void Remove(TTable item)
        {
            try
            {
                if (InsertList.Contains(item))
                {
                    InsertList.Remove(item);
                }
                {
                    Data.Remove(item);
                    DeleteList.Add(item);
                }
                if(UpdateList.Contains(item))
                {

                }
                NeedSaveChanges = true;
            }
            catch (Exception ex)
            {
                SendError(ex.Message);
            }
        }
        public void Update(TTable oldItem, TTable newItem)
        {
            try
            {
                Data[Data.IndexOf(oldItem)] = newItem;
                UpdateList.Add(newItem);
                NeedSaveChanges = true;
            }
            catch (Exception ex)
            {
                SendError(ex.Message);
            }
        }
    }
}
