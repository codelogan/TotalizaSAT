using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Security;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Totaliza
{
    public partial class Principal : Form
    {
        public List<DadosCupom> SortedList;
        string Pasta;

        public Principal()
        {
            InitializeComponent();
        }

        private void AbrePasta_Click(object sender, EventArgs e)
        {

            
            string valor = "0";
            string dtemissao = "";
            string hremissao = "";
            string numerocupom = "0";
            string id = "";
            string chcanc = "";
            System.DateTime varData;
            decimal varValor;
            int varNumeroCupom;
            string varId;
            string varChCanc;

            List<DadosCupom> lCupons = new List<DadosCupom>();
            Hashtable hashtableCupons = new Hashtable();

            //define as propriedades do controle 
            //OpenFileDialog
            this.ofd1.Multiselect = true;
            this.ofd1.Title = "Selecionar pasta arquivos SAT";
            ofd1.InitialDirectory = @"C:\";
            //filtra para exibir somente arquivos de imagens
            ofd1.Filter = "Images (*.XML)|*.XML|" + "All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;
            DialogResult dr = this.ofd1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Pasta = Path.GetDirectoryName(ofd1.FileName);
                DirectoryInfo Dir = new DirectoryInfo(Pasta);
                FileInfo[] Files = Dir.GetFiles("*", SearchOption.AllDirectories).OrderBy(p => p.CreationTimeUtc).ToArray();
                //Array.Sort(Files, (x, y) => Comparer<DateTime>.Default.Compare(x.CreationTime, y.CreationTime));
                txtCaminhoXML.Text = Pasta.ToString();
                // Le os arquivos selecionados 
                foreach (FileInfo File in Files)
                {
                    //txtArquivo.Text += arquivo;
                    // cria um PictureBox
                    try
                    {
                        XmlTextReader reader = new XmlTextReader(File.FullName);
                        //ArrayList elementos = new ArrayList();
                        valor = "0";
                        dtemissao = "";
                        hremissao = "";
                        numerocupom = "0";
                        id = "";
                        chcanc = "";
                        varValor = 0;
                        varNumeroCupom = 0;
                        varId = "";
                        varChCanc = "";

                        while ((reader.Read()))
                        {

                            if (reader.NodeType == XmlNodeType.Element)
                            {
                                switch (reader.Name)
                                {
                                    case "vCFe":
                                        valor = reader.ReadString();
                                        break;
                                    case "dEmi":
                                        dtemissao = reader.ReadString();
                                        break;
                                    case "hEmi":
                                        hremissao = reader.ReadString();
                                        break;
                                    case "nCFe":
                                        numerocupom = reader.ReadString();
                                        break;
                                    case "infCFe":
                                        id = reader.GetAttribute("Id");
                                        chcanc = reader.GetAttribute("chCanc") ?? "";
                                        break;
                                }
                            }
                        }
                        DateTimeFormatInfo usDtfi = new CultureInfo("pt-PT", false).DateTimeFormat;
                        varData = Convert.ToDateTime(dtemissao.Substring(6, 2) + "/" + dtemissao.Substring(4, 2) + "/" + dtemissao.Substring(0, 4) + " " + hremissao.Substring(0, 2) + ":" + hremissao.Substring(2, 2) + ":" + hremissao.Substring(4, 2), usDtfi);
                        varValor = Convert.ToDecimal(valor, new CultureInfo("en-US"));
                        varNumeroCupom = Convert.ToInt32(numerocupom);
                        varId = Convert.ToString(id);
                        varChCanc = Convert.ToString(chcanc);
                        //lCupons.Add(new DadosCupom(varNumeroCupom, varData, varValor, varId, varChCanc));
                        if (varChCanc.Length > 0)
                        {
                            if (hashtableCupons.ContainsKey(varChCanc))
                            {
                                //hashtableCupons[varChCanc] = new DadosCupom(varNumeroCupom, varData, varValor, varId, varChCanc);
                                ((DadosCupom)hashtableCupons[varChCanc]).chcanc = varId;

                            }
                            else
                            {
                                //hashtableCupons.Add(varId, new DadosCupom(varNumeroCupom, varData, varValor, varId, varChCanc));
                                hashtableCupons.Add(varId, new DadosCupom(0, varData, 0, varChCanc, varId));
                            }

                        }
                        else
                        {
                            if (hashtableCupons.ContainsKey(varId))
                            {
                                ((DadosCupom)hashtableCupons[varId]).Numero = varNumeroCupom;
                                ((DadosCupom)hashtableCupons[varId]).Data = varData;
                                ((DadosCupom)hashtableCupons[varId]).Valor = varValor;
                            }
                            else
                            {
                                hashtableCupons.Add(varId, new DadosCupom(varNumeroCupom, varData, varValor, varId, varChCanc));
                            }
                        }

                    }
                    catch (SecurityException ex)
                    {
                        // O usuário  não possui permissão para ler arquivos
                        MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                    "Mensagem : " + ex.Message + "\n\n" +
                                                    "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        // Não pode carregar a imagem (problemas de permissão)
                        MessageBox.Show(". Você pode não ter permissão para ler o arquivo , ou " +
                                                   " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                    }
                }
                //LblTotal.Text = Convert.ToString(lCupons.Sum(item => item.Valor));
                LblTotal.Text = "Total: " + Convert.ToString(DadosCupom.Soma(hashtableCupons));





                List<DadosCupom> hashToList = new List<DadosCupom>();
                foreach (DictionaryEntry de in hashtableCupons)
                {
                    hashToList.Add((DadosCupom)de.Value);
                }
                //Teoricamente ordenar aqui
                //List<DadosCupom> SortedList = hashToList.OrderBy(o => o.Data).ToList();
                SortedList = hashToList.OrderBy(o => o.Data).ToList();
                var bindingList = new BindingList<DadosCupom>(SortedList);
                var source1 = new BindingSource(bindingList, null);
                dgvHashCupons.DataSource = source1;
                dgvHashCupons.AutoResizeColumns();

                DataGridViewColumnCollection c = dgvHashCupons.Columns;

                c[0].HeaderText = "N. Cupom";
                c[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                c[1].HeaderText = "Data hora";
                c[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c[2].HeaderText = "Valor";
                c[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                c[3].HeaderText = "Chave de acesso";
                c[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c[4].HeaderText = "Chave de acesso cancelamento";
                c[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
        public void Exportar()
        {
            decimal total = 0;

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;

            //Excel.Range formatRange;
            int linha = 1;

            //Verificar se o excel está instalado
            if (xlApp == null)
            {
                MessageBox.Show("Excel não está instalado!");
                return;
            }
            //Cria o workbook
            xlWorkBook = xlApp.Workbooks.Add(Type.Missing);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //xlWorkSheet.Range[xlWorkSheet.Cells[linha, 1], xlWorkSheet.Cells[linha, 7]].Style.Locked = false;
            //Redimensionando coluna de nome do grupo
            ((Excel.Range)xlWorkSheet.Cells[linha, 1]).EntireColumn.ColumnWidth = 20;
            ((Excel.Range)xlWorkSheet.Cells[linha, 2]).EntireColumn.ColumnWidth = 15;
            ((Excel.Range)xlWorkSheet.Cells[linha, 3]).EntireColumn.ColumnWidth = 10;
            ((Excel.Range)xlWorkSheet.Cells[linha, 4]).EntireColumn.ColumnWidth = 50;
            ((Excel.Range)xlWorkSheet.Cells[linha, 5]).EntireColumn.ColumnWidth = 50;
            xlWorkSheet.Cells[linha, 1].NumberFormat = "dd/mm/yyyy hh:mm:ss";
            xlWorkSheet.Cells[linha, 1] = "Data hora";
            xlWorkSheet.Cells[linha, 2].NumberFormat = "@";
            xlWorkSheet.Cells[linha, 2] = "N. Cupom";
            xlWorkSheet.Cells[linha, 3].NumberFormat = "#,##0.00";
            xlWorkSheet.Cells[linha, 3] = "Valor";
            xlWorkSheet.Cells[linha, 3].Style.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            xlWorkSheet.Cells[linha, 4].NumberFormat = "@";
            xlWorkSheet.Cells[linha, 4] = "Chave de acesso";
            xlWorkSheet.Cells[linha, 5].NumberFormat = "@";
            xlWorkSheet.Cells[linha, 5] = "Chave de cancelamento";
            linha++;

            

            //List<DadosCupom> lProdutos = Produto.CarregaDadosProduto();

            foreach (DadosCupom dc in SortedList)
            {
                xlWorkSheet.Cells[linha, 1] = dc.Data;
                xlWorkSheet.Cells[linha, 2] = dc.Numero;
                xlWorkSheet.Cells[linha, 3] = dc.Valor.ToString("0.00");
                xlWorkSheet.Cells[linha, 4] = dc.id;
                xlWorkSheet.Cells[linha, 5] = dc.chcanc;
                if (string.IsNullOrWhiteSpace(dc.chcanc))
                {
                    total = total + dc.Valor;
                }
                linha++;
                lblMostrar.Text = "Exportando dados linha: " + linha;
            }
            xlWorkSheet.Cells[linha, 1].EntireRow.Font.Bold = true;
            xlWorkSheet.Cells[linha, 2] = "Total";
            xlWorkSheet.Cells[linha, 3] = total.ToString("0.00");
            xlApp.ActiveWindow.SplitRow = 1;
            //xlApp.ActiveWindow.SplitColumn = 1;
            xlApp.ActiveWindow.FreezePanes = true;

            //xlWorkSheet.Protect(Type.Missing, xlWorkSheet.ProtectDrawingObjects,  true, xlWorkSheet.ProtectScenarios, xlWorkSheet.ProtectionMode,  xlWorkSheet.Protection.AllowFormattingCells,  xlWorkSheet.Protection.AllowFormattingColumns,  xlWorkSheet.Protection.AllowFormattingRows,  xlWorkSheet.Protection.AllowInsertingColumns,  xlWorkSheet.Protection.AllowInsertingRows,  xlWorkSheet.Protection.AllowInsertingHyperlinks,  xlWorkSheet.Protection.AllowDeletingColumns,  xlWorkSheet.Protection.AllowDeletingRows,  xlWorkSheet.Protection.AllowSorting,  xlWorkSheet.Protection.AllowFiltering,  xlWorkSheet.Protection.AllowUsingPivotTables);
            //xlWorkSheet.EnableSelection = Excel.XlEnableSelection.xlUnlockedCells;
            //xlWorkSheet.Protect(Password: "luol2007", AllowFormattingCells: false);
            xlWorkSheet.Protect("luol2007", true, true);
            xlWorkBook.SaveAs(Pasta + "\\CuponsSAT.xlsx");
            xlWorkBook.Close(true, Type.Missing, Type.Missing);
            xlApp.Quit();
            //Interop marshaling governs how data is passed in method arguments and return values between managed 
            //and unmanaged memory during calls. Most data types have common representations in both managed 
            //and unmanaged memory. The interop marshaler handles these types for you. 
            //Other types can be ambiguous or not represented at all in managed memory.
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
            lblMostrar.Text = "Exportação dos dados concluida!";
            MessageBox.Show("Exportação dos dados concluida!", "Aviso");
         
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Exportar();
        }
    }
}
