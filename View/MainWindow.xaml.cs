using littleApp_MVVM.ViewModel;
using System.Windows;

namespace littleApp_MVVM
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new AppVM();
        }
    }
}
