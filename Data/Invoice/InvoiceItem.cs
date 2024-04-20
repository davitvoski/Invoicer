namespace Invoicer.Data.Invoice
{
	public class InvoiceItem
	{
		private Decimal totalPrice;
		
		public String Description { get; set; } = "";

		public DateOnly Date { get; set; }

		public int Quantity
		{ get; set; } = 1;

		public Decimal Price { get; set; } = 0;

		public Decimal TotalPrice { 
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
			this.totalPrice =  Quantity * Price;
		}

		public override string ToString()
		{
			return "Description: " + this.Description + " | Date: " + this.Date.ToString() + " | Quantity: " + this.Quantity + " | Price: " + this.Price + " | totalPrice: " + this.totalPrice;
		}
	}
}
