namespace regexer
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chk_onthefly = new System.Windows.Forms.CheckBox();
            this.txt_regex = new System.Windows.Forms.ComboBox();
            this.btn_go = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_replace_with = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_replace_what = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txt_in = new System.Windows.Forms.RichTextBox();
            this.txt_out = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_match = new System.Windows.Forms.RadioButton();
            this.rd_grep = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.chk_onthefly);
            this.splitContainer1.Panel1.Controls.Add(this.txt_regex);
            this.splitContainer1.Panel1.Controls.Add(this.btn_go);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txt_replace_with);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txt_replace_what);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(750, 573);
            this.splitContainer1.SplitterDistance = 119;
            this.splitContainer1.TabIndex = 8;
            // 
            // chk_onthefly
            // 
            this.chk_onthefly.AutoSize = true;
            this.chk_onthefly.Location = new System.Drawing.Point(92, 12);
            this.chk_onthefly.Name = "chk_onthefly";
            this.chk_onthefly.Size = new System.Drawing.Size(123, 17);
            this.chk_onthefly.TabIndex = 17;
            this.chk_onthefly.Text = "Aplly regex on the fly";
            this.chk_onthefly.UseVisualStyleBackColor = true;
            // 
            // txt_regex
            // 
            this.txt_regex.FormattingEnabled = true;
            this.txt_regex.Items.AddRange(new object[] {
            "\\b[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}(:[0-9]{1,5})?\\b"});
            this.txt_regex.Location = new System.Drawing.Point(16, 38);
            this.txt_regex.Name = "txt_regex";
            this.txt_regex.Size = new System.Drawing.Size(331, 21);
            this.txt_regex.TabIndex = 16;
            this.txt_regex.TextChanged += new System.EventHandler(this.txt_regex_TextChanged);
            // 
            // btn_go
            // 
            this.btn_go.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_go.Location = new System.Drawing.Point(548, 12);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(190, 77);
            this.btn_go.TabIndex = 15;
            this.btn_go.Text = "Process";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "in matches";
            // 
            // txt_replace_with
            // 
            this.txt_replace_with.Location = new System.Drawing.Point(157, 92);
            this.txt_replace_with.Name = "txt_replace_with";
            this.txt_replace_with.Size = new System.Drawing.Size(190, 20);
            this.txt_replace_with.TabIndex = 13;
            this.txt_replace_with.TextChanged += new System.EventHandler(this.txt_replace_with_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "with";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Replace";
            // 
            // txt_replace_what
            // 
            this.txt_replace_what.Location = new System.Drawing.Point(16, 92);
            this.txt_replace_what.Name = "txt_replace_what";
            this.txt_replace_what.Size = new System.Drawing.Size(100, 20);
            this.txt_replace_what.TabIndex = 10;
            this.txt_replace_what.TextChanged += new System.EventHandler(this.txt_replace_what_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Regexp";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txt_in);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txt_out);
            this.splitContainer2.Size = new System.Drawing.Size(750, 450);
            this.splitContainer2.SplitterDistance = 383;
            this.splitContainer2.TabIndex = 0;
            // 
            // txt_in
            // 
            this.txt_in.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_in.Location = new System.Drawing.Point(0, 0);
            this.txt_in.Name = "txt_in";
            this.txt_in.Size = new System.Drawing.Size(383, 450);
            this.txt_in.TabIndex = 0;
            this.txt_in.Text = "";
            this.txt_in.TextChanged += new System.EventHandler(this.txt_in_TextChanged);
            // 
            // txt_out
            // 
            this.txt_out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_out.Location = new System.Drawing.Point(0, 0);
            this.txt_out.Multiline = true;
            this.txt_out.Name = "txt_out";
            this.txt_out.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_out.Size = new System.Drawing.Size(363, 450);
            this.txt_out.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_grep);
            this.groupBox1.Controls.Add(this.rd_match);
            this.groupBox1.Location = new System.Drawing.Point(353, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // rd_match
            // 
            this.rd_match.AutoSize = true;
            this.rd_match.Checked = true;
            this.rd_match.Location = new System.Drawing.Point(7, 20);
            this.rd_match.Name = "rd_match";
            this.rd_match.Size = new System.Drawing.Size(66, 17);
            this.rd_match.TabIndex = 0;
            this.rd_match.TabStop = true;
            this.rd_match.Text = "Matches";
            this.rd_match.UseVisualStyleBackColor = true;
            this.rd_match.CheckedChanged += new System.EventHandler(this.rd_match_CheckedChanged);
            // 
            // rd_grep
            // 
            this.rd_grep.AutoSize = true;
            this.rd_grep.Location = new System.Drawing.Point(7, 59);
            this.rd_grep.Name = "rd_grep";
            this.rd_grep.Size = new System.Drawing.Size(115, 17);
            this.rd_grep.TabIndex = 1;
            this.rd_grep.Text = "Lines with matches";
            this.rd_grep.UseVisualStyleBackColor = true;
            this.rd_grep.CheckedChanged += new System.EventHandler(this.rd_grep_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 573);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(766, 311);
            this.Name = "Form1";
            this.Text = "Epicm.org Regexer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_replace_with;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_replace_what;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txt_out;
        private System.Windows.Forms.ComboBox txt_regex;
        private System.Windows.Forms.RichTextBox txt_in;
        private System.Windows.Forms.CheckBox chk_onthefly;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_grep;
        private System.Windows.Forms.RadioButton rd_match;
    }
}

