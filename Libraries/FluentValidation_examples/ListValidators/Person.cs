﻿using System.Collections.Generic;

namespace FluentValidation_examples.ListValidators
{
	public class Person
	{
		public List<string> AddressLines { get; set; } = new List<string>();
		public List<Order> Orders { get; set; } = new List<Order>();
	}
}