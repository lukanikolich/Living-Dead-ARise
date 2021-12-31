using System;

[Serializable]
public class PersonalBestData
{
    public int score;
    public DateTime date;

    public PersonalBestData(int score, DateTime date)
    {
        this.score = score;
        this.date = date;
    }
}
