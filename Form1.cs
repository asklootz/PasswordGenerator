

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> SpecialCharacters = new List<string>();
            /*{
                "!",
                "@",
                "#",
                "$",
                "%",
                "/",
                "?"
            };*/
        private void GenButton_Click(object sender, EventArgs e)
        {
            /*var popUp = new Form();
            popUp.Show();*/

            //Choose a random word from the list
            var lines = File.ReadAllLines("./WordList.txt");
            var r = new Random();
            var randomLineNumber = r.Next(0, lines.Length - 1);
            var line = lines[randomLineNumber];
            PasswordText.Text = line;
            Controls.Add(PasswordText); //Used to update label

        }

        private void PasswordText_Click(object sender, EventArgs e)
        {

        }
    }
}
