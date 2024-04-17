using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicer.Data.Invoice
{
	public class InvoiceItem
	{

		private int totalPrice;
		
		required
		public String Description { get; set; } = "";

		required
		public String? Date { get; set; }

		required
		public int Unit
		{ get; set; } = 1;

		required
		public int Price { get; set; }

		public int TotalPrice { 
			get 
			{
				CalculateTotalPrice();
				return this.totalPrice;
			}
		}

		/**
		 * Calculate the totale price of the invoice item.
		 */
		public void CalculateTotalPrice()
		{
			this.totalPrice = Unit * Price;
		}


	}
}
