//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FromDatabase
{
    using System;
    using System.Collections.Generic;
    
    public abstract partial class CourseRun
    {
        public CourseRun()
        {
            this.People = new HashSet<Person>();
        }
    
        public int Id { get; set; }
        public System.DateTime StartDate { get; set; }
        public string CourseCourseCode { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}