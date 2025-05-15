namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clbTasks = new CheckedListBox();
            btnAdd = new Button();
            txtNewTask = new TextBox();
            SuspendLayout();
            // 
            // clbTasks
            // 
            clbTasks.Font = new Font("Segoe UI", 21.75F);
            clbTasks.FormattingEnabled = true;
            clbTasks.Location = new Point(24, 18);
            clbTasks.Name = "clbTasks";
            clbTasks.Size = new Size(335, 414);
            clbTasks.Sorted = true;
            clbTasks.TabIndex = 0;
            clbTasks.ItemCheck += clbTasks_ItemCheck;
            clbTasks.SelectedIndexChanged += clbTasks_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 21.75F);
            btnAdd.Location = new Point(269, 455);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 64);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtNewTask
            // 
            txtNewTask.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewTask.Location = new Point(24, 455);
            txtNewTask.Multiline = true;
            txtNewTask.Name = "txtNewTask";
            txtNewTask.Size = new Size(239, 64);
            txtNewTask.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 541);
            Controls.Add(txtNewTask);
            Controls.Add(btnAdd);
            Controls.Add(clbTasks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox clbTasks;
        private Button btnAdd;
        private TextBox txtNewTask;
    }
}
