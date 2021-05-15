using System;
using System.Diagnostics;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace MiningStarterProgram
{
    public partial class SelectDirectory : Form
    {
        //All rights of this software are protected under the GPL license.
        //Copyright© 2021 BerkishTechnology

        string SelectPath, MiningPath = "C:\\MiningPool\\";

        public SelectDirectory()
        {
            InitializeComponent();
        }
        private void Btn_SelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderDialogs = new FolderBrowserDialog();
            FolderDialogs.ShowNewFolderButton = true;
            DialogResult result = FolderDialogs.ShowDialog();
            if (result == DialogResult.OK)
            {
                SelectPath = FolderDialogs.SelectedPath;
                Lbl_Folder.Text = SelectPath;
                Btn_CopyDirectory.Enabled = true;
            }            
        }

        private void Btn_CopyDirectory_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(MiningPath))
            {
                System.IO.Directory.CreateDirectory(MiningPath);               
            }
            if (!System.IO.File.Exists(MiningPath + "StartMining.bat"))
            {
                System.IO.FileStream fs = System.IO.File.Create(MiningPath + "StartMining.bat");
                fs.Close();
            }
            CopyDirectoryAndFiles(SelectPath, MiningPath);
            CreateShortcut("StartMining", Environment.GetFolderPath(Environment.SpecialFolder.Startup), (MiningPath + "StartMining.bat"));
            MessageBox.Show("Copying of Files in the Selected Directory Successful !", "INFO",MessageBoxButtons.OK, MessageBoxIcon.Information);
            Lbl_Status.Text = "Successful";
            Btn_EditFile.Enabled = true;
        }


        private static void CopyDirectoryAndFiles(string SourcePath, string TargetPath)
        {
            foreach (string DirectoryPath in System.IO.Directory.GetDirectories(SourcePath, "*", System.IO.SearchOption.AllDirectories))
            {
                System.IO.Directory.CreateDirectory(DirectoryPath.Replace(SourcePath, TargetPath));
            }
            foreach (string FilesPath in System.IO.Directory.GetFiles(SourcePath, "*.*", System.IO.SearchOption.AllDirectories))
            {
                System.IO.File.Copy(FilesPath, FilesPath.Replace(SourcePath, TargetPath), true);
            }
        }

        public static void CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation)
        {
            string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);
            shortcut.TargetPath = targetFileLocation;
            shortcut.Save();
        }

        private void Btn_EditFile_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", MiningPath + "StartMining.bat");
        }
    }
}
