using CrypticWizard;
using CrypticWizard.RandomWordGenerator;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> SpecialCharacters = new List<string>
            {
                "!",
                "@",
                "#",
                "$",
                "%",
                "/",
                "?"
            };
        private void GenButton_Click(object sender, EventArgs e)
        {
            //Choose a random word from the list
            var lines = File.ReadAllLines("./WordList.txt");
            var r = new Random();

            //Word 1
            var wordGen = new WordGenerator();
            string randString = wordGen.GetWord(WordGenerator.PartOfSpeech.adj);
            randString = char.ToUpper(randString[0]) + randString.Substring(1);

            //Word 2
            string randString1 = wordGen.GetWord(WordGenerator.PartOfSpeech.noun);
            randString1 = char.ToUpper(randString1[0]) + randString1.Substring(1);

            //Choose a random special character from the list
            int randomSpecialCharacter = r.Next(SpecialCharacters.Count);

            //Choose a random number
            int randomNumber = r.Next(0, 100);

            //Combination of all requirements
            string newPass = randString + SpecialCharacters[randomSpecialCharacter] + randString1 + randomNumber;


            //Used to update label
            if (newPass.Length >= 10)
            {
                PasswordText.Text = newPass;
            }
            else
            {
                GenButton_Click(sender, e);
            }
            //PasswordText.Text = newPass;


           // Controls.Add(PasswordText); 

        }

        private void PasswordText_Click(object sender, EventArgs e)
        {

        }
    }
}
