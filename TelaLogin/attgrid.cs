using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaLogin
{
    internal class attgrid
    {
        private DataGridView _dgv;

        public attgrid(DataGridView gridRecebido)
        {
            this._dgv = gridRecebido;
        }

        public void updategrid()
        {
            conectar conectar = new conectar();
            MySqlConnection con = conectar.conectando();
            try
            {
               
                con.Open();
                string sql = "SELECT * FROM estoque";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter estoque = new MySqlDataAdapter(cmd);
                DataTable qualquercoisa = new DataTable();
                estoque.Fill(qualquercoisa);
                _dgv.DataSource = qualquercoisa;
            }
            catch (Exception)
            {
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }
    }
}
