using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NMTest.DataSource
{
    public class DatabaseStore
    {
        Dictionary<string, object> _Values;

        public object GetValue(string key)
        {
            //simulates 50 ms roundtrip to the database
            Thread.Sleep(50);
            object value;
            if (_Values.TryGetValue(key, out value))
            {
                return value;
            }
            return null;
        }

        public void StoreValue(string key, object value)
        {
            //simulates 50 ms roundtrip to the database
            Thread.Sleep(50);
            _Values[key] = value;
        }
    }
}
