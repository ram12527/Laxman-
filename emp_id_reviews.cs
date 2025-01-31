using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm1 : System.Web.UI.Page
{
    private string connString = "database=hosptial;server=DESKTOP-525TI26\\SQLEXPRESS02;Integrated Security=True";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGrid();
        }
    }

    private void BindGrid()
    {
        using (SqlConnection conn = new SqlConnection(connString))
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM hosptaldetails", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            griddata.DataSource = dt;
            griddata.DataBind();
        }
    }

    protected void AddNewRecord(object sender, EventArgs e)
    {
        string hospitalName = txtHospitalName.Text;
        string location = txtLocation.Text;

        try
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "INSERT INTO hosptaldetails (HospitalName, Location) VALUES (@HospitalName, @Location)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@HospitalName", SqlDbType.NVarChar, 100)).Value = hospitalName;
                cmd.Parameters.Add(new SqlParameter("@Location", SqlDbType.NVarChar, 100)).Value = location;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            BindGrid();
            ClearInputs();
        }
        catch (Exception ex)
        {
            // Handle error, log it, or show a message to the user.
            Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
        }
    }

    protected void UpdateRecord(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "EditRecord")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = griddata.Rows[index];
            string hospitalId = griddata.DataKeys[index].Value.ToString();

            txtHospitalName.Text = row.Cells[1].Text;
            txtLocation.Text = row.Cells[2].Text;

            btnSave.Visible = false;
            btnUpdate.Visible = true;
            btnUpdate.CommandArgument = hospitalId;
        }
    }

    protected void UpdateRecordConfirmed(object sender, EventArgs e)
    {
        string hospitalId = btnUpdate.CommandArgument.ToString();
        string hospitalName = txtHospitalName.Text;
        string location = txtLocation.Text;

        try
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "UPDATE hosptaldetails SET HospitalName = @HospitalName, Location = @Location WHERE HospitalId = @HospitalId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@HospitalName", SqlDbType.NVarChar, 100)).Value = hospitalName;
                cmd.Parameters.Add(new SqlParameter("@Location", SqlDbType.NVarChar, 100)).Value = location;
                cmd.Parameters.Add(new SqlParameter("@HospitalId", SqlDbType.Int)).Value = hospitalId;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            BindGrid();
            ClearInputs();
            btnSave.Visible = true;
            btnUpdate.Visible = false;
        }
        catch (Exception ex)
        {
            // Handle error
            Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
        }
    }

    protected void DeleteRecord(object sender, GridViewDeleteEventArgs e)
    {
        int hospitalId = Convert.ToInt32(griddata.DataKeys[e.RowIndex].Value);

        try
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "DELETE FROM hosptaldetails WHERE HospitalId = @HospitalId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@HospitalId", SqlDbType.Int)).Value = hospitalId;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            BindGrid();
            ClearInputs();
        }
        catch (Exception ex)
        {
            // Handle error
            Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
        }
    }

    private void ClearInputs()
    {
        txtHospitalName.Text = "";
        txtLocation.Text = "";
    }
}