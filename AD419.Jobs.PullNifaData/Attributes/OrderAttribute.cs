using System.Runtime.CompilerServices;

namespace AD419.Jobs.PullNifaData.Attributes;

/// <summary>
/// Used to ensure properties are enumerated in declaration order when reflecting
/// </summary>
[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public sealed class OrderAttribute : Attribute
{
    private readonly int order_;
    public OrderAttribute([CallerLineNumber]int order = 0)
    {
        order_ = order;
    }

    public int Order { get { return order_; } }
}