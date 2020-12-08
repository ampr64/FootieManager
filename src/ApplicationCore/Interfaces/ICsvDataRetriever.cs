using System;
using System.Collections.Generic;

namespace ApplicationCore.Interfaces
{
    public interface ICsvDataRetriever
    {
        List<object> RetrieveData(Type type, string path);
        List<T> RetrieveData<T>(string path);
    }
}
