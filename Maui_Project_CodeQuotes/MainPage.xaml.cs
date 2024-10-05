namespace Maui_Project_CodeQuotes
{
    public partial class MainPage : ContentPage
    {
        List<string> quotes = new List<string>();
        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LoadMauiAsset();
        }

        async Task LoadMauiAsset()
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("quotes.txt");
            using var reader = new StreamReader(stream);

            while (reader.Peek() != -1)
            {
                quotes.Add(reader.ReadLine());
            }
        }

        private void btnGenerateQuote_Clicked(object sender, EventArgs e)

        {
            Color randomColor1 = Color.FromRgb(red: Random.Shared.Next(0, 256),
                green: Random.Shared.Next(0, 256),
                blue: Random.Shared.Next(0, 256));

            Color randomColor2 = Color.FromRgb(red: Random.Shared.Next(0, 256),
                green: Random.Shared.Next(0, 256),
                blue: Random.Shared.Next(0, 256));

            Color randomColor3 = Color.FromRgb(red: Random.Shared.Next(0, 256),
                green: Random.Shared.Next(0, 256),
                blue: Random.Shared.Next(0, 256));

            Color randomColor4 = Color.FromRgb(red: Random.Shared.Next(0, 256),
                green: Random.Shared.Next(0, 256),
                blue: Random.Shared.Next(0, 256));

            Color randomColor5 = Color.FromRgb(red: Random.Shared.Next(0, 256),
                green: Random.Shared.Next(0, 256),
                blue: Random.Shared.Next(0, 256));

            gstop1.Color = randomColor1;
            gstop2.Color = randomColor2;
            gstop3.Color = randomColor3;
            gstop4.Color = randomColor4;
            gstop5.Color = randomColor5;

            int index = Random.Shared.Next(quotes.Count);
            quote.Text = quotes[index];
        }
    }
}
