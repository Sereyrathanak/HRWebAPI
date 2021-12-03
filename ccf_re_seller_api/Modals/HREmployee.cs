﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ccf_re_seller_api.Models
{
    [Table("pinfo")]
    public class HREmployee
    {
        private readonly HRContext _context;

        public HREmployee(HRContext context)
        {
            _context = context;
        }

        [Key]
        public string eid { get; set; }
        public string ecard { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string dname { get; set; }
        public DateTime dob { get; set; }
        public string mstatus { get; set; }
        public string gender { get; set; }
        public string nat { get; set; }
        public string blo { get; set; }
        public string reg { get; set; }
        public string pba { get; set; }
        public string etn { get; set; }
        public string hnum { get; set; }
        public string rnum { get; set; }
        public string village { get; set; }
        public string district { get; set; }
        public string commune { get; set; }
        public string province { get; set; }
        public string dadd { get; set; }
        public string pnum { get; set; }
        public string fnum { get; set; }
        public string email { get; set; }
        public DateTime rdate { get; set; }
        public string estatus { get; set; }
        public string photo { get; set; }
        public int elevel { get; set; }
        public string u1 { get; set; }
        public string u2 { get; set; }
        public string u3 { get; set; }
        public string u4 { get; set; }
        public string u5 { get; set; }

        public virtual HREmployeeJoinInfo employeeJoinInfo { get; set; }
        public virtual HREmployeeHistory employeeHistory { get; set; }


    }

    public class ReturnDocumentByLoan
    {
        public string uid { get; set; }
        public string type { get; set; }
        public string edoc { get; set; }
        public string description { get; set; }
        public string filepath { get; set; }

       
    }
}
