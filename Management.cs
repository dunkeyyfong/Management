using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AnimalManagement
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        int index;
        bool isEdit = false;
        bool isAdd = false;
        int n = 0;

        AnimalManagement[] pLists = new AnimalManagement[100];

        OpenFileDialog openFileDialog1 = new OpenFileDialog();

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (!isAdd)
            {
                btnAddNew.Text = "Save";
                txtID.Enabled = true;
                txtName.Enabled = true;
                txtNational.Enabled = true;
                cboxType.Enabled = true;
            }
            else
            {
                if (CheckInput())
                {
                    AnimalManagement a = new AnimalManagement(); 
                    a.nameAnimal = txtName.Text;
                    a.idAnimal = txtID.Text;
                    a.typeAnimal = cboxType.SelectedItem.ToString();
                    a.imageAnimal = openFileDialog1.FileName;
                    a.fromAnimal = txtNational.Text;
                    pLists[n] = a;
                    n++;
                    btnAddNew.Text = "Add New";
                    LoadData(pLists);
                    MessageBox.Show(this, "Successfully added!!!",
                        "Result",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    txtID.Enabled = false;
                    txtName.Enabled = false;
                    txtNational.Enabled = false;
                    cboxType.Enabled = false;
                }
            }
            isAdd = !isAdd;

            txtName.Text = null;
            txtID.Text = null;
            txtImage.Text = null;
            cboxType.SelectedIndex = 0;
            txtNational.Text = null;
            pBoxImage.Image = null;

        }

        private bool CheckInput()
        {
            if (txtID.Text.Trim().Length == 0)
            {
                MessageBox.Show(this, "Id can not blank!!!", 
                    "Noitice", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
                txtID.Focus();
                return false;
            }
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show(this, "Name can not blank!!!", 
                    "Noitice", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboxType.Text.Trim().Length == 0)
            {
                MessageBox.Show(this, "Type can not blank!!!", 
                    "Noitice", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
            }
            if (txtImage.Text.Trim().Length == 0)
            {
                MessageBox.Show(this, "Image can not blank!!!", 
                    "Noitice", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtNational.Text.Trim().Length == 0)
            {
                MessageBox.Show(this, "National can not blank!!!", 
                    "Noitice", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "D:\\";  
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.gif)|*.gif|(*jpeg)|*jpeg|(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = openFileDialog1.FileName;
                pBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pBoxImage.Image = new Bitmap(openFileDialog1.FileName);

            }
        }

        private void LoadData(AnimalManagement[] pLists)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("nameAnimal", typeof(string)));
            dt.Columns.Add(new DataColumn("idAnimal", typeof(string)));
            dt.Columns.Add(new DataColumn("typeAnimal", typeof(string)));
            dt.Columns.Add(new DataColumn("imageAnimal", typeof(string)));
            dt.Columns.Add(new DataColumn("fromAnimal", typeof(string)));

            for (int i = 0; i < n; i++)
            {
                AnimalManagement a = pLists[i];
                if (a != null)
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = a.nameAnimal;
                    dr[1] = a.idAnimal;
                    dr[2] = a.typeAnimal;
                    dr[3] = a.imageAnimal;
                    dr[4] = a.fromAnimal;
                    dt.Rows.Add(dr);
                }
            }
            grvAnimal.DataSource = dt.DefaultView;
        }

        private void grvAnimal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            AnimalManagement a = pLists[index];
            PutData(a);
        }

        private void PutData(AnimalManagement a)
        {
            txtID.Text = a.idAnimal;
            txtName.Text = a.nameAnimal;
            cboxType.Text = a.typeAnimal;
            txtImage.Text = a.imageAnimal.ToString();
            txtNational.Text = a.fromAnimal;
            pBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxImage.Image = new Bitmap(a.imageAnimal);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                btnUpdate.Text = "Save";
                txtID.Enabled = true;
                txtName.Enabled = true;
                txtNational.Enabled = true;
                cboxType.Enabled = true;
            }
            else
            {
                    AnimalManagement a = pLists[index];
                    a.nameAnimal = txtName.Text;
                    a.idAnimal = txtID.Text;
                    a.typeAnimal = cboxType.SelectedItem.ToString();
                    a.imageAnimal = txtImage.Text;
                    btnUpdate.Text = "Edit";
                    LoadData(pLists);
                    MessageBox.Show(this, "Edited successful!!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtID.Enabled = false;
                    txtName.Enabled = false;
                    txtNational.Enabled = false;
                    cboxType.Enabled = false;
            }
            isEdit = !isEdit;

            txtName.Text = null;
            txtID.Text = null;
            txtImage.Text = null;
            cboxType.SelectedIndex = 0;
            txtNational.Text = null;
            pBoxImage.Image = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete?",
                "Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                while (index < n - 1)
                {
                    pLists[index] = pLists[index + 1];
                    index++;
                }

                pLists[n - 1] = null;
                n = n - 1;
                LoadData(pLists);
                MessageBox.Show(this, "Delete successful!!!",
                    "Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            txtName.Text = null;
            txtID.Text = null;
            txtImage.Text = null;
            cboxType.SelectedIndex = 0;
            txtNational.Text = null;
            pBoxImage.Image = null;
        }

        private void Management_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtName.Enabled = false;
            txtNational.Enabled = false;
            cboxType.Enabled = false;
        }
    }
}
