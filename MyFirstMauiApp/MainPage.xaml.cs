using System;
using MyFirstMauiApp.Models;
using MyFirstMauiApp.Pages;

namespace MyFirstMauiApp;

public partial class MainPage : ContentPage
{
    ServiceExterior _serviceExteriorPage;

    public MainPage(ServiceExterior serviceExterior)
	{
		InitializeComponent();
        _serviceExteriorPage = serviceExterior;
	}

    private async void GoToQuestion(object sender, EventArgs e) {
        var questionType = (QuestionType)((Button)sender).CommandParameter;

        switch (questionType)
        {
            case QuestionType.ServiceExterior:
                await Navigation.PushAsync(_serviceExteriorPage);
                break;
            case QuestionType.ServiceReception:
                await Navigation.PushAsync(new ServiceReception());
                break;
            default:
                Console.WriteLine("Invalid page");
                break;
        }

        
    }
}

