﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PBL03.DAL
{
    public class Change_StatusTable_DAL
    {
        private PBL3Entities1 db;
        public Change_StatusTable_DAL()
        {
            db = new PBL3Entities1 ();
        }
        public void setColor_Table(Guna2TileButton btn, string id)
        {
            using (var db = new PBL3Entities1())
            {
                var table = db.TableFoods.Find(id);
                //foreach (var i in table)
                //{
                //    btn = new Guna2TileButton();
                //    btn.Text = $"{i.ID_Table}";
                //    btn.FillColor = i.statusTable ? Color.Green : Color.Red;
                //}
                //btn = new Guna2TileButton();
                btn.Text = table.ID_Table;
                btn.Tag = id;
                btn.FillColor = table.statusTable ? Color.LimeGreen : Color.Red;
            //    return btn;
            }    
        }
        public void changeStatus(string id, bool status, int people)
        {
            using (var db = new PBL3Entities1())
            {
                var table = db.TableFoods.Find(id);
                table.statusTable = status;
                table.Capacity = people;
                db.SaveChanges();
            }    
        }
        public List<TableFood> GetAllTables()
        {
            return db.TableFoods.ToList();
        }
        public void UpdateTable(string id, bool st, int people)
        {
            TableFood tb = db.TableFoods.Find(id);
            if (tb != null)
            {
                tb.statusTable = st;
                tb.Capacity = people;
                db.SaveChanges();
            }
        }
        public void setColor_Table(FlowLayoutPanel flowpanel)
        {
            using (var db = new PBL3Entities1())
            {
                var data = db.TableFoods.ToList();
                foreach (var btn in flowpanel.Controls.OfType<Guna2TileButton>())
                {
                //    btn.Size = new Size(btn.Width, btn.Height);
                    var id = btn.Text;
                    var table = data.FirstOrDefault(p => p.ID_Table == id);
                    if (table != null && table.statusTable == true)
                    {
                        btn.FillColor = Color.Red;
                    }
                    else
                    {
                        btn.FillColor = Color.LimeGreen;
                    }
                    
                }
            }
        }
        public void Show_in_RickTextBox_DAL(string IDTable, RichTextBox rtb)
        {
            rtb.Text = "\t\t\t\t" + IDTable + "\n\n    Tên món \t\t\t\t Số lượng \n\n";
            var query = db.OrderTables
                .Join(db.Foods, p => p.IDFood, c => c.ID_Food, (p, c) => new { OrderTable = p, Food = c })
                .Where(x => x.OrderTable.IDTable == IDTable)
                .Select(x => new
                {
                    x.OrderTable.IDTable,
                    x.Food.NameFood,
                    x.OrderTable.Quantity
                }).ToList();
            foreach(var item in query)
            {
                rtb.AppendText("  " + item.NameFood.PadRight(20) + item.Quantity.ToString().PadLeft(20) + "\n");
            }
        }
    }
}
