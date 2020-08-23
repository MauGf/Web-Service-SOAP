using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProbarWebService
{
    public partial class WebFormMontoTotalOrdes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.GetConsulta_MontoOrdenesSoapClient connectService = new ServiceReference1.GetConsulta_MontoOrdenesSoapClient();
            DataSet ds = connectService.GetConsultaMontoOrdenes_();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }
    }
}