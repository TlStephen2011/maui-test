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
        await Navigation.PushAsync(new ServiceExterior());
    }
}

