namespace _180201028_yagmurkaya_cproject;

public partial class MovieActorPage : ContentPage
{
    int movieID;
    string movieName;
    int actorID;
    string actorName;
    string actorSurName;

    public MovieActorPage()
    {
        InitializeComponent();
        MovieActorList.ItemsSource = App.DBTrans.GetAllMovieActors();
    }

    private void ActorList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var actor = (Models.Actor)e.Item;
        actorID = actor.ActorID;
        actorName = actor.ActorName;
        actorSurName = actor.ActorSurName;
    }

    private void MovieList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var movie = (Models.Movie)e.Item;
        movieID = movie.MovieID;
        movieName = movie.MovieName;
    }

    private void Add_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddMovieActor(new Models.MovieActor
        {
            ActorID = actorID,
            ActorName = actorName,
            ActorSurname = actorSurName,
            MovieID = movieID,
            MovieName = movieName
        });
    }

    private void Show_Clicked(object sender, EventArgs e)
    {
        MovieActorList.ItemsSource = App.DBTrans.GetAllMovieActors();
    }

    private void Delete_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeleteMovieActor((int)button.BindingContext);
        MovieActorList.ItemsSource = App.DBTrans.GetAllMovieActors();
    }

    private void ContentPage_Appearing(object sender, EventArgs e)
    {
        MovieList.ItemsSource = App.DBTrans.GetAllMovies();
        ActorList.ItemsSource = App.DBTrans.GetAllActors();
    }
}