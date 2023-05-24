namespace PBL03
{
    partial class FormChamCong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChamCong));
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dtgvShow = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChamCong = new Guna.UI2.WinForms.Guna2Button();
            this.dtpkStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpkEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.tbSumWorkDay = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbShiftWork = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(502, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 79);
            this.label3.TabIndex = 13;
            this.label3.Text = "BẢNG CHẤM CÔNG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.guna2ShadowPanel1.Controls.Add(this.dtgvShow);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(53, 94);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1288, 401);
            this.guna2ShadowPanel1.TabIndex = 14;
            // 
            // dtgvShow
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvShow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvShow.ColumnHeadersHeight = 4;
            this.dtgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.Saturday,
            this.Sunday});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvShow.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvShow.GridColor = System.Drawing.Color.White;
            this.dtgvShow.Location = new System.Drawing.Point(3, 3);
            this.dtgvShow.Name = "dtgvShow";
            this.dtgvShow.RowHeadersVisible = false;
            this.dtgvShow.RowHeadersWidth = 51;
            this.dtgvShow.RowTemplate.Height = 24;
            this.dtgvShow.Size = new System.Drawing.Size(1282, 395);
            this.dtgvShow.TabIndex = 8;
            this.dtgvShow.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvShow.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvShow.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvShow.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvShow.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvShow.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvShow.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dtgvShow.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvShow.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvShow.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvShow.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvShow.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvShow.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvShow.ThemeStyle.ReadOnly = false;
            this.dtgvShow.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvShow.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvShow.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvShow.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvShow.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvShow.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvShow.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Name
            // 
            this.Name.HeaderText = "Tên";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Monday
            // 
            this.Monday.HeaderText = "Thứ 2";
            this.Monday.MinimumWidth = 6;
            this.Monday.Name = "Monday";
            // 
            // Tuesday
            // 
            this.Tuesday.HeaderText = "Thứ 3";
            this.Tuesday.MinimumWidth = 6;
            this.Tuesday.Name = "Tuesday";
            // 
            // Wednesday
            // 
            this.Wednesday.HeaderText = "Thứ 4";
            this.Wednesday.MinimumWidth = 6;
            this.Wednesday.Name = "Wednesday";
            // 
            // Thursday
            // 
            this.Thursday.HeaderText = "Thứ 5";
            this.Thursday.MinimumWidth = 6;
            this.Thursday.Name = "Thursday";
            // 
            // Friday
            // 
            this.Friday.HeaderText = "Thứ 6";
            this.Friday.MinimumWidth = 6;
            this.Friday.Name = "Friday";
            // 
            // Saturday
            // 
            this.Saturday.HeaderText = "Thứ 7";
            this.Saturday.MinimumWidth = 6;
            this.Saturday.Name = "Saturday";
            // 
            // Sunday
            // 
            this.Sunday.HeaderText = "Chủ nhật";
            this.Sunday.MinimumWidth = 6;
            this.Sunday.Name = "Sunday";
            // 
            // btnChamCong
            // 
            this.btnChamCong.BackColor = System.Drawing.Color.Transparent;
            this.btnChamCong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChamCong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChamCong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChamCong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChamCong.FillColor = System.Drawing.Color.White;
            this.btnChamCong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChamCong.ForeColor = System.Drawing.Color.White;
            this.btnChamCong.Image = ((System.Drawing.Image)(resources.GetObject("btnChamCong.Image")));
            this.btnChamCong.Location = new System.Drawing.Point(226, 632);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(90, 36);
            this.btnChamCong.TabIndex = 15;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // dtpkStart
            // 
            this.dtpkStart.Checked = true;
            this.dtpkStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpkStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkStart.Location = new System.Drawing.Point(56, 514);
            this.dtpkStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkStart.Name = "dtpkStart";
            this.dtpkStart.Size = new System.Drawing.Size(260, 36);
            this.dtpkStart.TabIndex = 16;
            this.dtpkStart.Value = new System.DateTime(2023, 5, 24, 20, 58, 43, 940);
            // 
            // dtpkEnd
            // 
            this.dtpkEnd.Checked = true;
            this.dtpkEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpkEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkEnd.Location = new System.Drawing.Point(358, 514);
            this.dtpkEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkEnd.Name = "dtpkEnd";
            this.dtpkEnd.Size = new System.Drawing.Size(260, 36);
            this.dtpkEnd.TabIndex = 17;
            this.dtpkEnd.Value = new System.DateTime(2023, 5, 24, 20, 58, 43, 940);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(56, 632);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 36);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            // 
            // tbSumWorkDay
            // 
            this.tbSumWorkDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSumWorkDay.DefaultText = "";
            this.tbSumWorkDay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSumWorkDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSumWorkDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSumWorkDay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSumWorkDay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSumWorkDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSumWorkDay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSumWorkDay.Location = new System.Drawing.Point(56, 574);
            this.tbSumWorkDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSumWorkDay.Name = "tbSumWorkDay";
            this.tbSumWorkDay.PasswordChar = '\0';
            this.tbSumWorkDay.PlaceholderText = "";
            this.tbSumWorkDay.SelectedText = "";
            this.tbSumWorkDay.Size = new System.Drawing.Size(260, 41);
            this.tbSumWorkDay.TabIndex = 19;
            // 
            // tbShiftWork
            // 
            this.tbShiftWork.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbShiftWork.DefaultText = "";
            this.tbShiftWork.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbShiftWork.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbShiftWork.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbShiftWork.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbShiftWork.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbShiftWork.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbShiftWork.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbShiftWork.Location = new System.Drawing.Point(358, 574);
            this.tbShiftWork.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbShiftWork.Name = "tbShiftWork";
            this.tbShiftWork.PasswordChar = '\0';
            this.tbShiftWork.PlaceholderText = "";
            this.tbShiftWork.SelectedText = "";
            this.tbShiftWork.Size = new System.Drawing.Size(260, 41);
            this.tbShiftWork.TabIndex = 20;
            // 
            // FormChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 701);
            this.Controls.Add(this.tbShiftWork);
            this.Controls.Add(this.tbSumWorkDay);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpkEnd);
            this.Controls.Add(this.dtpkStart);
            this.Controls.Add(this.btnChamCong);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sunday;
        private Guna.UI2.WinForms.Guna2Button btnChamCong;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkEnd;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox tbSumWorkDay;
        private Guna.UI2.WinForms.Guna2TextBox tbShiftWork;
    }
}