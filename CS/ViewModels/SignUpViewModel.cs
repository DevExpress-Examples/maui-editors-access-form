using System.ComponentModel;
using System.Text.RegularExpressions;
using AccessApp.Models;

namespace AccessApp.ViewModels;

public class SignUpViewModel : BaseViewModel {

    bool isValidationEnabled = false;
    bool isloginEnabled = false;
    bool issignupEnabled = false;
    string notes = "";
    DateTime? birthDate;
    string phone;
    string login = "";
    bool loginHasError = false;
    string password = "";
    bool passwordHasError = false;
    CountryCode selectedCountry;

    public SignUpViewModel() {
        Chips = new BindingList<ChipDataObject>() { new ChipDataObject() { Text = "C#" } };
        Codes = new List<CountryCode>() {
            new CountryCode {Country="Afghanistan", Code="+93"},
            new CountryCode {Country="Albania", Code="+355"},
            new CountryCode {Country="Algeria", Code="+213"},
            new CountryCode {Country="American Samoa", Code="+1"},
            new CountryCode {Country="Andorra", Code="+376"},
            new CountryCode {Country="Angola", Code="+244"},
            new CountryCode {Country="Anguilla", Code="+1"},
            new CountryCode {Country="Antigua and Barbuda", Code="+1"},
            new CountryCode {Country="Argentina", Code="+54"},
            new CountryCode {Country="Armenia", Code="+374"},
            new CountryCode {Country="Aruba", Code="+297"},
            new CountryCode {Country="Australia", Code="+61"},
            new CountryCode {Country="Austria", Code="+43"},
            new CountryCode {Country="Azerbaijan", Code="+994"},
            new CountryCode {Country="Bahamas", Code="+1"},
            new CountryCode {Country="Bahrain", Code="+973"},
            new CountryCode {Country="Bangladesh", Code="+880"},
            new CountryCode {Country="Barbados", Code="+1"},
            new CountryCode {Country="Belarus", Code="+375"},
            new CountryCode {Country="Belgium", Code="+32"},
            new CountryCode {Country="Belize", Code="+501"},
            new CountryCode {Country="Benin", Code="+229"},
            new CountryCode {Country="Bermuda", Code="+1"},
            new CountryCode {Country="Bhutan", Code="+975"},
            new CountryCode {Country="Bolivia", Code="+591"},
            new CountryCode {Country="Bosnia and Herzegovina", Code="+387"},
            new CountryCode {Country="Botswana", Code="+267"},
            new CountryCode {Country="Brazil", Code="+55"},
            new CountryCode {Country="Brunei Darussalam", Code="+673"},
            new CountryCode {Country="Bulgaria", Code="+359"},
            new CountryCode {Country="Burkina Faso", Code="+226"},
            new CountryCode {Country="Burundi", Code="+257"},
            new CountryCode {Country="Cambodia", Code="+855"},
            new CountryCode {Country="Cameroon", Code="+237"},
            new CountryCode {Country="Canada", Code="+1"},
            new CountryCode {Country="Cape Verde", Code="+238"},
            new CountryCode {Country="Cayman Islands", Code="+1"},
            new CountryCode {Country="Central African Republic", Code="+236"},
            new CountryCode {Country="Chad", Code="+235"},
            new CountryCode {Country="Chile", Code="+56"},
            new CountryCode {Country="China", Code="+86"},
            new CountryCode {Country="Christmas Island", Code="+61"},
            new CountryCode {Country="Cocos (Keeling) Islands", Code="+61"},
            new CountryCode {Country="Colombia", Code="+57"},
            new CountryCode {Country="Comoros", Code="+269"},
            new CountryCode {Country="Congo (Brazzaville)", Code="+242"},
            new CountryCode {Country="Congo (Kinshasa)", Code="+243"},
            new CountryCode {Country="Cook Islands", Code="+682"},
            new CountryCode {Country="Costa Rica", Code="+506"},
            new CountryCode {Country="Côte D'Ivoire (Ivory Coast)", Code="+225"},
            new CountryCode {Country="Croatia (Hrvatska)", Code="+385"},
            new CountryCode {Country="Cuba", Code="+53"},
            new CountryCode {Country="Cyprus", Code="+357"},
            new CountryCode {Country="Czech Republic", Code="+420"},
            new CountryCode {Country="Denmark", Code="+45"},
            new CountryCode {Country="Djibouti", Code="+253"},
            new CountryCode {Country="Dominica", Code="+1"},
            new CountryCode {Country="Dominican Republic", Code="+1"},
            new CountryCode {Country="Ecuador", Code="+593"},
            new CountryCode {Country="Egypt", Code="+20"},
            new CountryCode {Country="El Salvador", Code="+503"},
            new CountryCode {Country="Equatorial Guinea", Code="+240"},
            new CountryCode {Country="Eritrea", Code="+291"},
            new CountryCode {Country="Estonia", Code="+372"},
            new CountryCode {Country="Ethiopia", Code="+251"},
            new CountryCode {Country="Falkland Islands (Malvinas)", Code="+500"},
            new CountryCode {Country="Faroe Islands", Code="+298"},
            new CountryCode {Country="Fiji", Code="+679"},
            new CountryCode {Country="Finland", Code="+358"},
            new CountryCode {Country="France", Code="+33"},
            new CountryCode {Country="French Guiana", Code="+594"},
            new CountryCode {Country="French Polynesia", Code="+689"},
            new CountryCode {Country="Gabon", Code="+241"},
            new CountryCode {Country="Gambia", Code="+220"},
            new CountryCode {Country="Georgia", Code="+995"},
            new CountryCode {Country="Germany", Code="+49"},
            new CountryCode {Country="Ghana", Code="+233"},
            new CountryCode {Country="Gibraltar", Code="+350"},
            new CountryCode {Country="Greece", Code="+30"},
            new CountryCode {Country="Greenland", Code="+299"},
            new CountryCode {Country="Grenada", Code="+1"},
            new CountryCode {Country="Guadeloupe", Code="+590"},
            new CountryCode {Country="Guam", Code="+1"},
            new CountryCode {Country="Guatemala", Code="+502"},
            new CountryCode {Country="Guinea", Code="+224"},
            new CountryCode {Country="Guinea-Bissau", Code="+245"},
            new CountryCode {Country="Guyana", Code="+592"},
            new CountryCode {Country="Haiti", Code="+509"},
            new CountryCode {Country="Holy See (Vatican City State)", Code="+379"},
            new CountryCode {Country="Honduras", Code="+504"},
            new CountryCode {Country="Hong Kong, SAR", Code="+852"},
            new CountryCode {Country="Hungary", Code="+36"},
            new CountryCode {Country="Iceland", Code="+354"},
            new CountryCode {Country="India", Code="+91"},
            new CountryCode {Country="Indonesia", Code="+62"},
            new CountryCode {Country="Iran, Islamic Republic of", Code="+98"},
            new CountryCode {Country="Iraq", Code="+964"},
            new CountryCode {Country="Ireland", Code="+353"},
            new CountryCode {Country="Israel", Code="+972"},
            new CountryCode {Country="Italy", Code="+39"},
            new CountryCode {Country="Jamaica", Code="+1"},
            new CountryCode {Country="Japan", Code="+81"},
            new CountryCode {Country="Jordan", Code="+962"},
            new CountryCode {Country="Kazakhstan", Code="+7"},
            new CountryCode {Country="Kenya", Code="+254"},
            new CountryCode {Country="Kiribati", Code="+686"},
            new CountryCode {Country="Korea, Democratic People's Republic of (North)", Code="+850"},
            new CountryCode {Country="Korea, Republic of (South)", Code="+82"},
            new CountryCode {Country="Kuwait", Code="+965"},
            new CountryCode {Country="Kyrgyzstan", Code="+996"},
            new CountryCode {Country="Laos (Lao PDR)", Code="+856"},
            new CountryCode {Country="Latvia", Code="+371"},
            new CountryCode {Country="Lebanon", Code="+961"},
            new CountryCode {Country="Lesotho", Code="+266"},
            new CountryCode {Country="Liberia", Code="+231"},
            new CountryCode {Country="Libya", Code="+218"},
            new CountryCode {Country="Liechtenstein", Code="+423"},
            new CountryCode {Country="Lithuania", Code="+370"},
            new CountryCode {Country="Luxembourg", Code="+352"},
            new CountryCode {Country="Macao (SAR China)", Code="+853"},
            new CountryCode {Country="Macedonia, Republic of", Code="+389"},
            new CountryCode {Country="Madagascar", Code="+261"},
            new CountryCode {Country="Malawi", Code="+265"},
            new CountryCode {Country="Malaysia", Code="+60"},
            new CountryCode {Country="Maldives", Code="+960"},
            new CountryCode {Country="Mali", Code="+223"},
            new CountryCode {Country="Malta", Code="+356"},
            new CountryCode {Country="Marshall Islands", Code="+692"},
            new CountryCode {Country="Martinique", Code="+596"},
            new CountryCode {Country="Mauritania", Code="+222"},
            new CountryCode {Country="Mauritius", Code="+230"},
            new CountryCode {Country="Mayotte", Code="+262"},
            new CountryCode {Country="Mexico", Code="+52"},
            new CountryCode {Country="Micronesia, Federated States of", Code="+691"},
            new CountryCode {Country="Moldova", Code="+373"},
            new CountryCode {Country="Monaco", Code="+377"},
            new CountryCode {Country="Mongolia", Code="+976"},
            new CountryCode {Country="Montenegro", Code="+382"},
            new CountryCode {Country="Montserrat", Code="+1"},
            new CountryCode {Country="Morocco and Western Sahara", Code="+212"},
            new CountryCode {Country="Mozambique", Code="+258"},
            new CountryCode {Country="Myanmar", Code="+95"},
            new CountryCode {Country="Namibia", Code="+264"},
            new CountryCode {Country="Nauru", Code="+674"},
            new CountryCode {Country="Nepal", Code="+977"},
            new CountryCode {Country="Netherlands", Code="+31"},
            new CountryCode {Country="Netherlands Antilles", Code="+599"},
            new CountryCode {Country="New Caledonia", Code="+687"},
            new CountryCode {Country="New Zealand", Code="+64"},
            new CountryCode {Country="Nicaragua", Code="+505"},
            new CountryCode {Country="Niger", Code="+227"},
            new CountryCode {Country="Nigeria", Code="+234"},
            new CountryCode {Country="Niue", Code="+683"},
            new CountryCode {Country="Norfolk Island", Code="+672"},
            new CountryCode {Country="Northern Mariana Islands", Code="+1"},
            new CountryCode {Country="Norway", Code="+47"},
            new CountryCode {Country="Oman", Code="+968"},
            new CountryCode {Country="Pakistan", Code="+92"},
            new CountryCode {Country="Palau", Code="+680"},
            new CountryCode {Country="Palestinian Territory, Occupied", Code="+970"},
            new CountryCode {Country="Panama", Code="+507"},
            new CountryCode {Country="Papua New Guinea", Code="+675"},
            new CountryCode {Country="Paraguay", Code="+595"},
            new CountryCode {Country="Peru", Code="+51"},
            new CountryCode {Country="Philippines", Code="+63"},
            new CountryCode {Country="Pitcairn", Code="+870"},
            new CountryCode {Country="Poland", Code="+48"},
            new CountryCode {Country="Portugal", Code="+351"},
            new CountryCode {Country="Puerto Rico", Code="+1"},
            new CountryCode {Country="Qatar", Code="+974"},
            new CountryCode {Country="Réunion and Mayotte", Code="+262"},
            new CountryCode {Country="Romania", Code="+40"},
            new CountryCode {Country="Russian Federation", Code="+7"},
            new CountryCode {Country="Rwanda", Code="+250"},
            new CountryCode {Country="Saint Helena and also Tristan Da Cunha", Code="+290"},
            new CountryCode {Country="Saint Kitts and Nevis", Code="+1"},
            new CountryCode {Country="Saint Lucia", Code="+1"},
            new CountryCode {Country="Saint Pierre and Miquelon", Code="+508"},
            new CountryCode {Country="Saint Vincent and the Grenadines", Code="+1"},
            new CountryCode {Country="Samoa", Code="+685"},
            new CountryCode {Country="San Marino", Code="+378"},
            new CountryCode {Country="São Tomé and Principe", Code="+239"},
            new CountryCode {Country="Saudi Arabia", Code="+966"},
            new CountryCode {Country="Senegal", Code="+221"},
            new CountryCode {Country="Serbia", Code="+381"},
            new CountryCode {Country="Seychelles", Code="+248"},
            new CountryCode {Country="Sierra Leone", Code="+232"},
            new CountryCode {Country="Singapore", Code="+65"},
            new CountryCode {Country="Slovakia", Code="+421"},
            new CountryCode {Country="Slovenia", Code="+386"},
            new CountryCode {Country="Solomon Islands", Code="+677"},
            new CountryCode {Country="Somalia", Code="+252"},
            new CountryCode {Country="South Africa", Code="+27"},
            new CountryCode {Country="Spain", Code="+34"},
            new CountryCode {Country="Sri Lanka", Code="+94"},
            new CountryCode {Country="Sudan", Code="+249"},
            new CountryCode {Country="Suriname", Code="+597"},
            new CountryCode {Country="Svalbard and Jan Mayen Islands", Code="+47"},
            new CountryCode {Country="Swaziland", Code="+268"},
            new CountryCode {Country="Sweden", Code="+46"},
            new CountryCode {Country="Switzerland", Code="+41"},
            new CountryCode {Country="Syrian Arab Republic (Syria)", Code="+963"},
            new CountryCode {Country="Taiwan, Republic of China", Code="+886"},
            new CountryCode {Country="Tajikistan", Code="+992"},
            new CountryCode {Country="Tanzania, United Republic of", Code="+255"},
            new CountryCode {Country="Thailand", Code="+66"},
            new CountryCode {Country="Timor-Leste", Code="+670"},
            new CountryCode {Country="Togo", Code="+228"},
            new CountryCode {Country="Tokelau", Code="+690"},
            new CountryCode {Country="Tonga", Code="+676"},
            new CountryCode {Country="Trinidad and Tobago", Code="+1"},
            new CountryCode {Country="Tunisia", Code="+216"},
            new CountryCode {Country="Turkey", Code="+90"},
            new CountryCode {Country="Turkmenistan", Code="+993"},
            new CountryCode {Country="Turks and Caicos Islands", Code="+1"},
            new CountryCode {Country="Tuvalu", Code="+688"},
            new CountryCode {Country="Uganda", Code="+256"},
            new CountryCode {Country="Ukraine", Code="+380"},
            new CountryCode {Country="United Arab Emirates", Code="+971"},
            new CountryCode {Country="United Kingdom", Code="+44"},
            new CountryCode {Country="United States of America", Code="+1"},
            new CountryCode {Country="Uruguay", Code="+598"},
            new CountryCode {Country="Uzbekistan", Code="+998"},
            new CountryCode {Country="Vanuatu", Code="+678"},
            new CountryCode {Country="Venezuela (Bolivarian Republic of)", Code="+58"},
            new CountryCode {Country="Viet Nam", Code="+84"},
            new CountryCode {Country="Virgin Islands, British", Code="+1"},
            new CountryCode {Country="Virgin Islands, US", Code="+1"},
            new CountryCode {Country="Wallis and Futuna Islands", Code="+681"},
            new CountryCode {Country="Yemen", Code="+967"},
            new CountryCode {Country="Zambia", Code="+260"},
            new CountryCode {Country="Zimbabwe", Code="+263"}
        };
    }

    public bool IsLoginEnabled {
        get { return this.isloginEnabled; }
        set { SetProperty(ref this.isloginEnabled, value); }
    }

    public string Notes {
        get { return this.notes; }
        set { SetProperty(ref this.notes, value); }
    }

    public DateTime? BirthDate {
        get { return this.birthDate; }
        set { SetProperty(ref this.birthDate, value); }
    }

    public string Phone {
        get { return this.phone; }
        set { SetProperty(ref this.phone, value); }
    }

    public string Login {
        get { return this.login; }
        set { SetProperty(ref this.login, value); }
    }

    public bool LoginHasError {
        get { return this.loginHasError; }
        set { SetProperty(ref this.loginHasError, value); }
    }

    public string Password {
        get { return password; }
        set { SetProperty(ref this.password, value); }
    }

    public bool PasswordHasError {
        get { return this.passwordHasError; }
        set { SetProperty(ref this.passwordHasError, value); }
    }

    public CountryCode SelectedCountry {
        get { return selectedCountry; }
        set { SetProperty(ref this.selectedCountry, value); }
    }

    public List<CountryCode> Codes { get; }
    public BindingList<ChipDataObject> Chips { get; }

    public void EnableValidation() {
        this.isValidationEnabled = true;
    }

    public bool ValidateLogin() {
        if (!isValidationEnabled)
            return false;
        LoginHasError = String.IsNullOrEmpty(login);
        IsLoginEnabled = false;
        Validate();
        return true;
    }

    public bool ValidatePassword() {
        if (!isValidationEnabled)
            return false;
        PasswordHasError = !Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{5,}$");
        IsLoginEnabled = false;
        Validate();
        return false;
    }

    public bool Validate() {
        if (!isValidationEnabled)
            return false;
        if (!PasswordHasError && !LoginHasError) {
            IsLoginEnabled = true;
            return true;
        }
        else {
            IsLoginEnabled = false;
            return false;
        }
    }
}
