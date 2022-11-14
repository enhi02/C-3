using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLY
{
    public class DTO_ThanhVien
    {
        private int _THANHVIEN_ID;
        private string _THANHVIEN_NAME;
        private string _THANHVIEN_PHONE;
        private string _THANHVIEN_EMAIL;

        public int THANHVIEN_ID { get => _THANHVIEN_ID; set => _THANHVIEN_ID = value; }
        public string THANHVIEN_NAME { get => _THANHVIEN_NAME; set => _THANHVIEN_NAME = value; }
        public string THANHVIEN_PHONE { get => _THANHVIEN_PHONE; set => _THANHVIEN_PHONE = value; }
        public string THANHVIEN_EMAIL { get => _THANHVIEN_EMAIL; set => _THANHVIEN_EMAIL = value; }

        public DTO_ThanhVien()
        {

        }

        public DTO_ThanhVien(int id, string name, string phone, string email) 
        {
            this.THANHVIEN_ID = id;
            this.THANHVIEN_NAME = name;
            this.THANHVIEN_PHONE = phone;
            this.THANHVIEN_EMAIL = email;
        }
    }
}
