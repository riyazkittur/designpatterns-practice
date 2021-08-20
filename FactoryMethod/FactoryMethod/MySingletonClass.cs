using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public sealed class MySingletonClass :IDisposable
    {
        private static MySingletonClass Instance;
        public int Counter { get; set; }
        private MySingletonClass()
        {

        }
        public static MySingletonClass getInstance()
        {
            if (Instance == null)
            {
                Instance = new MySingletonClass();
            }
            return Instance;
        }

        void IDisposable.Dispose()
        {
            if (Instance != null)
            {
                Instance = null;
            }
        }
    }
}
