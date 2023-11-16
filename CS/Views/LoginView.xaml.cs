using System.ComponentModel;
using System.Text.RegularExpressions;
using AccessApp.ViewModels;
using AccessApp.Views;

namespace AccessApp.Views;

public partial class LoginView : ContentPage {

    public LoginView() {
        ViewModel = new LoginViewModel();
        BindingContext = ViewModel;
        InitializeComponent();
        IsInitialized = true;
    }

    LoginViewModel ViewModel { get; }
    bool IsInitialized { get; }

    void OnLoginClicked(object sender, EventArgs e) {
        DisplayAlert("Success", "You are logged in", "OK");
    }

    void OnTextEditTextChanged(System.Object sender, System.EventArgs e) {
        if (IsLoaded) {
            ViewModel.ValidateEditors();
        }
    }
}