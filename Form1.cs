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
        class ThemesJSONContent
        {
            string ThemeName { get; set; }
            string PrimaryBackgroundColor { get; set; }
        }

        class ThemesJSON
        {
            List<ThemesJSONContent> Collection { get; set; } = new();
        }
        #endregion

        #endregion

        #region Creating vars
        // JSON collections
        FilesJSON
                filesJSON = new(),
                themesJSON = new(),
                settingsJSON = new();

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
        // Add file button
        private void AddFile_button_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.SafeFileName;
                string filePath = openFileDialog1.FileName;

                // Add table row
                filesTable.Rows.Add(
                    fileName,
                    filePath,
                    "Run",
                    "Delete"
                    );

                // Add content to files collection
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
            string content = File.ReadAllText(filesJSONpath);

            // Check if content is empty
            if (content.Length > 0)
            {
                filesJSON = JsonSerializer.Deserialize<FilesJSON>(content) ?? new FilesJSON();

                foreach (var item in filesJSON.Collection)
                {
                    filesTable.Rows.Add(
                        item.name,
                        item.path,
                        "Run",
                        "Delete"
                        );
                }
            }
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            string content = JsonSerializer.Serialize(filesJSON);
            File.WriteAllText(filesJSONpath, content);
        }
        #endregion
    }
}
