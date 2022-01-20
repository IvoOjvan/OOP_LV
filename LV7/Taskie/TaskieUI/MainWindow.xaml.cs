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
using TaskieCore;

namespace TaskieUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TaskRepository repository = new TaskRepository();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveTask_Click(object sender, RoutedEventArgs e)
        {
            int importance = int.Parse(ImportanceInput.Value.ToString());
            DateTime date = DateInput.SelectedDate.Value;
            repository.AddTask(new DeadlineTask(TitleInput.Text, importance, date));
            TasksList.ItemsSource = repository.GetTasks();
        }

        private void TasksList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ToDoTask task = TasksList.SelectedItem as ToDoTask;
            repository.DeleteTask(task);
            TasksList.ItemsSource = repository.GetTasks();
        }

        private void CompleteTask_Click(object sender, RoutedEventArgs e)
        {
            repository.DeleteTasks(tasksToCompleteInput.Text);
            TasksList.ItemsSource = repository.GetTasks();
        }

        private void TaskCount_Click(object sender, RoutedEventArgs e)
        {
            string msg = repository.NumberOfTasks().ToString();
            MessageBox.Show("Number of tasks: " + msg, "Highest priority tasks");
        }
    }
}
