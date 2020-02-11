using System;

public class SpaceAge
{
    private readonly double years;

    public SpaceAge(int seconds)
    {
        years = (double)seconds / 31557600;
    }

    public double OnEarth()
    {
        return years;
    }

    public double OnMercury()
    {
        double mercuryYears = years / 0.2408467;
        return mercuryYears;
    }

    public double OnVenus()
    {
        double venusYears = years / 0.61519726;
        return venusYears;
    }

    public double OnMars()
    {
        double marsYears = years / 1.8808158;
        return marsYears;
    }

    public double OnJupiter()
    {
        double jupiterYears = years / 11.862615;
        return jupiterYears;
    }

    public double OnSaturn()
    {
        double saturnYears = years / 29.447498;
        return saturnYears;
    }

    public double OnUranus()
    {
        double uranusYears = years / 84.016846;
        return uranusYears;
    }

    public double OnNeptune()
    {
        double neptuneYears = years / 164.79132;
        return neptuneYears;
    }
}