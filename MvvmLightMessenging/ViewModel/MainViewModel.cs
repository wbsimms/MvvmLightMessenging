using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Practices.ServiceLocation;
using MvvmLightMessenging.DataServices.Interface;
using MvvmLightMessenging.Messages;

namespace MvvmLightMessenging.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        public const string DataPropertyName = "Data";
        private string data;
        public string Data
        {
            get { return data; }
            set { 
                if (data == value) return;
                data = value;
                RaisePropertyChanged(DataPropertyName);
            }
        }

        public MainViewModel()
        {
            IDataService dataService = ServiceLocator.Current.GetInstance<IDataService>();
            dataService.GetData((item, error) =>
                {
                    if (error != null)
                    {
                        return;
                    }
                    this.Data = item.Data;
                });

            Messenger.Default.Register<ButtonMessage>(this, (message) =>
                {
                    this.Data = message.ButtonText;
                });
        }
    }
}