using MVVM_DI.ViewModels;

namespace MVVM_DI.Views;

public partial class FileDetailView : ContentPage
{
    public FileDetailView(FileDetailViewModel viewModel)
    {
        BindingContext = viewModel;

        InitializeComponent();
    }
}