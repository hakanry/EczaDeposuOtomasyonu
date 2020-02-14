using System;
using System.Linq;
using System.Data;


namespace İlaçEczaOtomasyonu
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblDurum.Visible = false;
        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            var username = TextBox1.Text;
            var password = TextBox2.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblDurum.Visible = true;
                lblDurum.Text = "LÜTFEN BOŞ BIRAKMAYINIZ..";
                lblDurum.ForeColor = System.Drawing.Color.Red;
                return;
            }
            var LoginState = LoginFonk(username,password);
            if (LoginState == true)
            {
                lblDurum.Visible = true;
                lblDurum.Text = "GİRİŞ BAŞARILI! HOŞGELDİNİZ.";
                lblDurum.ForeColor = System.Drawing.Color.Red;
                Response.Redirect("anasayfa.aspx");
            }
            else
            {
                lblDurum.Visible = true;
                lblDurum.Text = "GİRİŞ BAŞARISIZ! TEKRAR DENEYİNİZ.";
                lblDurum.ForeColor = System.Drawing.Color.Red;
            }
        }
        public bool LoginFonk(string username, string password)
        {
            USERENTITY  kullanıcı = new USERENTITY();
            var user1 = (from x in kullanıcı.user
                        where x.kad == username &&
                              x.ksifre == password
                        select x).FirstOrDefault();
            if(user1 != null)
            {

                return true;
            }

            return false;
        }
    }
}