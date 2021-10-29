using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai9
{
    public partial class Xuly2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ten = Request.Form["ten"];
            string hang = Request.Form["hang"];
            string ngay = Request.Form["ngay"];
            string gia = Request.Form["gia"];
            string res = "<baocao>";
            res += "<name>" + ten + "</name><hang>" + hang + "</hang><ngay>" + ngay
                + "</ngay><gia>" + gia + "</gia></baocao>";
            Response.ContentType = "text/xml";
            Response.ContentEncoding = Encoding.UTF8;
            Response.Write(res);
            Response.End();
        }
    }
}