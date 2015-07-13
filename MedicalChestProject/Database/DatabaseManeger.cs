using System;
using System.Collections.Generic;
using LinqToDB.Data;
using LinqToDB.DataProvider;
using System.Data;

namespace MedicalChestProject
{
    public abstract class DatabaseManeger<TManeger, TDatabase, TDataprovider, TConnecition> : Singleton<TManeger, string>
        where TManeger:class
        where TDataprovider:IDataProvider
        where TConnecition:IDbConnection
        where TDatabase : Database<TDataprovider, TConnecition>
    {
        public ConnectionManeger ConnectionManeger { get; set; }
        public override string State
        {
            get { return ConnectionManeger.State; }
        }

        public List<ErrorMessageLogger<string>> Loggers { get; protected set; }

        protected virtual void Init()
        {
            Loggers = new List<ErrorMessageLogger<string>>();
            InitConnectionManeger();
            InitDatabase();
            InitTableManegers();
        }
        protected virtual void InitConnectionManeger()
        {
            ConnectionManeger = ConnectionManeger.Instance;
            SingUpForPublisher(ConnectionManeger);
        }

        protected virtual void DManegerMessageSend(string obj)
        {
            SendMessage(obj);
        }
        protected virtual void DManegerErrorSend(string obj)
        {
            SendError(obj);
        }
        protected virtual void DManegerStateChange(string obj)
        {
            InformStateChanged(obj);
        }

        protected abstract void InitDatabase();
        protected abstract void InitTableManegers();

        protected virtual void SingUpForPublisher(ErrorMessageLogger<string>[] publishers)
        {
            foreach(ErrorMessageLogger<string> p in publishers)
            {
                SingUpForPublisher(p);
            }
        }
        protected virtual void SingUpForPublisher(ErrorMessageLogger<string> publisher)
        {
            publisher.ErrorSend += DManegerErrorSend;
            publisher.MessageSend += DManegerMessageSend;
            publisher.StateChange += DManegerStateChange;
        }

    }
}
