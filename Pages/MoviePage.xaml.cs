namespace _180201028_yagmurkaya_cproject;

public partial class MoviePage : ContentPage
{

    int pID;
    string pName;


    public MoviePage()
    {
        InitializeComponent();
        MovieList.ItemsSource = App.DBTrans.GetAllMovies();
    }



    private void Add_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddMovie(new Models.Movie
        {
            MovieName = MovieName.Text,
            MovieRunTime = movieruntime.Text,
            PlaceID = pID,
            PlaceName = pName
        });
    }

    private void Show_Clicked(object sender, EventArgs e)
    {
        MovieList.ItemsSource = App.DBTrans.GetAllMovies();
    }

    private void Delete_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeleteMovie((int)button.BindingContext);
        MovieList.ItemsSource = App.DBTrans.GetAllMovies();
    }

    private void ContentPage_Appearing(object sender, EventArgs e)
    {
        PlaceList.ItemsSource = App.DBTrans.GetAllPlaces();
    }


    private void PlaceList_ItemTapped_1(object sender, ItemTappedEventArgs e)
    {
        var place = (Models.Place)e.Item;
        pID = place.PlaceID;
        pName = place.PlaceName;
    }
}