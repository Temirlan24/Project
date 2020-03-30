using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp5;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для RecipeWindow.xaml
    /// </summary>
    public partial class RecipeWindow : Window
    {
        public List<AddRecipeWindow> recipeWindows;
        

        public RecipeWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter= "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            
            if (fileDialog.ShowDialog() == true)
            {
                string fileName = fileDialog.FileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(fileName);
                bitmap.EndInit();
                Picture.Source = bitmap;
            }
        
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.recipeWindows.Add(new AddRecipeWindow()
            {
                FoodName = FoodNameTB.Text,
                FoodAvg = AVGTB.Text,
                TypeOfFood = TypeOfFoodTB.Text,
                TypeOfKitchen = TypeOfKitchenTB.Text,
                CompositionOfTheDish = CompositionOfTheDishLB.Text,
                StepByStepCooking = StepByStepCookingLB.Text
            });
            window.lstView.ItemsSource = recipeWindows;
            window.Show();

            this.Close();
        }
    }
}
