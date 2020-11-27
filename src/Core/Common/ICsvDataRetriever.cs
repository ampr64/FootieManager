using System;
using System.Collections.Generic;

namespace Core.Common
{
    public interface ICsvDataRetriever
    {
        IEnumerable<object> RetrieveData(Type type, string path);
    }
}
