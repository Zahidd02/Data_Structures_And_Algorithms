using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayList_Exercise_1
{
    public class Order
    {
		private int orderId;
		private List<String> itemNames;
		private bool cashOnDelivery;

		public Order(int orderId, List<String> itemNames, bool cashOnDelivery)
		{
			this.orderId = orderId;
			this.itemNames = itemNames;
			this.cashOnDelivery = cashOnDelivery;
		}

		public int getOrderId()
		{
			return orderId;
		}

		public void setOrderId(int orderId)
		{
			this.orderId = orderId;
		}

		public List<String> getItemNames()
		{
			return itemNames;
		}

		public void setItemNames(List<String> itemNames)
		{
			this.itemNames = itemNames;
		}

		public bool isCashOnDelivery()
		{
			return cashOnDelivery;
		}

		public void setCashOnDelivery(bool cashOnDelivery)
		{
			this.cashOnDelivery = cashOnDelivery;
		}
	}
}
