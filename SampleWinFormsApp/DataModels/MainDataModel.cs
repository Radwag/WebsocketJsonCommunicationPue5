using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using SampleWinFormsApp.DataModels.MassModels;

namespace SampleWinFormsApp.DataModels
{
    public class MainDataModel : PropViewModelBase
    {
        private int _activePlatformIndex;
        private Uri _activePlatformIndexImage;
        private string _date = "";

        private IList<MassDataModel> _mass;

        [JsonIgnore] public MassDataModel ActivePlatformMass { get; set; }

        public int ActivePlatformIndex
        {
            get { return _activePlatformIndex; }
            set
            {
                if (_activePlatformIndex != value)
                {
                    _activePlatformIndex = value;
                    
                    OnPropertyChanged();
                }
                ActivePlatformIndexImage = new Uri("\\Images\\Platform-" + (value + 1) + ".png", UriKind.Relative);
            }
        }

        public IList<MassDataModel> Mass
        {
            get { return _mass; }
            set
            {
                if (!Equals(_mass, value))
                {
                    ActivePlatformMass = value[Convert.ToInt32(ActivePlatformIndex)];
                    _mass = value;
                    OnPropertyChanged();
                }
            }
        }
        public Uri ActivePlatformIndexImage
        {
            get { return _activePlatformIndexImage; }
            set
            {
                _activePlatformIndexImage = value;
                OnPropertyChanged();
            }
        }

        public string Date
        {
            get { return _date; }
            set
            {
                if (_date != value)
                {
                    _date = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}