using System;
using System.Collections.Generic;

namespace Core.Common
{
    public interface ICsvDataRetriever
    {
        List<object> RetrieveData(Type type, string path);
        List<T> RetrieveData<T>(string path);
    }
}
