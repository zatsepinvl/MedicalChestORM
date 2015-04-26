using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalChestProject
{
    public class ErrorMessageLogger<T>
    {
        public virtual T State { get; protected set; }
        public event Action<T> ErrorSend;
        public event Action<T> MessageSend;
        public event Action<T> StateChange;

        protected virtual void SendError(T error)
        {
            if (ErrorSend != null)
            {
                ErrorSend(error);
            }
        }

        protected virtual void SendMessage(T message)
        {
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
