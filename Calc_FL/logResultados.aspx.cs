using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calc_FL
{
    public partial class logResultados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Resultado suma: " +  Convert.ToString(Session["suma"]);
            Label2.Text = "Resultado resta: " + Convert.ToString(Session["resta"]);
            Label4.Text = "Resultado multiplicación: " + Convert.ToString(Session["multiplicacion"]);
            Label5.Text = "Resultado divisipon: " + Convert.ToString(Session["division"]);
        }
    }
}