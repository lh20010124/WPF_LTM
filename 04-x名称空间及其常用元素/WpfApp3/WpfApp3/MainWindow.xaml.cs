using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        stu1.ID = 1111;
    }

    private void button1_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show(stu1.ID.ToString());
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        WindowHappy wh = new WindowHappy();
        wh.textBox1.Text = "I'm happy";
        wh.ShowDialog();
    }
}
public class Student
{
    public int ID { get; set; }
}