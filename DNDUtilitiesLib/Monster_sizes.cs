﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Monster_sizes : DBTable
    {
        private int size_id
        {
            get;
            set;
        }

        public virtual string size
        {
            get;
            set;
        }

        public virtual Monsters monsters
        {
            get;
            set;
        }

    }
}
