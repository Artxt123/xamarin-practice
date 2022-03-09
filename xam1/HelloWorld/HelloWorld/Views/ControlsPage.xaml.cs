using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlsPage : ContentPage
    {
        public ControlsPage()
        {
            InitializeComponent();

            var label = new Label
            {
                Text = "My first label",
                FontSize = 12,
                FontAttributes = FontAttributes.Bold,
                FontFamily = "Arial",
                TextColor = Color.Blue
            };
            ContentContainer.Children.Add(label);

            var entry = new Entry
            {
                Keyboard = Keyboard.Numeric,
                Placeholder = "Numeric value"
            };
            ContentContainer.Children.Add(entry);

            var button = new Button
            {
                Text = "Click me"
            };
            button.Clicked += Button_Clicked;
            ContentContainer.Children.Add(button);

            var checkbox = new CheckBox
            {
                IsChecked = false,
                HorizontalOptions = LayoutOptions.End
            };
            ContentContainer.Children.Add(checkbox);

            var switchControl = new Switch
            {
                IsToggled = true
            };
            ContentContainer.Children.Add(switchControl);

            var datePicker = new DatePicker
            {
                MinimumDate = new DateTime(2022, 1, 1)
            };
            ContentContainer.Children.Add(datePicker);

            List<string> daysList = new List<string>
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
            };

            var picker = new Picker
            {
                ItemsSource = daysList,
                Title = "Choose day"
            };
            ContentContainer.Children.Add(picker);

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}