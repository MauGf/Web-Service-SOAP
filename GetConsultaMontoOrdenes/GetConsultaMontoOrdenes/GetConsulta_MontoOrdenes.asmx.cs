using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace GetConsultaMontoOrdenes
{
    /// <summary>
    /// Descripción breve de GetConsulta_MontoOrdenes
    /// </summary>
    [WebService(Namespace = "http://maugarciaapps.tech/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class GetConsulta_MontoOrdenes : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public DataSet GetConsultaMontoOrdenes_()
        {
            //SqlConnection connect = new SqlConnection("Server=localhost;Database=AdventureWorks2014; Trusted_connection=True;");
            SqlConnection connect = new SqlConnection("Data Source=MAUGF; Initial Catalog=AdventureWorks2014; Trusted_connection=True;");//las credenciales de la BD Son las de mi windows 
            connect.Open();
            SqlDataAdapter consulta = new SqlDataAdapter("SELECT top 20 [SalesOrderID], COUNT([SalesOrderDetailID]) AS [# Line Items], STR(SUM([UnitPrice] * [OrderQty])) AS [Monto Total] FROM[Sales].[SalesOrderDetail] GROUP BY SalesOrderID",connect);

           
            DataSet ds = new DataSet();
            consulta.Fill(ds);
            return ds;

        }
    }
}
