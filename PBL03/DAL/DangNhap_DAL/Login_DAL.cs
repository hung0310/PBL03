﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL03.DAL.DangNhap_DAL
{
    internal class Login_DAL
    {
        private PBL3Entities1 db;
        private static Login_DAL _Instance;
        public static Login_DAL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new Login_DAL();
                return _Instance;
            }
        }
        private Login_DAL()
        {
            db = new PBL3Entities1();
        }
        public void dangnhap(string Username, string Password)
        {
            var user1 = db.Accounts.FirstOrDefault(u => u.Username == Username && u.NameType == "quanly");
            var uses2 = db.Accounts.FirstOrDefault(u => u.Username == Username && u.NameType == "thungan");
            if (user1 == null && uses2 == null)
            {
                MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string hashedPassword = user1 != null ? user1.PW : uses2.PW;
                if (BCrypt.Net.BCrypt.Verify(Password, hashedPassword))
                {

                    if (user1 != null)
                    {
                        Form_Admin fad = new Form_Admin();
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fad.Show();
                    }
                    else
                    {
                        FormMain ftn = new FormMain();
                        ftn.lbNameUser.Text = Username;
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ftn.Show();
                    }
                }

                else
                {
                    MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public bool CheckInfor(string user, string name, string phonenumber, string address)
        {
            var query = db.Employees.FirstOrDefault(u => u.Acc == user && u.Name_Employee == name && u.PhoneNumber == phonenumber && u.Address_Employee == address);
            if (query == null) return false;
            else return true;
        }

        public void ChangePass(string Account, string newpass)
        {
            var query = db.Accounts.FirstOrDefault(u => u.Username == Account);
            query.PW = newpass;
            db.SaveChanges();
        }
    }
}