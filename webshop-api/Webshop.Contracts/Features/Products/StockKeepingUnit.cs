using System.Globalization;
using System.Text.RegularExpressions;

namespace Webshop.Contracts.Features.Products
{
    [Serializable]
    public partial record class StockKeepingUnit
    {
        public string Value { get; }

        public StockKeepingUnit(string value)
        {
            Value = value;
        }

        private static bool IsValid(string? value)
        {
            return !string.IsNullOrEmpty(value) && MyRegex().IsMatch(value);
        }

        public static bool TryParse(string? value, out StockKeepingUnit result)
        {
            if (IsValid(value))
            {
                result = new StockKeepingUnit(value!);
                return true;
            }

            result = default!;
            return false;
        }

        public override string ToString()
        {
            return Value.ToString(CultureInfo.InvariantCulture);
        }

        public static StockKeepingUnit ConvertToStockKeepingUnit(string value)
        {
            if (TryParse(value, out var result))
            {
                return result;
            }

            throw new ArgumentException("Invalid value for the StockKeepingUnit", paramName: nameof(value));
        }

        [GeneratedRegex("^[a-zA-Z0-9_-]{8,12}$")]
        private static partial Regex MyRegex();
    }
}