using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calc_FL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Operacion _operacion;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            _operacion = new Operacion();
            if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                lbl1.Text = "Ingrese todos los números";
                lbl1.Visible = true;
                lbl1.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
            //    _operacion = new Operacion();
                _operacion.a = Convert.ToDouble(TextBox1.Text);
                Session["a"] = TextBox1.Text;
                _operacion.b = Convert.ToDouble(TextBox2.Text);
                Session["b"] = TextBox2.Text;
                Resul_txt.Text = Convert.ToString(_operacion.suma());
                Session["suma"] = Resul_txt.Text;
                TextBox1.Text = "";
                TextBox2.Text = "";
                
            }
    }
        protected void Button2_Click(object sender, EventArgs e)
        {
            _operacion = new Operacion();
            if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                lbl1.Text = "Ingrese todos los números";
                lbl1.Visible = true;
                lbl1.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
              //  _operacion = new Operacion();
                _operacion.a = Convert.ToDouble(TextBox1.Text);
                Session["a"] = TextBox1.Text;
                _operacion.b = Convert.ToDouble(TextBox2.Text);
                Session["b"] = TextBox2.Text;
                Resul_txt.Text = Convert.ToString(_operacion.resta());
                Session["resta"] = Resul_txt.Text;
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            _operacion = new Operacion();
            if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                lbl1.Text = "Ingrese todos los números";
                lbl1.Visible = true;
                lbl1.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                // _operacion = new Operacion();
                _operacion.a = Convert.ToDouble(TextBox1.Text);
                Session["a"] = TextBox1.Text;
                _operacion.b = Convert.ToDouble(TextBox2.Text);
                Session["b"] = TextBox2.Text;
                Resul_txt.Text = Convert.ToString(_operacion.multiplicacion());
                Session["multiplicacion"] = Resul_txt.Text;
                TextBox1.Text = "";
                TextBox2.Text = "";
                
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            _operacion = new Operacion();
            if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                lbl1.Text = "Ingrese todos los números";
                lbl1.Visible = true;
                lbl1.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
             //   _operacion = new Operacion();
                _operacion.a = Convert.ToDouble(TextBox1.Text);
                Session["a"] = TextBox1.Text;
                _operacion.b = Convert.ToDouble(TextBox2.Text);
                Session["b"] = TextBox1.Text;
                Resul_txt.Text = Convert.ToString(_operacion.division());
                Session["division"] = Resul_txt.Text;
                TextBox1.Text = "";
                TextBox2.Text = "";
                if (Resul_txt.Text == "∞")
                {
                    Resul_txt.Text = "no se puede dividir por cero";
                }
            }
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("logResultados.aspx");
        }
    }
}