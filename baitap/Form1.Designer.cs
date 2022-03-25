
namespace baitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.listViewInfo = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.haveA2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radioGender = new DevExpress.XtraEditors.RadioGroup();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkboxA2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ComboboxLop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtboxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.birthdayPicker = new baitap.DateTimePickerK();
            this.panelInput = new System.Windows.Forms.Panel();
            this.btnDeleteInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radioGender.Properties)).BeginInit();
            this.panelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên";
            // 
            // listViewInfo
            // 
            this.listViewInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.birthday,
            this.gender,
            this.classname,
            this.haveA2});
            this.listViewInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewInfo.FullRowSelect = true;
            this.listViewInfo.GridLines = true;
            this.listViewInfo.HideSelection = false;
            this.listViewInfo.Location = new System.Drawing.Point(453, 27);
            this.listViewInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewInfo.Name = "listViewInfo";
            this.listViewInfo.Size = new System.Drawing.Size(607, 396);
            this.listViewInfo.TabIndex = 9;
            this.listViewInfo.UseCompatibleStateImageBehavior = false;
            this.listViewInfo.View = System.Windows.Forms.View.Details;
            this.listViewInfo.SelectedIndexChanged += new System.EventHandler(this.listViewInfo_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "Họ và tên";
            this.name.Width = 100;
            // 
            // birthday
            // 
            this.birthday.Text = "Ngày sinh";
            this.birthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.birthday.Width = 100;
            // 
            // gender
            // 
            this.gender.Text = "Giới tính";
            this.gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gender.Width = 80;
            // 
            // classname
            // 
            this.classname.Text = "Lớp";
            this.classname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.classname.Width = 100;
            // 
            // haveA2
            // 
            this.haveA2.Text = "Đã có A2";
            this.haveA2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.haveA2.Width = 80;
            // 
            // radioGender
            // 
            this.radioGender.Location = new System.Drawing.Point(127, 146);
            this.radioGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioGender.Name = "radioGender";
            this.radioGender.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGender.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.radioGender.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGender.Properties.Appearance.Options.UseBackColor = true;
            this.radioGender.Properties.Appearance.Options.UseBorderColor = true;
            this.radioGender.Properties.Appearance.Options.UseFont = true;
            this.radioGender.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGender.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Nam", "Nam", true, null, "nam"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Nữ", "Nữ", true, null, "nu")});
            this.radioGender.Size = new System.Drawing.Size(239, 34);
            this.radioGender.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đã có A2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lớp";
            // 
            // checkboxA2
            // 
            this.checkboxA2.AutoSize = true;
            this.checkboxA2.BackColor = System.Drawing.Color.White;
            this.checkboxA2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkboxA2.CheckedState.BorderRadius = 2;
            this.checkboxA2.CheckedState.BorderThickness = 0;
            this.checkboxA2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkboxA2.ForeColor = System.Drawing.Color.White;
            this.checkboxA2.Location = new System.Drawing.Point(127, 255);
            this.checkboxA2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkboxA2.Name = "checkboxA2";
            this.checkboxA2.Size = new System.Drawing.Size(18, 17);
            this.checkboxA2.TabIndex = 6;
            this.checkboxA2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkboxA2.UncheckedState.BorderRadius = 2;
            this.checkboxA2.UncheckedState.BorderThickness = 0;
            this.checkboxA2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkboxA2.UseVisualStyleBackColor = false;
            // 
            // ComboboxLop
            // 
            this.ComboboxLop.BackColor = System.Drawing.Color.Transparent;
            this.ComboboxLop.BorderRadius = 6;
            this.ComboboxLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboboxLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboboxLop.FocusedColor = System.Drawing.Color.Empty;
            this.ComboboxLop.FocusedState.Parent = this.ComboboxLop;
            this.ComboboxLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboboxLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboboxLop.FormattingEnabled = true;
            this.ComboboxLop.HoverState.Parent = this.ComboboxLop;
            this.ComboboxLop.ItemHeight = 30;
            this.ComboboxLop.Items.AddRange(new object[] {
            "CNTT1",
            "CNTT2",
            "Bảo đảm ATTT",
            "An Ninh HTTT",
            "Phân tích dữ liệu",
            "Công trình",
            "Pháo tàu",
            "Đạn",
            "Vũ khí"});
            this.ComboboxLop.ItemsAppearance.Parent = this.ComboboxLop;
            this.ComboboxLop.Location = new System.Drawing.Point(126, 197);
            this.ComboboxLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboboxLop.Name = "ComboboxLop";
            this.ComboboxLop.ShadowDecoration.Parent = this.ComboboxLop;
            this.ComboboxLop.Size = new System.Drawing.Size(239, 36);
            this.ComboboxLop.TabIndex = 5;
            // 
            // txtboxName
            // 
            this.txtboxName.BorderRadius = 6;
            this.txtboxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxName.DefaultText = "";
            this.txtboxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxName.DisabledState.Parent = this.txtboxName;
            this.txtboxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxName.FocusedState.Parent = this.txtboxName;
            this.txtboxName.ForeColor = System.Drawing.Color.Black;
            this.txtboxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxName.HoverState.Parent = this.txtboxName;
            this.txtboxName.Location = new System.Drawing.Point(127, 11);
            this.txtboxName.Margin = new System.Windows.Forms.Padding(5);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.PasswordChar = '\0';
            this.txtboxName.PlaceholderText = "";
            this.txtboxName.SelectedText = "";
            this.txtboxName.ShadowDecoration.Parent = this.txtboxName;
            this.txtboxName.Size = new System.Drawing.Size(239, 44);
            this.txtboxName.TabIndex = 0;
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.birthdayPicker.BorderRadius = 6;
            this.birthdayPicker.BorderSize = 0;
            this.birthdayPicker.CustomFormat = "dd/MM/yyyy";
            this.birthdayPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.birthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdayPicker.Location = new System.Drawing.Point(127, 77);
            this.birthdayPicker.Margin = new System.Windows.Forms.Padding(4);
            this.birthdayPicker.MinimumSize = new System.Drawing.Size(4, 36);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(237, 36);
            this.birthdayPicker.SkinColor = System.Drawing.Color.Transparent;
            this.birthdayPicker.TabIndex = 1;
            this.birthdayPicker.TextColor = System.Drawing.Color.Black;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.ComboboxLop);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Controls.Add(this.radioGender);
            this.panelInput.Controls.Add(this.birthdayPicker);
            this.panelInput.Controls.Add(this.txtboxName);
            this.panelInput.Controls.Add(this.label6);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.checkboxA2);
            this.panelInput.Controls.Add(this.label7);
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Location = new System.Drawing.Point(18, 98);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(407, 298);
            this.panelInput.TabIndex = 12;
            // 
            // btnDeleteInfo
            // 
            this.btnDeleteInfo.BorderRadius = 16;
            this.btnDeleteInfo.CheckedState.Parent = this.btnDeleteInfo;
            this.btnDeleteInfo.CustomImages.Parent = this.btnDeleteInfo;
            this.btnDeleteInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeleteInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInfo.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInfo.HoverState.Parent = this.btnDeleteInfo;
            this.btnDeleteInfo.Image = global::baitap.Properties.Resources.icons8_Delete_30px;
            this.btnDeleteInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteInfo.Location = new System.Drawing.Point(772, 454);
            this.btnDeleteInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteInfo.Name = "btnDeleteInfo";
            this.btnDeleteInfo.ShadowDecoration.Parent = this.btnDeleteInfo;
            this.btnDeleteInfo.Size = new System.Drawing.Size(239, 46);
            this.btnDeleteInfo.TabIndex = 11;
            this.btnDeleteInfo.Text = "Xóa dòng thông tin";
            this.btnDeleteInfo.Click += new System.EventHandler(this.btnDeleteInfo_Click);
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.BorderRadius = 16;
            this.btnEditInfo.CheckedState.Parent = this.btnEditInfo;
            this.btnEditInfo.CustomImages.Parent = this.btnEditInfo;
            this.btnEditInfo.FillColor = System.Drawing.Color.Orange;
            this.btnEditInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditInfo.ForeColor = System.Drawing.Color.White;
            this.btnEditInfo.HoverState.Parent = this.btnEditInfo;
            this.btnEditInfo.Image = global::baitap.Properties.Resources.icons8_edit_property_26px;
            this.btnEditInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditInfo.Location = new System.Drawing.Point(453, 454);
            this.btnEditInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.ShadowDecoration.Parent = this.btnEditInfo;
            this.btnEditInfo.Size = new System.Drawing.Size(240, 46);
            this.btnEditInfo.TabIndex = 10;
            this.btnEditInfo.Text = "Sửa thông tin";
            this.btnEditInfo.Click += new System.EventHandler(this.btnEditInfo_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BorderRadius = 16;
            this.btnSubmit.CheckedState.Parent = this.btnSubmit;
            this.btnSubmit.CustomImages.Parent = this.btnSubmit;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.Parent = this.btnSubmit;
            this.btnSubmit.Image = global::baitap.Properties.Resources.icons8_add_30px;
            this.btnSubmit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSubmit.Location = new System.Drawing.Point(137, 454);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(239, 46);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Thêm thông tin";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(473, 40);
            this.label3.TabIndex = 13;
            this.label3.Text = "HỆ THỐNG QUẢN LÝ SINH VIÊN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 574);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.btnDeleteInfo);
            this.Controls.Add(this.btnEditInfo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.listViewInfo);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "QUẢN LÝ SINH VIÊN - CTK";
            ((System.ComponentModel.ISupportInitialize)(this.radioGender.Properties)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewInfo;
        private DevExpress.XtraEditors.RadioGroup radioGender;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader birthday;
        private System.Windows.Forms.ColumnHeader gender;
        private System.Windows.Forms.ColumnHeader classname;
        private System.Windows.Forms.ColumnHeader haveA2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CheckBox checkboxA2;
        private Guna.UI2.WinForms.Guna2ComboBox ComboboxLop;
        private Guna.UI2.WinForms.Guna2TextBox txtboxName;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private DateTimePickerK birthdayPicker;
        private Guna.UI2.WinForms.Guna2Button btnEditInfo;
        private Guna.UI2.WinForms.Guna2Button btnDeleteInfo;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label label3;
    }
}

