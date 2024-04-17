using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicer.Data.Invoice
{
	internal class Invoice(List<InvoiceItem> invoiceItems)
    {
		private List<InvoiceItem> invoiceItems = invoiceItems;
    }
}
