using System;
using System.Collections.Generic;
using System.Text;
using news.Common.Rsp;
using news.Common.BLL;

namespace news.BLL
{
    using DAL;
    using System.Linq;
    using news.DAL.Models;
    using news.Common.Req;

    public class LoaiTinSvc: GenericSvc<LoaiTinRep, LoaiTin>
    {
        public override SingleRsp Read(string id)
        {
            var res = new SingleRsp();
            try
            {
                var m = _rep.Read(id);
                res.Data = m;
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }

            return res;
        }

        public override SingleRsp Update(LoaiTin m)
        {
            var res = new SingleRsp();
            try
            {
                var m1 = m.Idloaitin != null ?_rep.Read(m.Idloaitin) : _rep.Read(m.TenLt);
                if (m1 == null)
                {
                    res.SetError("EZ103", "No data.");
                }
                else
                {
                    res = base.Update(m);
                    res.Data = m;
                }
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }


            return res;
        }

        public SingleRsp CreateLoaiTin(LoaiTinReq req)
        {
            var res = new SingleRsp();
            try
            {
                LoaiTin c = new LoaiTin();
                c.Idloaitin = req.Idloaitin;
                c.TenLt = req.TenLt;
                c.ThutuLt = req.ThutuLt;
                c.AnhienLt = req.AnhienLt;
                c.Idtheloai = req.Idtheloai;
                //
                res = base.Create(c);
                res.Data = c;
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }

            return res;
        }

        public SingleRsp UpdateLoaiTin(LoaiTinReq req)
        {
            var res = new SingleRsp();
            try
            {
                LoaiTin c = new LoaiTin();
                c.Idloaitin = req.Idloaitin;
                c.TenLt = req.TenLt;
                c.ThutuLt = req.ThutuLt;
                c.AnhienLt = req.AnhienLt;
                c.Idtheloai = req.Idtheloai;
                //
                res = base.Update(c);
                res.Data = c;
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }

            return res;
        }

        public object SearchLoaiTin(string keyWord, int size, int page)
        {

            var query = All; //Lấy toàn bộ dữ liệu của bảng customers
            if (!string.IsNullOrEmpty(keyWord)) //Kiểm tra keyWord có trống không
            {
                //Lấy dữ liệu theo keyWord ở bảng
                query = All.Where(x => x.Idloaitin.Contains(keyWord) || x.TenLt.Contains(keyWord));
            }
            //Độ dời. Thứ tự dữ liệu sẽ bắt đầu từ offset
            var offset = (page - 1) * size;
            //Tổng cộng bao nhiêu dữ liệu được tìm thấy
            var total = query.Count();
            //Tổng số trang
            //Ví dụ: 12 DL / Size 5 thì bằng 2 sẽ dư 2. Do đó phải có 3 trang để chứa đủ 12 DL
            int totalPage = (total % size) == 0 ? (int)(total / size) : (int)((total / size) + 1);
            //Lấy data tìm được
            //Dời tới offset theo size. Dữ liệu được lấy bắt đầu từ offset * size rồi gán qua list
            var data = query.Skip(offset).Take(size).ToList();
            //res sẽ lưu lại cái data cần thiết
            var res = new
            {
                Data = data,
                TotalRecords = total,
                Page = page,
                Size = size,
                TotalPages = totalPage
            };
            return res;
        }

        public SingleRsp DeleteLoaiTin(String id)
        {
            var res = new SingleRsp();
            try
            {
                res.Data = _rep.Remove(id);     // Kieu string ID
                // res.Data = Delete(id);
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }

            return res;
        }
    }
}
