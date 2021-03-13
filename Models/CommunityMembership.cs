﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class CommunityMembership
    {
        public int StudentID
        {
            get;
            set;
        }
        public string CommunityID
        {
            get;
            set;
        }
        public Community Community { get; set; }
        public Student Student { get; set; }
      
    }
}
