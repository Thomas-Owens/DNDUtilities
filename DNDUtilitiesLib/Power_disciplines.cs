﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Power_disiplines : DBTable
    {
        private int discipline_id
        {
            get;
            set;
        }

        public virtual string discipline
        {
            get;
            set;
        }

        private List<String> fieldList
        {
            get;
            set;
        }

        public virtual Powers powers
        {
            get;
            set;
        }

        public virtual void delete(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual Power_disiplines retrieve(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual void save(int Key)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}
