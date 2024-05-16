using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class FoodView : UserControl
    {
        public FoodView()
        {
            InitializeComponent();
        }
        public void SetFoodItem(FoodItem foodItem)
        {
            pictureFood.ImageLocation = foodItem.hinh_anh;
            labelName.Text = foodItem.ten_mon_an;
            labelPrice.Text = foodItem.gia.ToString();
            labelAddress.Text = foodItem.dia_chi;
            labelContributor.Text = foodItem.nguoi_dong_gop;
        }
    }
}
