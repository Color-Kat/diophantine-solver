namespace Diofant2
{
    partial class DiafantForm
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
            gridCoefficients = new DataGridView();
            a = new DataGridViewTextBoxColumn();
            b = new DataGridViewTextBoxColumn();
            c = new DataGridViewTextBoxColumn();
            solveButton = new Button();
            gridSolves = new DataGridView();
            xSolve = new DataGridViewTextBoxColumn();
            ySolve = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridCoefficients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridSolves).BeginInit();
            SuspendLayout();
            // 
            // gridCoefficients
            // 
            gridCoefficients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCoefficients.Columns.AddRange(new DataGridViewColumn[] { a, b, c });
            gridCoefficients.Location = new Point(12, 12);
            gridCoefficients.Name = "gridCoefficients";
            gridCoefficients.RowHeadersWidth = 92;
            gridCoefficients.Size = new Size(811, 306);
            gridCoefficients.TabIndex = 0;
            // 
            // a
            // 
            a.HeaderText = "A";
            a.MinimumWidth = 11;
            a.Name = "a";
            a.Width = 225;
            // 
            // b
            // 
            b.HeaderText = "B";
            b.MinimumWidth = 11;
            b.Name = "b";
            b.Width = 225;
            // 
            // c
            // 
            c.HeaderText = "c";
            c.MinimumWidth = 11;
            c.Name = "c";
            c.Width = 225;
            // 
            // solveButton
            // 
            solveButton.Location = new Point(12, 349);
            solveButton.Name = "solveButton";
            solveButton.Size = new Size(258, 369);
            solveButton.TabIndex = 1;
            solveButton.Text = "Решить";
            solveButton.UseVisualStyleBackColor = true;
            solveButton.Click += solveButton_Click;
            // 
            // gridSolves
            // 
            gridSolves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSolves.Columns.AddRange(new DataGridViewColumn[] { xSolve, ySolve });
            gridSolves.Location = new Point(276, 349);
            gridSolves.Name = "gridSolves";
            gridSolves.RowHeadersWidth = 92;
            gridSolves.Size = new Size(547, 369);
            gridSolves.TabIndex = 2;
            // 
            // xSolve
            // 
            xSolve.HeaderText = "X";
            xSolve.MinimumWidth = 11;
            xSolve.Name = "xSolve";
            xSolve.Width = 225;
            // 
            // ySolve
            // 
            ySolve.HeaderText = "Y";
            ySolve.MinimumWidth = 11;
            ySolve.Name = "ySolve";
            ySolve.Width = 225;
            // 
            // DiafantForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 740);
            Controls.Add(gridSolves);
            Controls.Add(solveButton);
            Controls.Add(gridCoefficients);
            Name = "DiafantForm";
            Text = "Решение Диофантовых уравнений";
            ((System.ComponentModel.ISupportInitialize)gridCoefficients).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridSolves).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridCoefficients;
        private Button solveButton;
        private DataGridView gridSolves;
        private DataGridViewTextBoxColumn a;
        private DataGridViewTextBoxColumn b;
        private DataGridViewTextBoxColumn c;
        private DataGridViewTextBoxColumn xSolve;
        private DataGridViewTextBoxColumn ySolve;
    }
}
