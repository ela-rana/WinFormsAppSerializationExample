using System;
using System.Windows.Forms;
using System.IO;    //needed for file operations
using System.Runtime.Serialization.Formatters.Binary;   //needed for binary ser/deser-ialization
using System.Runtime.Serialization.Formatters.Soap;   //needed for XML serialization
using System.Runtime.Serialization.Json;    //for json serialization

namespace WinFormsAppSerializationExample
{
    public partial class Form1 : Form
    {
        Student student;    //to create a student object of the Student class type
        string binaryFilePath = "BinarySerializedFile.txt"; //filename where binary serialized data is saved
        string xmlFilePath = "XMLSerializedFile.txt"; //filename where xml serialized data is saved
        string jsonFilePath = "JSONSerializedFile.txt"; //filename where json serialized data is saved
        FileStream fileStream = null;   //to create a file stream to read and write serialized values to files
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //we don't want the serialize or deserialize buttons to be clickable until we create a record first, so at form
            //load we are keeping them disabled then after we create a record they will become enabled
            btnBinarySerialize.Enabled = false;
            btnBinaryDeserialize.Enabled = false;
            btnXMLSerialize.Enabled = false;
            btnXMLDeserialize.Enabled = false;
            btnJSONSerialize.Enabled = false;
            btnJSONDeserialize.Enabled = false;
        }
        private void btnCreateStudentRecord_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStudentID.Text) && !string.IsNullOrEmpty(txtFullName.Text) &&
                !string.IsNullOrEmpty(txtGPA.Text))
            {
                //to intialize student
                student = new Student();
                student.StudentID = Int32.Parse(txtStudentID.Text);
                student.Name = txtFullName.Text;
                student.GPA = Single.Parse(txtGPA.Text);
                lblMessages.Visible = true;
                lblMessages.Text = "Record created";  //to display a message that the record has been created
                btnBinarySerialize.Enabled = true;    //now that the record has been created, we want to be able to serialize
                                                      //it so we mark the button enabled, but we keep deserialize button disabled because we cannot deserialize
                                                      //until we serialize it first
                btnXMLSerialize.Enabled = true;
                btnJSONSerialize.Enabled = true;
            }
            else
            {
                MessageBox.Show("All fields must be filled");
            }
        }

        private void btnBinarySerialize_Click(object sender, EventArgs e)
        {
            lblMessages.Visible=false;
            try
            {
                fileStream = new FileStream(binaryFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, student);  //filestream- where to put serialized, student- what to serialize
                lblMessages.Visible = true;
                lblMessages.Text = "Object has been binary serialized";
                btnBinaryDeserialize.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fileStream.Close();
            }
        }

        private void btnBinaryDeserialize_Click(object sender, EventArgs e)
        {
            lblMessages.Visible = false;
            try
            {
                fileStream = new FileStream(binaryFilePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                Student temp = (Student)formatter.Deserialize(fileStream);  //reads byte stream and puts it back into object
                lblMessages.Visible = true;
                lblMessages.Text = $"Here is the binary deserialized data:\nStudent ID: {temp.StudentID}, Name: {temp.Name}, GPA: {temp.GPA}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fileStream.Close();
            }
        }

        private void btnXMLSerialize_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(xmlFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                SoapFormatter formatter = new SoapFormatter();
                formatter.Serialize(fileStream, student);  //filestream- where to put serialized, student- what to serialize
                lblMessages.Visible = true;
                lblMessages.Text = "Object has been XML serialized";
                btnXMLDeserialize.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fileStream.Close();
            }
        }

        private void btnXMLDeserialize_Click(object sender, EventArgs e)
        {
            try
            {
                fileStream = new FileStream(xmlFilePath, FileMode.Open, FileAccess.Read);
                SoapFormatter formatter = new SoapFormatter();
                Student temp = (Student)formatter.Deserialize(fileStream);  //reads byte stream and puts it back into object
                lblMessages.Visible = true;
                lblMessages.Text = $"Here is the XML deserialized data:\nStudent ID: {temp.StudentID}, Name: {temp.Name}, GPA: {temp.GPA}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fileStream.Close();
            }
         }

        private void btnJSONSerialize_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(jsonFilePath, FileMode.Create, FileAccess.Write);
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Student));
                serializer.WriteObject(fileStream, student);  //filestream- where to put serialized, student- what to serialize
                lblMessages.Visible = true;
                lblMessages.Text = "Object has been JSON serialized";
                btnJSONDeserialize.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fileStream.Close();
            }
        }

        private void btnJSONDeserialize_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(jsonFilePath, FileMode.Open, FileAccess.Read);
                DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(Student));
                Student temp = (Student)deserializer.ReadObject(fileStream); //reads byte stream and puts it back into object
                //Student temp = deserializer.ReadObject(fileStream) as Student;  //this is exactly same as the line above it. 2 ways of type casting
                lblMessages.Visible = true;
                lblMessages.Text = $"Here is the JSON deserialized data:\nStudent ID: {temp.StudentID}, Name: {temp.Name}, GPA: {temp.GPA}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fileStream.Close();
            }
        }

        private void txtStudentID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int temp;   //a temporary variable to hold the value entered in the Student ID textbox
            bool parsed = Int32.TryParse(txtStudentID.Text, out temp);  //bool to check if user entered value parses to an integer
            if (parsed == false || temp < 1)  //if user entry is not an int or id is 0 or a negative number, then we need to get new entry
            {
                MessageBox.Show("Student ID must be a whole number ID greater than 0.\nIt cannot be blank"); //show error message
                txtStudentID.Clear();   //blank out the textbox so value can be reentered
            }
        }

        private void txtGPA_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            float temp;   //a temporary variable to hold the value entered in the GPA textbox
            bool parsed = Single.TryParse(txtGPA.Text, out temp);  //bool to check if user entered value parses to a float
            if (parsed == false || temp < 0 || temp > 4)  //if user entry is not a float or GPA is not between 0.0-4.0
            {
                MessageBox.Show("GPA value must be a whole number or decimal between 0.00 to 4.00\nIt cannot be blank"); //show error message
                txtGPA.Clear();   //blank out the textbox so value can be reentered
            }
        }
    }
}
