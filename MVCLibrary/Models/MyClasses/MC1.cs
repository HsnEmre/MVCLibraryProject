using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCLibrary.Models.Entities;
using MVCLibrary.Models.MyClasses;


namespace MVCLibrary.Models.MyClasses
{
    public class MC1
    {
        public IEnumerable<TBLBOOK> value1  { get; set; }
        public IEnumerable<TBLABOUT> value2 { get; set; }
    }
}