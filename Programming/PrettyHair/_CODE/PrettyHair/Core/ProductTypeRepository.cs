﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core {
	class ProductTypeRepository {
		private Dictionary<int, ProductType> Repository = new Dictionary<int, ProductType>();
		// TODO: Update Diagram ^^
		public bool AdjustPrice(ProductType productType, double price) {	
			productType.SetPrice(price);
			return true;
		}

		public bool AdjustDescription(ProductType productType, string desc) {
			productType.SetDescription(desc);
			return true;
		}
	}
}
