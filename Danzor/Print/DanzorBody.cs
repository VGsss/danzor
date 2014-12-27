using System.Collections.Generic;
using System.Linq;

namespace Danzor.Print
{
    public class DanzorBody
    {
        public dynamic nfe { get; set; }
        public dynamic det { get; set; }

        public DanzorBody(dynamic nfe, int page, int size)
        {
            this.nfe = nfe;
            GetDetItens(page - 1);
        }

        private void GetDetItens(int page)
        {
            var list = this.nfe.infNFe.det as List<DanzorDynamicXml>;
            var size = page * DanzorPrintManager.MAX_ITEM_PER_PAGE;

            this.det = list.Skip(size).Take(DanzorPrintManager.MAX_ITEM_PER_PAGE);
        }
    }
}
