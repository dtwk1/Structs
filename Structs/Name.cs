using System;
using System.Collections.Generic;
using System.Text;

namespace Structs
{
    using System.Linq;

    public struct Name
    {
        private string value;
        public Name(string value)
        {
            this.value = value;

        }



        public bool ContainsNumbers()
        {
            return this.value.Any(_ => char.IsDigit(_));

        }

        public bool IsDoubleBarrelled()
        {
            return this.value.Any(_ => _ =='-');

        }


    }
}
