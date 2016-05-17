using System;
using System.Windows.Forms;

public partial class frmMain : Form
{
    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    public frmMain()
    {
        InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtDescription.Text = "";
        txtQualityOnHand.Text = "";
        txtReorderDate.Text = "";
        txtUOP.Text = "";
        txtUPC.Text = "";
    }

    private void btnValidate_Click(object sender, EventArgs e)
    {
        const string upcErrorMessage = "UPC must be in the format mmmppp-c";
        const string descriptionErrorMessage = "Description must be entered.";
        const string qualityOnHandErrorMessage = "Quality on hand must be a non-numeric integer.";
        const string reorderDateFormatEM = "Enter valid date format.";
        const string reorderDateLengthEM = "If quality on hand is positive, do not enter reorderDate";
        const string reorderDateErrorMessage = "The date must include today's or a future date if the quality on hand is zero.";
        const string uopErrorMessage = "UOP must be one of the following codes: BG (bag), BX (box), CT (carton), LB (pound), GR (gross), RM (Ream) or SP (spool).";

        const string validMessage = "Input data is valid";

        string description;
        int qualityOnHand;
        DateTime reorderDate;
        string uop;
        string upc;

        bool didConvert;

        // Validate UPC
        upc = txtUPC.Text.Trim();

        if (validateUPC(upc) == false)
        {
            MessageBox.Show(upcErrorMessage);
            txtUPC.Focus();
            return;
        }

        // Validate Description
        description = txtDescription.Text.Trim();
        if (description.Length == 0)
        {
            MessageBox.Show(descriptionErrorMessage);
            txtDescription.Focus();
            return;
        }

        // Validate Quality on Hand
        didConvert = int.TryParse(txtQualityOnHand.Text, out qualityOnHand);

        if (didConvert == false || qualityOnHand < 0)
        {
            MessageBox.Show(qualityOnHandErrorMessage);
            txtQualityOnHand.Focus();
            return;
        }
        if (qualityOnHand > 0)
        {
            int check = txtReorderDate.Text.Trim().Length;
            if (check != 0)
            {
                MessageBox.Show(reorderDateLengthEM);
                txtReorderDate.Focus();
                return;
            }
        }
        else
        {
            // Validate Reorder date
            didConvert = DateTime.TryParse(txtReorderDate.Text, out reorderDate);
            if (didConvert == false)
            {
                MessageBox.Show(reorderDateFormatEM);
                txtReorderDate.Focus();
                return;
            }
            if (reorderDate < DateTime.Now.Date)
            {
                MessageBox.Show(reorderDateErrorMessage);
                txtReorderDate.Focus();
                return;
            }
        }
       
        // UOP
        uop = txtUOP.Text.Trim();

        if (!(uop.Equals("BG") || uop.Equals("BX") || uop.Equals("CT") || 
              uop.Equals("LB") || uop.Equals("GR") || uop.Equals("RM") ||
              uop.Equals("SP")))
        {
            MessageBox.Show(uopErrorMessage);
            txtUOP.Focus();
            return;
        }

        MessageBox.Show(validMessage);
    }

    public static bool validateUPC(String upc)
    {
        if (upc.Length != 8)
        {
            return false;
        } 
        else if (!upc.Substring(6, 1).Equals("-")) 
        {
            return false;
        }
        string mmm = upc.Substring(0, 3);
        string ppp = upc.Substring(3, 3);
        string c = upc.Substring(7, 1);
        if (mmm.Equals("456")) 
        {
            if (!(c.Equals(ppp.Substring(0, 1)))) {
                return false;
            }
        }
        else if (mmm.Equals("789")) 
        {
            if (!(c.Equals(ppp.Substring(1, 1)))) {
                return false;
            }
        }
        else if (mmm.Equals("123")) 
        {
            if (!(c.Equals("0") || c.Equals("5") || c.Equals("9"))) {
                return false;
            }
        }
        else 
        {
            return false;
        }   
        return true;
    }
}