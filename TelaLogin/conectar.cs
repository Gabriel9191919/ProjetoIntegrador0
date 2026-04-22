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
    internal class conectar
    {
        private static string conexao = "server=localhost; uid = root; pwd=; database = adega_jm;";

        public MySqlConnection conectando()
        {
            return new MySqlConnection(conexao);
        }
    }


}
