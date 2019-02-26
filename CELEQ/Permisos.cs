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
        DataTable r;
        public Permisos(string usuario = null)
        {
            bd = new AccesoBaseDatos();
            InitializeComponent();
            r = bd.ejecutarConsultaTabla("select * from permisos where usuario = '" + usuario + "'");
            for(int i = 1; i < r.Columns.Count; i++)
            {
                listPermisos.Items.Insert(i - 1, r.Columns[i].ColumnName);
                if(r.Rows[0].ItemArray[i].ToString() == "True")
                {
                    listPermisos.SetItemCheckState(i - 1, CheckState.Checked);
                }
            }
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            string campos = "";
            bd = new AccesoBaseDatos();
            int i = 1;
            while (i < r.Columns.Count)
            {
                if (i == r.Columns.Count - 2)
                {
                    while (i < r.Columns.Count)
                    {
                        campos += r.Columns[i].ColumnName + " = ";
                        if (listPermisos.GetItemCheckState(i - 1) == CheckState.Checked)
                            campos += 1;
                        else
                            campos += 0;
                        if (i == r.Columns.Count - 2)
                            campos += " , ";
                        i++;
                    }
                }
                else
                {
                    campos += r.Columns[i].ColumnName + " = ";
                    if (listPermisos.GetItemCheckState(i - 1) == CheckState.Checked)
                        campos += 1;
                    else
                        campos += 0;
                    campos += " , ";
                    i++;
                }
            }
                bd.actualizarDatos("update permisos set " + campos);
            this.Close();
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
