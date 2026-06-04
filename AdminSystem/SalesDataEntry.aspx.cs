using System;
using ClassLibrary;

public partial class SalesDataEntry : System.Web.UI.Page
{
    Int32 SaleID;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["SaleID"] != null)
        {
            SaleID = Convert.ToInt32(Session["SaleID"]);
        }
        else
        {
            SaleID = -1;
        }

        if (IsPostBack == false)
        {
            DisplayUnusedOrderIDs();

            if (SaleID != -1)
            {
                DisplaySale();
            }
        }
    }

    void DisplayUnusedOrderIDs()
    {
        clsDataConnection DB = new clsDataConnection();

        DB.Execute("sproc_tblOrders_SelectUnusedOrderIDs");

        ddlOrderID.DataSource = DB.DataTable;
        ddlOrderID.DataValueField = "OrderID";
        ddlOrderID.DataTextField = "OrderID";
        ddlOrderID.DataBind();
    }

    void DisplaySale()
    {
        clsSalesCollection AllSales = new clsSalesCollection();

        AllSales.ThisSale.Find(SaleID);

        txtSaleID.Text = AllSales.ThisSale.SaleID.ToString();

        ddlOrderID.Items.Insert(0, AllSales.ThisSale.OrderID.ToString());
        ddlOrderID.SelectedValue = AllSales.ThisSale.OrderID.ToString();

        txtSaleDate.Text = AllSales.ThisSale.SaleDate.ToShortDateString();
        txtTotalAmount.Text = AllSales.ThisSale.TotalAmount.ToString();
        txtPaymentMethod.Text = AllSales.ThisSale.PaymentMethod;
        txtSaleStatus.Text = AllSales.ThisSale.SaleStatus;
        chkIsRefunded.Checked = AllSales.ThisSale.IsRefunded;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsSales ASale = new clsSales();

        string SaleIDText = txtSaleID.Text;
        string OrderID = ddlOrderID.SelectedValue;
        string SaleDate = txtSaleDate.Text;
        string TotalAmount = txtTotalAmount.Text;
        string PaymentMethod = txtPaymentMethod.Text;
        string SaleStatus = txtSaleStatus.Text;
        string IsRefunded = chkIsRefunded.Checked.ToString();

        if (SaleID == -1)
        {
            SaleIDText = "0";
        }

        string Error = "";

        Error = ASale.Valid(SaleIDText, OrderID, SaleDate, TotalAmount, PaymentMethod, SaleStatus, IsRefunded);

        if (Error == "")
        {
            ASale.OrderID = Convert.ToInt32(OrderID);
            ASale.SaleDate = Convert.ToDateTime(SaleDate);
            ASale.TotalAmount = Convert.ToDecimal(TotalAmount);
            ASale.PaymentMethod = PaymentMethod;
            ASale.SaleStatus = SaleStatus;
            ASale.IsRefunded = chkIsRefunded.Checked;

            clsSalesCollection SalesList = new clsSalesCollection();

            if (SaleID == -1)
            {
                SalesList.ThisSale = ASale;

                Int32 NewSaleID = SalesList.Add();

                Session["SaleID"] = NewSaleID;
            }
            else
            {
                ASale.SaleID = SaleID;

                SalesList.ThisSale = ASale;

                SalesList.Update();

                Session["SaleID"] = SaleID;
            }

            Response.Redirect("SalesViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("SalesList.aspx");
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}