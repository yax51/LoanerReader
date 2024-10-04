namespace LoanerReader
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
            Table = new DataGridView();
            BtnLoad = new Button();
            label1 = new Label();
            label2 = new Label();
            TxtLoanerName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Table).BeginInit();
            SuspendLayout();
            // 
            // Table
            // 
            Table.AllowUserToAddRows = false;
            Table.AllowUserToDeleteRows = false;
            Table.AllowUserToOrderColumns = true;
            Table.AllowUserToResizeRows = false;
            Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Table.BorderStyle = BorderStyle.Fixed3D;
            Table.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Table.Location = new Point(12, 165);
            Table.Name = "Table";
            Table.ReadOnly = true;
            Table.RowHeadersVisible = false;
            Table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Table.ShowEditingIcon = false;
            Table.Size = new Size(1041, 410);
            Table.TabIndex = 0;
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(500, 581);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(75, 23);
            BtnLoad.TabIndex = 1;
            BtnLoad.Text = "Load";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(379, 9);
            label1.Name = "label1";
            label1.Size = new Size(331, 59);
            label1.TabIndex = 2;
            label1.Text = "Loaner Laptops";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 116);
            label2.Name = "label2";
            label2.Size = new Size(246, 15);
            label2.TabIndex = 3;
            label2.Text = "Loaner Name convention (i.e. IBR1GCPIRML):";
            // 
            // TxtLoanerName
            // 
            TxtLoanerName.CharacterCasing = CharacterCasing.Upper;
            TxtLoanerName.Location = new Point(272, 113);
            TxtLoanerName.Name = "TxtLoanerName";
            TxtLoanerName.Size = new Size(228, 23);
            TxtLoanerName.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1065, 616);
            Controls.Add(TxtLoanerName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnLoad);
            Controls.Add(Table);
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loaners";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Table;
        private Button BtnLoad;
        private Label label1;
        private Label label2;
        private TextBox TxtLoanerName;
    }
}
