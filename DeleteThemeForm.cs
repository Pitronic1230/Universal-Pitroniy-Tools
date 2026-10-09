namespace Universal_Pitroniy_Tools
{
    public partial class DeleteThemeForm : Form
    {
        private readonly UniversalPitroniyTool _UniversalPitroniyTool;
        private readonly UniversalPitroniyTool.ThemesJSON _themesJSON;

        public DeleteThemeForm(
            UniversalPitroniyTool universalPitroniyTool, 
            UniversalPitroniyTool.ThemesJSON themesJSON)
        {
            InitializeComponent();

            _UniversalPitroniyTool = universalPitroniyTool;
            _themesJSON = themesJSON;
        }

        private void DeleteThemeForm_Load(object sender, EventArgs e)
        {
            var themesJSON = _UniversalPitroniyTool.themesJSON;

            foreach (var item in themesJSON.Collection)
                themesList.Items.Add(item.Name);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (themesList.SelectedIndex >= 0)
            {
                // Delete theme form lists
                _themesJSON.Collection.RemoveAt(themesList.SelectedIndex);
                _UniversalPitroniyTool.themeSelector.Items.RemoveAt(themesList.SelectedIndex);
                Console.WriteLine(themesList.SelectedIndex);

                // Delete from JSON
                themesList.Items.RemoveAt(themesList.SelectedIndex);
            }
        }
    }
}
