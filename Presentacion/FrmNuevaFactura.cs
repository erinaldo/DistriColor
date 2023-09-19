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
            CargarFormasPago();
            CargarArticulos();
            Inicializar();

        }

        private void Inicializar()
        {
            txtFecha.Text = DateTime.Today.ToString();
            txtCliente.Text = "CONSUMIDOR FINAL";
            txtCantidad.Text = "1";
            txtSubTotal.Text = "0";
            txtTotal.Text = "0";
            txtCliente.Focus();
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

        private void CargarFormasPago()
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ALITTLESHOP_DB;Integrated Security=True");
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_CONSULTAR_FORMAS_PAGO";
            conexion.Open();
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            cboFormasPago.DataSource = tabla;
            cboFormasPago.ValueMember = "codigo_formapago";
            cboFormasPago.DisplayMember = "nombre_formapago";
            cboFormasPago.DropDownStyle = ComboBoxStyle.DropDownList;
            conexion.Close();
        }

        private void CargarArticulos()
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ALITTLESHOP_DB;Integrated Security=True");
            SqlCommand comando = new SqlCommand();
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_CONSULTAR_ARTICULOS";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            cboArticulos.DataSource = tabla;
            cboArticulos.ValueMember = "codigo_art"; // ojo los nombres, CHEQUEAR
            cboArticulos.DisplayMember = "nombre_art"; // ojo los nombres, CHEQUEAR
            cboArticulos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboArticulos.SelectedIndex = -1;
        }

    }
}
