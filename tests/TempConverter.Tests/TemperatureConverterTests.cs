using Xunit;

namespace TempConverter.Tests;

public class TemperatureConverterTests
{
    [Theory]
    [InlineData(0, 32)]
    [InlineData(100, 212)]
    [InlineData(-40, -40)]
    public void CelsiusToFahrenheit_Converts(double c, double expectedF)
    {
        Assert.Equal(expectedF, TemperatureConverter.CelsiusToFahrenheit(c), 3);
    }

    [Theory]
    [InlineData(32, 0)]
    [InlineData(212, 100)]
    [InlineData(-40, -40)]
    public void FahrenheitToCelsius_Converts(double f, double expectedC)
    {
        Assert.Equal(expectedC, TemperatureConverter.FahrenheitToCelsius(f), 3);
    }

    [Theory]
    [InlineData(0, 273.15)]
    [InlineData(100, 373.15)]
    public void CelsiusToKelvin_Converts(double c, double expectedK)
    {
        Assert.Equal(expectedK, TemperatureConverter.CelsiusToKelvin(c), 3);
    }

    [Fact]
    public void KelvinToCelsius_Converts()
    {
        Assert.Equal(0, TemperatureConverter.KelvinToCelsius(273.15), 3);
    }

    [Fact]
    public void CelsiusToKelvin_BelowAbsoluteZero_Throws()
    {
        Assert.Throws<System.ArgumentOutOfRangeException>(
            () => TemperatureConverter.CelsiusToKelvin(-300));
    }

    [Fact]
    public void KelvinToCelsius_Negative_Throws()
    {
        Assert.Throws<System.ArgumentOutOfRangeException>(
            () => TemperatureConverter.KelvinToCelsius(-1));
    }
}
