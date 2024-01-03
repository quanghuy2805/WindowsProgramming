using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson8_Exericse2
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            WebService webService = new WebService();
            int A = 6;
            int B = 7;
            Label1.Text = "Output of WebService: " + webService.Add(A, B).ToString();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            WebService webService = new WebService();
            int A = 6;
            int B = 7;
            Label2.Text = "Output of WebService: " + webService.Subtract(A, B).ToString();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            WebService webService = new WebService();
            int A = 6;
            int B = 7;
            Label3.Text = "Output of WebService: " + webService.Multiply(A, B).ToString();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            WebService webService = new WebService();
            int A = 6;
            int B = 7;
            Label4.Text = "Output of WebService: " + webService.Divide(A, B).ToString();
        }
    }
        
}