using System;

namespace ChatApplication
{
    public partial class Display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Application["Messages"] != null)
                {
                    litMessages.Text = Application["Messages"].ToString();
                }
            }
        }
    }
}
