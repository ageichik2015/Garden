namespace Garden
{
    partial class ChildEdirForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label childDateBirthLabel;
            System.Windows.Forms.Label childNameLabel;
            System.Windows.Forms.Label childSecondNameLabel;
            System.Windows.Forms.Label childAgeLabel;
            System.Windows.Forms.Label groupIDLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.childDateBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.childInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.childNameTextBox = new System.Windows.Forms.TextBox();
            this.childSecondNameTextBox = new System.Windows.Forms.TextBox();
            this.childAgeTextBox = new System.Windows.Forms.TextBox();
            this.GrouplistbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupIDComboBox = new System.Windows.Forms.ComboBox();
            childDateBirthLabel = new System.Windows.Forms.Label();
            childNameLabel = new System.Windows.Forms.Label();
            childSecondNameLabel = new System.Windows.Forms.Label();
            childAgeLabel = new System.Windows.Forms.Label();
            groupIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.childInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrouplistbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // childDateBirthLabel
            // 
            childDateBirthLabel.AutoSize = true;
            childDateBirthLabel.Location = new System.Drawing.Point(264, 119);
            childDateBirthLabel.Name = "childDateBirthLabel";
            childDateBirthLabel.Size = new System.Drawing.Size(104, 13);
            childDateBirthLabel.TabIndex = 4;
            childDateBirthLabel.Text = "День регистрации:";
            // 
            // childNameLabel
            // 
            childNameLabel.AutoSize = true;
            childNameLabel.Location = new System.Drawing.Point(264, 48);
            childNameLabel.Name = "childNameLabel";
            childNameLabel.Size = new System.Drawing.Size(77, 13);
            childNameLabel.TabIndex = 5;
            childNameLabel.Text = "Имя ребенка:";
            // 
            // childSecondNameLabel
            // 
            childSecondNameLabel.AutoSize = true;
            childSecondNameLabel.Location = new System.Drawing.Point(264, 84);
            childSecondNameLabel.Name = "childSecondNameLabel";
            childSecondNameLabel.Size = new System.Drawing.Size(104, 13);
            childSecondNameLabel.TabIndex = 6;
            childSecondNameLabel.Text = "Фамилия ребенка:";
            // 
            // childAgeLabel
            // 
            childAgeLabel.AutoSize = true;
            childAgeLabel.Location = new System.Drawing.Point(264, 156);
            childAgeLabel.Name = "childAgeLabel";
            childAgeLabel.Size = new System.Drawing.Size(52, 13);
            childAgeLabel.TabIndex = 8;
            childAgeLabel.Text = "Возраст:";
            // 
            // groupIDLabel
            // 
            groupIDLabel.AutoSize = true;
            groupIDLabel.Location = new System.Drawing.Point(264, 193);
            groupIDLabel.Name = "groupIDLabel";
            groupIDLabel.Size = new System.Drawing.Size(45, 13);
            groupIDLabel.TabIndex = 10;
            groupIDLabel.Text = "Группа:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(261, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // childDateBirthDateTimePicker
            // 
            this.childDateBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.childInfoBindingSource, "ChildDateBirth", true));
            this.childDateBirthDateTimePicker.Location = new System.Drawing.Point(374, 116);
            this.childDateBirthDateTimePicker.Name = "childDateBirthDateTimePicker";
            this.childDateBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.childDateBirthDateTimePicker.TabIndex = 5;
            // 
            // childInfoBindingSource
            // 
            this.childInfoBindingSource.DataSource = typeof(GardenLibrary.ChildInfo);
            // 
            // childNameTextBox
            // 
            this.childNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.childInfoBindingSource, "ChildName", true));
            this.childNameTextBox.Location = new System.Drawing.Point(373, 45);
            this.childNameTextBox.Name = "childNameTextBox";
            this.childNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.childNameTextBox.TabIndex = 6;
            // 
            // childSecondNameTextBox
            // 
            this.childSecondNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.childInfoBindingSource, "ChildSecondName", true));
            this.childSecondNameTextBox.Location = new System.Drawing.Point(374, 81);
            this.childSecondNameTextBox.Name = "childSecondNameTextBox";
            this.childSecondNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.childSecondNameTextBox.TabIndex = 7;
            // 
            // childAgeTextBox
            // 
            this.childAgeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.childInfoBindingSource, "ChildAge", true));
            this.childAgeTextBox.Location = new System.Drawing.Point(375, 153);
            this.childAgeTextBox.Name = "childAgeTextBox";
            this.childAgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.childAgeTextBox.TabIndex = 9;
            // 
            // GrouplistbindingSource
            // 
            this.GrouplistbindingSource.DataSource = typeof(GardenLibrary.ChildList);
            // 
            // groupIDComboBox
            // 
            this.groupIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.childInfoBindingSource, "GroupID", true));
            this.groupIDComboBox.DataSource = this.GrouplistbindingSource;
            this.groupIDComboBox.DisplayMember = "GroupNamber";
            this.groupIDComboBox.FormattingEnabled = true;
            this.groupIDComboBox.Location = new System.Drawing.Point(375, 190);
            this.groupIDComboBox.Name = "groupIDComboBox";
            this.groupIDComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.groupIDComboBox.TabIndex = 11;
            this.groupIDComboBox.ValueMember = "GroupNamber";
            // 
            // ChildEdirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(groupIDLabel);
            this.Controls.Add(this.groupIDComboBox);
            this.Controls.Add(childAgeLabel);
            this.Controls.Add(this.childAgeTextBox);
            this.Controls.Add(childSecondNameLabel);
            this.Controls.Add(this.childSecondNameTextBox);
            this.Controls.Add(childNameLabel);
            this.Controls.Add(this.childNameTextBox);
            this.Controls.Add(childDateBirthLabel);
            this.Controls.Add(this.childDateBirthDateTimePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ChildEdirForm";
            this.Text = "Добавление ребенка";
            this.Load += new System.EventHandler(this.ChildEdirForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.childInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrouplistbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource childInfoBindingSource;
        private System.Windows.Forms.DateTimePicker childDateBirthDateTimePicker;
        private System.Windows.Forms.TextBox childNameTextBox;
        private System.Windows.Forms.TextBox childSecondNameTextBox;
        private System.Windows.Forms.TextBox childAgeTextBox;
        private System.Windows.Forms.BindingSource GrouplistbindingSource;
        private System.Windows.Forms.ComboBox groupIDComboBox;
    }
}