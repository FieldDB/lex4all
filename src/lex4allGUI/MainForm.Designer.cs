﻿namespace lex4allGUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.addWordButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Audio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numPronsUpDn = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.shortGramChkBx = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPronsUpDn)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(379, 481);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(152, 23);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "BUILD LEXICON";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // addWordButton
            // 
            this.addWordButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addWordButton.Location = new System.Drawing.Point(456, 3);
            this.addWordButton.Name = "addWordButton";
            this.addWordButton.Size = new System.Drawing.Size(75, 23);
            this.addWordButton.TabIndex = 12;
            this.addWordButton.Text = "Add word";
            this.addWordButton.UseVisualStyleBackColor = true;
            this.addWordButton.Click += new System.EventHandler(this.addWordButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Word,
            this.Audio,
            this.buttonColumn,
            this.Delete});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 3);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(0, 10);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(528, 380);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // Word
            // 
            this.Word.HeaderText = "Word";
            this.Word.Name = "Word";
            this.Word.ReadOnly = true;
            // 
            // Audio
            // 
            this.Audio.HeaderText = "Audio Files";
            this.Audio.Name = "Audio";
            this.Audio.ReadOnly = true;
            // 
            // buttonColumn
            // 
            this.buttonColumn.HeaderText = "";
            this.buttonColumn.Name = "buttonColumn";
            this.buttonColumn.ReadOnly = true;
            this.buttonColumn.Text = "Edit";
            this.buttonColumn.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.44195F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.685393F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.87266F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.startButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.addWordButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.28413F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.749247F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.985397F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.981228F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 511);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Your lexicon is being built. This may take a few minutes.";
            this.label3.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Words and audio for lexicon training:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numPronsUpDn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.shortGramChkBx);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 418);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 3);
            this.groupBox1.Size = new System.Drawing.Size(242, 90);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // numPronsUpDn
            // 
            this.numPronsUpDn.Location = new System.Drawing.Point(185, 29);
            this.numPronsUpDn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPronsUpDn.Name = "numPronsUpDn";
            this.numPronsUpDn.Size = new System.Drawing.Size(47, 20);
            this.numPronsUpDn.TabIndex = 1;
            this.numPronsUpDn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.numPronsUpDn, "The maximum number of alternative pronunciations that will be included in the lex" +
        "icon. Generally (but not always), more pronunciations enable higher recognition " +
        "accuracy.");
            this.numPronsUpDn.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPronsUpDn.ValueChanged += new System.EventHandler(this.numPronsUpDn_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Maximum pronunciations per word:";
            this.toolTip1.SetToolTip(this.label2, "The maximum number of alternative pronunciations that will be included in the lex" +
        "icon. Generally (but not always), more pronunciations enable higher recognition " +
        "accuracy.");
            // 
            // shortGramChkBx
            // 
            this.shortGramChkBx.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.shortGramChkBx.AutoSize = true;
            this.shortGramChkBx.Checked = true;
            this.shortGramChkBx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shortGramChkBx.Location = new System.Drawing.Point(12, 59);
            this.shortGramChkBx.Name = "shortGramChkBx";
            this.shortGramChkBx.Size = new System.Drawing.Size(92, 17);
            this.shortGramChkBx.TabIndex = 15;
            this.shortGramChkBx.Text = "Faster training";
            this.toolTip1.SetToolTip(this.shortGramChkBx, "If checked, a shorter pronunciation discovery grammar will be used during trainin" +
        "g. This makes training much faster, but may produce slightly less accurate pronu" +
        "nciations.");
            this.shortGramChkBx.UseVisualStyleBackColor = true;
            this.shortGramChkBx.CheckedChanged += new System.EventHandler(this.shortGramChkBx_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.progressBar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(259, 445);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(272, 27);
            this.flowLayoutPanel1.TabIndex = 16;
            this.toolTip1.SetToolTip(this.flowLayoutPanel1, "The maximum number of alternative pronunciations that will be included in the lex" +
        "icon. Generally (but not always), more pronunciations enable higher recognition " +
        "accuracy.");
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Progress:";
            this.label4.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.progressBar.Location = new System.Drawing.Point(59, 2);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(207, 18);
            this.progressBar.TabIndex = 14;
            this.progressBar.Visible = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "pls";
            this.saveFileDialog1.FileName = "lexicon";
            this.saveFileDialog1.Filter = "Pronunciation Lexicon (*.pls) | *.pls|XML file (*.xml)|*.xml";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lex4all Lexicon Builder";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainForm_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPronsUpDn)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button addWordButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn Audio;
        private System.Windows.Forms.DataGridViewButtonColumn buttonColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox shortGramChkBx;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numPronsUpDn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;



    }
}