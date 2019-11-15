namespace ModelSubRedes
{
    public class SubRede
    {
        private int Hostsbase { get; set; }
        private int Somahosts { get; set; }
        private double Totalhosts { get; set; }

        public int Hosts
        {
            get { return Hostsbase; }
            set { Hostsbase = value; }
        }
        public int SomaIDBroadcast
        {
            get { return Somahosts; }
            set { Somahosts = value; }
        }
        public double Total
        {
            get { return Totalhosts; }
            set { Totalhosts = value; }
        }
    }
}
