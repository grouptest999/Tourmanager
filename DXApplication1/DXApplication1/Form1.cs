using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private Form kiemtratontai(Type type)
        //{
        //    foreach (Form f in this.MdiChildren)
        //    {
        //        if (f.GetType() == type)
        //        {
        //            return f;
        //        }
        //    }
        //    return null;
        //}
        private void btn_Login_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Form frm = this.kiemtratontai(typeof(Login));
            //if (frm != null)
            //{
            //    frm.Activate();
            //}
            //else
            //{
            //    Login l = new Login();
            //    l.MdiParent = this;
            //    l.Show();
            //}
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void btn_log_out_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
