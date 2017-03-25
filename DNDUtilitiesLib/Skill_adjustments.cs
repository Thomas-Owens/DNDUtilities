﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Skill_adjustments : DBTable_bridge
    {
        private int skill_adjustment_id
        {
            get;
            set;
        }

        private int skill_id
        {
            get;
            set;
        }

        public virtual int adjustment
        {
            get;
            set;
        }

        public virtual string condition
        {
            get;
            set;
        }

        private int race_id
        {
            get;
            set;
        }

        private int class_id
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

        public virtual Skills Skills
        {
            get;
            set;
        }

        public virtual Classes Classes
        {
            get;
            set;
        }

        public virtual Races races
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
