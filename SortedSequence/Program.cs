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
            //throw new NotImplementedException();
            List<Person> list = new List<Person>();
            var person1 = new Person();
            person1.Id = 1;

            Person mark = new Person();
            mark.Id = 2;

            list.Add(person1);
            return list;
        }
        private static void WriteToFile(string text, string path)
        {
            var file = new FileStream(path, FileMode.Create);
        }
        private static void ModifyPersons(List<Person> data)
        {
            foreach(var person in data)
            {
                person.Id++;
            }
        }
    }
    

   

    
}
