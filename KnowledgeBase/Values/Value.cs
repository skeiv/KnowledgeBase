namespace KnowledgeBase.Values;

/// <summary>
/// Значение
/// </summary>
public abstract class Value
{
    /// <summary>
    /// Метод установки значения
    /// </summary>
    /// <param name="s"></param>
    public abstract void SetValue(string s);

    /// <summary>
    /// Метод получения значения
    /// </summary>
    /// <returns></returns>
    public abstract string GetValue();

    /// <summary>
    /// Метод проверки значения
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public abstract bool IsFit(string s);

    /// <summary>
    /// Метод проверки набора
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public abstract bool IsCorrectSet(string s);
};
