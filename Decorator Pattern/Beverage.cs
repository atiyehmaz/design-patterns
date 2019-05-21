namespace Decorator_Pattern
{
    public abstract class Beverage
    {
        public virtual string Description => "Unknown Beverage";

        public virtual string getDescription()
        {
            return Description;
        }

        public abstract double Cost();
    }
}
