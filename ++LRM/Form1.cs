using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace __LRM
{
    public partial class Form1 : Form
    {
        LRMDataContext lrmDB = new LRMDataContext();
        public Form1()
        {
            InitializeComponent();
            dgvComputer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Disable button:
            btnThemSua.Enabled = false;
            btnXoa.Enabled = false;

            //Disable textbox:
            txtComputerID.Enabled = false;
            txtCPU.Enabled = false;
            txtHardDisk.Enabled = false;
            txtMornitor.Enabled = false;
            txtRAM.Enabled = false;
            txtRoomID.Enabled = false;
            txtRoomName.Enabled = false;
            txtVGA.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lrmDB.DeferredLoadingEnabled = false;
            // TODO: This line of code loads data into the 'lRMDataSet.Computer' table. You can move, or remove it, as needed.
            //this.computerTableAdapter.Fill(this.lRMDataSet.Computer);
            TreeNode root = new TreeNode();
            root.Text = "List Classes:";
            tvRoomInfor.Nodes.Add(root);
            List<Room> listRoom = lrmDB.Rooms.ToList();
            foreach (Room j in listRoom)
            {
                TreeNode node = new TreeNode(j.Room_Name);
                root.Nodes.Add(node);
            }
        }

        private void tvRoomInfor_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string select = e.Node.Text;

            if (e.Node.Text == select)
            {
                var getComputerDetails = lrmDB.Computers.Where(hh => hh.Room_Name == select).ToList();
                dgvComputer.DataSource = getComputerDetails;

                if (getComputerDetails.Count == 0)
                {
                    MessageBox.Show("Don't Have Any Data On Girdview !",
                                        "Warning", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvComputer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var computerID = dgvComputer.Rows[e.RowIndex].Cells[0].Value.ToString();
            Computer com = lrmDB.Computers.FirstOrDefault(
                            item => item.Computer_ID.Equals(int.Parse(computerID)));
            SetInputForm(com);
            txtComputerID.Text = computerID;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var check = MessageBox.Show("Do You Want To Exit ?"
                                            , "Exit", MessageBoxButtons.YesNo
                                            , MessageBoxIcon.Warning);
            if(check == DialogResult.Yes)
            {
                this.Close();
            }
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy";
                //Enable button:
                btnThemSua.Enabled = true;
                btnXoa.Enabled = true;
                //Enable textbox:
                txtComputerID.Enabled = true;
                txtCPU.Enabled = true;
                txtHardDisk.Enabled = true;
                txtMornitor.Enabled = true;
                txtRAM.Enabled = true;
                txtRoomID.Enabled = true;
                txtRoomName.Enabled = true;
                txtVGA.Enabled = true;


            }
            else
            {
                btnThem.Text = "Thêm";
                //Disable button:
                btnThemSua.Enabled = false;
                btnXoa.Enabled = false;
                //Disable textbox:
                txtComputerID.Enabled = false;
                txtCPU.Enabled = false;
                txtHardDisk.Enabled = false;
                txtMornitor.Enabled = false;
                txtRAM.Enabled = false;
                txtRoomID.Enabled = false;
                txtRoomName.Enabled = false;
                txtVGA.Enabled = false;
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(btnXoa.Text == "Xóa")
            {
                var check = MessageBox.Show("Do You Want To Delete ?",
                                "Warning", MessageBoxButtons.YesNo);

                if(check == DialogResult.Yes)
                {
                    Computer com = GetInputForm2();
                    Computer deleteCom = lrmDB.Computers.Single(
                                         item => item.Computer_ID.Equals(com.Computer_ID));
                    lrmDB.Computers.DeleteOnSubmit(deleteCom);
                    lrmDB.SubmitChanges();
                    //try
                    //{
                    //    Computer com = GetInputForm();
                    //    Computer deleteCom = lrmDB.Computers.Single(
                    //                         item => item.Computer_ID.Equals(com.Computer_ID));
                    //    lrmDB.Computers.DeleteOnSubmit(deleteCom);
                    //    lrmDB.SubmitChanges();

                    //}
                    //catch (Exception ex)
                    //{

                    //    MessageBox.Show(ex.Message);
                    //}
                }    
                else
                {

                }    



                btnThem.Text = "Thêm";
                btnThemSua.Enabled = false;
                btnXoa.Enabled = false;
            }    
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            //Submit new Computer:
            try
            {
                Computer com2 = GetInputForm2();
                lrmDB.Computers.InsertOnSubmit(com2);
                lrmDB.SubmitChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void SetInputForm(Computer c)
        {
            txtComputerID.Text = c.Computer_ID.ToString();
            txtCPU.Text = c.CPU;
            txtHardDisk.Text = c.Hard_Disk;
            txtRAM.Text = c.RAM;
            txtVGA.Text = c.VGA;
            txtMornitor.Text = c.Monitor;
            txtRoomName.Text = c.Room_Name;
            txtRoomID.Text = c.Room_ID.ToString();
        }

        private Computer GetInputForm()
        {
            if (txtCPU.Text == "")
            {
                throw new Exception("CPU Is Null");
            }
            if (txtHardDisk.Text == "")
            {
                throw new Exception("HardDisk Is Null");
            }
            if (txtRAM.Text == "")
            {
                throw new Exception("RAM Is Null");
            }
            if (txtVGA.Text == "")
            {
                throw new Exception("VGA Is Null");
            }
            if (txtMornitor.Text == "")
            {
                throw new Exception("Mornitor Is Null");
            }
            if (txtRoomName.Text == "")
            {
                throw new Exception("RoomName Is Null");
            }
            int roomID;
            if (int.TryParse(txtRoomID.Text, out roomID) == false)
            {
                throw new Exception("RoomID Don't Accept With Words, Try Again With Numeric");
            }
            int computerID;
            if (int.TryParse(txtRoomID.Text, out computerID) == false)
            {
                throw new Exception("ComputerID Don't Accept With Words, Try Again With Numeric");
            }

            Computer com = new Computer();
            com.Computer_ID = computerID;
            com.CPU = txtCPU.Text;
            com.Hard_Disk = txtHardDisk.Text;
            com.RAM = txtRAM.Text;
            com.VGA = txtVGA.Text;
            com.Monitor = txtMornitor.Text;
            com.Room_Name = txtRoomName.Text;
            com.Room_ID = roomID;

            return com;
        }

        private Computer GetInputForm2()
        {
            if (txtComputerID.Text == "")
            {
                txtComputerID.Text = "0";
            }
            if (txtCPU.Text == "")
            {
                throw new Exception("CPU Is Null");
            }
            if (txtHardDisk.Text == "")
            {
                throw new Exception("HardDisk Is Null");
            }
            if (txtRAM.Text == "")
            {
                throw new Exception("RAM Is Null");
            }
            if (txtVGA.Text == "")
            {
                throw new Exception("VGA Is Null");
            }
            if (txtMornitor.Text == "")
            {
                throw new Exception("Mornitor Is Null");
            }
            if (txtRoomName.Text == "")
            {
                throw new Exception("RoomName Is Null");
            }
            int roomID;
            if (int.TryParse(txtRoomID.Text, out roomID) == false)
            {
                throw new Exception("RoomID Don't Accept With Words, Try Again With Numeric");
            }

            Computer com2 = new Computer();
            com2.Computer_ID = int.Parse(txtComputerID.Text);
            com2.CPU = txtCPU.Text;
            com2.Hard_Disk = txtHardDisk.Text;
            com2.RAM = txtRAM.Text;
            com2.VGA = txtVGA.Text;
            com2.Monitor = txtMornitor.Text;
            com2.Room_Name = txtRoomName.Text;
            com2.Room_ID = roomID;

            return com2;
        }
    }
}
