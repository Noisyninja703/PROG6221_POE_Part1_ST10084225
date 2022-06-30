using System.Windows;
using System;


namespace PROG6221_POE_Draft2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LV0_Selected(object sender, RoutedEventArgs e)
        {

            SavingsPage savingsPage = new SavingsPage();

            mainFrame.Content = savingsPage;

        }

        private void LV1_Selected(object sender, RoutedEventArgs e)
        {

            BasicExpensesPage basicExpPage = new BasicExpensesPage();

            mainFrame.Content = basicExpPage;
        }

        private void LV2_Selected(object sender, RoutedEventArgs e)
        {
            
            HomeExpensesPage homeExpPage = new HomeExpensesPage();

            mainFrame.Content = homeExpPage;

        }

        private void LV3_Selected(object sender, RoutedEventArgs e)
        {
            CarExpense carExpPage = new CarExpense();
            mainFrame.Content = carExpPage;
           
        }

        private void LV4_Selected(object sender, RoutedEventArgs e)
        {
            BudgetReport budgetReportPage = new BudgetReport();
            mainFrame.Content = budgetReportPage;

        }

        private void LV5_Selected(object sender, RoutedEventArgs e)
        {

            System.Windows.Application.Current.Shutdown();

        }
    }
}
