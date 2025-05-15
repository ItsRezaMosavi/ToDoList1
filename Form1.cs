namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clbTasks.Items.Add(txtNewTask.Text);
        }

        private void clbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clbTasks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
                        
        }
    }
}
