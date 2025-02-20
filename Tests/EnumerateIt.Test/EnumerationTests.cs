
namespace EnumerateIt.Test
{
#pragma warning disable CS1718
    public class EnumerationTests
    {
        [Test]
        public void Enumeration_Id()
        {
            Assert.That(TestEnum.Test.Id, Is.EqualTo(1));
        }

        [Test]
        public void Enumeration_Name()
        {
            Assert.That(TestEnum.Test.Name, Is.EqualTo("Test"));
        }

        [Test]
        public void Enumeration_ToString()
        {
            Assert.That(TestEnum.Test.ToString(), Is.EqualTo("Test"));
        }

        [Test]
        public void Enumeration_ToString_Name()
        {
            Assert.That(TestEnum.Test.ToString(), Is.SameAs(TestEnum.Test.Name));
        }

        [Test]
        public void Enumeration_DirectCast()
        {
            Assert.That((string)TestEnum.Test, Is.EquivalentTo(TestEnum.Test.Name));
        }

        [Test]
        public void Enumeration_ToLower()
        {
            Assert.That(TestEnum.Test.ToLower(), Is.EqualTo("test"));
        }

        [Test]
        public void Enumeration_CompareTo()
        {
            Assert.That(TestEnum.Test.CompareTo(TestEnum.Test), Is.EqualTo(0));
        }

        [Test]
        public void Enumeration_CompareTo_Unequal()
        {
            Assert.That(TestEnum.Test.CompareTo(TestEnum.Two), Is.EqualTo(-1));
        }

        [Test]
        public void Enumeration_CompareTo_NewSame()
        {
            Assert.That(TestEnum.Test.CompareTo(new TestEnum(1, "Test")), Is.EqualTo(0));
        }

        [Test]
        public void Enumeration_CompareTo_UnequalId()
        {
            Assert.That(TestEnum.Test.CompareTo(new TestEnum(2, "Test")), Is.EqualTo(-1));
        }

        [Test]
        public void Enumeration_CompareTo_UnequalName()
        {
            Assert.That(TestEnum.Test.CompareTo(new TestEnum(1, "a")), Is.EqualTo(-1));
        }

        [Test]
        public void Enumeration_Compare()
        {
            Assert.That(TestEnum.Compare(TestEnum.Test, TestEnum.Test), Is.EqualTo(0));
        }

        [Test]
        public void Enumeration_Compare_Unequal()
        {
            Assert.That(TestEnum.Compare(TestEnum.Test, TestEnum.Two), Is.EqualTo(-1));
        }

        [Test]
        public void Enumeration_Compare_NewInstance()
        {
            Assert.That(TestEnum.Compare(TestEnum.Test, new TestEnum(1, "Test")), Is.EqualTo(0));
        }


        [Test]
        public void Enumeration_Equals()
        {
            Assert.That(TestEnum.Test.Equals(TestEnum.Test), Is.True);
        }

        [Test]
        public void Enumeration_Equals_Unequal()
        {
            Assert.That(TestEnum.Test.Equals(TestEnum.Two), Is.False);
        }

        [Test]
        public void Enumeration_Equals_NewInstance()
        {
            Assert.That(TestEnum.Test.Equals(new TestEnum(1, "Test")), Is.True);
        }

        [Test]
        public void Enumeration_GetHashCode()
        {
            Assert.That(TestEnum.Test.GetHashCode(), Is.Not.EqualTo(0));
        }

        [Test]
        public void Enumeration_Equals_Operator()
        {
            Assert.That(TestEnum.Test == TestEnum.Test, Is.True);
        }

        [Test]
        public void Enumeration_Equals_Operator_Invert()
        {
            Assert.That(TestEnum.Test == TestEnum.Two, Is.False);
        }

        [Test]
        public void Enumeration_Unequals_Operator()
        {
            Assert.That(TestEnum.Test != TestEnum.Two, Is.True);
        }

        [Test]
        public void Enumeration_Unequals_Operator_Invert()
        {
            Assert.That(TestEnum.Test != TestEnum.Test, Is.False);
        }

        [Test]
        public void Enumeration_Smaller_Operator()
        {
            Assert.That(TestEnum.Test < TestEnum.Two, Is.True);
        }

        [Test]
        public void Enumeration_Smaller_Operator_Invert()
        {
            Assert.That(TestEnum.Two < TestEnum.Test, Is.False);
        }

        [Test]
        public void Enumeration_SmallerEquals_Operator()
        {
            Assert.That(TestEnum.Test <= TestEnum.Two, Is.True);
        }

        [Test]
        public void Enumeration_SmallerEquals_Operator_Invert()
        {
            Assert.That(TestEnum.Two <= TestEnum.Test, Is.False);
        }

        [Test]
        public void Enumeration_SmallerEquals_Operator_Same()
        {
            Assert.That(TestEnum.Test <= TestEnum.Test, Is.True);
        }

        [Test]
        public void Enumeration_Greater_Operator()
        {
            Assert.That(TestEnum.Two > TestEnum.Test, Is.True);
        }

        [Test]
        public void Enumeration_Greater_Operator_Invert()
        {
            Assert.That(TestEnum.Test > TestEnum.Two, Is.False);
        }

        [Test]
        public void Enumeration_GreaterEquals_Operator()
        {
            Assert.That(TestEnum.Two >= TestEnum.Test, Is.True);
        }

        [Test]
        public void Enumeration_GreaterEquals_Operator_Invert()
        {
            Assert.That(TestEnum.Test >= TestEnum.Two, Is.False);
        }

        [Test]
        public void Enumeration_GreaterEquals_Operator_Same()
        {
            Assert.That(TestEnum.Test >= TestEnum.Test, Is.True);
        }

        [Test]
        public void Enumeration_Compare_String()
        {
            Assert.That(TestEnum.Test == "Test");
        }

        [Test]
        public void Enumeration_StringEnum_Compare_New()
        {
            Assert.That(StringEnum.StringOne, Is.EqualTo(new StringEnum("one")));
        }

        [Test]
        public void Enumeration_StringEnum_Compare_String()
        {
            Assert.That(StringEnum.StringOne == "one");
        }

        public class TestEnum : Enumeration
        {
            public static readonly TestEnum Test = new TestEnum(1, "Test");

            public static readonly TestEnum Two = new TestEnum(2, "Two");

            public TestEnum(int id, string name) : base(id, name)
            {
            }
        }

        public class StringEnum : Enumeration
        {
            public static readonly StringEnum StringOne = new StringEnum("one");

            public static readonly StringEnum StringTwo = new StringEnum("two");

            public StringEnum(string name) : base(name)
            {
            }
        }
    }
#pragma warning restore CS1718
}