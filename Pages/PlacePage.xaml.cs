namespace _180201028_yagmurkaya_cproject;

public partial class PlacePage : ContentPage
{
    public PlacePage()
    {
        InitializeComponent();
        PlaceList.ItemsSource = App.DBTrans.GetAllPlaces();
    }

    private void Add_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddPlace(new Models.Place
        {
            PlaceName = PlaceName.Text,
        });
    }

    private void Show_Clicked(object sender, EventArgs e)
    {
        PlaceList.ItemsSource = App.DBTrans.GetAllPlaces();
    }

    private void Delete_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeletePlace((int)button.BindingContext);
        PlaceList.ItemsSource = App.DBTrans.GetAllPlaces();
    }
}