namespace Prettybike
{
    partial class Manager_Part
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
            this.lbl_finished = new System.Windows.Forms.Label();
            this.lbl_amt_left = new System.Windows.Forms.Label();
            this.btn_newOrder = new System.Windows.Forms.Button();
            this.lbl_order_review = new System.Windows.Forms.Label();
            this.lbl_ordercomfirm = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.dateTP_Manager_To = new System.Windows.Forms.DateTimePicker();
            this.dateTP_Manager_from = new System.Windows.Forms.DateTimePicker();
            this.lbl_ManagerName = new System.Windows.Forms.Label();
            this.txtbox_CurrentOrder = new System.Windows.Forms.TextBox();
            this.txtbox_amount = new System.Windows.Forms.TextBox();
            this.combobox_Builders = new System.Windows.Forms.ComboBox();
            this.btn_validate = new System.Windows.Forms.Button();
            this.lbl_Manager = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_builder = new System.Windows.Forms.Label();
            this.lbl_orders = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_finished
            // 
            this.lbl_finished.AutoSize = true;
            this.lbl_finished.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_finished.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_finished.Location = new System.Drawing.Point(565, 400);
            this.lbl_finished.Name = "lbl_finished";
            this.lbl_finished.Size = new System.Drawing.Size(0, 28);
            this.lbl_finished.TabIndex = 38;
            // 
            // lbl_amt_left
            // 
            this.lbl_amt_left.AutoSize = true;
            this.lbl_amt_left.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_amt_left.Location = new System.Drawing.Point(87, 129);
            this.lbl_amt_left.Name = "lbl_amt_left";
            this.lbl_amt_left.Size = new System.Drawing.Size(0, 25);
            this.lbl_amt_left.TabIndex = 37;
            // 
            // btn_newOrder
            // 
            this.btn_newOrder.Location = new System.Drawing.Point(475, 311);
            this.btn_newOrder.Name = "btn_newOrder";
            this.btn_newOrder.Size = new System.Drawing.Size(112, 34);
            this.btn_newOrder.TabIndex = 36;
            this.btn_newOrder.Text = "New Order";
            this.btn_newOrder.UseVisualStyleBackColor = true;
            // 
            // lbl_order_review
            // 
            this.lbl_order_review.AutoSize = true;
            this.lbl_order_review.Location = new System.Drawing.Point(172, 403);
            this.lbl_order_review.Name = "lbl_order_review";
            this.lbl_order_review.Size = new System.Drawing.Size(0, 25);
            this.lbl_order_review.TabIndex = 35;
            // 
            // lbl_ordercomfirm
            // 
            this.lbl_ordercomfirm.AutoSize = true;
            this.lbl_ordercomfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ordercomfirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_ordercomfirm.Location = new System.Drawing.Point(605, 278);
            this.lbl_ordercomfirm.Name = "lbl_ordercomfirm";
            this.lbl_ordercomfirm.Size = new System.Drawing.Size(0, 32);
            this.lbl_ordercomfirm.TabIndex = 34;
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_To.Location = new System.Drawing.Point(129, 289);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(39, 25);
            this.lbl_To.TabIndex = 33;
            this.lbl_To.Text = "To :";
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_From.Location = new System.Drawing.Point(129, 184);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(63, 25);
            this.lbl_From.TabIndex = 32;
            this.lbl_From.Text = "From :";
            // 
            // dateTP_Manager_To
            // 
            this.dateTP_Manager_To.Location = new System.Drawing.Point(124, 330);
            this.dateTP_Manager_To.Name = "dateTP_Manager_To";
            this.dateTP_Manager_To.Size = new System.Drawing.Size(300, 31);
            this.dateTP_Manager_To.TabIndex = 31;
            // 
            // dateTP_Manager_from
            // 
            this.dateTP_Manager_from.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTP_Manager_from.Location = new System.Drawing.Point(124, 228);
            this.dateTP_Manager_from.Name = "dateTP_Manager_from";
            this.dateTP_Manager_from.Size = new System.Drawing.Size(307, 31);
            this.dateTP_Manager_from.TabIndex = 30;
            // 
            // lbl_ManagerName
            // 
            this.lbl_ManagerName.AutoSize = true;
            this.lbl_ManagerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_ManagerName.Location = new System.Drawing.Point(345, 45);
            this.lbl_ManagerName.Name = "lbl_ManagerName";
            this.lbl_ManagerName.Size = new System.Drawing.Size(0, 32);
            this.lbl_ManagerName.TabIndex = 29;
            // 
            // txtbox_CurrentOrder
            // 
            this.txtbox_CurrentOrder.Location = new System.Drawing.Point(157, 126);
            this.txtbox_CurrentOrder.Name = "txtbox_CurrentOrder";
            this.txtbox_CurrentOrder.Size = new System.Drawing.Size(221, 31);
            this.txtbox_CurrentOrder.TabIndex = 28;
            // 
            // txtbox_amount
            // 
            this.txtbox_amount.Location = new System.Drawing.Point(636, 124);
            this.txtbox_amount.Name = "txtbox_amount";
            this.txtbox_amount.Size = new System.Drawing.Size(77, 31);
            this.txtbox_amount.TabIndex = 27;
            // 
            // combobox_Builders
            // 
            this.combobox_Builders.FormattingEnabled = true;
            this.combobox_Builders.Items.AddRange(new object[] {
            "Louis",
            "Thibaut",
            "Sedric"});
            this.combobox_Builders.Location = new System.Drawing.Point(405, 124);
            this.combobox_Builders.Name = "combobox_Builders";
            this.combobox_Builders.Size = new System.Drawing.Size(182, 33);
            this.combobox_Builders.TabIndex = 26;
            // 
            // btn_validate
            // 
            this.btn_validate.Location = new System.Drawing.Point(475, 251);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(112, 34);
            this.btn_validate.TabIndex = 25;
            this.btn_validate.Text = "Validate";
            this.btn_validate.UseVisualStyleBackColor = true;
            // 
            // lbl_Manager
            // 
            this.lbl_Manager.AutoSize = true;
            this.lbl_Manager.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Manager.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Manager.Location = new System.Drawing.Point(103, 22);
            this.lbl_Manager.Name = "lbl_Manager";
            this.lbl_Manager.Size = new System.Drawing.Size(200, 48);
            this.lbl_Manager.TabIndex = 24;
            this.lbl_Manager.Text = "Manager :";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Amount.Location = new System.Drawing.Point(636, 84);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(77, 25);
            this.lbl_Amount.TabIndex = 23;
            this.lbl_Amount.Text = "Amount";
            // 
            // lbl_builder
            // 
            this.lbl_builder.AutoSize = true;
            this.lbl_builder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_builder.Location = new System.Drawing.Point(440, 84);
            this.lbl_builder.Name = "lbl_builder";
            this.lbl_builder.Size = new System.Drawing.Size(74, 25);
            this.lbl_builder.TabIndex = 22;
            this.lbl_builder.Text = "Builders";
            // 
            // lbl_orders
            // 
            this.lbl_orders.AutoSize = true;
            this.lbl_orders.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_orders.Location = new System.Drawing.Point(172, 84);
            this.lbl_orders.Name = "lbl_orders";
            this.lbl_orders.Size = new System.Drawing.Size(121, 25);
            this.lbl_orders.TabIndex = 21;
            this.lbl_orders.Text = "Current Order";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_finished);
            this.Controls.Add(this.lbl_amt_left);
            this.Controls.Add(this.btn_newOrder);
            this.Controls.Add(this.lbl_order_review);
            this.Controls.Add(this.lbl_ordercomfirm);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.lbl_From);
            this.Controls.Add(this.dateTP_Manager_To);
            this.Controls.Add(this.dateTP_Manager_from);
            this.Controls.Add(this.lbl_ManagerName);
            this.Controls.Add(this.txtbox_CurrentOrder);
            this.Controls.Add(this.txtbox_amount);
            this.Controls.Add(this.combobox_Builders);
            this.Controls.Add(this.btn_validate);
            this.Controls.Add(this.lbl_Manager);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.lbl_builder);
            this.Controls.Add(this.lbl_orders);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_finished;
        public Label lbl_amt_left;
        private Button btn_newOrder;
        private Label lbl_order_review;
        private Label lbl_ordercomfirm;
        private Label lbl_To;
        private Label lbl_From;
        private DateTimePicker dateTP_Manager_To;
        private DateTimePicker dateTP_Manager_from;
        public Label lbl_ManagerName;
        public TextBox txtbox_CurrentOrder;
        private TextBox txtbox_amount;
        private ComboBox combobox_Builders;
        private Button btn_validate;
        private Label lbl_Manager;
        private Label lbl_Amount;
        private Label lbl_builder;
        private Label lbl_orders;
    }
}