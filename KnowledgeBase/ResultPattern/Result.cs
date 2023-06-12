namespace KnowledgeBase.ResultPattern;

/// <summary>
/// Результат выполнения
/// </summary>
public abstract class Result
{
    /// <summary>
    /// Сообщение (об ошибке)
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// Есть ли ошибка
    /// </summary>
    public bool HasError { get; set; }
}

/// <summary>
/// Результат выполения, содержащий объект
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class Result<T> : Result
{
    /// <summary>
    /// .ctor
    /// </summary>
    /// <param name="data"></param>
    protected Result(T data)
    {
        ResponseObject = data;
    }

    /// <summary>
    /// Возвращаемое значение
    /// </summary>
    public T ResponseObject { get; protected set; }

    /// <summary>
    /// Возвращение результата с проверкой на ошибку
    /// </summary>
    /// <param name="errorMessage"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Result<T> CheckError(string errorMessage)
    {
        if (HasError)
        {
            Message = $"{errorMessage}. {Message}";
        }

        return this;
    }
}

/// <summary>
/// Успешный результат
/// </summary>
public class SuccessResult : Result
{
    /// <summary>
    /// .ctor
    /// </summary>
    public SuccessResult()
    {
        HasError = false;
    }
}


/// <summary>
/// Успешный результат с возвращаемым значением
/// </summary>
/// <typeparam name="T"></typeparam>
public class SuccessResult<T> : Result<T>
{
    /// <summary>
    /// .ctor
    /// </summary>
    /// <param name="data"></param>
    public SuccessResult(T data) : base(data)
    {
        HasError = false;
    }
}

/// <summary>
/// Результат с ошибкой
/// </summary>
public class ErrorResult : Result
{
    /// <summary>
    /// .ctor
    /// </summary>
    /// <param name="message"></param>
    public ErrorResult(string message)
    {
        Message = message;
        HasError = true;
    }
}

/// <summary>
/// Результат с ошибкой
/// </summary>
/// <typeparam name="T"></typeparam>
public class ErrorResult<T> : Result<T>
{
    /// <summary>
    /// .ctor
    /// </summary>
    /// <param name="message"></param>
    public ErrorResult(string? message = null) : base(default)
    {
        Message = message;
        HasError = true;

    }


    /// <summary>
    /// .ctor
    /// </summary>
    public ErrorResult(Result errorResult) : base(default)
    {
        Message = errorResult.Message;
        HasError = true;
    }
}
