using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai9
{
    public partial class Xuly : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string ten = Request.QueryString["ten"];
            string hang = Request.QueryString["hang"];
            string ngay = Request.QueryString["ngay"];
            string gia = Request.QueryString["gia"];
            string res = "<baocao>";
            res += "<name>" + ten + "</name><hang>" + hang + "</hang><ngay>" + ngay
                + "</ngay><gia>" + gia + "</gia></baocao>";
            Response.ContentType = "text/xml";
            Response.ContentEncoding = Encoding.UTF8;//quy định bảng  mã là UTF-8
            Response.Write(res);
            Response.End();
        }
    }
}