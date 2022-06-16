using Tuan05_NguyenVietHoang.Models;

public class Giohang
    {
        MyDataDataContext data = new MyDataDataContext();
        public int masach { get; set; }

        [Display(Name = "Tên sách" )]
        public string tensach { get; set; }

        [Display(Name = "Ảnh bìa" )]
        public string hinh { get; set; }
        
        [Display(Name = "Giá bán" )]
        public string giaban { get; set; }

        [Display(Name = "Số lượng" )]
        public string isoluong { get; set; }

        [Display(Name = "Thành tiền" )]
        public double DThanhtien
        {
                    
        }
}