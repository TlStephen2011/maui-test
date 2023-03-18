using System;
using MyFirstMauiApp.Models;
using MyFirstMauiApp.Pages;

namespace MyFirstMauiApp;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}

    private async void GoToQuestion(object sender, EventArgs e) {
        var questionType = (QuestionType)((Button)sender).CommandParameter;

        switch (questionType)
        {
            case QuestionType.ServiceExterior:
                await Navigation.PushAsync(new ServiceExterior());
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

