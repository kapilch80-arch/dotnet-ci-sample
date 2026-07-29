namespace TempConverter;

/// <summary>
/// Converts temperatures between Celsius, Fahrenheit, and Kelvin.
/// Used to demonstrate a CI pipeline (build → test → scan → publish).
/// </summary>
public static class TemperatureConverter
{
    public static double CelsiusToFahrenheit(double celsius) => celsius * 9d / 5d + 32d;

    public static double FahrenheitToCelsius(double fahrenheit) => (fahrenheit - 32d) * 5d / 9d;

    public static double CelsiusToKelvin(double celsius)
    {
        if (celsius < -273.15d)
        {
            throw new System.ArgumentOutOfRangeException(
                nameof(celsius), "Temperature cannot be below absolute zero (-273.15 °C).");
        }

        return celsius + 273.15d;
    }

    public static double KelvinToCelsius(double kelvin)
    {
        if (kelvin < 0d)
        {
            throw new System.ArgumentOutOfRangeException(
                nameof(kelvin), "Kelvin temperature cannot be negative.");
        }

        return kelvin - 273.15d;
    }
}
