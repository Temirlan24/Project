using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            AddRecipeWindow arw = new AddRecipeWindow();
            RecipeWindow rw = new RecipeWindow();
            NameOfFoodTBWindow.Text = arw.FoodName;
            FoodAvgTBWindow.Text = arw.FoodAvg;
            TypeOfFoodTBWindow.Text = arw.TypeOfFood;
            TypeOfKitchenTBWindow.Text = arw.TypeOfKitchen;
            CompositionOfTheDishTBWindow.Text = arw.CompositionOfTheDish;
            StepByStepCookingTBWindow.Text = arw.StepByStepCooking;
        }

        private void NameOfFoodTBWindow_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Случайно, не нужно.
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.Close();
        }
    }
}
