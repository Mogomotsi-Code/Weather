using System;
using Prism.Mvvm;

namespace Weather.Models.UIModels
{
    public class ForeCast : BindableBase
    {
        #region Private Members
        private string _day;
        private string _icon;
        private string _temperature;
        private string _description;
        private string _city;
        private DateTime _date;
        private DTOs.ForeCast _foreCast;
        #endregion

        #region Public Properties
        public string Day { get => _day; set => SetProperty(ref _day, value); }
        public string City { get => _city; set => SetProperty(ref _city, value); }
        public string Icon { get => _icon; set => SetProperty(ref _icon, value); }
        public string Temperature { get => _temperature; set => SetProperty(ref _temperature, value); }
        public DTOs.ForeCast ForeCastDtails { get => _foreCast; set => SetProperty(ref _foreCast, value); }
        public DateTime Date { get => _date; set => SetProperty(ref _date, value); }
        public string Description { get => _description; set => SetProperty(ref _description, value); }
        #endregion
    }
}
