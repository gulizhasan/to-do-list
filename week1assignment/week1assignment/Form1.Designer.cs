
namespace week1assignment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addTaskButton = new System.Windows.Forms.Button();
            this.removeTaskButton = new System.Windows.Forms.Button();
            this.taskBox = new System.Windows.Forms.TextBox();
            this.taskDescLabel = new System.Windows.Forms.Label();
            this.taskCountLabel = new System.Windows.Forms.Label();
            this.removedTaskLabel = new System.Windows.Forms.Label();
            this.removedTaskBox = new System.Windows.Forms.TextBox();
            this.firstTaskLabel = new System.Windows.Forms.Label();
            this.firstTaskBox = new System.Windows.Forms.TextBox();
            this.firstBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(119, 110);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(75, 23);
            this.addTaskButton.TabIndex = 0;
            this.addTaskButton.Text = "Add Task";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTask_Click);
            // 
            // removeTaskButton
            // 
            this.removeTaskButton.Location = new System.Drawing.Point(200, 102);
            this.removeTaskButton.Name = "removeTaskButton";
            this.removeTaskButton.Size = new System.Drawing.Size(84, 38);
            this.removeTaskButton.TabIndex = 1;
            this.removeTaskButton.Text = "Remove First Task";
            this.removeTaskButton.UseVisualStyleBackColor = true;
            this.removeTaskButton.Click += new System.EventHandler(this.removeTask_Click);
            // 
            // taskBox
            // 
            this.taskBox.Location = new System.Drawing.Point(119, 35);
            this.taskBox.Name = "taskBox";
            this.taskBox.Size = new System.Drawing.Size(266, 20);
            this.taskBox.TabIndex = 2;
            // 
            // taskDescLabel
            // 
            this.taskDescLabel.AutoSize = true;
            this.taskDescLabel.Location = new System.Drawing.Point(23, 38);
            this.taskDescLabel.Name = "taskDescLabel";
            this.taskDescLabel.Size = new System.Drawing.Size(90, 13);
            this.taskDescLabel.TabIndex = 3;
            this.taskDescLabel.Text = "Task Description:";
            // 
            // taskCountLabel
            // 
            this.taskCountLabel.AutoSize = true;
            this.taskCountLabel.Location = new System.Drawing.Point(116, 80);
            this.taskCountLabel.Name = "taskCountLabel";
            this.taskCountLabel.Size = new System.Drawing.Size(90, 13);
            this.taskCountLabel.TabIndex = 4;
            this.taskCountLabel.Text = "Number of tasks: ";
            // 
            // removedTaskLabel
            // 
            this.removedTaskLabel.AutoSize = true;
            this.removedTaskLabel.Location = new System.Drawing.Point(23, 198);
            this.removedTaskLabel.Name = "removedTaskLabel";
            this.removedTaskLabel.Size = new System.Drawing.Size(83, 13);
            this.removedTaskLabel.TabIndex = 5;
            this.removedTaskLabel.Text = "Removed Task:";
            // 
            // removedTaskBox
            // 
            this.removedTaskBox.Location = new System.Drawing.Point(119, 195);
            this.removedTaskBox.Name = "removedTaskBox";
            this.removedTaskBox.Size = new System.Drawing.Size(266, 20);
            this.removedTaskBox.TabIndex = 6;
            // 
            // firstTaskLabel
            // 
            this.firstTaskLabel.AutoSize = true;
            this.firstTaskLabel.Location = new System.Drawing.Point(23, 157);
            this.firstTaskLabel.Name = "firstTaskLabel";
            this.firstTaskLabel.Size = new System.Drawing.Size(56, 13);
            this.firstTaskLabel.TabIndex = 7;
            this.firstTaskLabel.Text = "First Task:";
            // 
            // firstTaskBox
            // 
            this.firstTaskBox.Location = new System.Drawing.Point(119, 154);
            this.firstTaskBox.Name = "firstTaskBox";
            this.firstTaskBox.Size = new System.Drawing.Size(266, 20);
            this.firstTaskBox.TabIndex = 8;
            // 
            // firstBox
            // 
            this.firstBox.Location = new System.Drawing.Point(293, 110);
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(92, 23);
            this.firstBox.TabIndex = 9;
            this.firstBox.Text = "Show First Task";
            this.firstBox.UseVisualStyleBackColor = true;
            this.firstBox.Click += new System.EventHandler(this.firstBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 238);
            this.Controls.Add(this.firstBox);
            this.Controls.Add(this.firstTaskBox);
            this.Controls.Add(this.firstTaskLabel);
            this.Controls.Add(this.removedTaskBox);
            this.Controls.Add(this.removedTaskLabel);
            this.Controls.Add(this.taskCountLabel);
            this.Controls.Add(this.taskDescLabel);
            this.Controls.Add(this.taskBox);
            this.Controls.Add(this.removeTaskButton);
            this.Controls.Add(this.addTaskButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Button removeTaskButton;
        private System.Windows.Forms.TextBox taskBox;
        private System.Windows.Forms.Label taskDescLabel;
        private System.Windows.Forms.Label taskCountLabel;
        private System.Windows.Forms.Label removedTaskLabel;
        private System.Windows.Forms.TextBox removedTaskBox;
        private System.Windows.Forms.Label firstTaskLabel;
        private System.Windows.Forms.TextBox firstTaskBox;
        private System.Windows.Forms.Button firstBox;
    }
}

