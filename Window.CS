using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // When the "Add Task" button is clicked
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the text entered in the TextBox
            string task = taskTextBox.Text.Trim();

            // Check if the text is not empty
            if (!string.IsNullOrEmpty(task))
            {
                // Add the task to the ListBox
                tasksListBox.Items.Add(task);

                // Clear the TextBox after adding the task
                taskTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task.");
            }
        }

        // When the "Delete Task" button is clicked
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Check if an item is selected in the ListBox
            if (tasksListBox.SelectedItem != null)
            {
                // Remove the selected task
                tasksListBox.Items.Remove(tasksListBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }
    }
}