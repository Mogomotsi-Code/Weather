using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Weather.Models.UIModels;

namespace Weather.ViewModels
{
    public class ForeCastDetailsPageViewModel: ViewModelBase
    {
        #region Private Members
        private ForeCast _foreCast;
        private string _city;
        #endregion

        #region Public Properties
        public ForeCast ForeCast { get => _foreCast; set => SetProperty(ref _foreCast,value); }
        public string City { get => _city; set => SetProperty(ref _city, value); }
        #endregion

        #region Commands
        public DelegateCommand GoBackCommand { get; private set; }
        #endregion

        #region Constructors
        public ForeCastDetailsPageViewModel(INavigationService navService)
            :base(navService)
        {
            GoBackCommand = new DelegateCommand(async () => await NavigateBack());
        }
        #endregion
        #region Public Methods
        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            ForeCast = parameters.GetValue<ForeCast>("Forecast");
            City = parameters.GetValue<string>("City");

        }
        #endregion

        #region Private Methods
        private async Task NavigateBack()
        {
            await _navService.GoBackAsync();
        }
        #endregion
    }
}
