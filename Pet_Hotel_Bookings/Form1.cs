using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pet_Hotel_Bookings
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        int Id = 0;

        private void lbl_Dog_Name_Click(object sender, EventArgs e)
        {

        }

        private void btn_Dog_Book_Click(object sender, EventArgs e)
        {
            try
            {
                string today = DateTime.UtcNow.ToString("MM-dd-yyyy");
                SqlConnection cnn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\admin\\source\\repos\\Pet_Hotel_Bookings\\Pet_Hotel_Bookings\\HotelDatabase.mdf;Integrated Security=True");
                cnn.Open();
                SqlCommand add = new SqlCommand(string.Format("INSERT INTO Dog VALUES(@DogName,@DogBreed,@DogAge,@SubDate)"), cnn);
                add.Parameters.AddWithValue("@DogName", txt_Dog_Name.Text);
                add.Parameters.AddWithValue("@DogBreed", txt_Dog_Breed.Text);
                add.Parameters.AddWithValue("@DogAge", int.Parse(txt_Dog_Age.Text));
                add.Parameters.AddWithValue("@SubDate", today.ToString());
                add.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Succesfully Booked !!");
            }
            catch (Exception q) 
            { 
                MessageBox.Show("Wrong Info !!");
            }
        }

        private void btn_Cat_Book_Click(object sender, EventArgs e)
        {
            try
            {
                string today = DateTime.UtcNow.ToString("MM-dd-yyyy");
                SqlConnection cnn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\admin\\source\\repos\\Pet_Hotel_Bookings\\Pet_Hotel_Bookings\\HotelDatabase.mdf;Integrated Security=True");
                cnn.Open();
                SqlCommand add = new SqlCommand(string.Format("INSERT INTO Cats VALUES(@CatName,@CatBreed,@CatAge,@SubDate)"), cnn);
                add.Parameters.AddWithValue("@CatName", txt_Cat_name.Text);
                add.Parameters.AddWithValue("@CatBreed", txt_Cat_breed.Text);
                add.Parameters.AddWithValue("@CatAge", int.Parse(txt_Cat_Age.Text));
                add.Parameters.AddWithValue("@SubDate", today.ToString());
                add.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Succesfully Booked !!");
            }
            catch (Exception r) 
            {
                MessageBox.Show("Wrong info !!");
            }
        }

        private void btn_checkOut_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxDog.Checked)
                {
                    SqlConnection cnn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\admin\\source\\repos\\Pet_Hotel_Bookings\\Pet_Hotel_Bookings\\HotelDatabase.mdf;Integrated Security=True");
                    cnn.Open();
                    SqlCommand search = new SqlCommand(string.Format("SELECT Sub_Date FROM Dog WHERE Name=@Name AND Breed=@Breed AND Age=@Age"), cnn);
                    search.Parameters.AddWithValue("@Name", txt_checkOut_Name.Text);
                    search.Parameters.AddWithValue("@Breed", txt_checkOut_Breed.Text);
                    search.Parameters.AddWithValue("@Age", int.Parse(txt_checkOut_Age.Text));
                    search.ExecuteNonQuery();
                    MessageBox.Show("Booking date was : " + search.ExecuteScalar().ToString());
                    cnn.Close();
                }
                else if (checkBoxCat.Checked)
                {
                    SqlConnection cnn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\admin\\source\\repos\\Pet_Hotel_Bookings\\Pet_Hotel_Bookings\\HotelDatabase.mdf;Integrated Security=True");
                    cnn.Open();
                    SqlCommand search = new SqlCommand(string.Format("SELECT Subscr_Date FROM Cats WHERE Name=@Name AND Breed=@Breed AND Age=@Age"), cnn);
                    search.Parameters.AddWithValue("@Name", txt_checkOut_Name.Text);
                    search.Parameters.AddWithValue("@Breed", txt_checkOut_Breed.Text);
                    search.Parameters.AddWithValue("@Age", int.Parse(txt_checkOut_Age.Text));
                    search.ExecuteNonQuery();
                    MessageBox.Show("Booking date was :" + search.ExecuteScalar().ToString());
                    cnn.Close();
                }
                else if (checkBoxDog.Checked && checkBoxCat.Checked)
                {
                    MessageBox.Show("Wrong info !!");
                }
                else
                {
                    MessageBox.Show("Wrong info !!");
                }
            }

            catch (Exception w) 
            {
                MessageBox.Show("Wrong info !!");
            }
        }
    }
}
