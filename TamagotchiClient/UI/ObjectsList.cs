using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace WebServicesProject.UI
{
    class ObjectsList : Screen
    {
        protected ICollection<Object> data;
        public ObjectsList(string title, ICollection<Object> data) : base(title)
        {
            this.data = data;
        }
        public override void Show()
        {
            //Display title
            Console.WriteLine($"\t{Title}");

            //check if list contains data
            if (data.Count == 0)
            {
                Console.WriteLine("\tNo Data Found");
                return;
            }
            //Get the type of the object!
            Type t = data.ElementAt<Object>(0).GetType();
            // Get the public properties of the instance (not only related to Object).
            PropertyInfo[] propInfos = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            // Display information for all properties.
            Console.Write("\t");
            foreach (PropertyInfo propInfo in propInfos)
            {
                bool readable = propInfo.CanRead;
                if (readable)
                {
                    //Do not display lists, arrays, classes, etc...
                    if (!(propInfo.PropertyType.IsClass && !propInfo.PropertyType.Equals(typeof(string))))
                        Console.Write("{0}\t\t", propInfo.Name);
                }
            }

            //list values for all data objects

            foreach (Object obj in data)
            {
                Console.WriteLine();
                Console.Write("\t");
                foreach (PropertyInfo propInfo in propInfos)
                {
                    bool readable = propInfo.CanRead;
                    if (readable)
                    {
                        Object prop = propInfo.GetValue(obj);
                        //Do not display lists, arrays, classes, etc...
                        if (!(propInfo.PropertyType.IsClass && !propInfo.PropertyType.Equals(typeof(string))))
                            Console.Write("{0}\t\t", propInfo.GetValue(obj));
                    }
                }
            }
        }
    }
}
