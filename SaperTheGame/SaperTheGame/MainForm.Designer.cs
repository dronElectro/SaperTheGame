namespace SaperTheGame
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaperField = new System.Windows.Forms.DataGridView();
            this.FieldSizeLabel = new System.Windows.Forms.Label();
            this.FieldSIzeTB = new System.Windows.Forms.TrackBar();
            this.NumOfMinesLabel = new System.Windows.Forms.Label();
            this.NumOfMinesTB = new System.Windows.Forms.TrackBar();
            this.StartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SaperField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldSIzeTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfMinesTB)).BeginInit();
            this.SuspendLayout();
            // 
            // SaperField
            // 
            this.SaperField.AllowUserToAddRows = false;
            this.SaperField.AllowUserToDeleteRows = false;
            this.SaperField.AllowUserToResizeColumns = false;
            this.SaperField.AllowUserToResizeRows = false;
            this.SaperField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaperField.ColumnHeadersVisible = false;
            this.SaperField.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaperField.Location = new System.Drawing.Point(0, 0);
            this.SaperField.Name = "SaperField";
            this.SaperField.RowHeadersVisible = false;
            this.SaperField.RowHeadersWidth = 51;
            this.SaperField.RowTemplate.Height = 24;
            this.SaperField.Size = new System.Drawing.Size(508, 496);
            this.SaperField.TabIndex = 0;
            this.SaperField.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SaperField_CellMouseDown_1);
            // 
            // FieldSizeLabel
            // 
            this.FieldSizeLabel.AutoSize = true;
            this.FieldSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FieldSizeLabel.Location = new System.Drawing.Point(514, 9);
            this.FieldSizeLabel.Name = "FieldSizeLabel";
            this.FieldSizeLabel.Size = new System.Drawing.Size(27, 29);
            this.FieldSizeLabel.TabIndex = 1;
            this.FieldSizeLabel.Text = "3";
            // 
            // FieldSIzeTB
            // 
            this.FieldSIzeTB.Location = new System.Drawing.Point(513, 41);
            this.FieldSIzeTB.Maximum = 20;
            this.FieldSIzeTB.Minimum = 3;
            this.FieldSIzeTB.Name = "FieldSIzeTB";
            this.FieldSIzeTB.Size = new System.Drawing.Size(104, 56);
            this.FieldSIzeTB.TabIndex = 2;
            this.FieldSIzeTB.Value = 3;
            this.FieldSIzeTB.Scroll += new System.EventHandler(this.FieldSIzeTB_Scroll);
            // 
            // NumOfMinesLabel
            // 
            this.NumOfMinesLabel.AutoSize = true;
            this.NumOfMinesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumOfMinesLabel.Location = new System.Drawing.Point(519, 104);
            this.NumOfMinesLabel.Name = "NumOfMinesLabel";
            this.NumOfMinesLabel.Size = new System.Drawing.Size(27, 29);
            this.NumOfMinesLabel.TabIndex = 3;
            this.NumOfMinesLabel.Text = "3";
            // 
            // NumOfMinesTB
            // 
            this.NumOfMinesTB.Location = new System.Drawing.Point(513, 136);
            this.NumOfMinesTB.Maximum = 400;
            this.NumOfMinesTB.Minimum = 3;
            this.NumOfMinesTB.Name = "NumOfMinesTB";
            this.NumOfMinesTB.Size = new System.Drawing.Size(104, 56);
            this.NumOfMinesTB.TabIndex = 4;
            this.NumOfMinesTB.Value = 3;
            this.NumOfMinesTB.Scroll += new System.EventHandler(this.NumOfMinesTB_Scroll);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(519, 199);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(98, 34);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 496);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.NumOfMinesTB);
            this.Controls.Add(this.NumOfMinesLabel);
            this.Controls.Add(this.FieldSIzeTB);
            this.Controls.Add(this.FieldSizeLabel);
            this.Controls.Add(this.SaperField);
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SaperTheGame";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResizeEnd += new System.EventHandler(this.MainWindow_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.SaperField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldSIzeTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfMinesTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SaperField;
        private System.Windows.Forms.Label FieldSizeLabel;
        private System.Windows.Forms.TrackBar FieldSIzeTB;
        private System.Windows.Forms.Label NumOfMinesLabel;
        private System.Windows.Forms.TrackBar NumOfMinesTB;
        private System.Windows.Forms.Button StartButton;
    }
}

