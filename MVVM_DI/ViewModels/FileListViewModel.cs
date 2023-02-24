using MVVM_DI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_DI.ViewModels
{
    public class FileListViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IFileService _fileService;
        public Command NavigateCommand => new Command(async () => await _navigationService.NavigateToFileDetailView());
        public FileListViewModel(IFileService fileService, INavigationService navigationService)
        {
            _fileService = fileService;
            _navigationService = navigationService;
        }
        public override Task OnNavigatedFrom(bool isForwardNavigation)
        {
            Console.WriteLine($"On {(isForwardNavigation ? "forward" : "backward")} navigated from MainPage");
            return base.OnNavigatedFrom(isForwardNavigation);
        }

        public override Task OnNavigatingTo(object? parameter)
        {
            Console.WriteLine($"On navigating to MainPage with parameter {parameter}");
            return base.OnNavigatingTo(parameter);
        }

        public override Task OnNavigatedTo()
        {
            Console.WriteLine("On navigated to MainPage");
            return base.OnNavigatedTo();
        }
    }
}
