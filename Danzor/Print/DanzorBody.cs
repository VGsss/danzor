using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danzor.Print
{
    public class DanzorBody
    {
        public int page { get; set; }
        public int size { get; set; }

        public dynamic nfe { get; set; }
        public dynamic det { get; set; }

        public DanzorBody(dynamic nfe, int page, int size)
        {
            this.page = page;
            this.size = size;

            this.nfe = nfe;
            GetDetItens(page - 1);
        }

        private void GetDetItens(int page)
        {
            var items = (List<DanzorDynamicXml>)this.nfe.infNFe.det;
            var skippages = page * DanzorPrintManager.ITEM_PER_PAGE;

            this.det = items.Skip(skippages).Take(DanzorPrintManager.ITEM_PER_PAGE);
        }
    }
}
