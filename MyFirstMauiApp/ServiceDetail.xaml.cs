namespace MyFirstMauiApp;

public partial class ServiceDetailCustomControl : ContentView {
    public static readonly BindableProperty IsDoneProperty =
        BindableProperty.Create(nameof(IsDone), typeof(bool), typeof(ServiceDetailCustomControl), default(bool));

    public static readonly BindableProperty RatingProperty =
        BindableProperty.Create(nameof(Rating), typeof(int), typeof(ServiceDetailCustomControl), default(int));

    public static readonly BindableProperty CommentProperty =
        BindableProperty.Create(nameof(Comment), typeof(string), typeof(ServiceDetailCustomControl), default(string));

    public static readonly BindableProperty ActionDateProperty =
        BindableProperty.Create(nameof(ActionDate), typeof(DateTime), typeof(ServiceDetailCustomControl), default(DateTime));

    public bool IsDone {
        get => (bool)GetValue(IsDoneProperty);
        set => SetValue(IsDoneProperty, value);
    }

    public int Rating {
        get => (int)GetValue(RatingProperty);
        set => SetValue(RatingProperty, value);
    }

    public string Comment {
        get => (string)GetValue(CommentProperty);
        set => SetValue(CommentProperty, value);
    }

    public DateTime ActionDate {
        get => (DateTime)GetValue(ActionDateProperty);
        set => SetValue(ActionDateProperty, value);
    }

    public ServiceDetailCustomControl() {
        BindingContext = this;
    }
}