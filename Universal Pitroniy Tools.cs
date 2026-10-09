using System.Diagnostics;
using System.Text.Json;

namespace Universal_Pitroniy_Tools
{
    public partial class UniversalPitroniyTool : Form
    {

        class PiTools
        {
            // Local Application Data folder path
            private static string savingDirrectoryPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), // local application data folder path
            "Universal Pitroniy Tools");

            public static string CreateFile(string path)
            {
                string returnedPath = Path.Combine(
                    savingDirrectoryPath,
                    path);

                if (!Directory.Exists(savingDirrectoryPath))
                    Directory.CreateDirectory(savingDirrectoryPath);

                if (!File.Exists(returnedPath))
                    File.Create(returnedPath).Close();

                return returnedPath;
            }
        }

        #region JSONs

        #region FilesJSON
        class FilesJSONContent
        {
            public string name { get; set; } = "";
            public string path { get; set; } = "";
        }

        class FilesJSON
        {
            public List<FilesJSONContent> Collection { get; set; } = new();
        }
        #endregion

        #region Themes JSON
        public class ThemesJSONContent
        {
            // Themes file
            public string Name { get; set; } = "";
            public string Path { get; set; } = "";

            // Theme
            public string PrimaryBackgroundColor { get; set; }
        }

        public class ThemesJSON
        {
            public List<ThemesJSONContent> Collection { get; set; } = new();
        }
        #endregion

        #region Settings JSON
        class SettingsJSON
        {
            // Settings file
            public string Name { get; set; } = "";
            public string Path { get; set; } = "";

            // Settings
            public string SelectedTheme { get; set; } = "";

            public string Language { get; set; } = "";
        }
        
        class SettingsJSONCollection
        {
            public List<SettingsJSON> Collection { get; set; } = [];
        }
        #endregion

        #endregion

        #region Creating vars
        // JSON collections
        FilesJSON filesJSON = new();
        public ThemesJSON themesJSON = new();
        SettingsJSON settingsJSON = new();

        // Path vars
        string
            filesJSONpath = PiTools.CreateFile("files.json"),
            themesJSONpath = PiTools.CreateFile("themes.json"),
            settingsJSONpath = PiTools.CreateFile("settings.json");
        #endregion

        public UniversalPitroniyTool()
        {
            InitializeComponent();
        }

        #region Events
        private void addThemeButton_Click(object sender, EventArgs e)
        {
            if (openThemeDialog.ShowDialog() == DialogResult.OK)
            {
                string themeName = openThemeDialog.SafeFileName;
                string themePath = openThemeDialog.FileName;

                ThemesJSONContent content = new()
                {
                    Name = themeName,
                    Path = themePath
                };

                themesJSON.Collection.Add(content);
                themeSelector.Items.Add(content.Name);
                /* TODO:
                 * Доделать добавление темы через кнопку и сохранение выбранной темы
                 * в JSON файл
                 */
            }
        }

        private void DeleteThemeButton_Click(object sender, EventArgs e)
        {
            DeleteThemeForm deleteThemeForm = new();

            deleteThemeForm.ShowDialog();
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.SafeFileName;
                string filePath = openFileDialog.FileName;

                filesTable.Rows.Add(fileName,filePath,"Run","Delete");

                filesJSON.Collection.Add(
                    new FilesJSONContent
                    {
                        name = fileName,
                        path = filePath
                    });
            }
        }

        // Click on columns buttons
        private void FilesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // Null row or column

            if (e.ColumnIndex == 2)
            {
                try
                {
                    string filePath = filesJSON.Collection[e.RowIndex].path;

                    Process.Start(new
                        ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    throw;
                }
            } // Run button

            if (e.ColumnIndex == 3)
            {
                filesJSON.Collection.RemoveAt(e.RowIndex);
                filesTable.Rows.RemoveAt(e.RowIndex);
            } // Delete Button
        }
        #endregion

        #region OnLoad and OnClosing Form1 funcs
        private void OnLoad(object sender, EventArgs e)
        {
            // Load JSONs
            string filesContent = File.ReadAllText(filesJSONpath);
            string themesContent = File.ReadAllText(themesJSONpath);
            string settingsContent = File.ReadAllText(settingsJSONpath);

            if (filesContent.Length > 0)
            {
                filesJSON = JsonSerializer.Deserialize<FilesJSON>(filesContent) 
                    ?? new FilesJSON();

                foreach (var item in filesJSON.Collection)
                {
                    filesTable.Rows.Add(
                        item.name,
                        item.path,
                        "Run",
                        "Delete"
                        );
                } // Creating files table from filesJSON
            }

            if (themesContent.Length > 0)
            {
                themesJSON = JsonSerializer.Deserialize<ThemesJSON>(themesContent) 
                    ?? new ThemesJSON();

                int number = 1;

                foreach (var item in themesJSON.Collection)
                {
                    themeSelector.Items.Add($"{number}: {item.Name}");
                    number++;
                }
            }

            if (settingsContent.Length > 0)
            {
                settingsJSON = JsonSerializer.Deserialize<SettingsJSON>(settingsContent) 
                    ?? new SettingsJSON();
            }
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            // Save JSONs
            string filesContent = JsonSerializer.Serialize(filesJSON);
            string themesContent = JsonSerializer.Serialize(themesJSON);
            string settingsContent = JsonSerializer.Serialize(settingsJSON);

            File.WriteAllText(filesJSONpath, filesContent);
            File.WriteAllText(themesJSONpath, themesContent);
            File.WriteAllText(settingsJSONpath, settingsContent);
        }
        #endregion

    }
}
