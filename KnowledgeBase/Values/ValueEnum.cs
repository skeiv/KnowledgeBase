namespace KnowledgeBase.Values;

/// <summary>
/// Перечисляемое значение
/// </summary>
public class ValueEnum : Value
{
    List<string> values;

    /// <summary>
    /// .ctor
    /// </summary>
    public ValueEnum()
    {
        values = new List<string>();
    }

    /// <inheritdoc />
    public override void SetValue(string s)
    {
        values = new List<string>();
        string[] parts = s.Split(',');
        foreach (string part in parts)
            values.Add(part);
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
        if (s == "")
            return false;
        return true;
    }

    /// <summary>
    /// проверка целостности
    /// </summary>
    /// <param name="signValue"></param>
    /// <param name="classValue"></param>
    /// <returns></returns>
    public static bool CheckIntegrity(ValueEnum signValue, ValueEnum classValue)
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
