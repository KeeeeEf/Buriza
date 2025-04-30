namespace Buriza.Data.Models.Common;

public record TokenProfile(
    string TokenName,
    string TokenImageSrc,
    double TokenPriceChange,
    double TokenPriceAda,
    double TokenPriceConversion
);