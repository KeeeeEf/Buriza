namespace Buriza.Data.Models.Common;

public record NftProfile(
    string NftName,
    string Collection,
    string NftImageSrc,
    decimal NftPrice,
    decimal NftPriceChange
);