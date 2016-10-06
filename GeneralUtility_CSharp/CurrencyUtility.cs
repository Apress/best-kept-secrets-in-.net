using System;

namespace GeneralUtility_CSharp
{
	/// <summary>
	/// Manages prices in multiple currencies.
	/// </summary>
	public struct Price
	{
		public float PriceInCurrency;
		public string CurrencyCode;
		public float ExchangeRateWRTUSD;

		public Price(float fPriceInCurrency, string sCurrencyCode, float fExchangeRateWRTUSD)
		{
			this.PriceInCurrency = fPriceInCurrency;
			this.CurrencyCode=sCurrencyCode;
			this.ExchangeRateWRTUSD = fExchangeRateWRTUSD;
		}

		/// <summary>
		/// Addition of prices, optionally in two different currencies.
		/// </summary>
		/// <param name="p1">First price</param>
		/// <param name="p2">Second price</param>
		/// <returns>Summed price in the currency of the first price</returns>
		public static Price operator +(Price p1, Price p2)
		{
			Price p3;

			//If both exchange rates are the same type, just add them
			if (p1.ExchangeRateWRTUSD == p2.ExchangeRateWRTUSD)
			{
				p3 = new Price(p1.PriceInCurrency+p2.PriceInCurrency,p1.CurrencyCode,p1.ExchangeRateWRTUSD);
			}
			else
			{
				//Convert both currencies to a base currency
				float p1InUSD = p1.PriceInCurrency * p1.ExchangeRateWRTUSD;
				float p2InUSD = p2.PriceInCurrency * p2.ExchangeRateWRTUSD;

				// Add the two prices in the base currency
				// Convert the result back to the first currency type
				float p3Converted = (p1InUSD + p2InUSD) / p1.ExchangeRateWRTUSD;
				p3 = new Price(p3Converted,p1.CurrencyCode,p1.ExchangeRateWRTUSD);
			}

			return p3;
		}

	}
}

