using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class student
    {
        int id;
        string name;
        string class_name;
        private student() { }
        private static student instance;
        public static student Instance {
            get => instance ?? (instance = new student());
            private set => instance = value;
        }

    }
}
