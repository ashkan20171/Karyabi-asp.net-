//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Karyabi
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Customers
    {
        public string UserName { get; set; }
        public string Username { get; internal set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Birth { get; set; }
        public string CodeMelli { get; set; }
        public string Tell { get; set; }
        public string Mobile { get; set; }
        public string WorkName { get; set; }
        public string MaritalStatus { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public byte[] Description { get; set; }
        public Nullable<bool> State { get; set; }
        public string Email { get; internal set; }
        public bool FlagAdmin { get; internal set; }
        public string OfficerValid { get; internal set; }

        public static implicit operator tbl_Customers(tbl_Customers v)
        {
            throw new NotImplementedException();
        }
    }
}