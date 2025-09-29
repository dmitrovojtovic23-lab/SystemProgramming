using System.Diagnostics;
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
namespace _02_TaskManager
{
    public class ProcessInfo
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public string StartTime { get; set; }
        public bool Responding { get; set; }
        public int BasePriority { get; set; }
        public Process ProcessRef { get; set; }
    }
    private List<ProcessInfo> GetProcessList()
    {
            var list = new List<ProcessInfo>();
            foreach (var proc in Process.GetProcesses())
            {
                string startTime = "";
                try { startTime = proc.StartTime.ToString(); } catch { }
                list.Add(new ProcessInfo
                {
                    Id = proc.Id,
                    ProcessName = proc.ProcessName,
                    StartTime = startTime,
                    Responding = proc.Responding,
                    BasePriority = proc.BasePriority,
                    ProcessRef = proc
                });
            }
            return list;
    }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = GetProcessList();
        }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = Process.GetProcesses();
            //(grid.SelectedItem as Process)
            string message = " ";
            message += "Hellloooooooooo";

            MessageBox.Show(message, "Process info", MessageBoxButton.OK, MessageBoxImage.Information);
            MessageBox.Show(nameProc.Text);
        }
    }
}