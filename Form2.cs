using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WOP
{
    public partial class Form2 : Form
    {
        bool mousedown;
        public Form2()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                // Get the base directory of your application
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Specify the relative path to your BAT file
                string batFilePath = Path.Combine(baseDirectory, "cleaner.bat");

                // Check if the BAT file exists
                if (File.Exists(batFilePath))
                {
                    // Create a ProcessStartInfo
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = batFilePath;

                    // Optionally, set the working directory if needed
                    // psi.WorkingDirectory = baseDirectory;

                    Process process = new Process();
                    process.StartInfo = psi;
                    process.Start();

                    // Wait for the process to exit (optional)
                    process.WaitForExit();

                    // Clean up resources
                    process.Close();

                    // Optionally, display a message when the script is done
                    MessageBox.Show("Script has completed.");
                }
                else
                {
                    MessageBox.Show("The BAT file does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the base directory of your application
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Specify the relative path to your cleaner.bat file
                string batFilePath = System.IO.Path.Combine(baseDirectory, "os-collect.bat");

                // Create a new ProcessStartInfo
                ProcessStartInfo psi = new ProcessStartInfo();

                // Set the FileName to the path of the cleaner.bat file
                psi.FileName = batFilePath;

                // You can set other properties like working directory, arguments, etc. if needed
                // psi.WorkingDirectory = baseDirectory;
                // psi.Arguments = "your_arguments_here";

                // Start the process
                Process process = new Process();
                process.StartInfo = psi;
                process.Start();

                // Wait for the process to exit (optional)
                process.WaitForExit();

                // Clean up resources
                process.Close();

                // Optionally, you can display a message when the script is done
                MessageBox.Show("Cleaner script has completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the base directory of your application
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Specify the relative path to your cleaner.bat file
                string batFilePath = System.IO.Path.Combine(baseDirectory, "NOSEC.bat");

                // Create a new ProcessStartInfo
                ProcessStartInfo psi = new ProcessStartInfo();

                // Set the FileName to the path of the cleaner.bat file
                psi.FileName = batFilePath;

                // You can set other properties like working directory, arguments, etc. if needed
                // psi.WorkingDirectory = baseDirectory;
                // psi.Arguments = "your_arguments_here";

                // Start the process
                Process process = new Process();
                process.StartInfo = psi;
                process.Start();

                // Wait for the process to exit (optional)
                process.WaitForExit();

                // Clean up resources
                process.Close();

                // Optionally, you can display a message when the script is done
                MessageBox.Show("Cleaner script has completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the base directory of your application
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Specify the relative path to your cleaner.bat file
                string batFilePath = System.IO.Path.Combine(baseDirectory, "services.bat");

                // Create a new ProcessStartInfo
                ProcessStartInfo psi = new ProcessStartInfo();

                // Set the FileName to the path of the cleaner.bat file
                psi.FileName = batFilePath;

                // You can set other properties like working directory, arguments, etc. if needed
                // psi.WorkingDirectory = baseDirectory;
                // psi.Arguments = "your_arguments_here";

                // Start the process
                Process process = new Process();
                process.StartInfo = psi;
                process.Start();

                // Wait for the process to exit (optional)
                process.WaitForExit();

                // Clean up resources
                process.Close();

                // Optionally, you can display a message when the script is done
                MessageBox.Show("Cleaner script has completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the base directory of your application
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Specify the relative path to your cleaner.bat file
                string batFilePath = System.IO.Path.Combine(baseDirectory, "bloat.bat");

                // Create a new ProcessStartInfo
                ProcessStartInfo psi = new ProcessStartInfo();

                // Set the FileName to the path of the cleaner.bat file
                psi.FileName = batFilePath;

                // You can set other properties like working directory, arguments, etc. if needed
                // psi.WorkingDirectory = baseDirectory;
                // psi.Arguments = "your_arguments_here";

                // Start the process
                Process process = new Process();
                process.StartInfo = psi;
                process.Start();

                // Wait for the process to exit (optional)
                process.WaitForExit();

                // Clean up resources
                process.Close();

                // Optionally, you can display a message when the script is done
                MessageBox.Show("Cleaner script has completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                int mousex = MousePosition.X - 400;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }
    }
}
