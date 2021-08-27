using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLWrongSDL
{
    public class Person
    {
        public Person()
        {
            Date = DateTimeOffset.UtcNow;
            Number = 6;
        }

        public DateTimeOffset Date { get; }
        public long Number { get; }
    }
}
