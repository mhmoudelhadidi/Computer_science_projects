using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//the core namespace
using System.Windows.Forms;
using System.IO;  //dire  //file

namespace WindowsFormsApp1
{
    public partial class frmform : Form
    {
        public frmform()
        {
            InitializeComponent();
        }


        //Folder
        //01.create folder
        private void CreFol_Click(object sender, EventArgs e)
        {
                                        
            bool exists = System.IO.Directory.Exists(path.Text + "//" + name.Text);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(path.Text + "//" + name.Text);
                MessageBox.Show("Folder Successfully Created... ");
            }
            else
            {
                MessageBox.Show("Aleardy Exists....");
            }
           
        }




        //Folder
        //02.delete folder

        private void btndelete_Click(object sender, EventArgs e)
        {
            //Delete is an overloading method

            bool exists = System.IO.Directory.Exists(path.Text);
            if (exists)
            {
                System.IO.Directory.Delete(path.Text, true);
                MessageBox.Show("Folder Successfully Deleted... ");
            }
            else
            {
                MessageBox.Show("Folder does not Exist....");
            }

        }




        

        //folder
        //03.move the folder
        private void btnmove_Click(object sender, EventArgs e)
        {

            bool exists = System.IO.Directory.Exists(path.Text);

            //if exists move it
            if (exists)
            {
                string newfoldername = "";
                for (int i = 0; i < path.Text.Length; i++)  //  C:\test\\moved == moved
                {

                    if (path.Text[i] == '\\')
                    {
                        newfoldername = "";
                    }
                    else
                        newfoldername += path.Text[i];
                }
                //MessageBox.Show(newfoldername);


                //create new direc with the old name
                System.IO.Directory.CreateDirectory(npath.Text + "//" + newfoldername);
                System.IO.Directory.Delete(path.Text, true);
                MessageBox.Show("Folder Successfully Moved to the new directory... ");
            }
            else
            {
                MessageBox.Show("Not found ....");
            }

        }




        //Folder
        //04.Rename the folder

        private void button4_Click(object sender, EventArgs e) 
        {
            string newfoldername = "";
            string InewPath = "";


            //To Get The Path in which the folder you want to rename in   "Inewpath"
            for (int i = 0; i < path.Text.Length; i++)
            {

                if (path.Text[i] == '\\')
                {
                    newfoldername = "";
                }
                else
                    newfoldername += path.Text[i];
            }

            for (int i = 0; i < path.Text.Length - newfoldername.Length; i++) //  C:\test\\moved  
                                                                              //           moved
            {
                InewPath += path.Text[i];
            }




            bool exists = System.IO.Directory.Exists(path.Text);    //  C:\test\\moved  
                                                                    //           moved
                                                                    //  C:\test\\
            if (exists)     
            {

                System.IO.Directory.CreateDirectory(InewPath + "//" + NN.Text); 
                System.IO.Directory.Delete(path.Text, true);
                MessageBox.Show("Folder Successfully Created... ");

            }
            else
            {
                MessageBox.Show("The folder you want to rename does not Exist....");
            }

        }





        //File
        //05.create file
        private void button1_Click(object sender, EventArgs e)
        {

          
            //optional
            //to link the folder with the file
            string file = System.IO.Path.Combine(path.Text, name.Text); 

            //checking 
            if (!System.IO.File.Exists(file))
            {
                System.IO.File.Create(file);
                MessageBox.Show("File Successfully Created... ");

            }
            else
                MessageBox.Show("Already Exists....");
        }
 




        //File
        //06.Delete file

        private void button2_Click(object sender, EventArgs e)
        {


            //to link the folder with the file
            string file = System.IO.Path.Combine(path.Text, name.Text);
            bool exists = System.IO.File.Exists(file);
            if (exists)
            {
                //no overloading
                System.IO.File.Delete(file);
                MessageBox.Show("File Successfully Deleted... ");
            }
            else
            {
                MessageBox.Show(" The file you want to delete does not  Exist....");
            }

        }




        //File
        //07.Move file
        private void button3_Click(object sender, EventArgs e)
        {
            //to link the folder with the file 
            string oldfile = System.IO.Path.Combine(path.Text, name.Text);
            string newfile = System.IO.Path.Combine(npath.Text, name.Text); //by same name different path

            //checking 
            if (System.IO.File.Exists(oldfile))
            {
                System.IO.File.Create(newfile);
                System.IO.File.Delete(oldfile);
                MessageBox.Show("File Successfully Moved... ");
            }
            else
                MessageBox.Show("Not Exist....");
        }




        //File
        //08.Rename file
        private void button4_Click_1(object sender, EventArgs e)
        {


            //to link the folder with the file
            string file = System.IO.Path.Combine(path.Text, name.Text);
            string Renamedfile = System.IO.Path.Combine(path.Text, NN.Text);  //by same path
                                                                              //but different name

            //checking 
            if (System.IO.File.Exists(file))
            {
                System.IO.File.Create(Renamedfile);
                System.IO.File.Delete(file);
                MessageBox.Show("File Successfully Renamed... ");

            }
            else
                MessageBox.Show("Not Exist....");
        }

 
    }
}
