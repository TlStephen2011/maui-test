using MyFirstMauiApp.ViewModels;

namespace MyFirstMauiApp.Pages;

public partial class ServiceExterior : ContentPage
{
    ServiceExteriorViewModel _vm;

    public ServiceExterior(ServiceExteriorViewModel vm)
	{
        InitializeComponent();
        _vm = vm;
        BindingContext = _vm;
	}
}
