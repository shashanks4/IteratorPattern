namespace EmployeeIterator.Example
{
 public  class Iterator : IAbstractIterator
    {
        private ConcreteCollection collection;
        private int current = 0;
        private int step = 1;
        // Constructor
        public Iterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }
        // Gets first item
        public Employee First()
        {
            current = 0;
            return collection.GetEmployee(current);
        }
        // Gets next item
        public Employee Next()
        {
            current += step;
            if (!IsCompleted)
            {
                return collection.GetEmployee(current);
            }
            else
            {
                return null;
            }
        }
        // Check whether iteration is complete
        public bool IsCompleted
        {
            get { return current >= collection.Count; }
        }
    }
}