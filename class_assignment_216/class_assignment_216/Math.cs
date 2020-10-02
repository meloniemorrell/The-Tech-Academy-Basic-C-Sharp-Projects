// C# program to demonstrate the 
// value of Math Class Fields 
using System;
using System.Collections.Generic;

namespace parameterList
{

	public class Methods
	{
		
		public Methods()
		{

            static double VAT(double productCost, double currentRate)
			{
				double cR = (currentRate + 100) / 100;
				return productCost * cR;
			}



