using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using CZS_Admin_Library.Models;
using Dapper;

namespace CZS_Admin_Library.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        const string MasterString =
            "Server=czsystems.database.windows.net;Database=czsystems_master;User ID=czsystems_admin2;Password=qD8Fd7^!k%C^*@T;";

        public bool Cliente_Create(ClienteModel model)
        {
            DefaultTypeMap.MatchNamesWithUnderscores = true;
            using (IDbConnection connection = new SqlConnection(MasterString))
            {
                try
                {
                    var p = new DynamicParameters();
                    p.Add("@Empresa", model.Empresa);
                    p.Add("@Contacto", model.Contacto);
                    p.Add("@Teléfono", model.Teléfono);
                    p.Add("@Correo", model.Correo);
                    p.Add("@Precio", model.Precio);
                    p.Add("@UltPago", model.UltPago);
                    p.Add("@SigPago", model.SigPago);
                    p.Add("@Habilitado", model.Habilitado);

                    connection.Execute("dbo.spLicencias_Insert", p, commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return false;
                }

                return true;
            }
        }

        public List<ClienteModel> Cliente_GetAll()
        {
            DefaultTypeMap.MatchNamesWithUnderscores = true;
            using (IDbConnection connection = new SqlConnection(MasterString))
            {
                try
                {
                    var output = connection.Query<ClienteModel>("dbo.spLicencias_GetAll").ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return null;
                }
            }
        }

        public bool Cliente_Update(ClienteModel model)
        {
            DefaultTypeMap.MatchNamesWithUnderscores = true;
            using (IDbConnection connection = new SqlConnection(MasterString))
            {
                try
                {
                    var p = new DynamicParameters();
                    p.Add("@Empresa", model.Empresa);
                    p.Add("@Contacto", model.Contacto);
                    p.Add("@Teléfono", model.Teléfono);
                    p.Add("@Correo", model.Correo);
                    p.Add("@Precio", model.Precio);
                    p.Add("@UltPago", model.UltPago);
                    p.Add("@SigPago", model.SigPago);
                    p.Add("@Habilitado", model.Habilitado);
                    p.Add("@id", model.Id);

                    connection.Execute("dbo.spLicencias_Update", p, commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    Debug.Write(ex.ToString());
                    Debug.Assert(false);
                    return false;
                }

                return true;
            }
        }
    }
}
