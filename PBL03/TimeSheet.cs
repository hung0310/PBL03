
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace PBL03
{

using System;
    using System.Collections.Generic;
    
public partial class TimeSheet
{

    public int ID_TimeSheet { get; set; }

    public int IDSchedule { get; set; }

    public System.DateTime WorkDay { get; set; }



    public virtual WorkSchedule WorkSchedule { get; set; }

}

}
