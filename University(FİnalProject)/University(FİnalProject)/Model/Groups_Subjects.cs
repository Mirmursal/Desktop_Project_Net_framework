//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace University_FİnalProject_.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Groups_Subjects
    {
        public int id { get; set; }
        public int Group_ID { get; set; }
        public int Subject_ID { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
