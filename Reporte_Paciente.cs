using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUNDALZHEIMER_CR
{
    public partial class Reporte_Usuario : Form
    {
        public Reporte_Usuario()
        {
            InitializeComponent();
        }

        private void Reporte_Usuario_Load(object sender, EventArgs e)
        {
            Conexion obj = new Conexion();
            obj.cargar_Usuario2(dgv_Registro_Paciente);

        }

        private void txt_CEDULA_PACIENTE_TextChanged(object sender, EventArgs e)
        {
            Conexion obj3 = new Conexion();
            obj3.cargarUSUARIO2(dgv_Registro_Paciente, txt_CEDULA_PACIENTE.Text);
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            if (dgv_Registro_Paciente.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf"; // Corregido: se corrigió el filtro de archivo PDF
                save.FileName = "Result";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                        {
                            Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                            PdfWriter writer = PdfWriter.GetInstance(document, fileStream);
                            document.Open();

                            PdfPTable pTable = new PdfPTable(dgv_Registro_Paciente.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            // Agregar encabezados de columna al PDF
                            foreach (DataGridViewColumn col in dgv_Registro_Paciente.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }

                            // Agregar datos de las filas al PDF
                            foreach (DataGridViewRow viewRow in dgv_Registro_Paciente.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value?.ToString() ?? ""); // Manejo de celdas nulas
                                }
                            }

                            document.Add(pTable);
                            document.Close();

                            MessageBox.Show("Datos exportados correctamente", "info");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay registros para exportar", "Info");
            }
        }

    }
}

