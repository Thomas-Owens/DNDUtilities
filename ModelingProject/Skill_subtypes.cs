//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DNDUtilitiesLib
{
    using System;
    using System.Collections.Generic;
    
    public partial class skill_subtypes
    {
        public long subtype_id { get; set; }
        public string subtype { get; set; }
        public long skill_id { get; set; }
    
        public virtual skill skill { get; set; }
    }
}