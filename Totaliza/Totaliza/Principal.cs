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

namespace Totaliza
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Totalizar_Click(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(txtCaminhoXML.Text);
            ArrayList elementos = new ArrayList();
            string valor;

            while ((reader.Read()))
            {
                if (reader.NodeType== XmlNodeType.Element && reader.Name == "vCFe")
                {
                    valor = reader.ReadString();
                    LblTotal.Text = valor;
                    DadosCupom dc = new DadosCupom();
                    //dc.valor = System.Convert.ToDecimal(valor);

                }
            }

        }


        private void AbrePasta_Click(object sender, EventArgs e)
        {

            string Pasta;
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
                FileInfo[] Files = Dir.GetFiles("*", SearchOption.AllDirectories);

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
                        varValor=0;
                        varNumeroCupom=0;
                        varId="";
                        varChCanc="";

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
                        DateTimeFormatInfo usDtfi = new CultureInfo("pt-PT",false).DateTimeFormat;
                        varData = Convert.ToDateTime(dtemissao.Substring(6, 2) + "/" +  dtemissao.Substring(4, 2) + "/" + dtemissao.Substring(0,4) + " " + hremissao.Substring(0, 2) + ":" + hremissao.Substring(2, 2) + ":" + hremissao.Substring(4, 2), usDtfi);
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
                LblTotal.Text = Convert.ToString(DadosCupom.Soma(hashtableCupons));





                List<DadosCupom> hashToList = new List<DadosCupom>();
                foreach(DictionaryEntry de in hashtableCupons)
                {
                    hashToList.Add((DadosCupom)de.Value);
                }
                var bindingList = new BindingList<DadosCupom>(hashToList);
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

        private void dgvHashCupons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
