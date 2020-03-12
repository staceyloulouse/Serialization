using System;
using System.Collections.Generic;
using System.Text;

namespace Serializations
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }


        List<Person> Children = new List<Person>();

    }
}
