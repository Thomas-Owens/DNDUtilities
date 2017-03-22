﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Feats : DBTable
    {
        private int feat_id
        {
            get;
            set;
        }

        public virtual string name
        {
            get;
            set;
        }

        public virtual string type
        {
            get;
            set;
        }

        public virtual string multiple
        {
            get;
            set;
        }

        public virtual string stack
        {
            get;
            set;
        }

        public virtual string choice
        {
            get;
            set;
        }

        public virtual string prerequisite
        {
            get;
            set;
        }

        public virtual string benefit
        {
            get;
            set;
        }

        public virtual string normal
        {
            get;
            set;
        }

        public virtual string special
        {
            get;
            set;
        }

        public virtual string full_text
        {
            get;
            set;
        }

        private List<String> fieldList
        {
            get;
            set;
        }

        public virtual void delete(int Key)
        {
            throw new System.NotImplementedException();
        }

        public virtual Feats retrieve(int Key)
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
