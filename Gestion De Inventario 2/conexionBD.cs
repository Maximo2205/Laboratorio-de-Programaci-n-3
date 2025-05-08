using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Collections;



namespace Gestion_De_Inventario_2
{
    internal class conexionBD
    {
        public DataSet DS { get; set; }
        public OleDbDataAdapter DAP { get; set; }
        public OleDbDataAdapter DAC { get; set; }

        public String Error = "";


        public conexionBD()
        {
            try
            {
                DS = new DataSet();

                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source=Inventario.mdb";
                cnn.Open();

                OleDbCommand cmp = new OleDbCommand();
                cmp.CommandType = CommandType.TableDirect;
                cmp.CommandText = "Productos";
                cmp.Connection = cnn;
                DAP = new OleDbDataAdapter();
                DAP.SelectCommand = cmp;
                DAP.Fill(DS, "Productos");

                OleDbCommand cmc = new OleDbCommand();
                cmc.CommandType = CommandType.TableDirect;
                cmc.CommandText = "Categorías";
                cmc.Connection = cnn;
                DAC = new OleDbDataAdapter();
                DAC.SelectCommand = cmc;
                DAC.Fill(DS, "Categorías");

                DataColumn[] clavePrimaria = new DataColumn[1];
                clavePrimaria[0] = DS.Tables["Productos"].Columns["Código"];
                DS.Tables["Productos"].PrimaryKey = clavePrimaria;

                OleDbCommandBuilder cb = new OleDbCommandBuilder(DAP);

            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }


        }

        public void Agregar(int Código, string Nombre, string Descripción, float precio, int stock, int id)
        {
            DataRow dr = DS.Tables["Productos"].NewRow();
            dr["Código"] = Código;
            dr["Nombre"] = Nombre;
            dr["Descripción"] = Descripción;
            dr["Precio"] = precio;
            dr["Stock"] = stock;
            dr["ID_Categoría"] = id;
            DS.Tables["Productos"].Rows.Add(dr);

            DAP.Update(DS, "Productos");
        }

        public DataTable BuscarProductos(string textoBusqueda)
        {
            DataTable resultados = DS.Tables["Productos"].Clone();

            foreach (DataRow row in DS.Tables["Productos"].Rows)
            {
                // Busca en Código, Nombre O Categoría (sin distinguir mayúsculas)
                if (row["Código"].ToString().Contains(textoBusqueda) ||
                    row["Nombre"].ToString().ToLower().Contains(textoBusqueda.ToLower()) ||
                    row["ID_Categoría"].ToString().Contains(textoBusqueda))
                {
                    resultados.ImportRow(row);
                }
            }

            return resultados;

        }

        public void Eliminar(int Código)
        {
            foreach(DataRow dr in DS.Tables["Productos"].Rows)
            {
                if ((int)dr["Código"] == Código)
                { 
                    dr.Delete();
                    break;
                }
            }

            OleDbCommandBuilder cb = new OleDbCommandBuilder(DAP);
            DAP.Update(DS, "Productos");
        }

        public void Modificar(int CodigoM, string Nombre1, int CategoriaM, int PrecioM, int StockM, string DescripcionM)
        {
            try
            {
                DataRow fila = DS.Tables["Productos"].Rows.Find(CodigoM);
                if (fila != null)
                {
                    fila.BeginEdit();
                    fila["Nombre"] = Nombre1;
                    fila["ID_Categoría"] = CategoriaM;
                    fila["Precio"] = PrecioM;
                    fila["Stock"] = StockM;
                    fila["Descripción"] = DescripcionM;
                    fila.EndEdit();

                    DAP.Update(DS, "Productos");
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                throw; 
            }
        }

        public DataTable ObtenerProductosStockBajo(int stockMinimo = 5)
        {
            DataTable dtResultado = DS.Tables["Productos"].Clone();
            var productosBajos = DS.Tables["Productos"].AsEnumerable()
                                .Where(row => Convert.ToInt32(row["Stock"]) < stockMinimo);

            if (productosBajos.Any())
                dtResultado = productosBajos.CopyToDataTable();

            return dtResultado;
        }

    }
}
