using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;


namespace Tiny_language_project
{
    public partial class Form1 : Form
    {
        bool mouseDown;
        private Point offest;

        int lines;
        public Form1()
        {
            InitializeComponent();
             lines = Code_editor.Lines.Length;

        }

        void PrintTokens()
        {
            for (int i = 0; i < Compiler.scanner.Tokens.Count; i++)
            {
                Tokens_table.Rows.Add(Compiler.scanner.Tokens.ElementAt(i).lexim, Compiler.scanner.Tokens.ElementAt(i).token_type);
            }
        }

        void PrintErrors()
        {
            if (Errors.Error_List.Count == 0)
            {
                errors_tx.ForeColor=Color.Gray;
                errors_tx.Text = "Empty";
            }
            else
            {
                errors_tx.ForeColor = Color.White;
                for (int i = 0; i < Errors.Error_List.Count; i++)
                {
                    errors_tx.Text += Errors.Error_List[i];
                    errors_tx.Text += "\r\n";
                }
            }
        }

        

        private void Code_editor_TextChanged_1(object sender, EventArgs e)
        {
            if (lines != Code_editor.Lines.Length)
            {
                line_num_tx.Clear();
                for (int i = 1; i <= Code_editor.Lines.Length; i++)
                {
                    line_num_tx.Text = line_num_tx.Text + i.ToString() + "\n";
                }
                lines = Code_editor.Lines.Length;
            }
            //label1.Text = Code_editor.Lines.Length.ToString();

            #region Regular_Expressions
            string Keywords = @"\b(until|if|elseif|else|then)";
            MatchCollection keywordsMatches = Regex.Matches(Code_editor.Text, Keywords);

            string datatypes = @"\b(int|float|string)";
            MatchCollection datatypes_Matches = Regex.Matches(Code_editor.Text, datatypes);

            string lang_functions = @"\b(read|write|repeat|return)";
            MatchCollection lang_functionsMatches = Regex.Matches(Code_editor.Text, lang_functions);

            string endl_key = @"\b(endl)";
            MatchCollection endl_keyMatches = Regex.Matches(Code_editor.Text, endl_key);
            string comments = @"/\*(.|\n)+?\*/";
            MatchCollection commentsMatches = Regex.Matches(Code_editor.Text, comments);

            string strings = "\".*?\"";
            MatchCollection StringsMatches = Regex.Matches(Code_editor.Text, strings);

            string digits = @"[0-9]+";
            MatchCollection digitsMatches = Regex.Matches(Code_editor.Text, digits);

            string equal_operator = @":=";
            MatchCollection equaloperatorMatches = Regex.Matches(Code_editor.Text, equal_operator);
            string bolean_operators = @"\<|\>|\!";
            MatchCollection bolean_operatorsMatches = Regex.Matches(Code_editor.Text, bolean_operators);
            string semi_colon_operator = @";";
            MatchCollection semi_colon_operatorMatches = Regex.Matches(Code_editor.Text, semi_colon_operator);
            #endregion

            #region saving the original start
            int originalindex = Code_editor.SelectionStart;
            int originallength = Code_editor.SelectionLength;
            Color originalColor = Color.White;
            #endregion

            Title.Focus();

            #region remove any previous highliting
            Code_editor.SelectionStart = 0;
            Code_editor.SelectionLength = Code_editor.Text.Length;
            Code_editor.SelectionColor = originalColor;
            #endregion

            #region scaning and coloring
            //match keywords
            foreach (Match m in keywordsMatches)
            {
                Code_editor.SelectionStart = m.Index;
                Code_editor.SelectionLength = m.Length;
                Code_editor.SelectionColor = Color.Violet;
            }
            foreach (Match m in datatypes_Matches)
            {
                Code_editor.SelectionStart = m.Index;
                Code_editor.SelectionLength = m.Length;
                Code_editor.SelectionColor = Color.Cyan;
            }
            foreach (Match m in lang_functionsMatches)
            {
                Code_editor.SelectionStart = m.Index;
                Code_editor.SelectionLength = m.Length;
                Code_editor.SelectionColor = Color.Yellow;
            }
            foreach (Match m in endl_keyMatches)
            {
                Code_editor.SelectionStart = m.Index;
                Code_editor.SelectionLength = m.Length;
                Code_editor.SelectionColor = Color.Green;
            }
            //match strings
            foreach (Match m in StringsMatches)
            {
                Code_editor.SelectionStart = m.Index;
                Code_editor.SelectionLength = m.Length;
                Code_editor.SelectionColor = Color.Orange;
            }
            //match comments
            foreach (Match m in commentsMatches)
            {
                Code_editor.SelectionStart = m.Index;
                Code_editor.SelectionLength = m.Length;
                Code_editor.SelectionColor = Color.LightGreen;
                
            }
            //match equal operator
            foreach (Match m in equaloperatorMatches)
            {
                Code_editor.SelectionStart = m.Index;
                Code_editor.SelectionLength = m.Length;
                Code_editor.SelectionColor = Color.Bisque;

            }
            //match digts
            foreach (Match m in digitsMatches)
            {
                Code_editor.SelectionStart = m.Index;
                Code_editor.SelectionLength = m.Length;
                Code_editor.SelectionColor = Color.Pink;

            }

            foreach (Match m in semi_colon_operatorMatches)
            {
                Code_editor.SelectionStart = m.Index;
                Code_editor.SelectionLength = m.Length;
                Code_editor.SelectionColor = Color.Red;

            }
            foreach (Match m in bolean_operatorsMatches)
            {
                Code_editor.SelectionStart = m.Index;
                Code_editor.SelectionLength = m.Length;
                Code_editor.SelectionColor = Color.Gray;

            }
            #endregion

            #region resting originalcolors
            Code_editor.SelectionStart = originalindex;
            Code_editor.SelectionLength = originallength;
            Code_editor.SelectionColor = originalColor;
            Code_editor.Focus();
           #endregion
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Code_editor.Text = "/*Sample Program in Tiny language - print hello world*/\n";
            Code_editor.Text+= "int Main()\n";
            Code_editor.Text += "{\n";
            Code_editor.Text += "\twrite \"Hello world\";\n";
            Code_editor.Text += "\treturn 0;\n";
            Code_editor.Text += "}\n";



        }




        private void Run_btn_Click(object sender, EventArgs e)
        {
            Run_compiler();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            
            System.Windows.Forms.Application.Exit();
            
            
        }



        private void Clear_btn_Click(object sender, EventArgs e)
        {
            errors_tx.Clear();
            Tokens_table.Rows.Clear();
            Compiler.TokenStream.Clear();
            treeView1.Nodes.Clear();
        }

        private void Run_compiler()
        {
            errors_tx.Clear();
            Tokens_table.Rows.Clear();
            Compiler.TokenStream.Clear();
            Errors.Error_List.Clear();
            errors_tx.Clear();
            treeView1.Nodes.Clear();
           
            string Code = Code_editor.Text;
            Compiler.Start_Compiling(Code);
            PrintTokens();
           treeView1.Nodes.Add(Parser.PrintParseTree(Compiler.treeroot));

            PrintErrors();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            sfd.Filter = "TL Files|*.TL";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                //if (Path.GetExtension(sfd.FileName).ToLower() != ".TL")
                //{
                //    path += ".TL";
                //}
                StreamWriter sw = new StreamWriter(path);
                for (int i = 0; i < Code_editor.Lines.Length; i++)
                {
                    sw.WriteLine(Code_editor.Lines[i]);
                }
                sw.Close();
            }
        }

        private void open_file_btn_Click(object sender, EventArgs e)
        {
            ofd.Title = "Please , choose file";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofd.Filter = "TL Files|*.TL";
           
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                Code_editor.Clear();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Code_editor.Text = Code_editor.Text + line + "\n";

                }
                sr.Close();
            }
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void title_bar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void title_bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenpos=PointToScreen(e.Location);
                Location = new Point(currentScreenpos.X - offest.X, currentScreenpos.Y - offest.Y);
            }
        }

        private void title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            offest.X = e.X;
            offest.Y = e.Y;
            mouseDown = true;
        }

        private void title_bar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }

        private void line_num_tx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
