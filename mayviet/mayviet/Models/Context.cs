﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mayviet.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        : base("name=LienMinhHTX")
        { }
        public virtual DbSet<Danhmucsanpham> Danhmucsanphams { get; set; }
    }
}