using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bai10
{
    public partial class Bai10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpPostedFile FileUpload = Request.Files["txtFile"];
            if (FileUpload != null && FileUpload.ContentLength > 0)
            {
                string name = Server.MapPath("App_Data/") + FileUpload.FileName;
                FileUpload.SaveAs(name);
                Response.Write(Request.Form["txtNoidung"]+ name);
                Response.End();
            }
        }
    }
}