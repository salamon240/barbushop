using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace barbushop
{
    public class MyDB
    {

        private static readonly string myConnStr = ConfigurationManager.ConnectionStrings["barbushopConnectionString"].ToString();
        private static SqlConnection connection;
        private string where = null;
        private string order = null;
        private string limit = null;

        public MyDB()
        {
            connection = new SqlConnection(myConnStr);
            connection.Open();

        }


        public bool Insert(string table, List<DbListAdapter> data)
        {
            if (table == null || data.Count == 0)
                return false;

            string secSql = "";
            string sql = "INSERT INTO " + table + "(";

            for (int i = 0; i < data.Count; i++)
            {
                sql += data[i].field;
                secSql += "'" + data[i].value + "'";

                if (i == data.Count - 1)
                {
                    sql += ")";
                    secSql += ")";
                }
                else
                {
                    sql += ",";
                    secSql += ",";
                }
            }

            sql += " VALUES (" + secSql;

            if (new SqlCommand(sql, connection).ExecuteNonQuery() == 0)
                return false;

            connection.Dispose();
            return true;


            //var Cmd = new SqlCommand(sql, connection);
            //int effectedRows;
            //effectedRows = Cmd.ExecuteNonQuery();
        }

        public MyDB Where(string field, string value, string oper = "=")
        {
            if (where != null)
                where += "AND ";
            else
                where = "WHERE ";

            where += field + oper + "'" + value + "' ";

            return this;
        }

        public MyDB OrWhere(string field, string value, string oper = "=")
        {
            if (where != null)
                where += "OR ";
            else
                where = "WHERE ";

            where += field + oper + "'" + value + "' ";

            return this;
        }

        public MyDB Sort(string method, params string[] fields)
        {
            if (method != "ASC" && method != "DESC")
                throw new ArgumentException(String.Format("The method {0} cannot be execute!", method));

            if (fields.Length == 0)
                throw new ArgumentException("You must provide at least 1 field for ordering");

            order = "ORDER BY ";

            for (int i = 0; i < fields.Length; i++)
            {
                order += fields[i];

                if (i != fields.Length - 1)
                    order += ", ";
                else
                    order += " ";
            }

            order += method + " ";

            return this;

        }

        public MyDB Limit(int number)
        {
            if (number < 1)
                throw new ArgumentException("You must provide number greater than 0.");

            limit = "TOP " + number.ToString() + " ";

            return this;
        }

        public DataTable Get(string table, params string[] fields)
        {
            if (table == null)
                throw new ArgumentNullException(table);

            string sql = "SELECT ";

            if (limit != null)
                sql += limit;

            if (fields.Length == 0)
                sql += "* ";
            else
            {
                for (int i = 0; i < fields.Length; i++)
                {
                    sql += fields[i];

                    if (i != fields.Length - 1)
                        sql += ", ";
                    else
                        sql += " ";
                }
            }

            sql += "FROM " + table + " ";

            if (where != null)
                sql += where;

            if (order != null)
                sql += order;

            var Cmd = new SqlCommand(sql, connection);

            var DataTable = new DataTable();
            var DataAdapter = new SqlDataAdapter();

            DataAdapter.SelectCommand = Cmd;

            DataAdapter.Fill(DataTable);

            connection.Dispose();
            return DataTable;
        }


    }
}