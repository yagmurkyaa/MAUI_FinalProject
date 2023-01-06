using _180201028_yagmurkaya_cproject.DataTransaction;

namespace _180201028_yagmurkaya_cproject;

public partial class App : Application
{
    public static DBTrans DBTrans { get; private set; }
    public App(DBTrans dbtrans)
    {
        InitializeComponent();

        MainPage = new AppShell();
        DBTrans = dbtrans;
    }
}
