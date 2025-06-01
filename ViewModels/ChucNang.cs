using _67TH3_LTUDTXD_HUCE_20_DuongThiDuyen_0257867_67TH3.Models;
using _67TH3_LTUDTXD_HUCE_20_DuongThiDuyen_0257867_67TH3.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace _67TH3_LTUDTXD_HUCE_20_DuongThiDuyen_0257867_67TH3.ViewModels
{
    public class ChucNang : INotifyPropertyChanged
    {
        private NguoiDung nguoiDung;
        private int _tietDienDamDaChon;
        public int TietDienDamDaChon
        {
            get => _tietDienDamDaChon;
            set
            {
                if (_tietDienDamDaChon != value)
                {
                    _tietDienDamDaChon = value;
                    OnPropertyChanged();
                }
            }
        }

        public Action DongCuaSoHienTai { get; set; }
        public Action HienThiDangKy { get; set; }
        public Action HienThiDangNhap { get; set; }
        public Action HienThiTrangChu { get; set; }
        public Action HienThiTrangTinhToanChuT { get; set; }
        public Action HienThiTrangTinhToanChuNhat { get; set; }

        public ICommand DangNhapTaiKhoan { get; }
        public ICommand DangKyTaiKhoan { get; }
        public ICommand ChuyenDenTrangDangKy { get; }
        public ICommand ChuyenDenTrangDangNhap { get; }
        public ICommand ChuyenDenTrangChu { get; }
        public ICommand ChuyenDenTrangChonVL { get; }
        public ICommand ChuyenDenTrangTinhToanChuT { get; }
        public ICommand ChuyenDenTrangTinhToanChuNhat { get; }

        public ObservableCollection<NguoiDung> ds { get; set; }

        public List<string> DanhSachBeTong { get; } = new() { "B15", "B20","B25", "B30", "B35","B40","B45","B50","B55","B60","B70","B80","B90" };
        public List<string> DanhSachCotThepDoc { get; } = new() { "CB240-T","CB300-T", "CB400-V", "CB500-V" };
        
        public ChucNang()
        {
            nguoiDung = new NguoiDung();
            ds = DanhSachNguoiDung.DanhSach;
            DangNhapTaiKhoan = new RelayCommand(KiemTraDangNhap);
            DangKyTaiKhoan = new RelayCommand(DangKy);
            ChuyenDenTrangDangKy = new RelayCommand(ChuyenDenDangKy);
            ChuyenDenTrangDangNhap = new RelayCommand(VeTrangDangNhap);
            ChuyenDenTrangChu = new RelayCommand(MoTrangChu);
            ChuyenDenTrangChonVL = new RelayCommand(MoTrangChonVL);
        }

        
        public string TaiKhoan
        {
            get => nguoiDung.TaiKhoan;
            set
            {
                nguoiDung.TaiKhoan = value;
                OnPropertyChanged(nameof(TaiKhoan));
            }
        }
        public string MatKhau
        {
            get => nguoiDung.MatKhau;
            set
            {
                nguoiDung.MatKhau = value;
                OnPropertyChanged(nameof(MatKhau));

            }
        }
        private void DangKy()
        {
            if (string.IsNullOrWhiteSpace(nguoiDung.TaiKhoan) || string.IsNullOrWhiteSpace(nguoiDung.MatKhau))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu");
                return;
            }
            if (DanhSachNguoiDung.DanhSach.Any(a => a.TaiKhoan == nguoiDung.TaiKhoan))
            {
                MessageBox.Show("Tài khoản đã tồn tại");
            }
            DanhSachNguoiDung.DanhSach.Add(new NguoiDung { TaiKhoan = nguoiDung.TaiKhoan, MatKhau = nguoiDung.MatKhau });
            OnPropertyChanged(nameof(ds));
            MessageBox.Show("Đăng ký thành công");
            TrangDangNhap trangDangNhap = new TrangDangNhap();
            trangDangNhap.Show();
            DongCuaSoHienTai?.Invoke();
        }
        private string _ketQuaTinhToan;
        public string KetQuaTinhToan
        {
            get => _ketQuaTinhToan;
            set
            {
                _ketQuaTinhToan = value;
                OnPropertyChanged();
            }
        }


        private void MoTrangChu()
        {
            HienThiTrangChu?.Invoke();
            DongCuaSoHienTai?.Invoke();

        }
        



        private void MoTrangChonVL()
        {

            if (TietDienDamDaChon == 0)
            {
                HienThiTrangTinhToanChuT?.Invoke();
            }
            else if (TietDienDamDaChon == 1)
            {
                HienThiTrangTinhToanChuNhat?.Invoke();
            }
        }

        private void ChuyenDenDangKy()
        {
            HienThiDangKy?.Invoke();
            DongCuaSoHienTai?.Invoke();
        }
        private void VeTrangDangNhap()
        {
            HienThiDangNhap?.Invoke();
            DongCuaSoHienTai?.Invoke();
        }

        private void KiemTraDangNhap()
        {
            if (DanhSachNguoiDung.DanhSach.Any(a => a.TaiKhoan == nguoiDung.TaiKhoan && a.MatKhau == nguoiDung.MatKhau))
            {
                MessageBox.Show("Đăng nhập thành công");
                TrangChu trangChu = new TrangChu();
                trangChu.Show();
                DongCuaSoHienTai?.Invoke();
            }
            else
            {
                MessageBox.Show("Sai tài khoản mật khẩu");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}
