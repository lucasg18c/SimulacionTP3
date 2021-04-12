using System.Windows.Forms;

namespace SimulacionTP3.Presentacion
{
    public partial class FrmPruebaBondad : Form
    {
        public FrmPruebaBondad()
        {
            InitializeComponent();
        }

        public void SetColumnasProcedimiento(string[] columnas)
        {
            for (int i = 0; i < columnas.Length; i++)
                tablaProcedimiento.Columns.Add($"col{i}", columnas[i]);
        }

        public void MostrarProcedimiento(string[][] procedimiento)
        {
            foreach (string[] fila in procedimiento)
                tablaProcedimiento.Rows.Add(fila);
        }

        public void MostrarConclusion(string conclusion)
        {
            lblCOnclusion.Text = conclusion;
        }
    }
}
