namespace MyFirstMauiApp.Models {
    public class Question {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}
