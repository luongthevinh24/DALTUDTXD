using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using _67TH3_LTUDTXD_HUCE_20_DuongThiDuyen_0257867_67TH3.Models;
using _67TH3_LTUDTXD_HUCE_20_DuongThiDuyen_0257867_67TH3.Views;
using System.Collections.ObjectModel;

namespace _67TH3_LTUDTXD_HUCE_20_DuongThiDuyen_0257867_67TH3.ViewModels
{
    public class DamChuNhatViewModel : INotifyPropertyChanged
    {
        private BeTong _beTong;
        private CotThep _cotThep;
        private double _moment;
        private double _rb;
        private double _rbt;
        private double _rs;
        private double _er;
        private double _ar;
        private double _b;
        private double _h;
        private string _ketQua;


        public double Rb
        {
            get => _rb;
            set
            {
                _rb = value;
                OnPropertyChanged(nameof(Rb));
            }
        }

        public double Rbt
        {
            get => _rbt;
            set
            {
                _rbt = value;
                OnPropertyChanged(nameof(Rbt));
            }
        }

        public double Rs
        {
            get => _rs;
            set
            {
                _rs = value;
                OnPropertyChanged(nameof(Rs));
            }
        }

        public double Er
        {
            get => _er;
            set
            {
                _er = value;
                OnPropertyChanged(nameof(Er));
            }
        }

        public double Ar
        {
            get => _ar;
            set
            {
                _ar = value;
                OnPropertyChanged(nameof(Ar));
            }
        }

        public double B
        {
            get => _b;
            set
            {
                _b = value;
                OnPropertyChanged(nameof(B));
            }
        }

        public double H
        {
            get => _h;
            set
            {
                _h = value;
                OnPropertyChanged(nameof(H));
            }
        }

        public string KetQua
        {
            get => _ketQua;
            set
            {
                _ketQua = value;
                OnPropertyChanged(nameof(KetQua));
            }
        }

        public ICommand TinhToanChuNhatCommand { get; }

        public DienTichThep[] _dienTichThep { get; } = new DienTichThep[]
        {
        new DienTichThep("Phi 6", 28.3),
        new DienTichThep("Phi 8", 50.3),
        new DienTichThep("Phi 10", 78.5),
        new DienTichThep("Phi 12", 113.1),
        new DienTichThep("Phi 14", 153.9),
        new DienTichThep("Phi 16", 201.1),
        new DienTichThep("Phi 18", 254.5),
        new DienTichThep("Phi 20", 314.2),
        new DienTichThep("Phi 22", 380.1),
        new DienTichThep("Phi 25", 490.9),
        new DienTichThep("Phi 28", 615.8),
        new DienTichThep("Phi 32", 804.2),
        new DienTichThep("Phi 36", 1017.9),
        new DienTichThep("Phi 40", 1256.6)
        };

        public DamChuNhatViewModel() { }

        public DamChuNhatViewModel(BeTong beTong, CotThep cotThep, double moment)
        {
            ToHopThepModel = new ObservableCollection<ToHopThepModel>();

            _beTong = beTong;
            _cotThep = cotThep;
            _moment = moment;

            Rb = beTong.Rb;
            Rbt = beTong.Rbt;
            Rs = cotThep.Rs;

            var ketqua = TinhEr(cotThep, beTong);
            Er = ketqua.Er;
            Ar = ketqua.Ar;

            TinhToanChuNhatCommand = new RelayCommand(ExecuteTinhToan);
        }

        private (double Er, double Ar) TinhEr(CotThep cotThep, BeTong beTong)
        {
            double Er = 0;
            double Ar = 0;
            string tenBT = beTong.Mac;
            string tenCT = cotThep.Loai;

            if (tenBT == "B70")
            {
                if (tenCT == "CB240-T")
                {
                    Er = 0.531;
                    Ar = 0.390;
                }
                else if (tenCT == "CB300-T" || tenCT == "CB300-V")
                {
                    Er = 0.502;
                    Ar = 0.376;
                }
                else if (tenCT == "CB400-V")
                {
                    Er = 0.457;
                    Ar = 0.353;
                }
                else
                {
                    Er = 0.411;
                    Ar = 0.326;
                }
            }
            else if (tenBT == "B80")
            {
                if (tenCT == "CB240-T")
                {
                    Er = 0.523;
                    Ar = 0.386;
                }
                else if (tenCT == "CB300-T" || tenCT == "CB300-V")
                {
                    Er = 0.494;
                    Ar = 0.372;
                }
                else if (tenCT == "CB400-V")
                {
                    Er = 0.448;
                    Ar = 0.348;
                }
                else
                {
                    Er = 0.401;
                    Ar = 0.320;
                }
            }
            else if (tenBT == "B90")
            {
                if (tenCT == "CB240-T")
                {
                    Er = 0.517;
                    Ar = 0.383;
                }
                else if (tenCT == "CB300-T" || tenCT == "CB300-V")
                {
                    Er = 0.487;
                    Ar = 0.368;
                }
                else if (tenCT == "CB400-V")
                {
                    Er = 0.440;
                    Ar = 0.343;
                }
                else
                {
                    Er = 0.393;
                    Ar = 0.316;
                }
            }
            else
            {
                if (tenCT == "CB240-T")
                {
                    Er = 0.615;
                    Ar = 0.426;
                }
                else if (tenCT == "CB300-T" || tenCT == "CB300-V")
                {
                    Er = 0.583;
                    Ar = 0.413;
                }
                else if (tenCT == "CB400-V")
                {
                    Er = 0.533;
                    Ar = 0.391;
                }
                else
                {
                    Er = 0.481;
                    Ar = 0.365;
                }
            }
            return (Er, Ar);
        }

        private void ExecuteTinhToan(object parameter)
        {

            if (B <= 0 || H <= 0)
            {
                MessageBox.Show("Nhập kích thước dầm (B, H > 0)");
                KetQua = string.Empty;
                return;
            }

            int a = H % 100 == 0 ? (int)(H / 100) * 10 - 10 : (int)(H / 100) * 10;
            double ho = H - a;
            double am = Math.Round(Math.Abs(_moment) * 1000000 / (Rb * B * ho * ho), 3);

            if (am >= Ar)
            {
                MessageBox.Show("Không thỏa mãn điều kiện giới hạn dẻo am > ar");
                KetQua = string.Empty;
                return;
            }

            double C = Math.Round(0.5 * (1 + Math.Sqrt(1 - 2 * am)), 3);
            double As = Math.Round(_moment * 1000000 / (Rs * C * ho), 3);
            double U = Math.Round(As / (B * ho) * 100, 3);
            double Umax = Math.Round(Er * Rb / Rs * 100, 3);

            if (U >= Umax || U <= 0.1)
            {
                MessageBox.Show($"Hàm lượng cốt thép không thỏa mãn U = {U}");
                KetQua = string.Empty;
                return;
            }

            double target = As;
            double maxDiff = target / 5;
            List<((int soLuong1, DienTichThep phi1), (int soLuong2, DienTichThep phi2), double tongTich, int soThanh, double att, double t, double cbv)> allPairs = new List<((int, DienTichThep), (int, DienTichThep), double, int, double, double, double)>();
            HashSet<string> toHop = new HashSet<string>();

            for (int soLuong1 = 0; soLuong1 <= 9; soLuong1++)
            {
                for (int i = 0; i < _dienTichThep.Length; i++)
                {
                    for (int soLuong2 = 0; soLuong2 <= 9; soLuong2++)
                    {
                        if (soLuong1 == 1 && soLuong2 % 2 != 0) continue;
                        if (soLuong2 == 1 && soLuong1 % 2 != 0) continue;
                        int soThanh = soLuong1 + soLuong2;
                        if (soThanh < 3 || soThanh > 6) continue;

                        if (soLuong1 > 0 && soLuong2 > 0)
                        {
                            for (int j = i + 1; j < _dienTichThep.Length; j++)
                            {
                                DienTichThep phi1 = _dienTichThep[i], phi2 = _dienTichThep[j];
                                int phi1Value = int.Parse(phi1.Phi.Replace("Phi ", ""));
                                int phi2Value = int.Parse(phi2.Phi.Replace("Phi ", ""));
                                int deltaPhi = Math.Abs(phi1Value - phi2Value);
                                if (deltaPhi < 3 || deltaPhi > 8) continue;

                                string combo1 = $"{soLuong1}x{phi1.Phi}";
                                string combo2 = $"{soLuong2}x{phi2.Phi}";
                                if (toHop.Contains(combo1) || toHop.Contains(combo2)) continue;

                                double tich1 = soLuong1 * phi1.S;
                                double tich2 = soLuong2 * phi2.S;
                                double tongTich = tich1 + tich2;
                                double diff = Math.Abs(tongTich - target);

                                if (tongTich >= target && diff <= maxDiff)
                                {
                                    int phiMax = Math.Max(phi1Value, phi2Value);
                                    double cbv = Math.Max(20, phiMax);
                                    double t = (B - cbv * 2 - soLuong1 * phi1Value - soLuong2 * phi2Value) / (soLuong1 + soLuong2 - 1);
                                    if (t < 30) continue;

                                    double att = cbv + phiMax / 2;
                                    if (att >= a) continue;

                                    toHop.Add(combo1);
                                    toHop.Add(combo2);
                                    allPairs.Add(((soLuong1, phi1), (soLuong2, phi2), tongTich, soThanh, att, t, cbv));
                                }
                            }
                        }
                        else if (soLuong1 == 0 || soLuong2 == 0)
                        {
                            if (soLuong1 == 0 && soLuong2 == 0) continue;
                            int soLuong;
                            DienTichThep phi;
                            if (soLuong1 == 0)
                            {
                                soLuong = soLuong2;
                                phi = _dienTichThep[i];
                            }
                            else
                            {
                                soLuong = soLuong1;
                                phi = _dienTichThep[i];
                            }

                            string combo = $"{soLuong}x{phi.Phi}";
                            if (toHop.Contains(combo)) continue;

                            double tongTich = soLuong * phi.S;
                            double diff = Math.Abs(tongTich - target);

                            if (tongTich >= target && diff <= maxDiff)
                            {
                                int phiValue = int.Parse(phi.Phi.Replace("Phi ", ""));
                                double cbv = Math.Max(20, phiValue);
                                double t = (B - soLuong * phiValue) / (soLuong - 1);
                                if (t < 30) continue;

                                double att = cbv + phiValue / 2.0;
                                if (att >= a) continue;

                                toHop.Add(combo);
                                DienTichThep dummyPhi = _dienTichThep[0];
                                if (soLuong1 == 0)
                                    allPairs.Add(((0, dummyPhi), (soLuong, phi), tongTich, soLuong, att, t, cbv));
                                else
                                    allPairs.Add(((soLuong, phi), (0, dummyPhi), tongTich, soLuong, att, t, cbv));
                            }
                        }
                    }
                }
            }

            var bestPairs = allPairs.OrderBy(pair => pair.soThanh).Take(10).ToList();
            KetQua = CreateRebarTable(bestPairs);

            foreach (var item in bestPairs)
            {
                string combo = "";
                if (item.Item1.soLuong1 > 0)
                    combo += $"{item.Item1.soLuong1}x{item.Item1.phi1.Phi}";
                if (item.Item2.soLuong2 > 0)
                {
                    if (!string.IsNullOrEmpty(combo)) combo += " + ";
                    combo += $"{item.Item2.soLuong2}x{item.Item2.phi2.Phi}";
                }

                ToHopThepModel.Add(new ToHopThepModel
                {
                    ToHop = combo,
                    TongDienTich = item.tongTich,
                    SoThanh = item.soThanh,
                    T = item.t,
                    Att = item.att,
                    Cbv = item.cbv
                });
            }
        }

        private string CreateRebarTable(List<((int soLuong1, DienTichThep phi1), (int soLuong2, DienTichThep phi2), double tongTich, int soThanh, double att, double t, double cbv)> pairs)
        {
            if (pairs.Count == 0)
            {
                return "Không tìm thấy tổ hợp cốt thép phù hợp.";
            }

            var table = new StringBuilder();
            table.AppendLine("Danh sách tổ hợp cốt thép:");
            table.AppendLine(new string('-', 80));
            table.AppendLine($"| {"Tổ hợp",-20} | {"Tổng diện tích (mm²)",-20} | {"Số thanh",-10} | {"t (mm)",-10} | {"att (mm)",-10} | {"cbv (mm)",-10} |");
            table.AppendLine(new string('-', 80));

            foreach (var pair in pairs)
            {
                string combo = "";
                if (pair.Item1.soLuong1 > 0)
                    combo += $"{pair.Item1.soLuong1}x{pair.Item1.phi1.Phi}";
                if (pair.Item2.soLuong2 > 0)
                {
                    if (combo != "") combo += " + ";
                    combo += $"{pair.Item2.soLuong2}x{pair.Item2.phi2.Phi}";
                }
                table.AppendLine($"| {combo,-20} | {pair.tongTich,-20:F2} | {pair.soThanh,-10} | {pair.t,-10:F2} | {pair.att,-10:F2} | {pair.cbv,-10:F2} |");
            }

            table.AppendLine(new string('-', 80));
            return table.ToString();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private class RelayCommand : ICommand
        {
            private readonly Action<object> _execute;

            public RelayCommand(Action<object> execute)
            {
                _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            }

            public bool CanExecute(object parameter) => true;

            public void Execute(object parameter) => _execute(parameter);

            public event EventHandler CanExecuteChanged;
        }

        public class DienTichThep
        {
            public string Phi { get; set; }
            public double S { get; set; }

            public DienTichThep(string phi, double s)
            {
                Phi = phi;
                S = s;
            }
        }


        private ObservableCollection<ToHopThepModel> _toHopThepModel = new ObservableCollection<ToHopThepModel>();
        public ObservableCollection<ToHopThepModel> ToHopThepModel
        {
            get => _toHopThepModel;
            set
            {
                _toHopThepModel = value;
                OnPropertyChanged(nameof(ToHopThepModel));
            }
        }
    }
}