using System;
using MvvmLightMessenging.DataServices.Interface;

namespace MvvmLightMessenging.DataServices.Implementation
{
    public class DataService : IDataService
    {
        public void GetData(Action<DataItem<string>, Exception> callback)
        {
            callback(new DataItem<string>("Production"), null);
        }
    }
}
