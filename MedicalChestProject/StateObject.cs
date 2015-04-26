using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalChestProject
{
    public class StateObject<T>
    {
        protected T state;
        public virtual T State { get { return state; } set { state = value; } }
        public event Action<string> ErrorSend;
        public event Action<string> MessageSend;
        public event Action StateChange;

        protected virtual void SendError(string error)
        {
            if (ErrorSend != null)
            {
                ErrorSend(DateTime.Now.ToString() + " " + error);
            }
        }

        protected virtual void SendMessage(string message)
        {
            if (MessageSend != null)
            {
                MessageSend(message);
            }
        }

        protected virtual void ChangeState()
        {
            if (StateChange != null)
            {
                StateChange();
            }
        }
    }
}
