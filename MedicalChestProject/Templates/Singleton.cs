using System;
using System.Reflection;
using System.Text;

namespace MedicalChestProject
{
    public class Singleton<T, V>:ErrorMessageLogger<V> where T : class
    {
        protected Singleton() { }
        private sealed class SingletonCreator<S> where S : class
        {
            private static readonly S instance = (S)typeof(S).GetConstructor(
                        BindingFlags.Instance | BindingFlags.NonPublic,
                        null,
                        new Type[0],
                        new ParameterModifier[0]).Invoke(null);
            public static S CreatorInstance
            {
                get { return instance; }
            }
        }

        public static T Instance
        {
            get { return SingletonCreator<T>.CreatorInstance; }
        }

    }
}
