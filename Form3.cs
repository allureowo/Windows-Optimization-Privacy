using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WOP
{
    public partial class Form3 : Form
    {
        bool mousedown;
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void panel2_MouseUp_1(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void panel2_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                int mousex = MousePosition.X - 400;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string packageName = "Mozilla.Firefox"; // Replace with the actual package name
            string installCommand = $"winget install {packageName}";

            // Disable the button while the installation is in progress
            button1.Enabled = false;

            try
            {
                await Task.Run(() =>
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        RedirectStandardInput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    process.StartInfo = startInfo;
                    process.Start();

                    // Send the install command to the command prompt
                    process.StandardInput.WriteLine(installCommand);
                    process.StandardInput.Flush();
                    process.StandardInput.Close();
                    process.WaitForExit();
                });

                MessageBox.Show("Package installed successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Package installation failed: {ex.Message}");
            }
            finally
            {
                // Re-enable the button after the installation is done
                button1.Enabled = true;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            {
                string packageName = "Valve.Steam"; // Replace with the actual package name
                string installCommand = $"winget install {packageName}";

                // Disable the button while the installation is in progress
                button2.Enabled = false;

                try
                {
                    await Task.Run(() =>
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            RedirectStandardInput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        process.StartInfo = startInfo;
                        process.Start();

                        // Send the install command to the command prompt
                        process.StandardInput.WriteLine(installCommand);
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        process.WaitForExit();
                    });

                    MessageBox.Show("Package installed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Package installation failed: {ex.Message}");
                }
                finally
                {
                    // Re-enable the button after the installation is done
                    button2.Enabled = true;
                }
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            {
                string packageName = "ShareX.ShareX"; // Replace with the actual package name
                string installCommand = $"winget install {packageName}";

                // Disable the button while the installation is in progress
                button3.Enabled = false;

                try
                {
                    await Task.Run(() =>
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            RedirectStandardInput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        process.StartInfo = startInfo;
                        process.Start();

                        // Send the install command to the command prompt
                        process.StandardInput.WriteLine(installCommand);
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        process.WaitForExit();
                    });

                    MessageBox.Show("Package installed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Package installation failed: {ex.Message}");
                }
                finally
                {
                    // Re-enable the button after the installation is done
                    button3.Enabled = true;
                }
            }
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            {
                string packageName = "Microsoft.VisualStudioCode"; // Replace with the actual package name
                string installCommand = $"winget install {packageName}";

                // Disable the button while the installation is in progress
                button7.Enabled = false;

                try
                {
                    await Task.Run(() =>
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            RedirectStandardInput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        process.StartInfo = startInfo;
                        process.Start();

                        // Send the install command to the command prompt
                        process.StandardInput.WriteLine(installCommand);
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        process.WaitForExit();
                    });

                    MessageBox.Show("Package installed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Package installation failed: {ex.Message}");
                }
                finally
                {
                    // Re-enable the button after the installation is done
                    button7.Enabled = true;
                }
            }
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            {
                string packageName = "LibreWolf.LibreWolf"; // Replace with the actual package name
                string installCommand = $"winget install {packageName}";

                // Disable the button while the installation is in progress
                button8.Enabled = false;

                try
                {
                    await Task.Run(() =>
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            RedirectStandardInput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        process.StartInfo = startInfo;
                        process.Start();

                        // Send the install command to the command prompt
                        process.StandardInput.WriteLine(installCommand);
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        process.WaitForExit();
                    });

                    MessageBox.Show("Package installed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Package installation failed: {ex.Message}");
                }
                finally
                {
                    // Re-enable the button after the installation is done
                    button8.Enabled = true;
                }
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            {
                string packageName = "Neovim.Neovim"; // Replace with the actual package name
                string installCommand = $"winget install {packageName}";

                // Disable the button while the installation is in progress
                button6.Enabled = false;

                try
                {
                    await Task.Run(() =>
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            RedirectStandardInput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        process.StartInfo = startInfo;
                        process.Start();

                        // Send the install command to the command prompt
                        process.StandardInput.WriteLine(installCommand);
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        process.WaitForExit();
                    });

                    MessageBox.Show("Package installed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Package installation failed: {ex.Message}");
                }
                finally
                {
                    // Re-enable the button after the installation is done
                    button6.Enabled = true;
                }
            }
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            {
                string packageName = "EpicGames.EpicGamesLauncher"; // Replace with the actual package name
                string installCommand = $"winget install {packageName}";

                // Disable the button while the installation is in progress
                button9.Enabled = false;

                try
                {
                    await Task.Run(() =>
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            RedirectStandardInput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        process.StartInfo = startInfo;
                        process.Start();

                        // Send the install command to the command prompt
                        process.StandardInput.WriteLine(installCommand);
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        process.WaitForExit();
                    });

                    MessageBox.Show("Package installed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Package installation failed: {ex.Message}");
                }
                finally
                {
                    // Re-enable the button after the installation is done
                    button9.Enabled = true;
                }
            }
        }

        private async void button10_Click(object sender, EventArgs e)
        {
            {
                string packageName = "Ubisoft.Connect"; // Replace with the actual package name
                string installCommand = $"winget install {packageName}";

                // Disable the button while the installation is in progress
                button10.Enabled = false;

                try
                {
                    await Task.Run(() =>
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            RedirectStandardInput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        process.StartInfo = startInfo;
                        process.Start();

                        // Send the install command to the command prompt
                        process.StandardInput.WriteLine(installCommand);
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        process.WaitForExit();
                    });

                    MessageBox.Show("Package installed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Package installation failed: {ex.Message}");
                }
                finally
                {
                    // Re-enable the button after the installation is done
                    button10.Enabled = true;
                }
            }
        }

        private async void button11_Click(object sender, EventArgs e)
        {
            {
                string packageName = "GIMP.GIMP"; // Replace with the actual package name
                string installCommand = $"winget install {packageName}";

                // Disable the button while the installation is in progress
                button11.Enabled = false;

                try
                {
                    await Task.Run(() =>
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            RedirectStandardInput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        process.StartInfo = startInfo;
                        process.Start();

                        // Send the install command to the command prompt
                        process.StandardInput.WriteLine(installCommand);
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        process.WaitForExit();
                    });

                    MessageBox.Show("Package installed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Package installation failed: {ex.Message}");
                }
                finally
                {
                    // Re-enable the button after the installation is done
                    button11.Enabled = true;
                }
            }
        }

        private async void button12_Click(object sender, EventArgs e)
        {
            {
                string packageName = "RARLab.WinRAR"; // Replace with the actual package name
                string installCommand = $"winget install {packageName}";

                // Disable the button while the installation is in progress
                button12.Enabled = false;

                try
                {
                    await Task.Run(() =>
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            RedirectStandardInput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        process.StartInfo = startInfo;
                        process.Start();

                        // Send the install command to the command prompt
                        process.StandardInput.WriteLine(installCommand);
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        process.WaitForExit();
                    });

                    MessageBox.Show("Package installed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Package installation failed: {ex.Message}");
                }
                finally
                {
                    // Re-enable the button after the installation is done
                    button12.Enabled = true;
                }
            }
        }

        private async void button13_Click(object sender, EventArgs e)
        {
            {
                string packageName = "ArmCord.ArmCord"; // Replace with the actual package name
                string installCommand = $"winget install {packageName}";

                // Disable the button while the installation is in progress
                button13.Enabled = false;

                try
                {
                    await Task.Run(() =>
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            RedirectStandardInput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        process.StartInfo = startInfo;
                        process.Start();

                        // Send the install command to the command prompt
                        process.StandardInput.WriteLine(installCommand);
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        process.WaitForExit();
                    });

                    MessageBox.Show("Package installed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Package installation failed: {ex.Message}");
                }
                finally
                {
                    // Re-enable the button after the installation is done
                    button13.Enabled = true;
                }
            }
        }

        private async void button14_Click(object sender, EventArgs e)
        {
            {
                string packageName = "Microsoft.VisualStudio.2022.Community.Preview"; // Replace with the actual package name
                string installCommand = $"winget install {packageName}";

                // Disable the button while the installation is in progress
                button14.Enabled = false;

                try
                {
                    await Task.Run(() =>
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            RedirectStandardInput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        process.StartInfo = startInfo;
                        process.Start();

                        // Send the install command to the command prompt
                        process.StandardInput.WriteLine(installCommand);
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        process.WaitForExit();
                    });

                    MessageBox.Show("Package installed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Package installation failed: {ex.Message}");
                }
                finally
                {
                    // Re-enable the button after the installation is done
                    button14.Enabled = true;
                }
            }
        }

        private async void button15_Click(object sender, EventArgs e)
        {
            {
                string packageName = "Python.Python.3.11"; // Replace with the actual package name
                string installCommand = $"winget install {packageName}";

                // Disable the button while the installation is in progress
                button15.Enabled = false;

                try
                {
                    await Task.Run(() =>
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            RedirectStandardInput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        process.StartInfo = startInfo;
                        process.Start();

                        // Send the install command to the command prompt
                        process.StandardInput.WriteLine(installCommand);
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        process.WaitForExit();
                    });

                    MessageBox.Show("Package installed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Package installation failed: {ex.Message}");
                }
                finally
                {
                    // Re-enable the button after the installation is done
                    button15.Enabled = true;
                }
            }
        }

        private async void button16_Click(object sender, EventArgs e)
        {
            {
                string packageName = "Mojang.MinecraftLauncher"; // Replace with the actual package name
                string installCommand = $"winget install {packageName}";

                // Disable the button while the installation is in progress
                button16.Enabled = false;

                try
                {
                    await Task.Run(() =>
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            RedirectStandardInput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        process.StartInfo = startInfo;
                        process.Start();

                        // Send the install command to the command prompt
                        process.StandardInput.WriteLine(installCommand);
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        process.WaitForExit();
                    });

                    MessageBox.Show("Package installed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Package installation failed: {ex.Message}");
                }
                finally
                {
                    // Re-enable the button after the installation is done
                    button16.Enabled = true;
                }
            }
        }

        private async void button17_Click(object sender, EventArgs e)
        {
            {
                string packageName = "nepnep.neofetch-win"; // Replace with the actual package name
                string installCommand = $"winget install {packageName}";

                // Disable the button while the installation is in progress
                button17.Enabled = false;

                try
                {
                    await Task.Run(() =>
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            RedirectStandardInput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        process.StartInfo = startInfo;
                        process.Start();

                        // Send the install command to the command prompt
                        process.StandardInput.WriteLine(installCommand);
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        process.WaitForExit();
                    });

                    MessageBox.Show("Package installed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Package installation failed: {ex.Message}");
                }
                finally
                {
                    // Re-enable the button after the installation is done
                    button17.Enabled = true;
                }
            }
        }

        private async void button18_Click(object sender, EventArgs e)
        {
            {
                string packageName = "Google.NearbyShare"; // Replace with the actual package name
                string installCommand = $"winget install {packageName}";

                // Disable the button while the installation is in progress
                button18.Enabled = false;

                try
                {
                    await Task.Run(() =>
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            RedirectStandardInput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        process.StartInfo = startInfo;
                        process.Start();

                        // Send the install command to the command prompt
                        process.StandardInput.WriteLine(installCommand);
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        process.WaitForExit();
                    });

                    MessageBox.Show("Package installed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Package installation failed: {ex.Message}");
                }
                finally
                {
                    // Re-enable the button after the installation is done
                    button18.Enabled = true;
                }
            }
        }

        private async void button19_Click(object sender, EventArgs e)
        {
            {
                string packageName = "Microsoft.PowerToys"; // Replace with the actual package name
                string installCommand = $"winget install {packageName}";

                // Disable the button while the installation is in progress
                button19.Enabled = false;

                try
                {
                    await Task.Run(() =>
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            RedirectStandardInput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        process.StartInfo = startInfo;
                        process.Start();

                        // Send the install command to the command prompt
                        process.StandardInput.WriteLine(installCommand);
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        process.WaitForExit();
                    });

                    MessageBox.Show("Package installed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Package installation failed: {ex.Message}");
                }
                finally
                {
                    // Re-enable the button after the installation is done
                    button19.Enabled = true;
                }
            }
        }

        private async void button20_Click(object sender, EventArgs e)
        {
            {
                string packageName = "TechPowerUp.GPU-Z"; // Replace with the actual package name
                string installCommand = $"winget install {packageName}";

                // Disable the button while the installation is in progress
                button20.Enabled = false;

                try
                {
                    await Task.Run(() =>
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            RedirectStandardInput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        process.StartInfo = startInfo;
                        process.Start();

                        // Send the install command to the command prompt
                        process.StandardInput.WriteLine(installCommand);
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        process.WaitForExit();
                    });

                    MessageBox.Show("Package installed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Package installation failed: {ex.Message}");
                }
                finally
                {
                    // Re-enable the button after the installation is done
                    button20.Enabled = true;
                }
            }
        }

        private async void button21_Click(object sender, EventArgs e)
        {
            {
                string packageName = "CPUID.CPU-Z"; // Replace with the actual package name
                string installCommand = $"winget install {packageName}";

                // Disable the button while the installation is in progress
                button21.Enabled = false;

                try
                {
                    await Task.Run(() =>
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            RedirectStandardInput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        process.StartInfo = startInfo;
                        process.Start();

                        // Send the install command to the command prompt
                        process.StandardInput.WriteLine(installCommand);
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        process.WaitForExit();
                    });

                    MessageBox.Show("Package installed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Package installation failed: {ex.Message}");
                }
                finally
                {
                    // Re-enable the button after the installation is done
                    button21.Enabled = true;
                }
            }
        }

        private async void button22_Click(object sender, EventArgs e)
        {
            {
                string packageName = "emoacht.Monitorian"; // Replace with the actual package name
                string installCommand = $"winget install {packageName}";

                // Disable the button while the installation is in progress
                button22.Enabled = false;

                try
                {
                    await Task.Run(() =>
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            RedirectStandardInput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };

                        process.StartInfo = startInfo;
                        process.Start();

                        // Send the install command to the command prompt
                        process.StandardInput.WriteLine(installCommand);
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        process.WaitForExit();
                    });

                    MessageBox.Show("Package installed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Package installation failed: {ex.Message}");
                }
                finally
                {
                    // Re-enable the button after the installation is done
                    button22.Enabled = true;
                }
            }
        }
    }
}