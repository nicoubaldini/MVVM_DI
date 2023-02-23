using MVVM_DI.Views;

namespace MVVM_DI;

public partial class App : Application
{
	public App(FileListView view)
	{
		InitializeComponent();

		MainPage = new NavigationPage(view);
	}
}
