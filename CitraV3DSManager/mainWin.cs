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
using Microsoft.WindowsAPICodePack.Dialogs;

namespace CitraV3DSManager
{
    public partial class mainWin : Form
    {
        private firstSetup fSetup;
        private setName nameSetter = new setName();
        private StreamWriter sw;
        private StreamReader sr;
        public string CitraFolder = "";
        public string cName = "";

        public mainWin()
        {
            InitializeComponent();
            toggleUIActive(false);
        }

        /// <summary>
        /// Selects Citra Folder and initilizes Virtual System List (Button Click)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_uF_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                tb_uF.Text = dialog.FileName;
                CitraFolder = dialog.FileName;

                if (!Directory.Exists(Path.Combine(CitraFolder, "v3DS")))
                {
                    MessageBox.Show("It looks like, you're using this Software for the first time. In the following Window, you can Name your current Setup");
                    fSetup = new firstSetup();
                    fSetup.ShowDialog();


                    Directory.CreateDirectory(Path.Combine(CitraFolder, "v3DS"));

                    sw = new StreamWriter(Path.Combine(CitraFolder, "v3DS", "current.txt"), false, Encoding.UTF8);
                    sw.WriteLine(fSetup.setName);
                    sw.Flush();
                    sw.Close();
                }

                cName = readFile(Path.Combine(CitraFolder, "v3DS", "current.txt"));
                lb_V3DS.Items.Clear();
                lb_V3DS.Items.AddRange(getAllVSystems());
                lbl_currentName.Text = cName;

                toggleUIActive(true);
            }
        }

        /// <summary>
        /// Switches between selected v3DS and current v3DS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_select_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.Combine(CitraFolder, "v3DS", cName)))
            {
                MessageBox.Show("Can't switch v3DS because current Name is already occupied!", "Switch blocked!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lb_V3DS.SelectedIndex < 0)
            {
                MessageBox.Show("Can't switch without selecting new v3DS!", "Switch blocked!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nName = (string)lb_V3DS.SelectedItem;

                Directory.CreateDirectory(Path.Combine(CitraFolder, "v3DS", cName));
                Directory.Move(Path.Combine(CitraFolder, "nand"), Path.Combine(CitraFolder, "v3DS", cName, "nand"));
                Directory.Move(Path.Combine(CitraFolder, "sdmc"), Path.Combine(CitraFolder, "v3DS", cName, "sdmc"));
                
                if (Directory.Exists(Path.Combine(CitraFolder, "v3DS", nName, "nand")))
                {
                    Directory.Move(Path.Combine(CitraFolder, "v3DS", nName, "nand"), Path.Combine(CitraFolder, "nand"));
                }
                else
                {
                    Directory.CreateDirectory(Path.Combine(CitraFolder, "nand"));
                }
                if (Directory.Exists(Path.Combine(CitraFolder, "v3DS", nName, "sdmc")))
                {
                    Directory.Move(Path.Combine(CitraFolder, "v3DS", nName, "sdmc"), Path.Combine(CitraFolder, "sdmc"));
                }
                else
                {
                    Directory.CreateDirectory(Path.Combine(CitraFolder, "sdmc"));
                }
                Directory.Delete(Path.Combine(CitraFolder, "v3DS", nName));

                sw = new StreamWriter(Path.Combine(CitraFolder, "v3DS", "current.txt"), false, Encoding.UTF8);
                sw.WriteLine(nName);
                sw.Flush();
                sw.Close();

                cName = nName;
                lb_V3DS.Items.Clear();
                lb_V3DS.Items.AddRange(getAllVSystems());
                lbl_currentName.Text = cName;
            }
        }

        /// <summary>
        /// Adds an Empty v3DS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addEmpty_Click(object sender, EventArgs e)
        {
            nameSetter.title = "Add Empty System";
            nameSetter.ShowDialog();

            if (nameSetter.setOutput)
            {
                Directory.CreateDirectory(Path.Combine(CitraFolder, "v3DS", nameSetter.output));

                lb_V3DS.Items.Clear();
                lb_V3DS.Items.AddRange(getAllVSystems());
            }
        }

        /// <summary>
        /// Duplicates selected v3DS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_duplicate_Click(object sender, EventArgs e)
        {
            string copname = (string)lb_V3DS.SelectedItem;

            if (lb_V3DS.SelectedIndex < 0)
            {
                MessageBox.Show("Can't do this action with a selection");
            }
            else
            {
                nameSetter.title = "Rename Current v3DS";
                nameSetter.ShowDialog();

                if (nameSetter.setOutput)
                {
                    string nName = nameSetter.output;

                    DirectoryCopy(Path.Combine(CitraFolder, "v3DS", copname), Path.Combine(CitraFolder, "v3DS", nName));

                    lb_V3DS.Items.Clear();
                    lb_V3DS.Items.AddRange(getAllVSystems());
                }
            }
        }

        /// <summary>
        /// Deletes the Selected v3DS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_del_Click(object sender, EventArgs e)
        {
            string delname = (string)lb_V3DS.SelectedItem;

            if (lb_V3DS.SelectedIndex < 0)
            {
                MessageBox.Show("Can't do this action with a selection");
            }
            else
            {
                var msgBoxRes = MessageBox.Show("This will permanently remove all Data stored within this Virtual 3DS!\nAre you sure, you want to continue?", "Irreversable Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (msgBoxRes == DialogResult.Yes)
                {
                    Directory.Delete(Path.Combine(CitraFolder, "v3DS", delname), true);

                    lb_V3DS.Items.Clear();
                    lb_V3DS.Items.AddRange(getAllVSystems());
                }
            }
        }

        /// <summary>
        /// Renames the current v3DS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_rename_Click(object sender, EventArgs e)
        {
            nameSetter.title = "Rename Current v3DS";
            nameSetter.ShowDialog();

            if (nameSetter.setOutput)
            {
                cName = nameSetter.output;

                sw = new StreamWriter(Path.Combine(CitraFolder, "v3DS", "current.txt"), false, Encoding.UTF8);
                sw.WriteLine(cName);
                sw.Flush();
                sw.Close();
                lbl_currentName.Text = cName;
            }
        }


        /// <summary>
        /// Toggles UI Button Enabled property
        /// </summary>
        /// <param name="enabled"></param>
        private void toggleUIActive(bool enabled)
        {
            gb_current.Enabled = enabled;
            lb_V3DS.Enabled = enabled;
            btn_addEmpty.Enabled = enabled;
            btn_del.Enabled = enabled;
            btn_duplicate.Enabled = enabled;
            btn_select.Enabled = enabled;
        }

        /// <summary>
        /// Returns a string array of existing v3DS 8excluding current v3DS
        /// </summary>
        /// <returns></returns>
        private string[] getAllVSystems()
        {
            List<string> allSystems = new List<string>();

            var otherVirtuals = Directory.GetDirectories(Path.Combine(CitraFolder, "v3DS"));
            for (int i = 0; i < otherVirtuals.Length; i++)
            {
                allSystems.Add(new DirectoryInfo(otherVirtuals[i]).Name);
            }

            return allSystems.ToArray();
        }

        /// <summary>
        /// Reads contents of any File on the disk
        /// </summary>
        /// <param name="path">Pth to File</param>
        /// <param name="ignoreNL">Wether or not New Lines should be included in output</param>
        /// <returns></returns>
        private string readFile(string path, bool ignoreNL=true)
        {
            sr = new StreamReader(path, Encoding.UTF8);
            string output = "";

            while (!sr.EndOfStream)
            {
                if (output != "" && !ignoreNL)
                {
                    output += "\n";
                }
                output += sr.ReadLine();
            }

            sr.Close();

            return output;
        }

        /// <summary>
        /// Copys Folder with all of it's contents recursively
        /// </summary>
        /// <param name="sourceDirName">Source Directory</param>
        /// <param name="destDirName">Destination Path</param>
        private void DirectoryCopy(string sourceDirName, string destDirName)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // Copy subdirectories and their contents to new location.
            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(destDirName, subdir.Name);
                DirectoryCopy(subdir.FullName, temppath);
            }
        }
    }
}
