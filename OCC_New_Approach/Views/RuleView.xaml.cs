using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OCC_New_Approach
{
    /// <summary>
    /// Interaction logic for RuleView.xaml
    /// </summary>
    public partial class RuleView : Window
    {
        public RuleView()
        {
            InitializeComponent();
            var rulevm = new RuleViewModel();
            DataContext = rulevm;
        }
    }
}
