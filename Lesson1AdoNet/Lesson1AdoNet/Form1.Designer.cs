namespace Lesson1AdoNet
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
            textBox1 = new TextBox();
            btnExec = new Button();
            btnFill = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 5);
            textBox1.Margin = new Padding(6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(694, 39);
            textBox1.TabIndex = 0;
            // 
            // btnExec
            // 
            btnExec.AutoSize = true;
            btnExec.Location = new Point(15, 53);
            btnExec.Name = "btnExec";
            btnExec.Size = new Size(109, 42);
            btnExec.TabIndex = 1;
            btnExec.Text = "Exec";
            btnExec.UseVisualStyleBackColor = false;
            btnExec.Click += btnExec_Click;
            // 
            // btnFill
            // 
            btnFill.AutoSize = true;
            btnFill.Location = new Point(171, 53);
            btnFill.Name = "btnFill";
            btnFill.Size = new Size(109, 42);
            btnFill.TabIndex = 1;
            btnFill.Text = "Fill";
            btnFill.UseVisualStyleBackColor = false;
            btnFill.Click += btnFill_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.Location = new Point(341, 53);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(139, 42);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update Db";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(697, 362);
            dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 476);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnFill);
            Controls.Add(btnExec);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnExec;
        private Button btnFill;
        private Button btnUpdate;
        private DataGridView dataGridView1;
    }
}
