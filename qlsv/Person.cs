﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlsv
{
    public class Person
    {
        private String _FullName;
        public String FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
        }
        private String _Gender;
        public String Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }
        private DateTime _DateOfBirth;
        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }
        private String _Nation;
        public String Nation
        {
            get { return _Nation; }
            set { _Nation = value; }
        }
    }
}
