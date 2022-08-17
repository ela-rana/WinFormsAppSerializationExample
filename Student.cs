using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppSerializationExample
{
    [Serializable] //means item below is serializable. If you don't mark it serializable it can't be serialized
                    //it can't be converted into a stream
    internal class Student
    {
        //[NonSerialized]   //if we put nonserialized like this here then while everything in this class is serializable
                        //the field below this line will be non-serializable. It only works for fields, not for property
                        //or method, so example, if I mark ID property as Nonserializable here it gives compiler error
        public int StudentID { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }
    }
}
