﻿using PBL03.DAL.DangNhap_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL03.BLL.DangNhap_BLL
{
    internal class Login_BLL
    {
        private static Login_BLL bll;
        public static Login_BLL Instance
        {
            get
            {
                if (bll == null)
                {
                    bll = new Login_BLL();
                }
                return bll;
            }
        }
        public void dangnhap(string Username, string Password)
        {
            Login_DAL.Instance.dangnhap(Username, Password);
        }
        public bool CheckInfor(string user, string name, string phonenumber, string address)
        {
            return Login_DAL.Instance.CheckInfor(user, name, phonenumber, address);
        }

        public void ChangePass(string Account, string newpass)
        {
            Login_DAL.Instance.ChangePass(Account, newpass);
        }
    }
}
