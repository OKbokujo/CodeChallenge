
namespace CodeChallengeRecorder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddLanguage = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.AddProblems = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveLanguage = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.DeleteProblems = new System.Windows.Forms.Button();
            this.AddSolutions = new System.Windows.Forms.Button();
            this.RemoveSolutions = new System.Windows.Forms.Button();
            this.WebURLinput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SolutionTitle = new System.Windows.Forms.TextBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Problemsbox = new System.Windows.Forms.CheckBox();
            this.SolutionsBox = new System.Windows.Forms.CheckBox();
            this.SearchResults = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AddMethods = new System.Windows.Forms.Button();
            this.LanguageMethods = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.URL = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(7, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(98, 94);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.LanguageChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 23);
            this.textBox1.TabIndex = 1;
            // 
            // AddLanguage
            // 
            this.AddLanguage.Location = new System.Drawing.Point(7, 150);
            this.AddLanguage.Name = "AddLanguage";
            this.AddLanguage.Size = new System.Drawing.Size(51, 23);
            this.AddLanguage.TabIndex = 2;
            this.AddLanguage.Text = "Add";
            this.AddLanguage.UseVisualStyleBackColor = true;
            this.AddLanguage.Click += new System.EventHandler(this.AddLanguage_clicked);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(6, 22);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(99, 214);
            this.listBox2.TabIndex = 4;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.ProblemChanged);
            // 
            // AddProblems
            // 
            this.AddProblems.BackColor = System.Drawing.SystemColors.Control;
            this.AddProblems.Location = new System.Drawing.Point(6, 242);
            this.AddProblems.Name = "AddProblems";
            this.AddProblems.Size = new System.Drawing.Size(51, 23);
            this.AddProblems.TabIndex = 5;
            this.AddProblems.Text = "Add";
            this.AddProblems.UseVisualStyleBackColor = true;
            this.AddProblems.Click += new System.EventHandler(this.AddProblem_clicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(658, 418);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 15);
            this.linkLabel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Problem";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(260, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(554, 279);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Solution";
            // 
            // RemoveLanguage
            // 
            this.RemoveLanguage.Location = new System.Drawing.Point(54, 150);
            this.RemoveLanguage.Name = "RemoveLanguage";
            this.RemoveLanguage.Size = new System.Drawing.Size(51, 23);
            this.RemoveLanguage.TabIndex = 13;
            this.RemoveLanguage.Text = "Delete";
            this.RemoveLanguage.UseVisualStyleBackColor = true;
            this.RemoveLanguage.Click += new System.EventHandler(this.DeleteLanguage_clicked);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(260, 341);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(554, 258);
            this.richTextBox2.TabIndex = 15;
            this.richTextBox2.Text = "";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(7, 24);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(99, 109);
            this.listBox3.TabIndex = 16;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.SolutionChanged);
            // 
            // DeleteProblems
            // 
            this.DeleteProblems.Location = new System.Drawing.Point(54, 242);
            this.DeleteProblems.Name = "DeleteProblems";
            this.DeleteProblems.Size = new System.Drawing.Size(51, 23);
            this.DeleteProblems.TabIndex = 17;
            this.DeleteProblems.Text = "Delete";
            this.DeleteProblems.UseVisualStyleBackColor = true;
            this.DeleteProblems.Click += new System.EventHandler(this.DeleteProblem_Clicked);
            // 
            // AddSolutions
            // 
            this.AddSolutions.Location = new System.Drawing.Point(7, 162);
            this.AddSolutions.Name = "AddSolutions";
            this.AddSolutions.Size = new System.Drawing.Size(51, 23);
            this.AddSolutions.TabIndex = 18;
            this.AddSolutions.Text = "Add";
            this.AddSolutions.UseVisualStyleBackColor = true;
            this.AddSolutions.Click += new System.EventHandler(this.AddSolution_Clicked);
            // 
            // RemoveSolutions
            // 
            this.RemoveSolutions.Location = new System.Drawing.Point(55, 162);
            this.RemoveSolutions.Name = "RemoveSolutions";
            this.RemoveSolutions.Size = new System.Drawing.Size(51, 23);
            this.RemoveSolutions.TabIndex = 19;
            this.RemoveSolutions.Text = "Delete";
            this.RemoveSolutions.UseVisualStyleBackColor = true;
            this.RemoveSolutions.Click += new System.EventHandler(this.DeleteSolution_Clicked);
            // 
            // WebURLinput
            // 
            this.WebURLinput.Location = new System.Drawing.Point(336, 614);
            this.WebURLinput.Name = "WebURLinput";
            this.WebURLinput.Size = new System.Drawing.Size(367, 23);
            this.WebURLinput.TabIndex = 20;
            this.WebURLinput.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 617);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "URL";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(623, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(191, 23);
            this.Title.TabIndex = 23;
            this.Title.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(588, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Title";
            this.label6.Visible = false;
            // 
            // SolutionTitle
            // 
            this.SolutionTitle.Location = new System.Drawing.Point(7, 139);
            this.SolutionTitle.Name = "SolutionTitle";
            this.SolutionTitle.Size = new System.Drawing.Size(99, 23);
            this.SolutionTitle.TabIndex = 25;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(5, 66);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(100, 23);
            this.SearchBox.TabIndex = 27;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBoxFocus);
            // 
            // Problemsbox
            // 
            this.Problemsbox.AutoSize = true;
            this.Problemsbox.BackColor = System.Drawing.Color.Transparent;
            this.Problemsbox.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Problemsbox.Location = new System.Drawing.Point(6, 25);
            this.Problemsbox.Name = "Problemsbox";
            this.Problemsbox.Size = new System.Drawing.Size(61, 33);
            this.Problemsbox.TabIndex = 28;
            this.Problemsbox.Text = "Problems";
            this.Problemsbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Problemsbox.UseVisualStyleBackColor = false;
            this.Problemsbox.Click += new System.EventHandler(this.Problemsbox_Clicked);
            // 
            // SolutionsBox
            // 
            this.SolutionsBox.AutoSize = true;
            this.SolutionsBox.BackColor = System.Drawing.Color.Transparent;
            this.SolutionsBox.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SolutionsBox.Location = new System.Drawing.Point(56, 25);
            this.SolutionsBox.Name = "SolutionsBox";
            this.SolutionsBox.Size = new System.Drawing.Size(60, 33);
            this.SolutionsBox.TabIndex = 29;
            this.SolutionsBox.Text = "Solutions";
            this.SolutionsBox.UseVisualStyleBackColor = false;
            this.SolutionsBox.Click += new System.EventHandler(this.SolutionsBox_Clicked);
            // 
            // SearchResults
            // 
            this.SearchResults.FormattingEnabled = true;
            this.SearchResults.ItemHeight = 15;
            this.SearchResults.Location = new System.Drawing.Point(6, 95);
            this.SearchResults.Name = "SearchResults";
            this.SearchResults.Size = new System.Drawing.Size(99, 169);
            this.SearchResults.TabIndex = 30;
            this.SearchResults.SelectedIndexChanged += new System.EventHandler(this.SearchItemChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SolutionTitle);
            this.groupBox1.Controls.Add(this.RemoveSolutions);
            this.groupBox1.Controls.Add(this.AddSolutions);
            this.groupBox1.Controls.Add(this.listBox3);
            this.groupBox1.Location = new System.Drawing.Point(1, 469);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 191);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solutions";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteProblems);
            this.groupBox2.Controls.Add(this.AddProblems);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(1, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 270);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Problems";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.RemoveLanguage);
            this.groupBox3.Controls.Add(this.AddLanguage);
            this.groupBox3.Location = new System.Drawing.Point(1, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 180);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Languages";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SolutionsBox);
            this.groupBox4.Controls.Add(this.Problemsbox);
            this.groupBox4.Controls.Add(this.SearchBox);
            this.groupBox4.Controls.Add(this.SearchResults);
            this.groupBox4.Location = new System.Drawing.Point(125, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(116, 270);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // AddMethods
            // 
            this.AddMethods.Location = new System.Drawing.Point(144, 608);
            this.AddMethods.Name = "AddMethods";
            this.AddMethods.Size = new System.Drawing.Size(75, 23);
            this.AddMethods.TabIndex = 37;
            this.AddMethods.Text = "Update database";
            this.AddMethods.UseVisualStyleBackColor = true;
            this.AddMethods.Click += new System.EventHandler(this.AddMethods_Click);
            // 
            // LanguageMethods
            // 
            this.LanguageMethods.FormattingEnabled = true;
            this.LanguageMethods.ItemHeight = 15;
            this.LanguageMethods.Location = new System.Drawing.Point(6, 22);
            this.LanguageMethods.Name = "LanguageMethods";
            this.LanguageMethods.Size = new System.Drawing.Size(99, 259);
            this.LanguageMethods.TabIndex = 38;
            this.LanguageMethods.SelectedIndexChanged += new System.EventHandler(this.LanguageMethods_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.LanguageMethods);
            this.groupBox6.Location = new System.Drawing.Point(125, 301);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(116, 298);
            this.groupBox6.TabIndex = 39;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Methods";
            // 
            // URL
            // 
            this.URL.AutoSize = true;
            this.URL.Location = new System.Drawing.Point(336, 617);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(0, 15);
            this.URL.TabIndex = 40;
            this.URL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.URL_Clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 662);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.AddMethods);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WebURLinput);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddLanguage;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button AddProblems;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RemoveLanguage;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button DeleteProblems;
        private System.Windows.Forms.Button AddSolutions;
        private System.Windows.Forms.Button RemoveSolutions;
        private System.Windows.Forms.TextBox WebURLinput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SolutionTitle;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.CheckBox Problemsbox;
        private System.Windows.Forms.CheckBox SolutionsBox;
        private System.Windows.Forms.ListBox SearchResults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
       
        private System.Windows.Forms.Button AddMethods;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox LanguageMethods;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.LinkLabel URL;
    }
}

