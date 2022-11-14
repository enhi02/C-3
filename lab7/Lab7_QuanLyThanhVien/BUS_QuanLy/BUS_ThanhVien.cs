using DAL_QuanLy;
using DTO_QuanLY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy
{
    public class BUS_ThanhVien
    {
        DAL_ThanhVien dalThanhVien = new DAL_ThanhVien();

        public DataTable getThanhVien()
        {
            return dalThanhVien.getThanhVien();
        }

        public bool themThanhVien(DTO_ThanhVien tv)
        {
            return dalThanhVien.themThanhVien(tv);
        }

        public bool suaThanhVien(DTO_ThanhVien tv)
        {
            return dalThanhVien.suaThanhVien(tv);
        }

        public bool xoaThanhVien(int tv_id)
        {
            return dalThanhVien.xoaThanhVien(tv_id);
        }
    }
}
