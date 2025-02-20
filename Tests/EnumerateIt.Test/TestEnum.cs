using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerateIt.Test
{
    public class TestEnum : Enumeration
    {
        public TestEnum(int id, string name) : base(id, name)
        {
        }

        public static readonly TestEnum One = new(1, "one");

        public static readonly TestEnum Two = new(1, "two");

        public static readonly TestEnum Three = new(1, "three");
    }
}
