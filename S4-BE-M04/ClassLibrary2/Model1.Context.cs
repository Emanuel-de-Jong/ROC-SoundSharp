﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SoundSharpDBEntities : DbContext
    {
        public SoundSharpDBEntities()
            : base("name=SoundSharpDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int spAddTrackToList(Nullable<int> tRACKID, Nullable<int> tRACKLISTID)
        {
            var tRACKIDParameter = tRACKID.HasValue ?
                new ObjectParameter("TRACKID", tRACKID) :
                new ObjectParameter("TRACKID", typeof(int));
    
            var tRACKLISTIDParameter = tRACKLISTID.HasValue ?
                new ObjectParameter("TRACKLISTID", tRACKLISTID) :
                new ObjectParameter("TRACKLISTID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddTrackToList", tRACKIDParameter, tRACKLISTIDParameter);
        }
    }
}
