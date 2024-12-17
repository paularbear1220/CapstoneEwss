namespace ewssApp1.Pages;

public partial class Dashboard : ContentPage
{
    public string TodayDate { get; set; }
    public string YesterdayDate { get; set; }

    public Dashboard()
    {
        InitializeComponent();
        TodayDate = DateTime.Now.ToString("dd MMM yyyy");
        YesterdayDate = DateTime.Now.AddDays(-1).ToString("dd MMM yyyy");
        BindingContext = this;
    }

    private async void OnTodaysWasteTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TodayStats());
    }

    private async void OnYesterdaysWasteTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new YesterdayStats());
    }

}