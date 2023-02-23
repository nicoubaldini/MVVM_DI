using MVVM_DI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_DI.ViewModels
{
    public class FileListViewModel
    {
        readonly INavigationService _navigationService;
        readonly IFileService _fileService;
        public Command NavigateCommand => new Command(async () => await _navigationService.NavigateToFileDetailView());
        public FileListViewModel(IFileService fileService, INavigationService navigationService)
        {
            _fileService = fileService;
            _navigationService = navigationService;
        }
    }
}
