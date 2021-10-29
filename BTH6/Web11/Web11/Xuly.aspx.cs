using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web11
{
    public partial class Xuly : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string hoten=Request.Form["hoten"];
            int namsinh = Convert.ToInt32(Request.Form["namsinh"]);
            Nhanvien ds = new Nhanvien(hoten, namsinh);
            List<Nhanvien> a= (List<Nhanvien>)Session["danhsach"];//
            a.Add(ds);
            Session["danhsach"] = a;
            int k = 1;
            foreach(Nhanvien b in a)
            {
                TableRow i = new TableRow();
                TableCell i1 = new TableCell();
                i1.Text = Convert.ToString( k);
                k++;
                TableCell i2 = new TableCell();
                i2.Text = b.Hoten;
                TableCell i3 = new TableCell();
                i3.Text = Convert.ToString(b.Namsinh);
                i.Cells.Add(i1);
                i.Cells.Add(i2);
                i.Cells.Add(i3);
                Table1.Rows.Add(i);
            }
        }

    }
}