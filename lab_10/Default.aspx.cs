using System;

namespace ChatApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            if (!string.IsNullOrEmpty(username))
            {
                Session["Username"] = username;
                Response.Redirect("ChatPage.html");
            }
        }
    }
}

