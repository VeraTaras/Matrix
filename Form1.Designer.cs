namespace SP._2
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            comboBoxChooseMatrix = new ComboBox();
            comboBoxOperating = new ComboBox();
            buttonK = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(800, 469);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(22, 35);
            button1.Name = "button1";
            button1.Size = new Size(152, 40);
            button1.TabIndex = 1;
            button1.Text = "Show Matrix";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(180, 35);
            button2.Name = "button2";
            button2.Size = new Size(148, 40);
            button2.TabIndex = 2;
            button2.Text = "Read Matrix";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBoxChooseMatrix
            // 
            comboBoxChooseMatrix.Anchor = AnchorStyles.Top;
            comboBoxChooseMatrix.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxChooseMatrix.FormattingEnabled = true;
            comboBoxChooseMatrix.Items.AddRange(new object[] { "None", "MatrixA-input", "MatrixB-input", "MatrixC-output", "detA-output" });
            comboBoxChooseMatrix.Location = new Point(637, 18);
            comboBoxChooseMatrix.Name = "comboBoxChooseMatrix";
            comboBoxChooseMatrix.Size = new Size(151, 33);
            comboBoxChooseMatrix.TabIndex = 3;
            comboBoxChooseMatrix.Text = "Choose Matrix";
            comboBoxChooseMatrix.SelectedIndexChanged += comboBoxChooseMatrix_SelectedIndexChanged;
            // 
            // comboBoxOperating
            // 
            comboBoxOperating.Anchor = AnchorStyles.Top;
            comboBoxOperating.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxOperating.FormattingEnabled = true;
            comboBoxOperating.Items.AddRange(new object[] { "A+B", "A-B", "k*A", "A*B", "detA" });
            comboBoxOperating.Location = new Point(637, 57);
            comboBoxOperating.Name = "comboBoxOperating";
            comboBoxOperating.Size = new Size(151, 33);
            comboBoxOperating.TabIndex = 4;
            comboBoxOperating.Text = "Operations";
            comboBoxOperating.SelectedIndexChanged += comboBoxOperating_SelectedIndexChanged;
            // 
            // buttonK
            // 
            buttonK.Anchor = AnchorStyles.Top;
            buttonK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonK.Location = new Point(334, 35);
            buttonK.Name = "buttonK";
            buttonK.Size = new Size(144, 40);
            buttonK.TabIndex = 5;
            buttonK.Text = "Read scalar";
            buttonK.UseVisualStyleBackColor = true;
            buttonK.Click += buttonK_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(484, 35);
            button3.Name = "button3";
            button3.Size = new Size(132, 40);
            button3.TabIndex = 6;
            button3.Text = "Show det";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 574);
            Controls.Add(button3);
            Controls.Add(buttonK);
            Controls.Add(comboBoxOperating);
            Controls.Add(comboBoxChooseMatrix);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Matrix";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private ComboBox comboBoxChooseMatrix;
        private ComboBox comboBoxOperating;
        private Button buttonK;
        private Button button3;
    }
}