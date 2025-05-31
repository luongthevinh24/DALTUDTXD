using _67TH3_LTUDTXD_HUCE_20_DuongThiDuyen_0257867_67TH3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _67TH3_LTUDTXD_HUCE_20_DuongThiDuyen_0257867_67TH3.Views
{
    /// <summary>
    /// Interaction logic for TrangChu.xaml
    /// </summary>
    public partial class TrangChu : Window
    {
        string imagePath = "pack://application:,,,/Resources/Images/MacDinh.jpg";
        int mode = 0;
        public TrangChu()
        {
            InitializeComponent();
            chonTietDienDam.SelectedIndex = -1;
            if (DataContext is ChucNang vm)
            {
                vm.HienThiTrangTinhToanChuT = () =>
                {
                    TinhToanChuT tinhToanChuT = new TinhToanChuT();
                    tinhToanChuT.Show();
                };
                vm.HienThiTrangTinhToanChuNhat = () =>
                {
                    TinhToanChuNhat tinhToanChuNhat = new TinhToanChuNhat();
                    tinhToanChuNhat.Show();
                };
                vm.DongCuaSoHienTai = () => this.Close();
            }
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save button clicked!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Add button clicked!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        private void ClearButton(object sender, RoutedEventArgs e)
        {
            // Xóa toàn bộ TextBox
            ClearAllTextBoxes(this);

            // Xóa toàn bộ ComboBox
            ClearAllComboBoxes(this);
        }

        // Đệ quy tìm và xóa TextBox
        private void ClearAllTextBoxes(DependencyObject parent)
        {
            int count = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < count; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);

                if (child is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else
                {
                    ClearAllTextBoxes(child);
                }
            }
        }

        // Đệ quy tìm và reset ComboBox
        private void ClearAllComboBoxes(DependencyObject parent)
        {
            int count = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < count; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);

                if (child is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1; // hoặc comboBox.SelectedItem = null;
                }
                else
                {
                    ClearAllComboBoxes(child);
                }
            }
        }

        private void ThayDoiTietDienDam(object sender, SelectionChangedEventArgs e)
        {
            
            if (chonTietDienDam.SelectedItem is ComboBoxItem selectedItem)
            {
                string selected = ((ComboBoxItem)chonTietDienDam.SelectedItem).Content.ToString();
                if (selected == "Tiết diện chữ T")
                {
                    mode = 1;
                }
                else if (selected == "Tiết diện chữ nhật")
                {
                    mode = 2;
                }
                else
                {
                    mode = 0;
                }

                

                switch (mode)
                {
                    case 0:
                        imagePath = "pack://application:,,,/Resources/Images/MacDinh.jpg";
                        break;
                    case 1:
                        imagePath = "pack://application:,,,/Resources/Images/TietDienT.jpg";
                        break;
                    case 2:
                        imagePath = "pack://application:,,,/Resources/Images/TietDienCN.jpg";
                        break;
                }

                if (SectionImage != null && !string.IsNullOrEmpty(imagePath))
                {
                    SectionImage.Source = new BitmapImage(new Uri(imagePath));
                }

            }
        }
    }
}
