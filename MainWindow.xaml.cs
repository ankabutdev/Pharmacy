using Pharmacy.Entities;
using Pharmacy.Pages;
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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pharmacy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public object SealsPage { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void brDragable_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else this.WindowState = WindowState.Maximized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void rbDashboard_Click(object sender, RoutedEventArgs e)
        {
            DashboardPage dashboardPage = new DashboardPage();
            PageNavigator.Content = dashboardPage;
        }

        private void rbMedicine_Click(object sender, RoutedEventArgs e)
        {
            MedicinePage medicinePage = new MedicinePage();
            PageNavigator.Content = medicinePage;
        }

        private void rbSeals_Click(object sender, RoutedEventArgs e)
        {
            SalesPage sealsPage = new SalesPage();
            PageNavigator.Content = sealsPage;
        }
    }
}
