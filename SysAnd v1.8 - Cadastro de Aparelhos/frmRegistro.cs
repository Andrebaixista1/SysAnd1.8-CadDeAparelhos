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

namespace SysAnd_v1._8___Cadastro_de_Aparelhos
{
    public partial class frmRegistro : UserControl
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=brm3907\SQLEXPRESS;initial Catalog=FixManutencaoDB;integrated security=SSPI");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dt;
        DataTable db = new DataTable();
        string arquivoCSV = @"C:\dev\TabelaFIX.csv";

        private void loadingDataBase()
        {
            
            cmd.CommandText = "select * from DB_Manutencao";
            cmd.Connection = cn;

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adp.SelectCommand = cmd;
            adp.Fill(dt);

            dgvTabela.DataSource = dt;
            dgvTabela.Columns[0].HeaderText = "ID";
            dgvTabela.Columns[1].HeaderText = "Entrada";
            dgvTabela.Columns[2].HeaderText = "OS";
            dgvTabela.Columns[3].HeaderText = "Patrimônio";
            dgvTabela.Columns[4].HeaderText = "Modelo";
            dgvTabela.Columns[5].HeaderText = "Cor";
            dgvTabela.Columns[6].HeaderText = "Defeito";
            dgvTabela.Columns[7].HeaderText = "Reparo";
            dgvTabela.Columns[8].HeaderText = "Status";
            dgvTabela.Columns[9].HeaderText = "Obs.";
            dgvTabela.Columns[10].HeaderText = "Saida";
            dgvTabela.Columns[11].HeaderText = "Laudo";
            dgvTabela.Columns[12].HeaderText = "Garantia";

            

        }

        private void teste()
        {
            
        }
        private void frmRegistro_Load(object sender, EventArgs e)
        {
            cbDefeito.Sorted = true;
            cbColor.Sorted = true;
            cbStatus.Sorted = true;
            cbModelo.Sorted = true;
            defeitos();
            cn.Open();
            loadingDataBase();
            DateTime data = DateTime.Now;
            txtEntrada.Text = data.ToString();
            txtSaida.Text = "01012000 0000";
            cn.Close();
            limpar();

        }

        private void cbEntrada_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEntrada.Checked)
            {
                txtEntrada.Enabled = true;
            }
            else
            {
                txtEntrada.Enabled = false;
            }

        }

        private void cbSaida_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSaida.Checked)
            {
                txtSaida.Enabled = true;
                txtSaida.Text = "";
            }
            else
            {
                txtSaida.Enabled= false;
                txtSaida.Text = "01012000 0000";
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtOS_MouseClick(object sender, MouseEventArgs e)
        {
            txtOS.Text = "";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void defeitos()
        {
            cbDefeito.Items.Add("Não Liga");
            cbDefeito.Items.Add("Bateria");
            cbDefeito.Items.Add("Botão Home");
            cbDefeito.Items.Add("Botão Silêncioso");
            cbDefeito.Items.Add("Não sobe dados");
            cbDefeito.Items.Add("Display Riscado");
            cbDefeito.Items.Add("Reboot");
            cbDefeito.Items.Add("Botão Power");
            cbDefeito.Items.Add("Audio Codec");
            cbDefeito.Items.Add("Alto Falante Auricular");
            cbDefeito.Items.Add("Tampa Traseira Avariada");
            cbDefeito.Items.Add("Pixel Morto");
            cbDefeito.Items.Add("Slot SIM Card");
            cbDefeito.Items.Add("Sensor Frontal");
            cbDefeito.Items.Add("Lente da Câmera Traseira Avariada");
            cbDefeito.Items.Add("Display / Touch");
            cbDefeito.Items.Add("Display Quebrado");
            cbDefeito.Items.Add("Display Manchado");
            cbDefeito.Items.Add("Conector de Carga/ Não Reconhece USB/ Não carrega");
            cbDefeito.Items.Add("Carcaça / Chassi Avariada");
            cbDefeito.Items.Add("PT - Perda Total");

                 
                        
                       
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            /*cbGarantia.Items.Clear();*/
            try
            {
                SqlCommand cm = new SqlCommand();
                cn.Open();



                cm.CommandText = "select * from DB_Manutencao";
                cm.Connection = cn;

                SqlDataAdapter adp = new SqlDataAdapter(cm); // recebe os dados de uma tabela depois da execução de um Select
                DataTable dt = new DataTable(); // representa uma ou mais tabelas que permanecem alocadas em memória

                adp.SelectCommand = cm; // recebendo os dados da instrução Select
                adp.Fill(dt); //preenchendo o DataTable

                dgvTabela.DataSource = dt; //Tabela que será preenchida
                                           // cn.Close();

                /*int ids = dt.Rows.Count;
                ids += 1;

                

                int id = ids;*/

                DateTime entrada = Convert.ToDateTime(txtEntrada.Text);
                string patrimonio = txtPatrimonio.Text;
                string OS = txtOS.Text;
                string modelo = cbModelo.Text;
                string cor = cbColor.Text;

                string reparo = txtReparo.Text;
                string status = cbStatus.Text;
                string obs = txtObs.Text;
                DateTime saida = Convert.ToDateTime(txtSaida.Text);

                string defeito = string.Empty;
                string laudo = string.Empty;
                string garantia = string.Empty;

                foreach (object d in cbDefeito.CheckedItems)
                {
                    if (cbDefeito.CheckedItems.Count > 1)
                    {
                        defeito += d.ToString() + Environment.NewLine + ", ";
                    }
                    else
                    {
                        defeito += d.ToString() + Environment.NewLine;
                    }
                   
                }

                

                if (rbSimGarantia.Checked)
                {
                    laudo = "Sim";
                }
                else
                {
                    laudo = "Não";
                }

                
                if (rbSImLaudo.Checked)
                {
                    garantia = "Sim";
                }
                else
                {
                    garantia = "Não";
                }
                
                

                
                /*Console.WriteLine(defeito, "Deu certo !");
                Console.WriteLine(laudo, "Deu certo !");
                Console.WriteLine(garantia, "Deu certo !");*/




                string sql = "insert into DB_manutencao(entrada,os,patrimonio,modelo,cor,defeito,reparo,status,obs,saida,laudo,garantia) values(@entrada,@os,@patrimonio,@modelo,@cor,@defeito,@reparo,@status,@obs,@saida,@laudo,@garantia)";
                SqlCommand cmd = new SqlCommand(sql, cn);

                
                cmd.Parameters.Add("@entrada", SqlDbType.DateTime).Value = entrada;
                cmd.Parameters.Add("@patrimonio", SqlDbType.VarChar).Value = patrimonio;
                cmd.Parameters.Add("@os", SqlDbType.VarChar).Value = OS;
                cmd.Parameters.Add("@modelo", SqlDbType.VarChar).Value = modelo;
                cmd.Parameters.Add("@cor", SqlDbType.VarChar).Value = cor;
                cmd.Parameters.Add("@defeito", SqlDbType.Text).Value = defeito;
                cmd.Parameters.Add("@reparo", SqlDbType.Text).Value = reparo;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
                cmd.Parameters.Add("@obs", SqlDbType.Text).Value = obs;
                cmd.Parameters.Add("@saida", SqlDbType.DateTime).Value = saida;
                cmd.Parameters.Add("@laudo", SqlDbType.Text).Value = laudo;
                cmd.Parameters.Add("@garantia", SqlDbType.Text).Value = garantia;

                cmd.ExecuteNonQuery(); //Executar sem consulta
                
                MessageBox.Show("Aparelho cadastrado com sucesso !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                loadingDataBase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }

        

        private void cbDefeito_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void limpar()
        {
            
            txtID.Text = "00";
            txtID.Enabled = false;
            txtEntrada.Text = DateTime.Now.ToString();
            txtEntrada.Enabled = false;
            txtOS.Text = "000000";
            txtOS.Enabled = false;
            txtSaida.Text = "01012000 0000";
            txtSaida.Enabled = false;

            txtPatrimonio.Text = "";
            txtPatrimonio.Enabled = false;
            cbModelo.Text = "";
            cbModelo.Enabled = false;
            cbColor.Text = "";
            cbColor.Enabled = false;
            cbStatus.Text = "";
            cbStatus.Enabled = false;

            rbNãoGarantia.Enabled = false;
            rbSimGarantia.Enabled = false;
            rbSImLaudo.Enabled = false;
            rbNãoLaudo.Enabled = false;


            rbNãoGarantia.Select();
            rbNãoLaudo.Select();
            
            cbDefeito.Enabled = false ;
            txtReparo.Text = "";
            txtReparo.Enabled = false;
            txtObs.Text = "";
            txtObs.Enabled = false;

            cbEntrada.Enabled = false;
            cbSaida.Enabled = false;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtID.Text = "00";
            txtID.Enabled = false;
            txtEntrada.Text = DateTime.Now.ToString();
            txtEntrada.Enabled = false;
            txtOS.Text = "000000";
            txtOS.Enabled = true;
            txtSaida.Text = "01012000 0000";
            txtSaida.Enabled = false;

            txtPatrimonio.Text = "";
            txtPatrimonio.Enabled = true;
            cbModelo.Text = "";
            cbModelo.Enabled = true;
            cbColor.Text = "";
            cbColor.Enabled = true;
            cbStatus.Text = "";
            cbStatus.Enabled = true;

            rbSimGarantia.Enabled = true;
            rbNãoGarantia.Enabled = true;
            rbNãoGarantia.Select();

            rbSImLaudo.Enabled = true;
            rbNãoLaudo.Enabled = true;
            rbNãoLaudo.Select();

            for (int i = 0; i < cbDefeito.Items.Count; i++)
            {
                cbDefeito.SetItemChecked(i, false);
            }
            cbDefeito.Enabled = true;
            txtReparo.Text = "";
            txtReparo.Enabled = true;
            txtObs.Text = "";
            txtObs.Enabled = true;
            
            cbSaida.Enabled = true;
            cbEntrada.Enabled = true;


            }

        private void dgvTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void chargeData()
        {
            txtID.Text = dgvTabela.SelectedRows[0].Cells[0].Value.ToString();
            txtEntrada.Text = dgvTabela.SelectedRows[0].Cells[1].Value.ToString();
            txtOS.Text = dgvTabela.SelectedRows[0].Cells[2].Value.ToString();
            txtSaida.Text = dgvTabela.SelectedRows[0].Cells[10].Value.ToString();
            txtPatrimonio.Text = dgvTabela.SelectedRows[0].Cells[3].Value.ToString();
            cbModelo.Text = dgvTabela.SelectedRows[0].Cells[4].Value.ToString();
            cbColor.Text = dgvTabela.SelectedRows[0].Cells[5].Value.ToString();
            cbStatus.Text = dgvTabela.SelectedRows[0].Cells[8].Value.ToString();
            
            string garantia = dgvTabela.SelectedRows[0].Cells[12].Value.ToString();
            if (garantia == "Sim")
            {
                rbSimGarantia.Select();
            }
            else
            {
                rbNãoGarantia.Select();
            }

            string laudo = dgvTabela.SelectedRows[0].Cells[11].Value.ToString();
            if (laudo == "Sim")
            {
                rbSImLaudo.Select();
            }
            else
            {
                rbNãoLaudo.Select();
            }

            string defeito = dgvTabela.SelectedRows[0].Cells[6].Value.ToString();
            
          

            


            txtReparo.Text = dgvTabela.SelectedRows[0].Cells[7].Value.ToString();
            txtObs.Text = dgvTabela.SelectedRows[0].Cells[9].Value.ToString();
        }
        private void dgvTabela_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            chargeData();
        }
    }
    }


