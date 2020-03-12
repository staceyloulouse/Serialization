using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace Serializations
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = GetInitialData();
            string json = ConvertToJson(data);


        }

        private static string ConvertToJson(object data)
        {
            throw new NotImplementedException();
        }

        private static object GetInitialData()
        {
            throw new NotImplementedException();
            var list = new List<Person>();
            var person1 = new Person();
            person1.Id = 1;

            var mark = new Person();
            mark.Id = 2;
        }
    }
    private static void WriteToFile(string text)
    {
        
    }

    private static List<Person> GetInitialData()
    {
        
    }

    
}
