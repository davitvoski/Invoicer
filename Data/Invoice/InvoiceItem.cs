namespace Invoicer.Data.Invoice
{
	public class InvoiceItem()
	{
		public String Description { get; set; } = "";

		public DateTime Date { get; set; } = DateTime.Today;

		public int Quantity
		{ get; set; } = 1;

		public Decimal Price { get; set; } = 0;

		public Decimal TotalPrice { 
			get 
			{
				return  Quantity * Price;
			}
			set
			{
				//Set the total price
			}
		}
	
		public override string ToString()
		{
			return "Description: " + this.Description + " | Date: " + this.Date.ToString() + " | Quantity: " + this.Quantity + " | Price: " + this.Price + " | totalPrice: " + this.TotalPrice;
		}
	}
}
