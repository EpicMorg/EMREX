using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
//using System.Runtime.InteropServices;
namespace regexer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Regex r;
        bool CreateRegex(bool msg)
        {
            try
            {
                r = new Regex(txt_regex.Text);
                return true;
            }
            catch { if (msg) MessageBox.Show("wrong regex"); return false; }
        }
        void update_input_box(Match[] v1)
        {
            try
            {
                this.ResumeLayout();
                txt_in.SuspendLayout();
                int selPos = txt_in.SelectionStart,sellen=txt_in.SelectionLength;
                txt_in.SelectAll();
                txt_in.SelectionBackColor = Color.White;
                //For each match from the regex, highlight the word.
                foreach (Match keyWordMatch in v1)
                {
                    txt_in.Select(keyWordMatch.Index, keyWordMatch.Length);
                    txt_in.SelectionBackColor = Color.Yellow;
                    //txt_in.SelectionStart = selPos;
                    //txt_in.SelectionBackColor = Color.White;
                }
                txt_in.SelectionStart=selPos;
                txt_in.SelectionLength = sellen;
                //txt_in.SelectionStart=selPos;
            }
            finally
            {
                Application.DoEvents();
                this.ResumeLayout();
                txt_in.ResumeLayout();
            }
        }
        void update_output(Match[] v1)
        {

            string f = txt_replace_what.Text, t = txt_replace_with.Text;
            string[] v;
            if (rd_match.Checked)
                v = v1.Select(a => a.ToString()).ToArray();
            else
                 v = (txt_in.Lines).ToArray().Where(a => r.Match(a).Index > 0).ToArray();
            if (!String.IsNullOrEmpty(f))
                v = v.Select(a => a.Replace(f, t)).ToArray();
            txt_out.Lines = v.ToArray();
        }
        void auto_up()
        {
            if (chk_onthefly.Checked)
                if (CreateRegex(false))
                    update_results();
        }
        void update_results()
        {
            try
            {
                var v1 = (from Match m in r.Matches(txt_in.Text) select m).ToArray();
                update_output(v1);
                update_input_box(v1);
            }
            catch { }
        }
        private void btn_go_Click(object sender, EventArgs e)
        {
            if (CreateRegex(true))
            {
                txt_regex.Items.Insert(0, txt_regex.Text);
                update_results();
            }
        }
        private void txt_regex_TextChanged(object sender, EventArgs e)
        {
            auto_up();
        }
        private void txt_in_TextChanged(object sender, EventArgs e)
        {
            auto_up();
        }

        private void rd_match_CheckedChanged(object sender, EventArgs e)
        {
            auto_up();
        }

        private void rd_grep_CheckedChanged(object sender, EventArgs e)
        {
            auto_up();
        }

        private void txt_replace_what_TextChanged(object sender, EventArgs e)
        {
            auto_up();
        }

        private void txt_replace_with_TextChanged(object sender, EventArgs e)
        {
            auto_up();
        }
    }
}
