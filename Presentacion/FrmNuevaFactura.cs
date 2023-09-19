using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistriColor.Presentacion
{
    public partial class FrmNuevaFactura : Form
    {
        public FrmNuevaFactura()
        {
            InitializeComponent();
        }

        private void FrmNuevaFactura_Load(object sender, EventArgs e)
        {
            ProximaFactura();
        }

        private void ProximaFactura()
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ALITTLESHOP_DB;Integrated Security=True");
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_PROXIMA_FC";
            SqlParameter parametro = new SqlParameter("@proxima_fc", SqlDbType.Int); // TIPO DE DATO: INT
            parametro.Direction = ParameterDirection.Output; // DIRECCION: SALIDA
            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();
            conexion.Close();
            lblNroFactura.Text = lblNroFactura.Text + parametro.Value;
        }
    }
}
