﻿using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;
using GradeBook.GradeBooks;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook :BaseGradeBook
    {
        // call to base ctor passing name.
        public StandardGradeBook(string name, bool theBool) :base(name,theBool)     
        {

           Type = GradeBookType.Standard;
        }
    }
}
