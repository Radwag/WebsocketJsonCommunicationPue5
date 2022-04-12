using SampleWpfApp.ViewModels;

namespace SampleWpfApp.DataModels.MassModels
{
    public class MassDataModel : PropViewModelBase
    {
        private ActMassDataModel _actMassDataModel;
        private CalMassDataModel _calMassDataModel;
        
        private string _tare;
        private string _range;
        private string _max;
        private double _maxAct;
        private bool _isStab;
        private bool _isTare;
        private bool _isZero;
        private bool _isTareGiven;
        private int _highlightedDigits;
        private int _hiddenDigits;
        private string _weighingStatus;
        private int _platformIndex;
        private string _errorText;


        public ActMassDataModel NetAct
        {
            get { return _actMassDataModel; }
            set
            {
                if (_actMassDataModel != value)
                {
                    _actMassDataModel = value;
                    OnPropertyChanged();
                }
            }
        }

        public CalMassDataModel CalAct
        {
            get { return _calMassDataModel; }
            set
            {
                if (_calMassDataModel != value)
                {
                    _calMassDataModel = value;
                    OnPropertyChanged();
                }
            }
        }

       
        public string Tare
        {
            get { return _tare; }
            set
            {
                if (_tare != value)
                {
                    _tare = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Range
        {
            get { return _range; }
            set
            {
                if (_range != value)
                {
                    _range = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Max
        {
            get { return _max; }
            set
            {
                if (_max != value)
                {
                    _max = value;
                    OnPropertyChanged();
                }
            }
        }

        public double MaxAct
        {
            get { return _maxAct; }
            set
            {
                if (_maxAct != value)
                {
                    _maxAct = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsStab
        {
            get { return _isStab; }
            set
            {
                if (_isStab != value)
                {
                    _isStab = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsTare
        {
            get { return _isTare; }
            set
            {
                if (_isTare != value)
                {
                    _isTare = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsZero
        {
            get { return _isZero; }
            set
            {
                if (_isZero != value)
                {
                    _isZero = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsTareGiven
        {
            get { return _isTareGiven; }
            set
            {
                if (_isTareGiven != value)
                {
                    _isTareGiven = value;
                    OnPropertyChanged();
                }
            }
        }

        public int HighlightedDigits
        {
            get { return _highlightedDigits; }
            set
            {
                if (_highlightedDigits != value)
                {
                    _highlightedDigits = value;
                    OnPropertyChanged();
                }
            }
        }

        public int HiddenDigits
        {
            get { return _hiddenDigits; }
            set
            {
                if (_hiddenDigits != value)
                {
                    _hiddenDigits = value;
                    OnPropertyChanged();
                }
            }
        }

        public string WeighingStatus
        {
            get { return _weighingStatus; }
            set
            {
                if (_weighingStatus != value)
                {
                    _weighingStatus = value;
                    OnPropertyChanged();
                }
            }
        }

        public int PlatformIndex
        {
            get { return _platformIndex; }
            set
            {
                if (_platformIndex != value)
                {
                    _platformIndex = value;
                    OnPropertyChanged();
                }
            }
        }

        public string ErrorText
        {
            get { return _errorText; }
            set
            {
                if (_errorText != value)
                {
                    _errorText = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}