
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace MIS
{

using System;
    using System.Collections.Generic;
    
public partial class PurposeInfo
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public PurposeInfo()
    {

        this.FollowUpTables = new HashSet<FollowUpTable>();

    }


    public int PId { get; set; }

    public string Purpose { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<FollowUpTable> FollowUpTables { get; set; }

}

}