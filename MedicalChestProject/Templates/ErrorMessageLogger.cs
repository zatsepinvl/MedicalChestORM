using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalChestProject
{
    public class ErrorMessageLogger<T>
    {
        public List<T> ErrorList { get; protected set; }
        public List<T> MessageList { get; protected set; }
        public virtual T State { get; protected set; }
        public event Action<T> ErrorSend;
        public event Action<T> MessageSend;
        public event Action<T> StateChange;

        public ErrorMessageLogger() { ErrorList = new List<T>(); MessageList = new List<T>(); }

        protected virtual void SendError(T error)
        {
            ErrorList.Add(error);
            if (ErrorSend != null)
            {
                ErrorSend(error);
            }
        }
        protected virtual void SendMessage(T message)
        {
            MessageList.Add(message);
            if (MessageSend != null)
            {
                MessageSend(message);
            }
        }
        protected virtual void InformStateChanged(T state)
        {
            if (StateChange != null)
            {
                StateChange(state);
            }
        }
    }
}
