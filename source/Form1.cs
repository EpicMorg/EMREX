using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace regexer {
    public partial class Form1 : Form {
        private Regex _r;
        public Form1() { this.InitializeComponent(); }

        private bool CreateRegex( bool msg ) {
            try {
                var s = this.txt_regex.Text;
                if ( string.IsNullOrWhiteSpace( s ) )
                    return false;
                this._r = new Regex( s );
                return true;
            }
            catch {
                if ( msg ) MessageBox.Show( @"Wrong regex" );
                return false;
            }
        }

        private void update_input_box( IEnumerable<Match> v1 ) {
            try {
                this.ResumeLayout();
                this.txt_in.SuspendLayout();
                int selPos = this.txt_in.SelectionStart, sellen = this.txt_in.SelectionLength;
                this.txt_in.SuspendLayout();
                this.txt_in.SelectAll();
                this.txt_in.SelectionBackColor = Color.White;
                foreach ( var keyWordMatch in v1 ) {
                    this.txt_in.Select( keyWordMatch.Index, keyWordMatch.Length );
                    this.txt_in.SelectionBackColor = Color.Yellow;
                }
                this.txt_in.SelectionStart = selPos;
                this.txt_in.SelectionLength = sellen;
                this.txt_in.ResumeLayout();
            }
            finally {
                Application.DoEvents();
                this.ResumeLayout();
                this.txt_in.ResumeLayout();
            }
        }

        private void update_output( IEnumerable<Match> v1 ) {
            var f = this.txt_replace_what.Text;
            var t = this.txt_replace_with.Text;
            var v = this.rd_match.Checked ? v1.Select( a => a.ToString() ).ToArray() : ( this.txt_in.Lines ).ToArray().Where( a => this._r.Match( a ).Index > 0 ).ToArray();
            if ( !String.IsNullOrEmpty( f ) )
                v = v.Select( a => a.Replace( f, t ) ).ToArray();
            this.txt_out.Lines = v.ToArray();
        }

        private void auto_up() {
            if ( this.chk_onthefly.Checked )
                if ( this.CreateRegex( false ) )
                    this.update_results();
        }

        private void update_results() {
            try {
                var v1 = ( from Match m in this._r.Matches( this.txt_in.Text ) select m ).ToArray();
                this.update_output( v1 );
                this.update_input_box( v1 );
            }
            catch {}
        }

        private void btn_go_Click( object sender, EventArgs e ) {
            if ( this.CreateRegex( true ) ) {
                this.txt_regex.Items.Insert( 0, this.txt_regex.Text );
                this.update_results();
            }
        }

        private void txt_regex_TextChanged( object sender, EventArgs e ) { this.auto_up(); }
        private void txt_in_TextChanged( object sender, EventArgs e ) { this.auto_up(); }

        private void rd_match_CheckedChanged( object sender, EventArgs e ) { this.auto_up(); }

        private void rd_grep_CheckedChanged( object sender, EventArgs e ) { this.auto_up(); }

        private void txt_replace_what_TextChanged( object sender, EventArgs e ) { this.auto_up(); }

        private void txt_replace_with_TextChanged( object sender, EventArgs e ) { this.auto_up(); }
    }
}