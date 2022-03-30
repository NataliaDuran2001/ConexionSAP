using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SAPbobsCOM;

namespace ConexionSAP
{
    public static class ConexionSAP
    {
        public static Company mycompany = null;

        public static bool Open()
        {
            try
            {
                bool respuesta = false;

                mycompany = new Company();
                //SBO-SAP-SYN
                //mycompany.Server = "SBO-SAP-SYN";
                mycompany.DbServerType = BoDataServerTypes.dst_MSSQL2016;
                mycompany.Server = "10.10.1.8";
                mycompany.LicenseServer = "10.10.1.8:40000";
                mycompany.UseTrusted = false;
                mycompany.CompanyDB = "PRUEBAS_SYNERGY17";
                mycompany.UserName = "manager";
                mycompany.Password = "syn123..";
                mycompany.language = BoSuppLangs.ln_Spanish_La;

                //Console.WriteLine(mycompany.Connect().ToString());
                int error = mycompany.Connect();

                if (error == 0)
                {
                    respuesta = true;
                    Javascript.Alert("CONEXION EXITOSA A LA BD DE SAP");
                } else
                {
                    Javascript.Alert("ERROR -- " + mycompany.GetLastErrorDescription().ToString());
                    
                }



                return respuesta;

            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}