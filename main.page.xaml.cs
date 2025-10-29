using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace SimpleTodoList2
{
    public partial class MainPage : ContentPage
    {
       ObservableCollection<TodoTask> Tasks;
        public int IdCounter = 1;
        
        public MainPage()
        {
            Tasks= new ObservableCollection<TodoTask>();
            InitializeComponent();
            TaskListView.ItemsSource = Tasks;
            var newTask = new TodoTask();
        }

        private void Add_Clicked(object sender, EventArgs e)
        {
            var newTask = new TodoTask()
            {
                
                Id = IdCounter++,
                Title = TaskEntry.Text,
                IsCompleted = true,
            };
            Tasks.Add(newTask);
            TaskEntry.Text = String.Empty;
        }

        private void DelSel_Clicked(object sender, EventArgs e)
        {
            Tasks.Remove((TodoTask)TaskListView.SelectedItem);
        }

        private void DelAll_Clicked(object sender, EventArgs e)
        {
            Tasks.Clear();  
        }
    }
}
