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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str1 = this.textBox1.Text;
            string str2 = this.textBox2.Text;
            int result = Convert.ToInt32(str1) + Convert.ToInt32(str2);
            this.textBox3.Text = Convert.ToString(result);
        }
    }
}
