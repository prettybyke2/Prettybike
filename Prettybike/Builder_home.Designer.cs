namespace Prettybike
{
    partial class Builder_home
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
            this.btn_piecies = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_Builder = new System.Windows.Forms.Label();
            this.btn_calendar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_piecies
            // 
            this.btn_piecies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_piecies.Location = new System.Drawing.Point(625, 84);
            this.btn_piecies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_piecies.Name = "btn_piecies";
            this.btn_piecies.Size = new System.Drawing.Size(162, 60);
            this.btn_piecies.TabIndex = 9;
            this.btn_piecies.Text = "Show piecies";
            this.btn_piecies.UseVisualStyleBackColor = true;
            this.btn_piecies.Click += new System.EventHandler(this.btn_piecies_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "blue bike",
            "yellow bike",
            "blue bike"});
            this.checkedListBox1.Location = new System.Drawing.Point(190, 84);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(380, 292);
            this.checkedListBox1.TabIndex = 8;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(199, -2);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(409, 81);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "TO DO TODAY";
            // 
            // lbl_Builder
            // 
            this.lbl_Builder.AutoSize = true;
            this.lbl_Builder.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Builder.Location = new System.Drawing.Point(13, 9);
            this.lbl_Builder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Builder.Name = "lbl_Builder";
            this.lbl_Builder.Size = new System.Drawing.Size(110, 41);
            this.lbl_Builder.TabIndex = 6;
            this.lbl_Builder.Text = "Builder";
            this.lbl_Builder.Click += new System.EventHandler(this.lbl_Builder_Click);
            // 
            // btn_calendar
            // 
            this.btn_calendar.Location = new System.Drawing.Point(13, 386);
            this.btn_calendar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_calendar.Name = "btn_calendar";
            this.btn_calendar.Size = new System.Drawing.Size(261, 58);
            this.btn_calendar.TabIndex = 10;
            this.btn_calendar.Text = "SHOW MY CALENDAR";
            this.btn_calendar.UseVisualStyleBackColor = true;
            this.btn_calendar.Click += new System.EventHandler(this.btn_calendar_Click);
            // 
            // Builder_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_calendar);
            this.Controls.Add(this.btn_piecies);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_Builder);
            this.Name = "Builder_home";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_piecies;
        private CheckedListBox checkedListBox1;
        private Label lbl_title;
        private Label lbl_Builder;
        private Button btn_calendar;
    }
}