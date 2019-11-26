using System;
using System.Threading;

/// <summary>
/// Семейный банковский счет
/// </summary>
class Account
{
    protected static double sum;     //баланс - сумма на счете
    protected bool error;   // true - если последняя операция не выполнена 
    protected string message;         // сообщение о результате операции
    protected double positive, negative;  // приход и расход

    public bool Error
    {
        get { return error; }
    }
    public string Message
    {
        get { return message; }
    }
    public double Positive
    {
        get { return positive; }
    }
    public double Negative
    {
        get { return negative; }
    }
    public double Sum
    {
        get { return sum; }
    }

    /// <summary>
    /// Конструктор счета
    /// </summary>
    /// <param name="Init">начальный взнос</param>
    public Account(double Init)
    {
        if (Init > 100)
        {
            sum = Init;
            positive = Init;
            negative = 0;
            error = false;
            message = "Создание счета прошло успешно";
        }
        else
        {
            sum = 0;
            positive = 0;
            negative = 0;
            error = true;
            message = "Начальный взнос должен быть > 100";
        }
    }


    /// <summary>
    /// Положить на счет
    /// </summary>
    /// <param name="s"> добавляемая сумма</param> 
    public virtual void Add(double s)
    {
        if (s > 0)
        {
            sum += s;
            error = false;
            message = " Операция начисления прошла успешно";
            positive += s;
        }
        else
        {
            error = true;
            message = "При пополнении счета сумма должна быть положительной";
        }
    }
    /// <summary>
    /// Снять со счета
    /// </summary>
    /// <param name="s"> снимаемая сумма</param> 
    public virtual void Sub(double s)
    {
        if (s < 0)
        {
            error = true;
            message = "При снятии сумма должна быть положительной";
        }
        else
            if (sum >= s)
        {
            sum -= s;
            error = false;
            message = " Операция снятия прошла успешно";
            negative += s;
        }
        else
        {
            error = true;
            message = "На счете нет запрашиваемой суммы";
        }
    }
}

