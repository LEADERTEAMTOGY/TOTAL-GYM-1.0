using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace TESTJVRF301510920
{
    class datos2
    {
        private string cadena = "Data Source=(local);Initial Catalog=TESTAJVRF;Integrated Security=True";
        public SqlConnection cn;
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;
        private void conectar()
        {
            cn = new SqlConnection(cadena);
        }
        public datos2()
        {
            conectar();
        }
        //CONSULTAR
        public void consultar(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }
        //ELIMINAR
        public bool eliminar(string tabla, string condiction)
        {
            cn.Open();
            string sql = "delete from " + tabla + " where " + condiction;
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else { return false; }
        }
        //ACTUALIZAR
        public bool actualizar(string tabla, string campos, string condiction)
        {
            cn.Open();
            string sql = "update " + tabla + " set "  + " where" + condiction;
            comando = new SqlCommand(sql, cn);
            
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if(i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable consultar2(string tabla)
        {
            string sql = "select * from " + tabla;
            da = new SqlDataAdapter(sql, cn);
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];
            return dt;

        }
        public bool insertar(string sql)
        {
            cn.Open();
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if(i > 0)
            {
                return true;
            }
            else { return false; }
        }
    }
}
