class Safe_Account: Account
    {
        static object Locker = new object();        
       
       public Safe_Account(double Init): base (Init)
       {
          
       }       
        /// <summary>
        /// Положить на счет
        /// </summary>
        /// <param name="s"> добавляемая сумма</param> 
        public override void Add(double s)
        {
            lock (Locker)
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
                  message = "При пополнении сумма должна быть положительной";
                } 
            }
        }
        /// <summary>
        /// Снять со счета
        /// </summary>
        /// <param name="s"> снимаемая сумма</param> 
        public override void Sub(double s)
        {
            lock (Locker)
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
    }