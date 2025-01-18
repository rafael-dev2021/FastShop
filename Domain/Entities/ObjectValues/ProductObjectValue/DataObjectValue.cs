namespace Domain.Entities.ObjectValues.ProductObjectValue;

public class DataObjectValue
{
    public string ReleaseMonth { get; private set; } = string.Empty;
    public int ReleaseYear { get; private set; }

    public void SetReleaseMonth(string releaseMonth) => ReleaseMonth = releaseMonth;
    public void SetReleaseYear(int releaseYear) => ReleaseYear = releaseYear;
}