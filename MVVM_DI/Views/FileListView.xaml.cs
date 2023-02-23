using MVVM_DI.ViewModels;

namespace MVVM_DI.Views;

public partial class FileListView : ContentPage
{
    
	public FileListView(FileListViewModel viewModel)
	{
		BindingContext = viewModel;

		InitializeComponent();
	}

}