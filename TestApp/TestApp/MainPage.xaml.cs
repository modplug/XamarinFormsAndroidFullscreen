using Xamarin.Forms;

namespace TestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Title = "First Page";
            Grid grid = new Grid();
            grid.BackgroundColor = Color.Red;
            grid.HorizontalOptions = LayoutOptions.FillAndExpand;
            grid.VerticalOptions = LayoutOptions.FillAndExpand;
            var button = new Button()
            {
                WidthRequest = 100,
                HeightRequest = 100,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Text = "Next Page"
            };
            button.Clicked += (sender, args) => Navigation.PushAsync(new NextPage());
            grid.Children.Add(button);
            Content = grid;
        }
    }
}
