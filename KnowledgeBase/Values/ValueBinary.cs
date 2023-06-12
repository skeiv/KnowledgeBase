namespace KnowledgeBase.Values;

/// <summary>
/// Бинарное значение
/// </summary>
public class ValueBinary : Value
{
    List<string> values;

    /// <summary>
    /// .ctor
    /// </summary>
    public ValueBinary()
    {

    }

    /// <inheritdoc />
    public override void SetValue(string s)
    {
        if (s.Split(',').Length == 2)
        {
            values = new List<string> { "да", "нет" };
        }
        else
        {
            if (s == "да")
                values = new List<string> { "да" };
            else
                values = new List<string> { "нет" };
        }
    }

    /// <inheritdoc />
    public override string GetValue()
    {
        string output = string.Join(',', values);
        return output;
    }

    /// <inheritdoc />
    public override bool IsFit(string s)
    {
        foreach (var v in values)
            if (v == s)
                return true;
        return false;
    }

    /// <inheritdoc />
    public override bool IsCorrectSet(string s)
    {
        if (s == "") return false;
        if (s.IndexOf(',') == -1) return false;
        foreach (string p in s.Split(','))
            if (p != "да" && p != "нет")
                return false;

        return true;
    }

    /// <summary>
    /// Проверка целостности
    /// </summary>
    /// <param name="signValue"></param>
    /// <param name="classValue"></param>
    /// <returns></returns>
    public static bool CheckIntegrity(ValueBinary signValue, ValueBinary classValue)
    {
        bool flag;
        foreach (string cv in classValue.values)
        {
            flag = false;
            foreach (string sv in signValue.values)
            {
                if (sv == cv)
                {
                    flag = true;
                    break;
                }
            }
            if (!flag) return false;
        }
        return true;
    }
}
