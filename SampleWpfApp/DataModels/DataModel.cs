using SampleWpfApp.ViewModels;

namespace SampleWpfApp.DataModels
{
    public class DataModel : PropViewModelBase
    {
        public string COMMAND { get; set; }

        private MainDataModel _mainDataModel = new MainDataModel();
        public MainDataModel RECORD
        {
            get { return _mainDataModel; }
            set
            {
                if ( _mainDataModel != value)
                {
                    _mainDataModel = value;
                    OnPropertyChanged();
                }
                
            }
        }


        public DataModel(){}
    }
}