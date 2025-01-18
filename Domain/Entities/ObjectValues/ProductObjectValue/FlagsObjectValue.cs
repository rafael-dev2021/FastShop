namespace Domain.Entities.ObjectValues.ProductObjectValue;

public class FlagsObjectValue
{
    public bool IsFavorite { get; private set; }
    public bool IsDailyOffer { get; private set; }
    public bool IsBestSeller { get; private set; }

    public void SetIsFavorite(bool isFavorite) => IsFavorite = isFavorite;
    public void SetIsDailyOffer(bool isDailyOffer) => IsDailyOffer = isDailyOffer;
    public void SetIsBestSeller(bool isBestSeller) => IsBestSeller = isBestSeller;
}