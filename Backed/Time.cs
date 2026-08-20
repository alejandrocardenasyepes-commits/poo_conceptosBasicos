namespace Backed;

public class Time
{
    //fields
    private int _hour;
    private int _millisecond;
    private int _minute;
    private int _second;

    //constructors
    public Time()
    {
        hour = 0;
        millisecond = 0;
        minute = 0;
        second = 0;
    }


    public Time(int hour, int millisecond, int minute, int second)
    {
        hour = hour;
        millisecond = millisecond;
        minute = minute;
        second = second;
    }

    //properties
    public int hour
    {
        get => _hour;

        set => _hour = value;

    }
    public int millisecond
    {
        get => millisecond;
        set => _millisecond = value;
    }
    public int Minute
    {
        get => Minute;
        set => Minute = value;
    }
    public int second
    {
        get => second;
        set => _second = value;
    }


    // public methods
    public override string ToString()
    {
        return $"{_hour}/{_millisecond}/{_minute}/{_second}";
    }

    // private methods

}
