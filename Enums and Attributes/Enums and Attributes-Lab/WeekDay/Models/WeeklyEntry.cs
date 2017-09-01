using System;

public class WeeklyEntry : IComparable<WeeklyEntry>
{
    public WeekDay WeekDay { get; private set; }

    public string Notes { get; private set; }

    public WeeklyEntry(string weekDay, string notes)
    {
        this.WeekDay = (WeekDay)Enum.Parse(typeof(WeekDay), weekDay);
        this.Notes = notes;
    }

    public int CompareTo(WeeklyEntry other)
    {
        if (ReferenceEquals(this, other))
        {
            return 0;
        }

        if (ReferenceEquals(null, other))
        {
            return 1;
        }

        var weekDayComparasion = this.WeekDay.CompareTo(other.WeekDay);

        if (weekDayComparasion != 0)
        {
            return weekDayComparasion;
        }

        return string.Compare(this.Notes, other.Notes, StringComparison.Ordinal);
    }

    public override string ToString()
    {
        return $"{this.WeekDay} - {this.Notes}";
    }
}

