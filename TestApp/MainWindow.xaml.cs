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

namespace TestApp
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
        
        private void EnterDown(object sender, KeyEventArgs e)
        {

            TabItem tempTab = (TabItem)playerTabCont.Items.CurrentItem;
            Grid tempGrid = (Grid)playerTabCont.SelectedContent;
            UIElementCollection tempUI = tempGrid.Children;
            TextBox tempText = (TextBox)tempUI[0];


            if (e.Key == Key.Enter) 
            {
                

                tempText.AppendText("\nYou: " + DMChat.Text);
                DMChat.Text = "";
                int tmp = tempText.LineCount;
                tempText.ScrollToLine(tmp-1);
            }
        }

        private void addTab(object sender, MouseButtonEventArgs e)
        {
            int thisTab = playerTabCont.SelectedIndex;
            

            TabItem newTab = new TabItem { DataContext = defaultTab.DataContext };
            newTab.Header = "Stuff";
            newTab.Visibility = Visibility.Visible;
            playerTabCont.Items.Add(newTab);
        }
    }
}