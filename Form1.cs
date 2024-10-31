using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BKT_2_31_10_2024.Form1;

namespace BKT_2_31_10_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadProduct();
            Display();
        }

        public class Product
        {
            public string TenSP { get; set;}
            public float Gia { get; set; }
            public int SoLuong {  get; set; }
            public Product(string tenSP, float gia, int soLuong)
            {
                TenSP = tenSP;
                Gia = gia;
                SoLuong = soLuong;
            }
        }
        public class CartItem
        {
            public Product SP;
            public int SL;
            public CartItem(Product sp, int sl)
            {
                SP = sp;    
                SL = sl;
            }
            public float Tong => SP.Gia * SL; 
        }
        private void LoadProduct()
        {
            products.Add(new Product("Áo Vàng", 100000, 3));
            products.Add(new Product("Áo xanh", 100000, 5));
            products.Add(new Product("Áo Đen", 100000, 4));
            products.Add(new Product("Áo Trắng", 100000, 5));
            products.Add(new Product("Áo đen trắng ", 200000, 5));
            products.Add(new Product("Ao Đỏ", 100000, 5));
        }
        private List<Product> products = new List<Product>();
        private List<CartItem> cart = new List<CartItem>();
        private void Display()
        {
            ListSP.Items.Clear();
            foreach (Product p in products)
            {
                ListSP.Items.Add($"{p.TenSP} - {p.Gia} - Số lượng còn lại {p.SoLuong}");
            } 
                
        }
        private void DisplayCart()
        {
            ListCart.Items.Clear();
            foreach (CartItem item in cart)
            {
                ListCart.Items.Add($"{item.SP.TenSP} - Số lượng: {item.SL} - Giá: {item.SP.Gia} - Thành tiền: {item.Tong}");
            }
            TongTien.Text = $"{TongSoTien():C}";
            TongSL.Text = $"{TongSoLuong()}";
        }

        private float TongSoTien()
        {
            return cart.Sum(item => item.Tong);
        }
        private int TongSoLuong()
        {
            return cart.Sum(item => item.SL);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void them_Click(object sender, EventArgs e)
        {
            Product selectedProduct = products[ListSP.SelectedIndex];
            if (selectedProduct.SoLuong > 0)
            {
                CartItem cartItem = cart.FirstOrDefault(i => i.SP == selectedProduct);

                if (cartItem != null)
                {
                    cartItem.SL++;
                }
                else
                {
                    cart.Add(new CartItem(selectedProduct, 1));
                }

                
                selectedProduct.SoLuong--;
                Display();
                DisplayCart();
            }
            else
            {
                MessageBox.Show("Sản phẩm đã hết hàng.");
            }
        }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DanhSachSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void ListSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listCart_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (ListCart.SelectedIndex >= 0)
            {
                int index = ListCart.SelectedIndex;
                CartItem selectedCartItem = cart[index];

                
                selectedCartItem.SP.SoLuong += selectedCartItem.SL;
                cart.Remove(selectedCartItem);
                Display();
                DisplayCart();
            }
        }

        private void ThanhToan_Click(object sender, EventArgs e)
        {
            if (cart.Count > 0)
            {
                MessageBox.Show("Đơn hàng đã được thanh toán thành công!", "Thanh toán");
                cart.Clear();
                Display();
                DisplayCart();
            }
            else
            {
                MessageBox.Show("Giỏ hàng hiện tại trống.", "Thông báo");
            }
        }
    }
}
