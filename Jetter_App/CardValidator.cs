using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jetter_App
{
    public class CardValidator
    {
        public static bool ValidateCardNumber(string cardNumber)
        {
            cardNumber = cardNumber.Replace(" ", "").Replace("-", "");

            if (string.IsNullOrEmpty(cardNumber) || !long.TryParse(cardNumber, out _))
            {
                return false;
            }

            int sum = 0;
            bool isEven = false;

            for (int i = cardNumber.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(cardNumber[i].ToString());

                if (isEven)
                {
                    digit *= 2;

                    if (digit > 9)
                    {
                        digit -= 9;
                    }
                }

                sum += digit;
                isEven = !isEven;
            }

            return sum % 10 == 0;
        }
    }
}
