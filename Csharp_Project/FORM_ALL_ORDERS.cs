/*using iTextSharp.text;
using iTextSharp.text.pdf;
*/
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

namespace Csharp_Project
{
    public partial class FORM_ALL_ORDERS : Form
    {
        Order order = new Order();
        public FORM_ALL_ORDERS()
        {
            InitializeComponent();
        }

        // Print The Selected Order in PDF File Using iTextSharp
  /*      private void BTN_PRINT_ORDER_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\BOBI\Desktop\files\Printed_Order.pdf", FileMode.Create);
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.AddAuthor("1BestCsharp");
            document.AddCreator("Inventory App");
            document.AddKeywords("Order");
            document.AddSubject("Customer Order");
            document.AddTitle("Order Details");

            // Open the document to enable you to write to the document
            document.Open();
            PdfPTable table = new PdfPTable(5);
            DataTable SelectedOrderDetails = new DataTable();
            String totalOrderAmount = order.getOrderTotalAmount(Convert.ToInt32(DGV_ALL_ORDERS.CurrentRow.Cells[0].Value.ToString())).Rows[0][0].ToString();
            string ordId = DGV_ALL_ORDERS.CurrentRow.Cells[0].Value.ToString();
            string ordDate = DGV_ALL_ORDERS.CurrentRow.Cells[3].Value.ToString();
            SelectedOrderDetails = order.getOrderDetails(Convert.ToInt32(DGV_ALL_ORDERS.CurrentRow.Cells[0].Value.ToString()));
            PdfPCell cellHeader = new PdfPCell(new Phrase("Naracka " + ordId+" Detali"));
            cellHeader.Colspan = 5;
            cellHeader.HorizontalAlignment = 1;
            cellHeader.ExtraParagraphSpace = 20;
            table.AddCell(cellHeader);
            table.AddCell("Broj na produkt");
            table.AddCell("Ime na produktot");
            table.AddCell("Kolicina");
            table.AddCell("Cena");
            table.AddCell("Kolicina x Cena");
         
            for (int i = 0; i < SelectedOrderDetails.Rows.Count; i++)
            {
                table.AddCell(SelectedOrderDetails.Rows[i][0].ToString());
                table.AddCell(SelectedOrderDetails.Rows[i][1].ToString());
                table.AddCell(SelectedOrderDetails.Rows[i][2].ToString());
                table.AddCell(SelectedOrderDetails.Rows[i][3].ToString());
                table.AddCell(SelectedOrderDetails.Rows[i][4].ToString());
            }

            string custFullName = DGV_ALL_ORDERS.CurrentRow.Cells[1].Value.ToString() + " " + DGV_ALL_ORDERS.CurrentRow.Cells[2].Value.ToString();
            
            Paragraph prg = new Paragraph("Data na poracka : "+ordDate+"\n\n\nKlient : "+ custFullName+"\n"+"Br. na naracka : "+ordId+"\n\n");

            PdfPCell cellAmount = new PdfPCell(new Phrase("Vkupno : " + totalOrderAmount));
            cellAmount.HorizontalAlignment = 2;
            cellAmount.Colspan = 5;

            document.Add(prg);
            table.AddCell(cellAmount);
            
            document.Add(table);
            //document.Add(prg);
            // Close the document
            document.Close();
            // Close the writer instance
            writer.Close();
            // Always close open filehandles explicity
            fs.Close();
            MessageBox.Show("Reportot e uspesno generiran");
        }
*/
        private void PANEL_MIN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FORM_ALL_ORDERS_Load(object sender, EventArgs e)
        {

        }
    }
}
