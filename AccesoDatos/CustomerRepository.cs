using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CustomerRepository
    {
        public List<Customers> ObtenerTodo()
        {
            using (var conexion =
                DataBase.GetSqlConnection())
            {
                String selectALL = "";
                selectALL = selectALL + "SELECT [CustomerID] " + "\n";
                selectALL = selectALL + "      ,[CompanyName] " + "\n";
                selectALL = selectALL + "      ,[ContactName] " + "\n";
                selectALL = selectALL + "      ,[ContactTitle] " + "\n";
                selectALL = selectALL + "      ,[Address] " + "\n";
                selectALL = selectALL + "      ,[City] " + "\n";
                selectALL = selectALL + "      ,[Region] " + "\n";
                selectALL = selectALL + "      ,[PostalCode] " + "\n";
                selectALL = selectALL + "      ,[Country] " + "\n";
                selectALL = selectALL + "      ,[Phone] " + "\n";
                selectALL = selectALL + "      ,[Fax] " + "\n";
                selectALL = selectALL + "  FROM [dbo].[Customers]";

                var cliente = conexion.Query<Customers>(selectALL).ToList();
                return cliente;

            }
        }
    }
}
