using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureWindowsForms
{
    public partial class SavefilesForm : Form
    {
        private MainGameForm mainGameForm;
        private MainMenuForm mainMenuForm;
        public SavefilesForm(MainGameForm mainGame, MainMenuForm mainMenu)
        {
            InitializeComponent();
            mainGameForm = mainGame;
            mainMenuForm = mainMenu;
            LoadSavedFiles();
        }

        private void loadSaveButton_Click(object sender, EventArgs e)
        {
            string selectedFileName = SaveFileListBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedFileName))
            {
                string playerName = ExtractPlayerNameFromFileName(selectedFileName);

                if (!string.IsNullOrEmpty(playerName))
                {
                    // Determine the folder where the save file is stored (e.g., LocalApplicationData)
                    string saveFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

                    string saveFilePath = Path.Combine(saveFolder, $"{selectedFileName}_savefile.json");

                    if (File.Exists(saveFilePath))
                    {
                        if (mainGameForm == null)
                        {
                            mainGameForm = new MainGameForm(selectedFileName, playerName, mainMenuForm);
                        }
                        else
                        {
                            mainGameForm.PlayerName = playerName;
                            // Additional updates or operations as needed...
                        }

                        mainGameForm.LoadGameStateFromFile(saveFilePath, playerName);
                        mainGameForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Save file not found!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a save file with a valid player name.");
                }
            }
            else
            {
                MessageBox.Show("Please select a save file.");
            }
        }







        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void LoadSavedFiles()
        {
            SaveFileListBox.Items.Clear();
            string saveFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string[] savedFiles = Directory.GetFiles(saveFolder, "*_savefile.json");

            foreach (var file in savedFiles)
            {
                string fileName = Path.GetFileName(file);
                string playerName = ExtractPlayerNameFromFileName(fileName);

                if (!string.IsNullOrEmpty(playerName))
                {
                    SaveFileListBox.Items.Add(playerName);
                }
            }
        }

        public string ExtractPlayerNameFromFileName(string fileName)
        {
            // Get the file name without the extension
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);

            // Split the file name using the underscore character
            string[] parts = fileNameWithoutExtension.Split('_');

            // Check if the parts array has at least one element
            if (parts.Length >= 1)
            {
                return parts[0]; // Assuming the player name is the first part before the underscore
            }
            else
            {
                // Handle the failure case by returning a default value instead of showing a message box
                return "UnknownPlayer"; // Return a default player name or an empty string
            }
        }
    }

}


