﻿using System.Linq;

namespace CreditCardValidator.Helpers
{
    internal static class ValidationHelper
    {
        public static bool IsAValidNumber(string number)
        {
            number = number.RemoveWhiteSpace();

            return (number
                .ToCharArray()
                .All(char.IsNumber) &&
                    !string.IsNullOrEmpty(number));
        }

		public static bool IsAValidLength(CardIssuer brand, int length)
		{
			var rule = CreditCardData.BrandsData[brand].Rules.First();

			return rule.Lengths.Contains(length);
		}
    }
}