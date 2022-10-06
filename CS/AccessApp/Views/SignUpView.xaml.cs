using DevExpress.Maui.Controls;
using DevExpress.Maui.Editors;
using AccessApp.Models;
using AccessApp.ViewModels;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace AccessApp.Views;

public partial class SignUpView : ContentPage {

    public SignUpView() {
        InitializeComponent();
        ViewModel = new SignUpViewModel();
        BindingContext = ViewModel;
    }

    SignUpViewModel ViewModel { get; }

    void OnSignUpClicked(System.Object sender, System.EventArgs e) {
        ViewModel.ValidateEditors();
        if (ViewModel.ValidateEditors())
            DisplayAlert("Success", "You account created successfully", "OK");
    }

    void OnInputChipGroupCompleted(object sender, CompletedEventArgs e) {
        var chipGroup = sender as InputChipGroup;
        if (chipGroup.EditorText.Length < 2) {
            e.ClearEditorText = false;
        } else {
            IList<ChipDataObject> list = chipGroup.ItemsSource as BindingList<ChipDataObject>;
            list.Add(new ChipDataObject() { Text = chipGroup.EditorText });
        }
    }

    private void TextEdit_TextChanged(object sender, EventArgs e) {
        ViewModel.ValidateEditors();
    }
}
