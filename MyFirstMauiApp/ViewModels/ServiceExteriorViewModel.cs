using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMauiApp.Models;


namespace MyFirstMauiApp.ViewModels
{
	public partial class ServiceExteriorViewModel : ObservableObject
	{

        public ObservableCollection<Question> Questions { get; set; } = new();

        public ServiceExteriorViewModel()
        {
            Questions.Add(new Question { Description = "Test", Comment = "My random comment"});

            Questions.Add(new Question { Description = "Test 2", Comment = "My random comment" });
        }
    }
}

