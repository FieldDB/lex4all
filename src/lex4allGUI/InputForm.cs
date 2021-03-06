﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lex4all;
using lex4allRecording;

namespace lex4allGUI
{
    public partial class InputForm : Form
    {
        //public Dictionary<String, String[]> wavDict = new Dictionary<string, string[]>();
        public static lex4allRecording.Recorder recorder;
        

        public InputForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// upload wav file to word
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chooseWav_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string wav in openFileDialog1.FileNames)
                {
                    int alreadyIn = 0;

                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].Text.Equals(wav))
                        {
                            alreadyIn = 1;
                        }
                    }

                    if (alreadyIn == 0)
                    {
                    listView1.Items.Add(wav);
                    }
                }

            }
        }

        /// <summary>
        /// enable or disable remove button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_ItemChecked(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count > 0)
            {
                rmCheckedBtn.Enabled = true;
            }
            else
            {
                rmCheckedBtn.Enabled = false;
            }
        }

        /// <summary>
        /// add word to lexicon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void audioOK_Click(object sender, EventArgs e)
        {

            string word = word1.Text;
            //if (lex4allGUI.MainForm.wavDict.ContainsKey(word))
            //{
            //    string alreadyInLexMsg = "That word is already in your lexicon. The audio files selected here will replace any audio files previously associated with this word.";
            //    DialogResult result = MessageBox.Show(alreadyInLexMsg, "Word already in lexicon", MessageBoxButtons.OKCancel);
            //    if (result == DialogResult.Cancel)
            //    {
            //        return;
            //    }
            //}
            List<String> wavList = new List<string>();
            foreach (ListViewItem item in listView1.Items)
            {
                wavList.Add(item.Text);
            }

            String[] wavs = wavList.ToArray();

            if (word == "")
            {
                MessageBox.Show("Please enter a word.", "Error: Word field is empty");
                return;
            }
            //else if (wavs.Length == 0)
            //{
            //    MessageBox.Show("Please choose one or more audio files.", "Error: No audio files selected");
            //}
            else
            {
                lex4allGUI.Program.main.wavDict[word] = wavs;
                lex4allGUI.Program.main.updateListView();

                this.Close();
                lex4allGUI.Program.main.Show();

                //this.Controls.RemoveByKey("audioOK");
                //this.Controls.RemoveByKey("label3");
                //this.Controls.RemoveByKey("listView1");

                //chooseWav.Text = wavDict[word].Length.ToString() + " files selected";
            }
        }
     
        /// <summary>
        /// remove checked items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rmCheckedBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked)
                {
                    item.Remove();
                }
            }

            if (listView1.CheckedItems.Count > 0)
            {
                rmCheckedBtn.Enabled = true;
            }
            else
            {
                rmCheckedBtn.Enabled = false;
            }
        }

        /// <summary>
        /// record audio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recordButton_Click(object sender, EventArgs e) {

            RecordForm record = new RecordForm();
            this.Hide();
            record.Show();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        /// <summary>
        /// go back and discard all
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            if (word1.Text == "" && listView1.Items.Count == 0)
            {
                this.Close();
                lex4allGUI.Program.main.Show();
            }
            else
            {
                if
                (MessageBox.Show("All changes will be discarded. Are you sure?", "Back to Start", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                    lex4allGUI.Program.main.Show();
                }
            }
        }

        /// <summary>
        /// add recorded data to word
        /// </summary>
        /// <param name="files">audio files passed from recording</param>
        public void updateFromRecorder(List<String> files)
        {
            foreach (String file in files)
            {
                listView1.Items.Add(file);
            }

        }
    }
}
