using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace DQDLab05._1.Models
{
    public class DqdMember
    {
        
        [Required(ErrorMessage = "DQD- Hay Nhap Ma So")]
        [DataType(DataType.Currency)]
        public int Id { get; set; }
        [Required(ErrorMessage = "DQD- Hay Nhap Ten Dang Nhap")]

        public string UserName { get; set; }
        [Required(ErrorMessage = "DQD- Hay Nhap Ho Ten ")]


        public string FullName { get; set; }
        [Required(ErrorMessage = "DQD- Hay Nhap Mat Khau ")]
        [DataType(DataType.Password)]

        public string PassWord { get; set; }
        [Required(ErrorMessage = "DQD- Hay nhap tuoi")]
        [Range(18, 50, ErrorMessage = "DQD-  Tuoi tu 18-50")]

        public int Age { get; set; }
        [Required(ErrorMessage = "DQD- Hay nhap Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email phai dung dinh dang")]
        public string Email { get; set; }
    }
}


