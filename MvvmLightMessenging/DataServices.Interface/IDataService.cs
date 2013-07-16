using System;

namespace MvvmLightMessenging.DataServices.Interface
{
    public interface IDataService
    {
        void GetData(Action<DataItem<String>, Exception> callback);
    }

    public class DataItem<T>
    {
        public DataItem(T response)
        {
            Data = response;
        }

        public T Data
        {
            get;
            private set;
        }
    }
}
