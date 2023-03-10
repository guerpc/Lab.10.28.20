using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab._10._28._20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<VideoGame> videoGames;

        public MainWindow()
        {
            InitializeComponent();
            videoGames = new ObservableCollection<VideoGame>();
            DataContext = videoGames;
        }

        private void ListView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VideoGame vg = new VideoGame();

            string gName = textBoxGameName.Text;
            string gRating = textBoxRating.Text;
            double gPrice = Convert.ToDouble(textBoxPrice.Text);

            vg.GameName = gName;
            vg.Rating = gRating;
            vg.Price = gPrice;

            // add the videogame instance to the collection
            videoGames.Add(vg);
        }
    }
   
}
