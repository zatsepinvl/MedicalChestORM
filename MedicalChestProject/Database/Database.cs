using System;
using LinqToDB.Data;
using LinqToDB.DataProvider;
using System.Data;

namespace MedicalChestProject
{
    public class Database<TDataProvider, TConnection> : DataConnection
        where TDataProvider : IDataProvider
        where TConnection : IDbConnection
    {
        public new static TDataProvider DataProvider { get; set; }
        public new static TConnection Connection { get; set; }
        public Database() : base(DataProvider, Connection) {  }
    }
}
