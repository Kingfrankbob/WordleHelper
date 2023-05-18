using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordleHelpr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 5)
            refresh();
        }

        private void Inside_TextChanged(object sender, EventArgs e)
        {
                refresh();
        }

        private void isNotIn_TextChanged(object sender, EventArgs e)
        {
                refresh();
        }


        private void refresh()
        {
            String knownThing = knownStuff.Text, existsText = Inside.Text, notIn = isNotIn.Text;
            var prints = WordleRefr.Class1.SearchWith(knownThing, existsText, notIn);
            textBox1.Text = "Current Matches:\n" + prints.Count();
            prints.Sort();
            var previousletter = "";
            wordList.Nodes.Clear();
            var tds = wordList.Nodes;
            TreeNode currentNode = new TreeNode();
            foreach(var word in prints)
            {
                if (word[0].ToString().ToLower() != previousletter.ToLower())
                {
                    previousletter = word[0].ToString().ToLower();
                    currentNode = tds.Add("Category with " + previousletter + ":");
                }
                var otherOne = currentNode.Nodes.Add(word);
                otherOne.Tag = word;
                otherOne.StateImageIndex = 1;


            }
           

        }
    }
}
