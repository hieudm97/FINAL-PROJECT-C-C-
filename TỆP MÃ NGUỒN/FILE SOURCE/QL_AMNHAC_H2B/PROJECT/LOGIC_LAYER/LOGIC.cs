using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT.LOGIC_LAYER
{
    public class LOGIC
    {
        //member
        DB db = new DB();


        //func
        internal IEnumerable<object> get_BAIHAT()
        {
            var  lst_baihat = db.BAIHATs;
            return lst_baihat;
        }

        internal IEnumerable<PHIM> get_PHIM()
        {
            IEnumerable<PHIM> lst_PHIM = db.PHIMs;
            return lst_PHIM;
        }

        internal int getmaidfromtendangnhap_nguoidung(string tendangnhap)
        {
            //throw new NotImplementedException();
            int maid = db.NGUOIDUNGs.Where(nguoidung => nguoidung.TENDANGNHAP == tendangnhap).First().MAID;
            return maid;
        }



        internal IEnumerable<object> show_baihat_playlist(int maid)
        {
            //throw new NotImplementedException();
            /*show các bài hát thuộc playlist người dùng*/
            var ds_bh = from dsbh in db.DANHSACHCHOINHACs
                        join ctds in db.CTDANHSACHCHOINHACs on dsbh.DANHSACHID equals ctds.DANHSACHID
                        join bh in db.BAIHATs on ctds.BAIHATID equals bh.BAIHATID
                        where dsbh.MAID_NGUOIDUNG == maid
                        select bh;
            return ds_bh.ToList();
        }

        internal void add_chitietdanhsach( int danhsachid, int idbaihat)
        {
            CTDANHSACHCHOINHAC ctds = new CTDANHSACHCHOINHAC();
            ctds.DANHSACHID = danhsachid;
            ctds.BAIHATID = idbaihat;
            db.CTDANHSACHCHOINHACs.Add(ctds);
            db.SaveChanges();
        }

        

        internal void add_danhsachchoinhac(int danhsachid, string tenlistnhac, int maid)
        {
            // throw new NotImplementedException();
            DANHSACHCHOINHAC dscn = new DANHSACHCHOINHAC();
            dscn.DANHSACHID = danhsachid;
            dscn.TENLISTNHAC = tenlistnhac;
            dscn.MAID_NGUOIDUNG = maid;
            db.DANHSACHCHOINHACs.Add(dscn);
            db.SaveChanges();
        }

        internal int get_danhsachid()
        {
            //  throw new NotImplementedException();
            int danhsachid = db.DANHSACHCHOINHACs.Max(danhsach => danhsach.DANHSACHID);
            return danhsachid + 1 ;
        }

        internal string getTenNguoiDungTuMaID(int mAID)
        {
            // throw new NotImplementedException();
            string tennguoidung = db.NGUOIDUNGs.Where(nd => nd.MAID == mAID).FirstOrDefault().TEN;
            return tennguoidung;

        }

        internal string get_iddanhsachchoinhac_nguoidung()
        {
            // throw new NotImplementedException();
            int count_danhsach = db.DANHSACHCHOINHACs.Count() + 1 ;
            return count_danhsach.ToString(); 
        }

        internal void add_thu_nguoidung(int v, string txt_ngaytao, int mAID, object selectedValue)
        {
            // throw new NotImplementedException();
            HOPTHU thu = new HOPTHU();
           
            thu.NGAYKHOITAO = DateTime.ParseExact(txt_ngaytao, "ddmmyyyy", System.Globalization.CultureInfo.InvariantCulture);
            thu.NGUOIDUNGID = mAID;
            thu.ADMINID = int.Parse(selectedValue.ToString());
            db.HOPTHUs.Add(thu);
            db.SaveChanges();

        }

        internal string count_thu_nguoidung(int maid)
        {
            // throw new NotImplementedException();
            int count_thu = db.HOPTHUs.Where(hopthu => hopthu.NGUOIDUNGID == maid).Count();
            return count_thu.ToString();
        }

        ////   internal void suagng_thongtinplaylist_banuoidung(int maid, string madanhsach)
        //   {
        //       //throw new NotImplementedException();
        //       NGUOIDUNG ng = db.NGUOIDUNGs.Where(nguoidung => nguoidung.MAID == maid).First();
        //       ng.DANHSACHID = int.Parse(madanhsach);
        //       db.SaveChanges();
        //   }

        internal void add_playlist_nguoidung( string textBox1,string  textBox2)
        {
            //  throw new NotImplementedException();
            DANHSACHCHOINHAC ds = new DANHSACHCHOINHAC();
            ds.DANHSACHID = int.Parse(textBox1);
            ds.TENLISTNHAC = textBox2;
            db.DANHSACHCHOINHACs.Add(ds);
            db.SaveChanges();
        }

        internal string get_soluongphim()
        {
            // throw new NotImplementedException();
            int count_baihat = db.PHIMs.Count();
            count_baihat += 1;
            return count_baihat.ToString();
        }

        internal string get_mathu_ql()
        {
            // throw new NotImplementedException();
            int count_baihat = db.HOPTHUs.Count();
            count_baihat += 1;
            return count_baihat.ToString();
        }

        internal string get_tenquantrivien(string tendangnhap)
        {
            // throw new NotImplementedException();
            ADMINISTATOR ad = db.ADMINISTATORs.Where(admin => admin.TENDANGNHAP == tendangnhap).First();
            return ad.TEN;

        }

        internal void sua_khachang_ql(string text1, string text2, string text3, string text4, string text5,string text6)
        {
            // throw new NotImplementedException();
            int maid = int.Parse(text1);
            NGUOIDUNG nguoidung = db.NGUOIDUNGs.Where(ad => ad.MAID == maid).First();
            nguoidung.TEN = text2;
            nguoidung.TUOI = int.Parse(text3);
            nguoidung.CONGTY = text4;
            nguoidung.TENDANGNHAP = text5;
            nguoidung.MATKHAU = text6;
            db.SaveChanges(); 


        }

        internal bool check_list_nhac(int mAID)
        {
            // throw new NotImplementedException();
            //   MessageBox.Show(mAID.ToString()); 
            int flag = db.DANHSACHCHOINHACs.Where(danhsach => danhsach.MAID_NGUOIDUNG == mAID).Count();
           
            if(flag >= 1)
            {
                return true; 
            }
            return false ;
        }

        internal void sua_nhanvien(string text1, string text2, string text3, string text4, string text5, string text6)
        {
            // throw new NotImplementedException();
            int maid = int.Parse(text1);
            ADMINISTATOR admin = db.ADMINISTATORs.Where(ad => ad.AID == maid).First();
            admin.TEN = text2;
            admin.TUOI = int.Parse(text3);
            admin.DIACHI = text4;
            admin.TENDANGNHAP = text5;
            admin.MATKHAU = text6;
            db.SaveChanges();

        }

        internal int getAIDfromTENDANGNHAP(string tendangnhap)
        {
            //throw new NotImplementedException();
            int id_ad = db.ADMINISTATORs.Where(admin => admin.TENDANGNHAP == tendangnhap).FirstOrDefault().AID;
            return id_ad;
        }

        internal void add_thu_ql(string text1, string text2, 
            object selectedValue, int v, string text3)
        {
            // throw new NotImplementedException();
            HOPTHU hopthu = new HOPTHU();
            hopthu.EMAILID = int.Parse(text1);
            hopthu.NGAYKHOITAO = DateTime.ParseExact(text2, "ddmmyyyy",System.Globalization.CultureInfo.InvariantCulture);
            hopthu.NGUOIDUNGID = int.Parse(selectedValue.ToString());
            hopthu.ADMINID = v;
            hopthu.NOIDUNG = text3;
            db.HOPTHUs.Add(hopthu);
            db.SaveChanges();

        }

        internal void timkiembaihattuten_GUI_ND_FORM1(string tutimkiem)
        {
            throw new NotImplementedException();
        }

        ////    internal bool check_playlistnguoidung(int mAID)
        //    {
        //       // // throw new NotImplementedException();
        //       // NGUOIDUNG ng = db.NGUOIDUNGs.Where(nguoidung => nguoidung.MAID == mAID).First(); 

        //       //if(ng.DANHSACHID == null)
        //       // {
        //       //     return false; 
        //       // }
        //       //else
        //       // {
        //       //     return true;
        //       // }
        //    }

        internal string get_soluongbaihat()
        {
            //throw new NotImplementedException();
            int count_baihat = db.BAIHATs.Count();
            count_baihat += 1;
            return count_baihat.ToString(); 
            
        }

        internal IEnumerable<NGHESI> get_nghesi()
        {
            // throw new NotImplementedException();
            IEnumerable<NGHESI> lst_nghesi = db.NGHESIs;
            return lst_nghesi;
        }

        internal void add_nhanvien(string text1, string text2, string text3, string text4, string text5, string text6)
        {
            // throw new NotImplementedException();
            ADMINISTATOR admin = new ADMINISTATOR();
            admin.AID = int.Parse(text1);
            admin.TEN = text2;
            admin.TUOI = int.Parse(text3);
            admin.DIACHI = text4;
            admin.TENDANGNHAP = text5;
            admin.MATKHAU = text6;
            db.ADMINISTATORs.Add(admin);
            db.SaveChanges();
        }

        internal IEnumerable<BAIHAT> getBaiHatFromNgheSi(string tennghesi)
        {
            // throw new NotImplementdException();
            /* từ tên nghệ sĩ lấy ra id của nghệ sĩ đó*/
            int nghesiid = db.NGHESIs.Where(nghesi => nghesi.TEN == tennghesi).FirstOrDefault().NGHESIID;

            IEnumerable<BAIHAT> lst_baihat = db.BAIHATs.Where(baihat => baihat.NGHESIID == nghesiid);
            return lst_baihat;

        }

        internal void delete_baihat_ql(int maidorphim)
        {
            //   throw new NotImplementedException();
            BAIHAT bh = db.BAIHATs.Where(baihat => baihat.BAIHATID == maidorphim).FirstOrDefault();
            db.BAIHATs.Remove(bh);
            db.SaveChanges();
        }

        internal void add_phim_ql(string text1, string text2, 
            object selectedValue1, string text3, 
            object selectedValue2, string text4)
        {
            // throw new NotImplementedException();
            PHIM phim = new PHIM();
            phim.PHIMID = int.Parse(text1);
            phim.TENPHIM = text2;
            phim.NGHESIID = int.Parse(selectedValue1.ToString());
            phim.DANHGIA = int.Parse(text3);
            phim.ALBUMID = int.Parse(selectedValue2.ToString());
            phim.DUONGDANPHIM = text4;
            db.PHIMs.Add(phim);
            db.SaveChanges();
        }

        internal void delete_phim_ql(int maidorphim)
        {
            // throw new NotImplementedException();
            PHIM phim = db.PHIMs.Where(phim_del => phim_del.PHIMID == maidorphim).FirstOrDefault();
            db.PHIMs.Remove(phim);
            db.SaveChanges(); 
        }

        internal void add_baihat_ql(string text1, string text2, object selectedValue_nghesi,
            string text4, object selectedValue_album, string text5)
        {
            // throw new NotImplementedException();
            BAIHAT baihat = new BAIHAT();
            baihat.BAIHATID = int.Parse(text1);
            baihat.TENBAIHAT = text2;
            baihat.NGHESIID = int.Parse(selectedValue_nghesi.ToString());
            baihat.DANHGIA = int.Parse(text4);
            baihat.ALBUMID = int.Parse(selectedValue_album.ToString());
            baihat.DUONGDANBAIHAT = text5;
            db.BAIHATs.Add(baihat);
            db.SaveChanges();
        }

        internal IEnumerable<HOPTHU> search_hopthu_ql(int mahopthu)
        {
            //throw new NotImplementedException();
            IEnumerable<HOPTHU> lst_hopthu = db.HOPTHUs.Where(email => email.EMAILID == mahopthu);
            return lst_hopthu;
        }

        internal IEnumerable<NGUOIDUNG> search_nguoidung_ql(int manguoidung)
        {
            //throw new NotImplementedException();
            IEnumerable<NGUOIDUNG> lst_nguoidung = db.NGUOIDUNGs.Where(ng => ng.MAID == manguoidung);
            return lst_nguoidung; 
        }

        internal IEnumerable<ADMINISTATOR> search_nv(int v)
        {
            //throw new NotImplementedException();
            IEnumerable<ADMINISTATOR> lst_ad = db.ADMINISTATORs.Where(ad => ad.AID == v);
            return lst_ad;
            
        }

        internal IEnumerable<HOPTHU> get_hopthu_ql()
        {
            //throw new NotImplementedException();
            IEnumerable<HOPTHU> lst_ad = from ad in db.HOPTHUs
                                            select ad;
            return lst_ad;
        }

        internal IEnumerable<PHIM> search_phim_ql(string tenphim)
        {
            // throw new NotImplementedException();
            IEnumerable<PHIM> lst_phim = db.PHIMs.Where(phim => phim.TENPHIM == tenphim);
            return lst_phim;
        }

        internal IEnumerable<NGUOIDUNG> get_nguoidung_ql()
        {
            // throw new NotImplementedException();
            IEnumerable<NGUOIDUNG> lst_ad = from ad in db.NGUOIDUNGs
                                               select ad;
            return lst_ad;
        }

        internal IEnumerable<BAIHAT> search_baihat_ql(string tenbaihat)
        {
            // throw new NotImplementedException();
            IEnumerable<BAIHAT> lst_phim = db.BAIHATs.Where(phim => phim.TENBAIHAT == tenbaihat);
            return lst_phim;
        }

        internal IEnumerable<ADMINISTATOR> get_nhanvien_ql()
        {
            // throw new NotImplementedException();
            IEnumerable<ADMINISTATOR> lst_ad = from ad in db.ADMINISTATORs
                                               select ad;
            return lst_ad;
        }

        internal IEnumerable<HOPTHU> get_email(int v)
        {
            // throw new NotImplementedException();
            IEnumerable<HOPTHU> lst_hopthu = db.HOPTHUs.Where(thu => thu.NGUOIDUNGID == v);
            return lst_hopthu;
        }

        internal bool check_quantrivien(string text1, string text2)
        {
            // throw new NotImplementedException();
            int flag = (from admin in db.ADMINISTATORs
                        where admin.TENDANGNHAP == text1 && admin.MATKHAU == text2
                        select admin).Count();
            if (flag > 0)
                return true;
            else return false;
        }

        internal void dangky(string text1, string text2, string text3, string text4, string text5)
        {
            //throw new NotImplementedException();
            NGUOIDUNG ng = new NGUOIDUNG();
            ng.TEN = text1;
            ng.TUOI = int.Parse(text2);
            ng.CONGTY = text3;
            ng.TENDANGNHAP = text4;
            ng.MATKHAU = text5;
            db.NGUOIDUNGs.Add(ng);
            db.SaveChanges();

        }

        internal bool check_nguoidung(string text1, string text2)
        {
            //  throw new NotImplementedException();
            int flag = (from admin in db.NGUOIDUNGs
                        where admin.TENDANGNHAP == text1 && admin.MATKHAU == text2
                        select admin).Count();
            if (flag > 0)
                return true;
            else return false;
        }

        internal IEnumerable<BAIHAT> search_nguoidung(string text)
        {
            //throw new NotImplementedException();
            IEnumerable<BAIHAT> lst_baihat = db.BAIHATs.Where(bh => bh.TENBAIHAT == text);
            return lst_baihat;
        }

        internal void delete_nhanvien(int v)
        {
            //throw new NotImplementedException();
            ADMINISTATOR ad = (from admin in db.ADMINISTATORs
                              where admin.AID == v
                              select admin).FirstOrDefault();
            db.ADMINISTATORs.Remove(ad);
            db.SaveChanges(); 
        }


        internal IEnumerable<ALBUM> get_Album()
        {
            // throw new NotImplementedException();
            IEnumerable<ALBUM> lst_album = from album in db.ALBUMs
                                           select album;
            return lst_album;

        }

        internal IEnumerable<BAIHAT> get_BAIHAT_album(string text)
        {
            //throw new NotImplementedException();
            var tmp = (from album in db.ALBUMs
                           where album.TENALBUM == text
                           select album).First();
            int albumid = tmp.ALBUMID;
            

            IEnumerable<BAIHAT> lst_baihat = from baihat in db.BAIHATs
                                             where baihat.ALBUMID == albumid
                                             select baihat;
            return lst_baihat;
        }

        internal void delete_nguoidung(int v)
        {
            //throw new NotImplementedException();
            NGUOIDUNG ad = db.NGUOIDUNGs.Where(nd => nd.MAID == v).First();
            db.NGUOIDUNGs.Remove(ad);
            db.SaveChanges();
        }

        internal void delete_hopthu(int p)
        {
            //hrow new NotImplementedException();
            HOPTHU ad = (from admin in db.HOPTHUs
                            where admin.EMAILID == p
                            select admin).FirstOrDefault();
            db.HOPTHUs.Remove(ad);
            db.SaveChanges();
        }

        internal IEnumerable<PHIM> get_PHIM_album(string text)
        {
            //  throw new NotImplementedException();
            var tmp = (from album in db.ALBUMs
                       where album.TENALBUM == text
                       select album).FirstOrDefault();
            int albumid = tmp.ALBUMID;

            IEnumerable<PHIM> lst_baihat = from baihat in db.PHIMs
                                             where baihat.ALBUMID == albumid
                                             select baihat;
            return lst_baihat;

        }
    }
}
