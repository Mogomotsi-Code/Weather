using System;
using Prism.Mvvm;

namespace Weather.Models.UIModels
{
    public class Temparature : BindableBase
    {
        #region Private Members
        private string _max;
        private string _min;
        private string _description;
        private string _value;
        #endregion

        #region Public Properties
        public string Value { get => _value; set => SetProperty(ref _value, value); }
        public string Max { get => _max; set => SetProperty(ref _max, value); }
        public string Min { get => _min; set => SetProperty(ref _min, value); }
        public string Description { get => _description; set => SetProperty(ref _description, value); }
        #endregion
    }
}
