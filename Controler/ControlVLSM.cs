using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ModelIPBase;
using ModelSubRedes;
using DAOCalVLSM;

namespace ControlerVLSM
{
    class ControlVLSM
    {
        DAOVLSM daovlsm = new DAOVLSM();
        string newLine = "\r\n";
        string separasubredes = "****************************************************";

        public IPBase PesquisaDadosIPBase(string ipbase)
        {
            IPBase dadosIPBase = new IPBase();

            string[] separaclasse = ipbase.Split(',');
            try
            {
                if (separaclasse[0] != "   " && separaclasse[1] != "   " && separaclasse[2] != "   " && separaclasse[3] != "")
                {
                    int addr1 = Convert.ToInt32(separaclasse[0]);
                    int addr2 = Convert.ToInt32(separaclasse[1]);
                    int addr3 = Convert.ToInt32(separaclasse[2]);
                    int addr4 = Convert.ToInt32(separaclasse[3]);

                    bool rangeIpcorreto = true;

                    rangeIpcorreto = ValidaRangeIP(addr2, 0, 255);
                    rangeIpcorreto &= ValidaRangeIP(addr3, 0, 255);
                    rangeIpcorreto &= ValidaRangeIP(addr4, 0, 255);

                    if (rangeIpcorreto)
                    {
                        if (addr1 > 0 && 128 > addr1)
                        {
                            dadosIPBase.Classe = 'A';
                            dadosIPBase.EnderecoIP = $"{addr1}.{addr2}.{addr3}.{addr4}";
                            dadosIPBase.MascaraPadrao = "255.0.0.0";
                            dadosIPBase.EnderecoIPBIN = $"{Binario(addr1)}.{Binario(addr2)}.{Binario(addr3)}.{Binario(addr4)}";
                            dadosIPBase.MascaraPadraoBIN = "11111111.00000000.00000000.00000000";
                        }
                        else if (addr1 > 127 && 192 > addr1)
                        {
                            dadosIPBase.Classe = 'B';
                            dadosIPBase.EnderecoIP = $"{addr1}.{addr2}.{addr3}.{addr4}";
                            dadosIPBase.MascaraPadrao = "255.255.0.0";
                            dadosIPBase.EnderecoIPBIN = $"{Binario(addr1)}.{Binario(addr2)}.{Binario(addr3)}.{Binario(addr4)}";
                            dadosIPBase.MascaraPadraoBIN = "11111111.11111111.00000000.00000000";
                        }
                        else if (addr1 > 191 && 224 > addr1)
                        {
                            dadosIPBase.Classe = 'C';
                            dadosIPBase.EnderecoIP = $"{addr1}.{addr2}.{addr3}.{addr4}";
                            dadosIPBase.MascaraPadrao = "255.255.255.0";
                            dadosIPBase.EnderecoIPBIN = $"{Binario(addr1)}.{Binario(addr2)}.{Binario(addr3)}.{Binario(addr4)}";
                            dadosIPBase.MascaraPadraoBIN = "11111111.11111111.11111111.00000000";
                        }
                        else if (addr1 >= 224 && 241 > addr1)
                        {
                            MessageBox.Show("Somente endereços Classe A, B e C são permitidos", "Classe não permitida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dadosIPBase = null;
                        }
                        else
                        {
                            MessageBox.Show("Endereço IP inválido", "Endereço inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dadosIPBase = null;
                        }
                    }
                }
                else
                {
                    dadosIPBase = null;
                }
            }
            catch
            {
                MessageBox.Show("Erro na Digitação do IP Base para início da Calculadora VLSM", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return dadosIPBase;
        }

        private bool ValidaRangeIP(int addr, int min, int max)
        {
            bool rangecorreto = true;

            if (min <= addr && addr <= max)
            {
                rangecorreto = true;
            }
            else
            {
                MessageBox.Show("Range de IP invalido");
                rangecorreto = false;
            }
            return rangecorreto;
        }

        public string Binario(int addr)
        {
            string ret = string.Empty;
            int count = 0;

            while (addr > 0)
            {
                int init = addr % 2;
                addr /= 2;
                ret = init.ToString() + ret;
                count++;
            }
            for (int i = 0; i < 8 - count; i++)
            {
                ret = "0" + ret;
            }
            return ret;
        }

        public double TotalHostsPotencia2(int somaIDBroad, double potencia)
        {
            int i = 0;
            while (somaIDBroad > potencia)
            {
                potencia = Math.Pow(2, i);
                i++;
            }
            return potencia;
        }
        public void incluir(SubRede hosts)
        {
            daovlsm.addSubRede(hosts);
        }

        public void ordenaLista()
        {
            daovlsm.ordenarListaDecrescente();
        }

        public void ZeraLista()
        {
            daovlsm.limpaLista();
        }

        public int QuantidadeSubRedes()
        {
            return daovlsm.QuantidadeSubRedesExistentes();
        } 

        public List<SubRede> listaSubRedes()
        {
            return daovlsm.listaGeralSubrede();
        }

        public bool CheckLimiteHosts(char classe)
        {
            return daovlsm.AvaliaRangeHostsClasse(classe);
        }

        public string SomaHostsSubRede(string Ipbase, double total, char classe)
        {
            string[] separaip = Ipbase.Split('.');
            int addr1 = Convert.ToInt32(separaip[0]);
            int addr2 = Convert.ToInt32(separaip[1]);
            int addr3 = Convert.ToInt32(separaip[2]);
            int addr4 = Convert.ToInt32(separaip[3]);
            int addrAcum = addr4 + Convert.ToInt32(total);

            if (classe == 'A')
            {
                if (addrAcum < 256)
                {
                    Ipbase = $"{addr1}.{addr2}.{addr3}.{addrAcum--}";
                }
                else
                {
                    while (addrAcum >= 256)
                    {
                        addrAcum = addrAcum - 256;
                        addr3++;
                        while (addr3 >= 256)
                        {
                            addr3 = addr3 - 256;
                            addr2++;
                            while (addrAcum >= 256)
                            {
                                addrAcum = addrAcum - 256;
                                addr3++;
                            }

                        }
                    }
                    Ipbase = $"{addr1}.{addr2}.{addr3}.{addrAcum}";
                }
            }
            else if (classe == 'B')
            {
                if (addrAcum < 256)
                {
                    Ipbase = $"{addr1}.{addr2}.{addr3}.{addrAcum}";
                }
                else
                {
                    while (addrAcum > 256)
                    {
                        addrAcum = addrAcum - 256;
                        addr3++;
                    }
                    Ipbase = $"{addr1}.{addr2}.{addr3}.{addrAcum}";
                }
            }
            else if (classe == 'C')
            {
                Ipbase = $"{addr1}.{addr2}.{addr3}.{(addr4 + total)}";
            }
            return Ipbase;
        }

        public string convertBinarioSubRedes(string convertbinario)
        {
            string[] separar = convertbinario.Split('.');

            int addr1 = Convert.ToInt32(separar[0]);
            int addr2 = Convert.ToInt32(separar[1]);
            int addr3 = Convert.ToInt32(separar[2]);
            int addr4 = Convert.ToInt32(separar[3]);
            string addr1bin = Binario(addr1);
            string addr2bin = Binario(addr2);
            string addr3bin = Binario(addr3);
            string addr4bin = Binario(addr4);
            return convertbinario = $"{addr1bin}.{addr2bin}.{addr3bin}.{addr4bin}";
        }
        public string Broadcast(string ipbase)
        {
            string[] separaclasse = ipbase.Split('.');
            int addr1 = Convert.ToInt32(separaclasse[0]);
            int addr2 = Convert.ToInt32(separaclasse[1]);
            int addr3 = Convert.ToInt32(separaclasse[2]);
            int addr4 = Convert.ToInt32(separaclasse[3]) - 1;

            int Broadnum3 = addr3 - 1;

            if (addr4 == -1)
            {
                addr4 = 255;
                addr3 = addr3 - 1;
                if (Broadnum3 == -1)
                {
                    addr3 = 255;
                    addr2 = addr2 - 1;
                }
            }
            return ipbase = $"{addr1}.{addr2}.{addr3}.{addr4}";
        }

        public string SomaMaskCustom(double total, char classe)
        {
            string mascaraCustomizada = "";
            switch (classe)
            {
                case 'A':
                    mascaraCustomizada = maskA(total);
                    break;
                case 'B':
                    mascaraCustomizada = maskB(total);
                    break;
                case 'C':
                    mascaraCustomizada = maskC(total);
                    break;
            }
            return mascaraCustomizada;
        }

        public string maskA(double host)
        {
            int addr1 = 255;
            int addr2 = 0;
            int addr3 = 0;
            int addr4 = 0;
            string mascaraCustom = "";
            switch (host)
            {
                case 16777216:
                    addr2 = 0;
                    break;
                case 8388608:
                    addr2 = 128;
                    break;
                case 4194304:
                    addr2 = 192;
                    break;
                case 2097152:
                    addr2 = 224;
                    break;
                case 1048576:
                    addr2 = 224;
                    break;
                case 524288:
                    addr2 = 248;
                    break;
                case 262144:
                    addr2 = 252;
                    break;
                case 131072:
                    addr2 = 254;
                    break;
                case 65536:
                    addr2 = 255;
                    addr3 = 128;
                    break;
                case 32768:
                    addr2 = 255;
                    addr3 = 192;
                    break;
                case 16384:
                    addr2 = 255;
                    addr3 = 224;
                    break;
                case 8192:
                    addr2 = 255;
                    addr3 = 240;
                    break;
                case 4096:
                    addr2 = 255;
                    addr3 = 248;
                    break;
                case 2048:
                    addr2 = 255;
                    addr3 = 252;
                    break;
                case 1024:
                    addr2 = 255;
                    addr3 = 254;
                    break;
                case 512:
                    addr2 = 255;
                    addr3 = 255;
                    break;
                case 256:
                    addr2 = 255;
                    addr3 = 255;
                    break;
                case 128:
                    addr2 = 255;
                    addr3 = 255;
                    addr4 = 128;
                    break;
                case 64:
                    addr2 = 255;
                    addr3 = 255;
                    addr4 = 192;
                    break;
                case 32:
                    addr2 = 255;
                    addr3 = 255;
                    addr4 = 224;
                    break;
                case 16:
                    addr2 = 255;
                    addr3 = 255;
                    addr4 = 240;
                    break;
                case 8:
                    addr2 = 255;
                    addr3 = 255;
                    addr4 = 248;
                    break;
                case 4:
                    addr2 = 255;
                    addr3 = 255;
                    addr4 = 252;
                    break;
            }
            mascaraCustom = $"{addr1}.{addr2}.{addr3}.{addr4}";

            return mascaraCustom;
        }

        public string maskB(double host)
        {
            int addr1 = 255;
            int addr2 = 255;
            int addr3 = 0;
            int addr4 = 0;
            string mascaraCustom = "";
            switch (host)
            {
                case (65536):
                    addr3 = 0;
                    break;
                case (32768):
                    addr3 = 128;
                    break;
                case (16384):
                    addr3 = 192;
                    break;
                case (8192):
                    addr3 = 224;
                    break;
                case (4096):
                    addr3 = 240;
                    break;
                case (2048):
                    addr3 = 248;
                    break;
                case (1024):
                    addr3 = 252;
                    break;
                case (512):
                    addr3 = 254;
                    break;
                case (256):
                    addr3 = 255;
                    break;
                case (128):
                    addr3 = 255;
                    addr4 = 128;
                    break;
                case (64):
                    addr3 = 255;
                    addr4 = 192;
                    break;
                case (32):
                    addr3 = 255;
                    addr4 = 224;
                    break;
                case (16):
                    addr3 = 255;
                    addr4 = 240;
                    break;
                case (8):
                    addr3 = 255;
                    addr4 = 248;
                    break;
                case (4):
                    addr3 = 255;
                    addr4 = 252;
                    break;
            }
            mascaraCustom = $"{addr1}.{addr2}.{addr3}.{addr4}";
            return mascaraCustom;
        }
        public string maskC(double host)
        {
            int addr1 = 255;
            int addr2 = 255;
            int addr3 = 255;
            int addr4 = 0;
            string mascaraCustom = "";
            switch (host)
            {
                case (256):
                    addr4 = 0;
                    break;
                case (128):
                    addr4 = 128;
                    break;
                case (64):
                    addr4 = 192;
                    break;
                case (32):
                    addr4 = 224;
                    break;
                case (16):
                    addr4 = 240;
                    break;
                case (8):
                    addr4 = 248;
                    break;
                case (4):
                    addr4 = 252;
                    break;

                default:
                    break;
            }
            mascaraCustom = $"{addr1}.{addr2}.{addr3}.{addr4}";
            return mascaraCustom;
        }

        public string ListaDadosSubRede(int quantiadeSubRedes, IPBase SubIP, List<SubRede> listasubredes)
        {
            string subrede = string.Empty;
            int loop = 0;

            foreach (SubRede host in listasubredes)
            {

                string ipsubrede = SubIP.EnderecoIP;
                double totalHosts = listasubredes[loop].Total;
                string somasubrede = SubIP.EnderecoIP = SomaHostsSubRede(ipsubrede, totalHosts, SubIP.Classe);

                string somaMaskCustom = SomaMaskCustom(totalHosts, SubIP.Classe);
                string broadcastSubrede = Broadcast(SubIP.EnderecoIP);
                subrede += (newLine + separasubredes + newLine);
                subrede += ($"Subrede {loop} : {ipsubrede} / {somaMaskCustom}" + newLine);
                subrede += ("Endereço IP ID de Rede binario: " + newLine);
                subrede += (convertBinarioSubRedes(ipsubrede) + newLine);
                subrede += ("Máscara customizada binario:" + newLine);
                subrede += (convertBinarioSubRedes(somaMaskCustom) + newLine);
                subrede += ($"Broadcast: {broadcastSubrede}" + newLine);
                subrede += ("Endereço IP Broadcast Binario:" + newLine);
                subrede += (convertBinarioSubRedes(broadcastSubrede) + newLine);
                subrede += ($"A Subrede {loop} possui um total de {totalHosts} hosts " + newLine);
                loop++;
            }
            return subrede;
        }

        public string ParticipantesdoGrupo()
        {
            var creditos = "André Luis Martinelli RA: 2019203023 (Calouro)\n" + "Carlos Eduardo Klein RA: 2019100129 \n" + "Daniel de Oliveira Sens RA: 2019100972 \n";
            return creditos.ToString();
        }

    }
}
