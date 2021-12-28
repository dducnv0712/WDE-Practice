using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD.Models
{
    public class Exam
    {
        [DisplayName("#")]
        public int id { get; set; }
        [DisplayName("Môn Thi")]
        [Required(ErrorMessage = "Vui Lòng Chọn Môn Thi.")]
        public string examSubject { get; set; }
        [DisplayName("Thời Gian Bắt Đầu")]
        [Required(ErrorMessage ="Vui Lòng Chọn Thời Gian Bắt Đầu.")]
        public string startTime { get; set; }
        [DisplayName("Ngày Thi")]
        [Required(ErrorMessage ="Vui Lòng Chọn Ngày Thi.")]
        public string examDate { get; set; }
        [DisplayName("Thời Gian Làm Bài")]
        [Required(ErrorMessage ="Vui Lòng Chọn Thời Gian Làm Bài.")]
        public string examDuration { get; set; }
        [DisplayName("Phòng Thi")]
        [Required(ErrorMessage = "Vui Lòng Chọn Phòng Thi.")]
        public string classRoom { get; set; }
        [DisplayName("Giám Thị")]
        [Required(ErrorMessage = "Vui Lòng Chọn Giám Thị.")]
        public string facully { get; set; }
    }
}