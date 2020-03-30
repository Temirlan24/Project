using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<AddRecipeWindow> recipeWindows=new List<AddRecipeWindow>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            RecipeWindow recipe = new RecipeWindow();
            //recipe.Owner = this;
            recipe.recipeWindows = this.recipeWindows;
            recipe.ShowDialog();     
            this.Close();
            
        }

        private void ExportBtn_Click(object sender, RoutedEventArgs e)
        {
            Export export = new Export();
            export.Owner = this;
            export.Show();
        }

        private void lstView_Selected(object sender, RoutedEventArgs e)
        {
            
         
        }

        private void lstView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RecipeWindow recipe = new RecipeWindow();
            recipe.recipeWindows = this.recipeWindows;
            recipe.FoodNameTB.Text = (this.lstView.SelectedItem as AddRecipeWindow).FoodName;
            recipe.TypeOfFoodTB.Text = (this.lstView.SelectedItem as AddRecipeWindow).TypeOfFood;
            recipe.TypeOfKitchenTB.Text = (this.lstView.SelectedItem as AddRecipeWindow).TypeOfKitchen;
            recipe.AVGTB.Text = (this.lstView.SelectedItem as AddRecipeWindow).FoodAvg;
            recipe.CompositionOfTheDishLB.Text = (this.lstView.SelectedItem as AddRecipeWindow).CompositionOfTheDish;
            recipe.Show();
            //recipe.recipeWindows.Add(new AddRecipeWindow()
            //{
            //    FoodName = recipe.FoodNameTB.Text,
            //    FoodAvg = recipe.AVGTB.Text,
            //    TypeOfFood = recipe.TypeOfFoodTB.Text,
            //    TypeOfKitchen = recipe.TypeOfKitchenTB.Text,
            //    CompositionOfTheDish = recipe.CompositionOfTheDishLB.Text,
            //    StepByStepCooking = recipe.StepByStepCookingLB.Text
            //});
            //this.lstView.ItemsSource = recipe.recipeWindows;
            this.Close();
        }
    }
}
