using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using cleardrive.viewmodel;
//using System.Text.Json;

namespace cleardrive.desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private static readonly HttpClient client = new HttpClient();
        //private readonly HttpClient _httpClient;

        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = new MainViewModel();
            //_httpClient = new HttpClient();
        }

        /*private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var response = await GetItemsFromApi();
            MessageBox.Show(response);
        }

        private async Task<string> GetItemsFromApi()
        {
            try
            {
                // A backend API elérési URL-je
                string apiUrl = "http://localhost:5000/api/items";

                // GET kérés küldése
                var response = await client.GetStringAsync(apiUrl);
                return response;
            }
            catch (HttpRequestException ex)
            {
                return "Hiba történt: " + ex.Message;
            }
        }*/





        /*private async Task GetDataFromApi()
        {
            try
            {
                string apiUrl = "https://your-api-endpoint.com/data";

                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    // API válaszának beolvasása JSON formátumban
                    string responseData = await response.Content.ReadAsStringAsync();

                    // A JSON adat deszerializálása (feltételezzük, hogy van egy Data típusú osztály)
                    var data = JsonConvert.DeserializeObject<MyDataType>(responseData);

                    // UI frissítése a lekért adatokkal
                    Dispatcher.Invoke(() =>
                    {
                        // Például egy TextBox frissítése
                        myTextBox.Text = data.SomeProperty;
                    });
                }
                else
                {
                    MessageBox.Show("Hiba történt a kérés feldolgozása közben.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba: {ex.Message}");
            }
        }

        private async void OnButtonClick(object sender, RoutedEventArgs e)
        {
            await GetDataFromApi();
        }*/
    }
}