using EatApp.Model;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EatApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> persons = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();

            
            //persons.Add(new Person("Лаура", "Laura"));
            //persons.Add(new Person("Лаура1", "Laura1"));
            //persons.Add(new Person("Лаура1", "Laura1"));

            MyData.ItemsSource = persons;
        }

        private  void Button_Click(object sender, RoutedEventArgs e)
        {
            //var weatherForecast = new WeatherForecast
            //{
            //    Date = DateTime.Parse("2019-08-01"),
            //    TemperatureCelsius = 25,
            //    Summary = "Hot",
            //    SummaryField = "Hot",
            //    DatesAvailable = new List<DateTimeOffset>()
            //        { DateTime.Parse("2019-08-01"), DateTime.Parse("2019-08-02") },
            //    TemperatureRanges = new Dictionary<string, HighLowTemps>
            //    {
            //        ["Cold"] = new HighLowTemps { High = 20, Low = -10 },
            //        ["Hot"] = new HighLowTemps { High = 60, Low = 20 }
            //    },
            //    SummaryWords = new[] { "Cool", "Windy", "Humid" }
            //};

            //var options = new JsonSerializerOptions { WriteIndented = true };
            //string jsonString = JsonSerializer.Serialize(weatherForecast, options);

            Person person = new Person
            {
                PersonName = "Лаура 01",
                PersonLogin = "01"
            };

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(person, options);

            MessageBox.Show(jsonString);

        }

        public class WeatherForecast
        {
            public DateTimeOffset Date { get; set; }
            public int TemperatureCelsius { get; set; }
            public string? Summary { get; set; }
            public string? SummaryField;
            public IList<DateTimeOffset>? DatesAvailable { get; set; }
            public Dictionary<string, HighLowTemps>? TemperatureRanges { get; set; }
            public string[]? SummaryWords { get; set; }
        }

        public class HighLowTemps
        {
            public int High { get; set; }
            public int Low { get; set; }
        }
    }
}