namespace _180201028_yagmurkaya_cproject;

public static class ActorGender
{
    public static string A_Gender { get; set; }
}


public partial class ActorPage : ContentPage
{
    public ActorPage()
    {
        InitializeComponent();
        ActorList.ItemsSource = App.DBTrans.GetAllActors();
    }


    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton radiobutton = (RadioButton)sender;
        ActorGender.A_Gender = radiobutton.Content.ToString();

    }

    private void Add_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddActor(new Models.Actor
        {
            ActorName = ActorName.Text,
            ActorSurName = ActorSurName.Text,
            ActorGender = ActorGender.A_Gender,
        });
    }

    private void Show_Clicked(object sender, EventArgs e)
    {
        ActorList.ItemsSource = App.DBTrans.GetAllActors();
    }

    private void Delete_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeleteActor((int)button.BindingContext);
        ActorList.ItemsSource = App.DBTrans.GetAllActors();
    }
}