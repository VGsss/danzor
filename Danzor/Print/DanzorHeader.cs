namespace Danzor.Print
{
    public class DanzorHeader
    {
        public dynamic ide { get; set; }
        public dynamic emit { get; set; }
        public dynamic dest { get; set; }
        public dynamic total { get; set; }
        public dynamic transp { get; set; }
        public dynamic cobr { get; set; }

        public DanzorHeader(dynamic nfe)
        {
            this.ide = nfe.infNFe.ide;
            this.emit = nfe.infNFe.emit;
            this.dest = nfe.infNFe.dest;
            this.total = nfe.infNFe.total;
            this.transp = nfe.infNFe.transp;
            this.cobr = nfe.infNFe.cobr;
        }
    }
}
