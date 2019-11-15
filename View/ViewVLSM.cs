using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ModelIPBase;
using ModelSubRedes;
using ControlerVLSM;

namespace Calculadora_VLSM_Redes_de_Computadores_
{
    public partial class Form1 : Form
    {
        ControlVLSM controlVLSM = new ControlVLSM();
        string newLine = "\r\n";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (mskIP.Text != "   ,   ,   ,")
            {
                IPBase ipbase = controlVLSM.PesquisaDadosIPBase(mskIP.Text);
                if (ipbase != null)
                {
                    lblClass.Visible = true;
                    lblMask.Visible = true;
                    txtClass.Visible = true;
                    txtMask.Visible = true;
                    lblIpBinario.Visible = true;
                    txtIpBinario.Visible = true;
                    lblMaskBinario.Visible = true;
                    txtMaskBinario.Visible = true;
                    btnNext.Enabled = false;
                    grpSubNet.Visible = true;
                    mskIP.Enabled = false;
                    mskIP.BackColor = Color.White;
                    MostraDadosIPBase(ipbase);
                }
            }

            else
            {
                mskIP.BackColor = Color.LightCoral;
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnAddHosts_Click(object sender, EventArgs e)
        {
            controlVLSM.incluir(inserirSubRede());
            controlVLSM.ordenaLista();
            dataGridView.DataSource = controlVLSM.listaSubRedes();
            btnCalcular.Enabled = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            IPBase ip = controlVLSM.PesquisaDadosIPBase(mskIP.Text);
            bool avaliaRangeHosts = controlVLSM.CheckLimiteHosts(ip.Classe);
            if (avaliaRangeHosts == true)
            {
                richResult.Visible = true;
                btnAddHosts.Enabled = false;
                btnCalcular.Enabled = false;
                richResult.Clear();
                ExecCalculoSubRede();
            }
            else
            {
                MessageBox.Show($"Número de hosts excedido para a classe {ip.Classe}. Remova hosts da lista!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostraDadosIPBase(IPBase ipbase)
        {
            txtClass.Text = ipbase.Classe.ToString();
            txtMask.Text = ipbase.MascaraPadrao;
            txtIpBinario.Text = ipbase.EnderecoIPBIN;
            txtMaskBinario.Text = ipbase.MascaraPadraoBIN;
        }

        private void LimparCampos()
        {
            mskIP.Clear();
            txtClass.Clear();
            txtMask.Clear();
            mskIP.BackColor = Color.White;
            lblClass.Visible = false;
            lblMask.Visible = false;
            txtClass.Visible = false;
            txtMask.Visible = false;
            lblIpBinario.Visible = false;
            txtIpBinario.Visible = false;
            lblMaskBinario.Visible = false;
            txtMaskBinario.Visible = false;
            mskIP.Enabled = true;
            btnNext.Enabled = true;
            btnCalcular.Enabled = false;
            grpSubNet.Visible = false;
            richResult.Visible = false;
            btnAddHosts.Enabled = true;
            richResult.Clear();
            dataGridView.DataSource = null;
            controlVLSM.ZeraLista();
            numHosts.Value = 2;
        }

        public SubRede inserirSubRede()
        {
            SubRede hosts = new SubRede();
            hosts.Hosts = Convert.ToInt32(numHosts.Value);
            hosts.SomaIDBroadcast = (hosts.Hosts + 2);
            hosts.Total = controlVLSM.TotalHostsPotencia2(hosts.SomaIDBroadcast, 0);
            return hosts;
        }
        private void ExecCalculoSubRede()
        {
            IPBase SubIP = controlVLSM.PesquisaDadosIPBase(mskIP.Text);
            int qntSubRedes = controlVLSM.QuantidadeSubRedes();
            List<SubRede> listasubredes = controlVLSM.listaSubRedes();

            richResult.AppendText("Utilizando o IP base: " + SubIP.EnderecoIP + newLine);
            richResult.AppendText("Classe: " + SubIP.Classe + newLine);
            richResult.AppendText("Máscara padrão: " + SubIP.MascaraPadrao + newLine);
            richResult.AppendText(controlVLSM.ListaDadosSubRede(qntSubRedes, SubIP, listasubredes)); ;
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controlVLSM.ParticipantesdoGrupo(),"Integrantes");
        }
    }
}
