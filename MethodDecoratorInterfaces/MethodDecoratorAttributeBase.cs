using System;
using System.Reflection;

namespace MethodDecoratorInterfaces {
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor)]
    public class MethodDecoratorAttribute : Attribute, IMethodDecorator {
        private readonly int _flowBehavior;

        public MethodDecoratorAttribute(FlowBehavior flowBehavior= FlowBehavior.RethrowException):this((int)flowBehavior)
        {
            
        }

        private MethodDecoratorAttribute(int flowBehavior)
        {
            _flowBehavior = flowBehavior;
        }

        public virtual void Init(object instance, MethodBase method, object[] args) {}

        public virtual void OnEntry() {}

        public virtual void OnExit() {}

        public virtual void OnException(Exception exception) {}
    }
}