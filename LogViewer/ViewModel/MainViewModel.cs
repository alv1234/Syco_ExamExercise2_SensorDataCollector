using GalaSoft.MvvmLight;
using LogViewer.SR_ServiceLayer;
using Shared;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace LogViewer.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<SensorModel> log;
        private WcfServiceDefinitionClient client = new WcfServiceDefinitionClient();

        public ObservableCollection<SensorModel> Log
        {
            get { return log; }
            set { log = value; RaisePropertyChanged(); }
        }

        public MainViewModel()
        {
            Log = new ObservableCollection<SensorModel>(client.GetSensorData());
        }

    }
}