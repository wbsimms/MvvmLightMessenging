using System;
using MvvmLightMessenging.DataServices.Interface;

namespace MvvmLightMessenging.DataServices.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<DataItem<string>, Exception> callback)
        {
            callback(new DataItem<string>("Testing"), null);
        }
    }
}
