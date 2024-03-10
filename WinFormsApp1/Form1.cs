using WinFormsApp1.Models;
using System.Text.Json;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int nextId = 1;
        Personel editedPersonel = null;

        public Form1()
        {
            InitializeComponent();
        }

       


        
        void PersonelShow(Personel personel)
        {

            editedPersonel = personel;
            if (personel == null)
            {
                info.Text = "New Personel";
                btnUpdate.Text = "Add";
                txtName.Text = "";
                txtSurname.Text = "";
                txtPhone.Text = "";
                addressBox.Text = "";
                txtDepartment.SelectedIndex = 0;
                dateTimePicker1.Value = DateTime.Now;
                childNum.Value = 0;
                militarySBox.Checked = false;
                fLanguageBox.Checked = false;
                btnOhsYes.Checked = false;
                btnMasteryYes.Checked = false;
            }
            else
            {

                info.Text = "Edited Personel";
                btnUpdate.Text = "Update";
                txtName.Text = personel.Name;
                txtSurname.Text = personel.Surname;
                txtPhone.Text = personel.Phone;
                addressBox.Text = personel.Address;
                txtDepartment.SelectedIndex = personel.DepartmentId;
                dateTimePicker1.Value = personel.StartofWork;
                childNum.Value = personel.NumOfChildren;
                militarySBox.Checked = personel.MilitaryService;
                fLanguageBox.Checked = personel.ForeignLanguage;
                btnOhsYes.Checked = personel.OHS;
                btnMasteryYes.Checked = personel.Certificate_of_Mastery;
            }

        }
        private void personelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = personelList.SelectedIndex;
            if (index >= 0)
            {
                Personel personel = (Personel)personelList.Items[index];
                PersonelShow(personel);
            }
            else
            {
                PersonelShow(null);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("personel.json"))
            {
                try
                {
                    String str = File.ReadAllText("personel.json");
                    var list = JsonSerializer.Deserialize<Personel[]>(str);
                    if (list.Length > 0)
                    {
                        Personel lastPersonel = list[list.Length - 1];
                        nextId = lastPersonel.Id + 1;
                        foreach (var item in list)
                        {
                            personelList.Items.Add(item);
                        }
                        lblPerson.Text = personelList.Items.Count.ToString();
                    }
                    else
                    {
                        nextId = 1;
                    }


                }
                catch (System.Text.Json.JsonException ex)
                {
                    MessageBox.Show("JsonException: " + ex.Message);
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("FileNotFoundException: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
            



        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errPro.SetError(txtName, "Name is required");
                e.Cancel = true;
            }
            else
            {
                errPro.SetError(txtName, null);
            }
        }

        private void txtSurname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                errPro.SetError(txtSurname, "Surname is required");
                e.Cancel = true;
            }
            else
            {
                errPro.SetError(txtSurname, null);
            }
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            string str = JsonSerializer.Serialize(personelList.Items);
            File.WriteAllText("personel.json", str);
            MessageBox.Show("Personel List Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please fill the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Personel personel;
            if (editedPersonel != null)
            {
                personel = editedPersonel;
            }
            else
            {
                personel = new Personel(nextId);
            }


            personel.Name = txtName.Text;
            personel.Surname = txtSurname.Text;
            personel.Phone = txtPhone.Text;
            personel.Address = addressBox.Text;
            personel.DepartmentId = txtDepartment.SelectedIndex;
            personel.StartofWork = dateTimePicker1.Value;
            personel.NumOfChildren = (int)childNum.Value;
            personel.MilitaryService = militarySBox.Checked;
            personel.ForeignLanguage = fLanguageBox.Checked;
            personel.OHS = btnOhsYes.Checked;
            personel.Certificate_of_Mastery = btnMasteryYes.Checked;


            if (editedPersonel == null)
            {
                personelList.Items.Add(personel);
                nextId++;

            }
            else
            {
                personelList.Items[personelList.SelectedIndex] = personel;
            }

            lblPerson.Text = personelList.Items.Count.ToString();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            PersonelShow(null);
        }
       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Delete Personel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                personelList.Items.Remove(editedPersonel);
                lblPerson.Text = personelList.Items.Count.ToString();
            }



        }
       

    }
}
