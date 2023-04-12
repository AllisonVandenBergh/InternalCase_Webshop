export const FormatCurrency = (currency: number) => {
    return currency.toFixed(2).toString().replace(".", ",");
}