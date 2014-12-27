namespace Danzor.Print
{
    public class DanzorFooter
    {
        public dynamic infAdic { get; set; }
        public dynamic protNFe { get; set; }

        public DanzorFooter(dynamic nfe, dynamic protNFe)
        {
            this.infAdic = nfe.infNFe.infAdic;
            this.protNFe = protNFe;
        }
    }

}
