using System.Windows.Controls;
using MVVM_Pattern.ViewModels;

namespace MVVM_Pattern.Views
{
    /// <summary>
    /// Interaction logic for UserHometownView.xaml
    /// </summary>
    public partial class UserHometownView : UserControl
    {
        public UserHometownView(UserHometownViewModel uhvm)
        {
            InitializeComponent();
            DataContext = uhvm;
        }
    }
}
