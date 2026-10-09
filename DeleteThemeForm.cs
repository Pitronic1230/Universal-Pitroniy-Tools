namespace Universal_Pitroniy_Tools
{
    public partial class DeleteThemeForm : Form
    {
        public DeleteThemeForm()
        {
            InitializeComponent();
        }

        private void DeleteThemeForm_Load(object sender, EventArgs e)
        {
            UniversalPitroniyTool universalPitroniyTool = new();
            var themesJSON = universalPitroniyTool.themesJSON;

            foreach (var item in themesJSON.Collection)
            {
                
            }
        }
    }
}
