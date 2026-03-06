using System.Windows;

namespace Group4337
{
    public partial class MainWindow : Window
    {
        public MainWindow()
            => InitializeComponent();

        private void Info_4337_Belyaeva_Click(object sender, RoutedEventArgs e)
        {
            var infoWindow = new Window1();
            infoWindow.Show();
        }
    }
}