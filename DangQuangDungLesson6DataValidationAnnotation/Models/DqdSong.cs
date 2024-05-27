using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace DangQuangDungLesson6DataValidationAnnotation.Models
{
    public class DqdSong
    {
        public int Id { get; set; }

        [DisplayName(" DQD- Tieu De") ]
        [Required (ErrorMessage = "DQD- Hay Nhap Tieu De")]

        public string Title { get; set; }

        [DisplayName(" DQD- Tac Gia")]
        [Required(ErrorMessage = "DQD- Hay Nhap Tac Gia")]

        public string Author { get; set; }

        [DisplayName("DQD- Nghe Si")]
        [Required(ErrorMessage = "DQD- Hay Nhap Nghe Si")]
        [StringLength (50,MinimumLength  = 2 ,ErrorMessage= "DQD-  Do Dai Phai Trong Khoang [2-50]")]

        public string Artist { get; set; }

        [DisplayName("DQD- Nam Xuat Ban")]
        [Required(ErrorMessage = "DQD- Hay Nhap Nam Xuat Ban")]
        [RegularExpression (@"[0-9]{4}", ErrorMessage = "DQD- Nam Xuat Ban Phai Co 4 Ki Tu So")]
        [Range(1990,2020, ErrorMessage = "DQD- Nam Xuat Ban Phai Tu 1990-2020 ")]
        public int YearRelease { get; set; }

    }
}