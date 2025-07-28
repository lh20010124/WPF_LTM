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

namespace ControlLibrary
{
    /// <summary>
    /// SalaryCalculator.xaml 的交互逻辑
    /// </summary>
    public partial class SalaryCalculator : UserControl
    {
        public SalaryCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.textBox3.Text = Convert.ToString(Convert.ToInt32(this.textBox1.Text) + Convert.ToInt32(this.textBox2.Text));
        }
    }
}
