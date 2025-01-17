using AccessApp.Views;

namespace AccessApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        Routing.RegisterRoute("LoginView", typeof(LoginView));
        Routing.RegisterRoute("SignUpView", typeof(SignUpView));
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        return new Window(new AppShell());
    }
}
