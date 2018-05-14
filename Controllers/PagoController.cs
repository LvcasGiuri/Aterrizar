using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using WebApplication1.Models;
using System.Data;
using System.Collections;

namespace WebApplication1.Controllers
{
    public class PagoController : Controller
    {
        //
        // GET: /Pago/
        public ActionResult Pago()
        {
            //getPagos();
            return View();
        }

        public Pago create()
        {
            Pago pago = new Pago();
            pago.IdPago = 2;
            pago.IdReserva = 2;
            pago.MetodoPago = "sds";
            return pago;
        }

        public void getPagos()
        {

            DBManager manager = new DBManager();

            using (SqlConnection cn = manager.getConnection())
            {
                ArrayList pagos = new ArrayList();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "StoredProcedureName";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;

                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                Pago pago = new Pago();

                if (dr.Read())
                {

                    foreach (var dataread in dr)
                    {
                        pago.IdPago = dr.GetInt32(0);
                        pago.MetodoPago = dr.GetString(1);
                        pago.IdReserva = dr.GetInt32(2);
                        pagos.Add(pago);
                    }
                }

                cn.Close();

            }
        }


    }
}