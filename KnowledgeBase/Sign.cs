using KnowledgeBase.Enums;
using KnowledgeBase.ResultPattern;
using KnowledgeBase.Values;
using System.Reflection.Metadata.Ecma335;

namespace KnowledgeBase
{
    /// <summary>
    /// Признак
    /// </summary>
    public class Sign
    {
        string Name;
        SignTypes Type;
        public Value value;

        /// <summary>
        /// Метод получения названия признака
        /// </summary>
        /// <returns></returns>
        public Result<string> GetName() { return new SuccessResult<string>(Name); }

        /// <summary>
        /// Метод установки названия признака
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name) { Name = name; }

        /// <summary>
        /// Метод получения строки типа признака 
        /// </summary>
        /// <returns></returns>
        public Result<string> GetTypeString()
        {
            if (Type == SignTypes.Binary) return new SuccessResult<string>("бинарный");
            if (Type == SignTypes.Enumeration) return new SuccessResult<string>("перечислимый");
            if (Type == SignTypes.Interval) return new SuccessResult<string>("интервальный");
            return new ErrorResult<string>("Произошла ошибка при определении типа признака");
        }

        // <summary>
        /// Метод получения строки типа признака 
        /// </summary>
        /// <returns></returns>
        public new Result<SignTypes> GetType()
        {
            return new SuccessResult<SignTypes>(Type);
        }

        public Result SetType(int index)
        {
            try
            {
                Type = index switch
                {
                    0 => SignTypes.Binary,
                    1 => SignTypes.Enumeration,
                    2 => SignTypes.Interval,
                    _ => throw new ArgumentException()
                };
                return new SuccessResult();
            }
            catch(ArgumentException)
            {
                return new ErrorResult("Неправильный ввод типа признака");
            }
        }

        /// <summary>
        /// Метод получения значения признака
        /// </summary>
        /// <returns></returns>
        public string GetValue()
        {
            return value.GetValue();
        }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="n"></param>
        /// <param name="t"></param>
        public Sign(string n, string t)
        {
            Name = n;
            switch (t)
            {
                case "бинарный":
                    Type = SignTypes.Binary;
                    value = new ValueBinary();
                    break;
                case "перечислимый":
                    Type = SignTypes.Enumeration;
                    value = new ValueEnum();
                    break;
                case "интервальный":
                    Type = SignTypes.Interval;
                    value = new ValueInterval();
                    break;
            }
        }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        public Sign(string name, int type)
        {
            Name = name;
            switch (type)
            {
                case (int)SignTypes.Binary:
                    value = new ValueBinary();
                    break;
                case (int)SignTypes.Enumeration:
                    value = new ValueEnum();
                    break;
                case (int)SignTypes.Interval:
                    value = new ValueInterval();
                    break;
            }
        }
    }
}
