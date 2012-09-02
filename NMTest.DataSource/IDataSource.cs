using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NMTest.DataSource
{
    public interface IDataSource
    {
        object GetValue(string key);
    }
}
