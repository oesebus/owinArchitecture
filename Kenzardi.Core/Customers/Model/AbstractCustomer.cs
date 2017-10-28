using System;
namespace Customers.Model
{
	public class AbstractCustomer
	{
		protected double discountAmount;
		protected double PerProductOrderLimit;
		protected Boolean CanCancelOrder;
		protected Boolean CanEditOrder;

		public AbstractCustomer()
		{

		}
	}
}
