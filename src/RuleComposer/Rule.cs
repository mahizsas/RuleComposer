﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuleComposer
{
    public class Rule<T>:IRule<T>
    {
        private Predicate<T> Condition;
        private Action<T> RuleAction;
        
        public Rule()
        {

        }
        public void When(Predicate<T> condition)
        {
            this.Condition = condition;
           
        }

        public void Then(Action<T> action)
        {
            this.RuleAction = action;
        }

        public T Execute(T @object)
        {
            if (Condition(@object))
            {
                RuleAction(@object);
            }
            return @object;
        }


       
    }
}
