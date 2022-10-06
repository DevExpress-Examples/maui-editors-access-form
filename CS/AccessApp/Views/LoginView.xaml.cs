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
    }

    LoginViewModel ViewModel { get; }
    bool IsLoaded { get; }

    void OnLoginClicked(object sender, EventArgs e) {
        if (ViewModel.ValidateEditors())
            DisplayAlert("Success", "You are logged in", "OK");
    }

    void TextEdit_Unfocused(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e) {
        ViewModel.ValidateEditors();
    }

    void TextEdit_TextChanged(System.Object sender, System.EventArgs e) {
        if (IsLoaded)
            ViewModel.ValidateEditors();
    }
}

