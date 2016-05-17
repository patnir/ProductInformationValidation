partial class frmMain
{
    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtUPC = new System.Windows.Forms.TextBox();
            this.lblUPC = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtQualityOnHand = new System.Windows.Forms.TextBox();
            this.txtReorderDate = new System.Windows.Forms.TextBox();
            this.txtUOP = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblQualityOnHand = new System.Windows.Forms.Label();
            this.lblReorderDate = new System.Windows.Forms.Label();
            this.lblUOP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(222, 13);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 0;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtUPC
            // 
            this.txtUPC.Location = new System.Drawing.Point(102, 15);
            this.txtUPC.Name = "txtUPC";
            this.txtUPC.Size = new System.Drawing.Size(100, 20);
            this.txtUPC.TabIndex = 1;
            // 
            // lblUPC
            // 
            this.lblUPC.AutoSize = true;
            this.lblUPC.Location = new System.Drawing.Point(12, 18);
            this.lblUPC.Name = "lblUPC";
            this.lblUPC.Size = new System.Drawing.Size(32, 13);
            this.lblUPC.TabIndex = 2;
            this.lblUPC.Text = "UPC:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(222, 43);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(222, 73);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(102, 45);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 5;
            // 
            // txtQualityOnHand
            // 
            this.txtQualityOnHand.Location = new System.Drawing.Point(102, 75);
            this.txtQualityOnHand.Name = "txtQualityOnHand";
            this.txtQualityOnHand.Size = new System.Drawing.Size(100, 20);
            this.txtQualityOnHand.TabIndex = 6;
            // 
            // txtReorderDate
            // 
            this.txtReorderDate.Location = new System.Drawing.Point(102, 104);
            this.txtReorderDate.Name = "txtReorderDate";
            this.txtReorderDate.Size = new System.Drawing.Size(100, 20);
            this.txtReorderDate.TabIndex = 7;
            // 
            // txtUOP
            // 
            this.txtUOP.Location = new System.Drawing.Point(102, 133);
            this.txtUOP.Name = "txtUOP";
            this.txtUOP.Size = new System.Drawing.Size(100, 20);
            this.txtUOP.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 48);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description:";
            // 
            // lblQualityOnHand
            // 
            this.lblQualityOnHand.AutoSize = true;
            this.lblQualityOnHand.Location = new System.Drawing.Point(12, 78);
            this.lblQualityOnHand.Name = "lblQualityOnHand";
            this.lblQualityOnHand.Size = new System.Drawing.Size(86, 13);
            this.lblQualityOnHand.TabIndex = 10;
            this.lblQualityOnHand.Text = "Quality on Hand:";
            // 
            // lblReorderDate
            // 
            this.lblReorderDate.AutoSize = true;
            this.lblReorderDate.Location = new System.Drawing.Point(12, 107);
            this.lblReorderDate.Name = "lblReorderDate";
            this.lblReorderDate.Size = new System.Drawing.Size(74, 13);
            this.lblReorderDate.TabIndex = 11;
            this.lblReorderDate.Text = "Reorder Date:";
            // 
            // lblUOP
            // 
            this.lblUOP.AutoSize = true;
            this.lblUOP.Location = new System.Drawing.Point(12, 136);
            this.lblUOP.Name = "lblUOP";
            this.lblUOP.Size = new System.Drawing.Size(33, 13);
            this.lblUOP.TabIndex = 12;
            this.lblUOP.Text = "UOP:";
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(309, 182);
            this.Controls.Add(this.lblUOP);
            this.Controls.Add(this.lblReorderDate);
            this.Controls.Add(this.lblQualityOnHand);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtUOP);
            this.Controls.Add(this.txtReorderDate);
            this.Controls.Add(this.txtQualityOnHand);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblUPC);
            this.Controls.Add(this.txtUPC);
            this.Controls.Add(this.btnValidate);
            this.Name = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    #endregion

    private System.Windows.Forms.Button btnValidate;
    private System.Windows.Forms.TextBox txtUPC;
    private System.Windows.Forms.Label lblUPC;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.TextBox txtDescription;
    private System.Windows.Forms.TextBox txtQualityOnHand;
    private System.Windows.Forms.TextBox txtReorderDate;
    private System.Windows.Forms.TextBox txtUOP;
    private System.Windows.Forms.Label lblDescription;
    private System.Windows.Forms.Label lblQualityOnHand;
    private System.Windows.Forms.Label lblReorderDate;
    private System.Windows.Forms.Label lblUOP;
}