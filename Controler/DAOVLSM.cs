using System.Collections.Generic;
using System.Linq;
using ModelSubRedes;

namespace DAOCalVLSM
{
    class DAOVLSM
    {
        private List<SubRede> listasubrede = new List<SubRede>();

        public int QuantidadeSubRedesExistentes()
        {
            return listasubrede.Count;
        }

        public void addSubRede(SubRede subrede)
        {
            listasubrede.Add(subrede);
        }

        public void ordenarListaDecrescente()
        {
            listasubrede = listasubrede.OrderByDescending(x => x.Total).ToList();
        }

        internal List<SubRede> listaGeralSubrede()
        {
            return listasubrede;
        }

        public void limpaLista()
        {
            listasubrede.Clear();
        }

        public bool AvaliaRangeHostsClasse(char classe)
        {
            bool rangecorreto = false;

            double totalhosts = 0;
            foreach (SubRede host in listasubrede)
            {
                totalhosts += host.Total;
            }

            if (classe == 'A' && totalhosts <= 16777216 || classe == 'B' && totalhosts <= 65536 || classe == 'C' && totalhosts <= 256)
            {
                rangecorreto = true;
            }
            else
            {
                rangecorreto = false;
            }

            return rangecorreto;
        }
    }
}
