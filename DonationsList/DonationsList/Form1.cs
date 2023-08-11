using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonationsList
{
    public partial class DonationsList : Form
    {
        int age;
        string nickName;
        decimal amount;
        Personal p;
        Business b;

        public DonationsList()
        {
            InitializeComponent();
        }
     
        public void BtnAddDonation_Click(object sender, EventArgs e)
        {

            try
            {
                if (sender == rdPersonal)
                {
                    Personal p = new Personal
                {
                    FirstName = TxtFirstName.Text,
                    LastName = TxtLastName.Text,
                    PhoneNumber = TxtPhoneNumber.Text,
                   
                    };

                    nickName = p.GiveANickName(TxtFirstName.Text, TxtLastName.Text);
                    age = int.Parse(TxtAge.Text);
                    amount = p.GiveMoney();

                    AddDonationToListBoxp(p);
                    
                    TxtAge.Text = " ";
                    TxtFirstName.Text = " ";
                    TxtLastName.Text = " ";
                    TxtPhoneNumber.Text = " ";
                }
                else if (sender == rdBusiness)
                {
                    Business b = new Business
                    {
                        FirstName = TxtFirstName.Text,
                        LastName = TxtLastName.Text,
                        PhoneNumber = TxtPhoneNumber.Text
                    };

                    nickName = b.GiveANickName(TxtFirstName.Text, TxtLastName.Text);
                    amount = b.GiveMoney();
                    age = int.Parse(TxtAge.Text);

                    AddDonationToListBoxb(b);
                    TxtAge.Text = " ";
                    TxtFirstName.Text = " ";
                    TxtLastName.Text = " ";
                    TxtPhoneNumber.Text = " ";
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                TxtAge.Text = " ";
                TxtFirstName.Text = " ";
                TxtLastName.Text = " ";
                TxtPhoneNumber.Text = " ";
            }
        }

        private void AddDonationToListBoxb(Business b)
        {
            listBox.Items.Add(b.FirstName + "--" + b.LastName + "--" + b.PhoneNumber + "-- " + age + "-- (" + nickName + ")-- $" + amount + "-- Business Donation");
        }

        private void AddDonationToListBoxp(Personal p)
        {
            listBox.Items.Add(p.FirstName + "-- " + p.LastName + "-- " + p.PhoneNumber + "-- " + age + "-- (" + nickName + ")-- $" + amount + "-- Personal Donation");
        }
    }
}
