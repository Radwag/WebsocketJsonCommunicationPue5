namespace SampleWinFormsApp.DataModels.MassModels
{
    public class CalMassDataModel: PropViewModelBase
    {
        private double _value;
        private string _unit;
        private int _precision;
       
        
        public double Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                { 
                    _value = value;
                    OnPropertyChanged();
                }
                
                
            }
        }
        public string Unit
        {
            get { return _unit; }
            set
            {
                if (_unit != value)
                {
                    _unit = value;
                    OnPropertyChanged();
                }
                
                
            }
        }
        public int Precision
        {
            get { return _precision; }
            set
            {
                if (_precision != value)
                {
                    _precision = value;
                    OnPropertyChanged();
                }
                
                
            }
        }
    }
}