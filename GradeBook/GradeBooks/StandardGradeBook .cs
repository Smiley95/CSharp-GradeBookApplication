﻿using GradeBook.GradeBooks;
using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;


namespace GradeBook
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name): base(name)
        {
            base.Type = GradeBookType.Standard;
        }
    }
}