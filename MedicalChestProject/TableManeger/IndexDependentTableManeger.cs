using System;
using System.Collections.Generic;
using LinqToDB.Data;
using LinqToDB;

namespace MedicalChestProject
{
    public abstract class IndexDependentTableManeger<TDatabase, TTable> : TableManeger<TDatabase, TTable>
        where TDatabase : DataConnection, new()
    {
        protected int index;
        public int Index
        {
            get { return index; }
            set
            {
                index = value;
                if (index > -1)
                {
                    LoadAll = false;
                }
                else
                {
                    LoadAll = true;
                }
                ChooseDataByIndex();
            }
        }
        public  List<TTable> DataByIndex { get; protected set; }
        public bool LoadAll { get; set; }
        protected abstract void ChooseDataByIndex();
        public override List<TTable> GetData()
        {
            if (!DataLoaded)
            {
                Load();
            }
            return DataByIndex;
        }
    }
}
