using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CELEQ
{
    public partial class Permisos : Form
    {
        AccesoBaseDatos bd;
        public Permisos(string usuario = null)
        {
            bd = new AccesoBaseDatos();
            InitializeComponent();
            DataTable r = bd.ejecutarConsultaTabla("select * from permisos where usuario = " + usuario);
            for(int i = 0; i < r.Columns.Count - 1; i++)
            {
                listPermisos.Items.Insert(i, r.Columns[i + 1].ColumnName);
                if(r.Rows[0].ItemArray[i].ToString() == "True")
                {
                    listPermisos.SetItemCheckState(i, CheckState.Checked);
                }
            }
        }

    }
}
