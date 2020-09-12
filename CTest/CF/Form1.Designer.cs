namespace CF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.UI_tbxSearch = new System.Windows.Forms.TextBox();
            this.UI_cbxIsPhrase = new System.Windows.Forms.CheckBox();
            this.UI_btnAddWord = new System.Windows.Forms.Button();
            this.UI_btnSearch = new System.Windows.Forms.Button();
            this.UI_btnClear = new System.Windows.Forms.Button();
            this.UI_nudTop = new System.Windows.Forms.NumericUpDown();
            this.UI_btnFindTop = new System.Windows.Forms.Button();
            this.UI_cbxConjunction = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.UI_nudTop)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ChooseFile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UI_tbxSearch
            // 
            this.UI_tbxSearch.Location = new System.Drawing.Point(82, 186);
            this.UI_tbxSearch.Name = "UI_tbxSearch";
            this.UI_tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.UI_tbxSearch.TabIndex = 1;
            // 
            // UI_cbxIsPhrase
            // 
            this.UI_cbxIsPhrase.AutoSize = true;
            this.UI_cbxIsPhrase.Location = new System.Drawing.Point(234, 188);
            this.UI_cbxIsPhrase.Name = "UI_cbxIsPhrase";
            this.UI_cbxIsPhrase.Size = new System.Drawing.Size(59, 17);
            this.UI_cbxIsPhrase.TabIndex = 2;
            this.UI_cbxIsPhrase.Text = "Phrase";
            this.UI_cbxIsPhrase.UseVisualStyleBackColor = true;
            // 
            // UI_btnAddWord
            // 
            this.UI_btnAddWord.Location = new System.Drawing.Point(377, 182);
            this.UI_btnAddWord.Name = "UI_btnAddWord";
            this.UI_btnAddWord.Size = new System.Drawing.Size(75, 23);
            this.UI_btnAddWord.TabIndex = 3;
            this.UI_btnAddWord.Text = "Add";
            this.UI_btnAddWord.UseVisualStyleBackColor = true;
            this.UI_btnAddWord.Click += new System.EventHandler(this.UI_btnAddWord_Click);
            // 
            // UI_btnSearch
            // 
            this.UI_btnSearch.Location = new System.Drawing.Point(82, 232);
            this.UI_btnSearch.Name = "UI_btnSearch";
            this.UI_btnSearch.Size = new System.Drawing.Size(75, 23);
            this.UI_btnSearch.TabIndex = 4;
            this.UI_btnSearch.Text = "Search";
            this.UI_btnSearch.UseVisualStyleBackColor = true;
            this.UI_btnSearch.Click += new System.EventHandler(this.UI_btnSearch_Click);
            // 
            // UI_btnClear
            // 
            this.UI_btnClear.Location = new System.Drawing.Point(234, 232);
            this.UI_btnClear.Name = "UI_btnClear";
            this.UI_btnClear.Size = new System.Drawing.Size(75, 23);
            this.UI_btnClear.TabIndex = 5;
            this.UI_btnClear.Text = "Clear";
            this.UI_btnClear.UseVisualStyleBackColor = true;
            this.UI_btnClear.Click += new System.EventHandler(this.UI_btnClear_Click);
            // 
            // UI_nudTop
            // 
            this.UI_nudTop.Location = new System.Drawing.Point(82, 281);
            this.UI_nudTop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UI_nudTop.Name = "UI_nudTop";
            this.UI_nudTop.Size = new System.Drawing.Size(120, 20);
            this.UI_nudTop.TabIndex = 6;
            this.UI_nudTop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UI_btnFindTop
            // 
            this.UI_btnFindTop.Location = new System.Drawing.Point(253, 281);
            this.UI_btnFindTop.Name = "UI_btnFindTop";
            this.UI_btnFindTop.Size = new System.Drawing.Size(75, 23);
            this.UI_btnFindTop.TabIndex = 7;
            this.UI_btnFindTop.Text = "FindTop";
            this.UI_btnFindTop.UseVisualStyleBackColor = true;
            this.UI_btnFindTop.Click += new System.EventHandler(this.UI_btnFindTop_Click);
            // 
            // UI_cbxConjunction
            // 
            this.UI_cbxConjunction.AutoSize = true;
            this.UI_cbxConjunction.Location = new System.Drawing.Point(403, 283);
            this.UI_cbxConjunction.Name = "UI_cbxConjunction";
            this.UI_cbxConjunction.Size = new System.Drawing.Size(86, 17);
            this.UI_cbxConjunction.TabIndex = 8;
            this.UI_cbxConjunction.Text = "conjunctions";
            this.UI_cbxConjunction.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_cbxConjunction);
            this.Controls.Add(this.UI_btnFindTop);
            this.Controls.Add(this.UI_nudTop);
            this.Controls.Add(this.UI_btnClear);
            this.Controls.Add(this.UI_btnSearch);
            this.Controls.Add(this.UI_btnAddWord);
            this.Controls.Add(this.UI_cbxIsPhrase);
            this.Controls.Add(this.UI_tbxSearch);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UI_nudTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox UI_tbxSearch;
        private System.Windows.Forms.CheckBox UI_cbxIsPhrase;
        private System.Windows.Forms.Button UI_btnAddWord;
        private System.Windows.Forms.Button UI_btnSearch;
        private System.Windows.Forms.Button UI_btnClear;
        private System.Windows.Forms.NumericUpDown UI_nudTop;
        private System.Windows.Forms.Button UI_btnFindTop;
        private System.Windows.Forms.CheckBox UI_cbxConjunction;
    }
}

