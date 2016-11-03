using Xamarin.Forms;

namespace TestApp
{
    public partial class NextPage : ContentPage
    {
        public NextPage()
        {
            InitializeComponent();
            Title = "Page";
            Grid grid = new Grid();
            grid.BackgroundColor = Color.Blue;
            grid.HorizontalOptions = LayoutOptions.FillAndExpand;
            grid.VerticalOptions = LayoutOptions.FillAndExpand;
            var button = new Button()
            {
                WidthRequest = 100,
                HeightRequest = 100,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Text = "New page"
            };
            button.Clicked += (sender, args) => Navigation.PushAsync(new NextPage());
            grid.Children.Add(button);
            Content = grid;
        }
    }
}