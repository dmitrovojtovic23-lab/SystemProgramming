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
        private void ShowInfo_Click(object sender, RoutedEventArgs e)
        {

            Process selectedProcess = (grid.SelectedItem as Process);
            string info = $"Process Name: {selectedProcess.ProcessName}\n";
                //              $"PID: {selectedProcess.Id}\n" +
                //              $"Start Time: {selectedProcess.StartTime}\n" +
                //              $"Priority: {selectedProcess.PriorityClass}\n" +
                //              $"Total Processor Time: {selectedProcess.TotalProcessorTime}\n";
                MessageBox.Show(info, "Process Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void Kill_Click(object sender, RoutedEventArgs e)
        {
            if (grid.SelectedItem is Process selectedProcess)
            {
                    selectedProcess.Kill();
                    MessageBox.Show($"Process {selectedProcess.ProcessName} (PID: {selectedProcess.Id}) terminated.", "Process Killed", MessageBoxButton.OK, MessageBoxImage.Information);
                    grid.ItemsSource = Process.GetProcesses();
            }
        }
    }
}