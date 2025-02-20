# EnumerateIt
Custom enums

Even a string can be cast or compared to a Enumeration

```
public class TestEnum : Enumeration
{
    public TestEnum(int id, string name) : base(id, name)
    {
    }

    public static readonly TestEnum One = new(1, "one");

    public static readonly TestEnum Two = new(2, "two");

    public static readonly TestEnum Three = new(3, "three");
}

public class SimpleEnum : Enumeration
{
    public SimpleEnum(string name) : base(name)
    {
    }

    public static readonly SimpleEnum One = new("one");

    public static readonly SimpleEnum Two = new("two");

    public static readonly SimpleEnum Three = new("three");
}
```

```
Assert.That(SimpleEnum.One == SimpleEnum.One);
Assert.That(SimpleEnum.One == new SimpleEnum("one"));
Assert.That(SimpleEnum.One == "one");
```

