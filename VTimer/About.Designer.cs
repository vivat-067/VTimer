namespace VTimer
{
    partial class AboutForm
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
            tlpMain = new TableLayoutPanel();
            tlpAbout = new TableLayoutPanel();
            btnClose = new Button();
            flpAbout = new FlowLayoutPanel();
            labAppName = new Label();
            labVersion = new Label();
            labAssembley = new Label();
            labDevBy = new Label();
            labDescription = new Label();
            pbLogo = new PictureBox();
            tlpMain.SuspendLayout();
            tlpAbout.SuspendLayout();
            flpAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 181F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(tlpAbout, 1, 0);
            tlpMain.Controls.Add(pbLogo, 0, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(364, 261);
            tlpMain.TabIndex = 0;
            // 
            // tlpAbout
            // 
            tlpAbout.ColumnCount = 2;
            tlpAbout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.263158F));
            tlpAbout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 94.73684F));
            tlpAbout.Controls.Add(btnClose, 2, 1);
            tlpAbout.Controls.Add(flpAbout, 1, 0);
            tlpAbout.Dock = DockStyle.Fill;
            tlpAbout.Location = new Point(184, 10);
            tlpAbout.Margin = new Padding(3, 10, 3, 3);
            tlpAbout.Name = "tlpAbout";
            tlpAbout.RowCount = 1;
            tlpAbout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAbout.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tlpAbout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpAbout.Size = new Size(177, 248);
            tlpAbout.TabIndex = 0;
            tlpAbout.Paint += tableLayoutPanel1_Paint;
            // 
            // btnClose
            // 
            btnClose.AutoEllipsis = true;
            btnClose.Dock = DockStyle.Right;
            btnClose.Location = new Point(74, 222);
            btnClose.Margin = new Padding(3, 3, 15, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(88, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "OK";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // flpAbout
            // 
            flpAbout.AutoSize = true;
            flpAbout.Controls.Add(labAppName);
            flpAbout.Controls.Add(labVersion);
            flpAbout.Controls.Add(labAssembley);
            flpAbout.Controls.Add(labDevBy);
            flpAbout.Controls.Add(labDescription);
            flpAbout.Dock = DockStyle.Fill;
            flpAbout.FlowDirection = FlowDirection.TopDown;
            flpAbout.Location = new Point(9, 3);
            flpAbout.Margin = new Padding(0, 3, 3, 3);
            flpAbout.Name = "flpAbout";
            flpAbout.Size = new Size(165, 213);
            flpAbout.TabIndex = 2;
            // 
            // labAppName
            // 
            labAppName.Dock = DockStyle.Right;
            labAppName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labAppName.Location = new Point(48, 0);
            labAppName.Name = "labAppName";
            labAppName.Size = new Size(114, 30);
            labAppName.TabIndex = 3;
            labAppName.Text = "vTimer";
            // 
            // labVersion
            // 
            labVersion.Dock = DockStyle.Top;
            labVersion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labVersion.Location = new Point(3, 30);
            labVersion.Name = "labVersion";
            labVersion.Size = new Size(159, 23);
            labVersion.TabIndex = 4;
            labVersion.Text = "версия:";
            labVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labAssembley
            // 
            labAssembley.Dock = DockStyle.Top;
            labAssembley.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labAssembley.Location = new Point(3, 53);
            labAssembley.Name = "labAssembley";
            labAssembley.Size = new Size(159, 23);
            labAssembley.TabIndex = 5;
            labAssembley.Text = "сборка";
            labAssembley.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labDevBy
            // 
            labDevBy.AutoSize = true;
            labDevBy.Dock = DockStyle.Top;
            labDevBy.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labDevBy.Location = new Point(3, 79);
            labDevBy.Margin = new Padding(3, 3, 3, 8);
            labDevBy.Name = "labDevBy";
            labDevBy.RightToLeft = RightToLeft.No;
            labDevBy.Size = new Size(159, 13);
            labDevBy.TabIndex = 6;
            labDevBy.Text = "DevBy";
            labDevBy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labDescription
            // 
            labDescription.Dock = DockStyle.Left;
            labDescription.Location = new Point(3, 100);
            labDescription.Name = "labDescription";
            labDescription.Size = new Size(159, 49);
            labDescription.TabIndex = 8;
            labDescription.Text = "Таймер напоминания\r\n о необходимости сделать перерыв";
            labDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            pbLogo.BackgroundImage = Properties.Resources.TimerAbout3;
            pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pbLogo.Dock = DockStyle.Fill;
            pbLogo.Image = Properties.Resources.Logo9;
            pbLogo.Location = new Point(3, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(175, 255);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 261);
            ControlBox = false;
            Controls.Add(tlpMain);
            MinimizeBox = false;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            Load += AboutForm_Load;
            tlpMain.ResumeLayout(false);
            tlpAbout.ResumeLayout(false);
            tlpAbout.PerformLayout();
            flpAbout.ResumeLayout(false);
            flpAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpAbout;
        private Button btnClose;
        private PictureBox pbLogo;
        private FlowLayoutPanel flpAbout;
        private Label labAppName;
        private Label labVersion;
        private Label labAssembley;
        private Label labDevBy;
        private Label labDescription;
    }
}