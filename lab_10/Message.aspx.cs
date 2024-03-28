using System;

namespace ChatApplication
{
    public partial class Message : System.Web.UI.Page
    {
        protected void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                Application.Lock();
                string username = (string)Session["Username"];
                string messages = Application["Messages"] != null ? Application["Messages"].ToString() : "";
                messages += $"{username}: {message}<br>";
                Application["Messages"] = messages;
                Application.UnLock();
                Response.Redirect("ChatPage.html");
            }
        }
    }
}
