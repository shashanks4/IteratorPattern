using System;
namespace EmployeeIterator.Example
{
//Iterator class
    public interface IAbstractIterator
    {
         Employee First();
         Employee Next();
         bool IsCompleted { get; }
    }
}