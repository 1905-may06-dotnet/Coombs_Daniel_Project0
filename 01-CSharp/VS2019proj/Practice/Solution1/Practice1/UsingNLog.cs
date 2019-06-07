using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Practice1
{
    public class UsingNLog<T>
    {
        [DataMember]
        public static int age = 40;
        [DataMember]
        public static string name = "Tom Hardy";
        static void main(String[] args) {
            
        }

        public void TestException()
        {
            MemoryStream m = new MemoryStream();
            StreamReader sr = null;
            DataContractJsonSerializer dj = new DataContractJsonSerializer(typeof(T));

            String path = "";

            dj.WriteObject(m, )

            try
            {
                sr = new StreamReader(path);
            }
            catch (Exception e)
            {

            }
        }
    }
}
