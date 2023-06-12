using System.Globalization;

namespace KnowledgeBase.Values;

/// <summary>
/// Интервальное значение
/// </summary>
public class ValueInterval : Value
{
    float leftValue;
    float rightValue;

    public ValueInterval() { }

    /// <inheritdoc />
    public override void SetValue(string s)
    {
        string[] parts = s.Split(':');
        IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
        leftValue = float.Parse(parts[0], formatter);
        rightValue = float.Parse(parts[1], formatter);
    }

    /// <inheritdoc />
    public override string GetValue()
    {
        return leftValue.ToString(System.Globalization.CultureInfo.InvariantCulture) + ":" + rightValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    }

    /// <inheritdoc />
    public override bool IsFit(string s)
    {
        IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
        float currValue = float.Parse(s);
        if (leftValue <= currValue && currValue <= rightValue)
            return true;
        else
            return false;
    }

    /// <inheritdoc />
    public override bool IsCorrectSet(string s)
    {
        if (s == "")
            return false;
        string[] parts = s.Split(':');
        if (parts.Length != 2)
            return false;
        IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
        float tleft = float.Parse(parts[0], formatter);
        float tright = float.Parse(parts[1], formatter);
        if (tleft > tright)
            return false;
        return true;
    }

    /// <summary>
    /// Проверка целостности
    /// </summary>
    /// <param name="signValue"></param>
    /// <param name="classValue"></param>
    /// <returns></returns>
    public static bool CheckIntegrity(ValueInterval signValue, ValueInterval classValue)
    {
        return (classValue.leftValue >= signValue.leftValue && classValue.rightValue <= signValue.rightValue);
    }
}
