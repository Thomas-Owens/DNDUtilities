﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Saving_throws : DBTable_lookup
    {
        private int saving_throw_id
        {
            get;
            set;
        }

        public virtual int saving_throw
        {
            get;
            set;
        }

        public virtual string condition
        {
            get;
            set;
        }

        public virtual bool immune
        {
            get;
            set;
        }

        internal virtual string FIELD
        {
            get;
            set;
        }

        internal virtual string FIELD_LIST
        {
            get;
            set;
        }

        internal virtual string TABLE
        {
            get;
            set;
        }

        public virtual void delete(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual Domains retrieve(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual void save(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}
