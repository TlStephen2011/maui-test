namespace MyFirstMauiApp;

public partial class ServiceDetailControl : ContentView
{
    public static readonly BindableProperty IsDoneProperty =
    BindableProperty.Create(nameof(IsDone), typeof(bool), typeof(ServiceDetailControl), default(bool));

    public static readonly BindableProperty RatingProperty =
        BindableProperty.Create(nameof(Rating), typeof(int), typeof(ServiceDetailControl), default(int));

    public static readonly BindableProperty CommentProperty =
        BindableProperty.Create(nameof(Comment), typeof(string), typeof(ServiceDetailControl), default(string));

    public static readonly BindableProperty ActionDateProperty =
        BindableProperty.Create(nameof(ActionDate), typeof(DateTime), typeof(ServiceDetailControl), default(DateTime));

    public bool IsDone
    {
        get => (bool)GetValue(IsDoneProperty);
        set => SetValue(IsDoneProperty, value);
    }

    public int Rating
    {
        get => (int)GetValue(RatingProperty);
        set => SetValue(RatingProperty, value);
    }

    public string Comment
    {
        get => (string)GetValue(CommentProperty);
        set => SetValue(CommentProperty, value);
    }

    public DateTime ActionDate
    {
        get => (DateTime)GetValue(ActionDateProperty);
        set => SetValue(ActionDateProperty, value);
    }

    public ServiceDetailControl()
	{
        BindingContext= this;
		InitializeComponent();
	}
}