using WAD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WAD.Models;

namespace StudentManage.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext():base("name=T2009MTest")
        {

        }
        public DbSet<Exam> Exam { get; set; }
    }
}