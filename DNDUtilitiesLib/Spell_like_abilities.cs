﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDUtilitiesLib
{
    public class Spell_like_abilities : DBTable_lookup
    {
        private int spell_like_ability_id
        {
            get;
            set;
        }

        public virtual string description
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
