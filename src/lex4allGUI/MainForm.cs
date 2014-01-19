﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;

namespace lex4allGUI
{
    public partial class MainForm : Form
    {
        public static Dictionary<String, String[]> wavDict = new Dictionary<string, string[]>();
        public static int numProns = 5;

        public MainForm()
        {
            InitializeComponent();
            
        }

        public void updateListView()
        {
            // listView1.Clear();
            dataGridView1.Rows.Clear();
            if (wavDict.Count > 0)
            {
                startButton.Enabled = true;
            }

            foreach (string word in wavDict.Keys)
            {
                // this.listView1.Items.Add(word);
                dataGridView1.Rows.Add(new string[] { word, wavDict[word].Length.ToString() });
            }

            // update row headers with row numbers
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Index > -1)
                    row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            
        }

            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {  
           
                startButton.Enabled = false;
                addWordButton.Enabled = false;
                dataGridView1.Enabled = false;
                startButton.Text = "Working...";
                Stopwatch watch = Stopwatch.StartNew();

                label3.Show();
                label4.Show();
                progressBar.Show();
                BuildLexicon(wavDict, saveFileDialog1.FileName);

                watch.Stop();
                TimeSpan time = watch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);

                MessageBox.Show("Lexicon was built in " + elapsedTime + "\n" + "Saved as " + saveFileDialog1.FileName, "Done");
                progressBar.Value = 0;
                progressBar.Hide();
                label4.Hide();
                label3.Hide();
                
                if (MessageBox.Show("Build another lexicon?", "Continue", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                startButton.Text = "BUILD LEXICON";
                startButton.Enabled = true;
                addWordButton.Enabled = true;
                dataGridView1.Enabled = true;
            }
                else
                {
                    this.Close();
        }

                
            }
        }

        private void addWordButton_Click(object sender, EventArgs e)
        {
            InputForm wordInput = new InputForm();
            this.Hide();
            wordInput.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex > -1)
            { //button column is third column
                    int row = e.RowIndex;
                    string word = dataGridView1.Rows[row].Cells[0].Value.ToString();
                    InputForm wordInput = new InputForm();
                    wordInput.word1.Text = word;
                    foreach (string wav in wavDict[word])
                    {
                        wordInput.listView1.Items.Add(wav);
                    }
                    this.Hide();
                    wordInput.Show();
                
            }
            if (e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                int row = e.RowIndex;
                string word = dataGridView1.Rows[row].Cells[0].Value.ToString();
                if (MessageBox.Show("Are you sure you want to delete this word and its audio files?", "Remove word",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    wavDict.Remove(word);
                    updateListView();
                }
            }
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Quit the lexicon builder?", "Confirm", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
           
        }

        private void MainForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            if
            (MessageBox.Show("This application supports you in building your own lexicon. For further information have a look on our wikipage. Do you want to be be redirected immediately?", "Welcome to lex4all", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {System.Diagnostics.Process.Start("http://lex4all.github.io/lex4all/");}
        }

        public void BuildLexicon(Dictionary<string, string[]> wavDict, string filename)
        {   
            Dictionary<String, String[]> lexDict = new Dictionary<string,string[]>();
            int wordProportion = 100/wavDict.Count;

            foreach (KeyValuePair<String, String[]> kvp in wavDict)
            {
                String word = kvp.Key;
                lexDict[word] = lex4all.Program.GetProns(kvp.Value);
                progressBar.Increment(wordProportion);
            }

            XDocument lexDoc = lex4all.Program.DictToXml(lexDict);
            lexDoc.Save(filename);
            
        }
        
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            lex4allGUI.Program.start.Show();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 1)
            {
                var cell = dataGridView1.Rows[e.RowIndex].Cells[1];
                string word = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string ttText;
                if (wavDict[word].Count() > 0)
                {
                    string files = String.Join("\n", wavDict[word]);
                    ttText = "Selected audio files:\n" + files;
                }
                else ttText = "No audio files selected.";

                cell.ToolTipText = ttText;
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            e.PaintHeader(DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentBackground);

        }

        private void shortGramChkBx_CheckedChanged(object sender, EventArgs e)
        {
            if (shortGramChkBx.Checked == true)
            {
                lex4all.GrammarControl.wildcardFile = lex4all.Properties.Resources.en_US_wildcard1;
                lex4all.GrammarControl.prefixWildcardFile = lex4all.Properties.Resources.en_US_wildcard1;
            }
            else
            {
                lex4all.GrammarControl.wildcardFile = lex4all.Properties.Resources.en_US_wildcard123;
                lex4all.GrammarControl.prefixWildcardFile = lex4all.Properties.Resources.en_US_wildcard12;
            }
        }

        private void numPronsUpDn_ValueChanged(object sender, EventArgs e)
        {
            numProns = (int)numPronsUpDn.Value;
        }

        
        
    }
}
