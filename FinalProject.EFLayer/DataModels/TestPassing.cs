//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject.DataLayer.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestPassing
    {
        public int Id { get; set; }
        public Nullable<int> StudentId { get; set; }
        public int TestId { get; set; }
        public Nullable<int> TeacherId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Test Test { get; set; }
    }
}
