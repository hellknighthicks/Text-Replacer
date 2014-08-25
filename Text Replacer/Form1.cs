using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Text_Replacer
{
    public partial class Form1 : Form
    {
        fileprocessor templateFile;
        fileprocessor csvFile;

        public Form1()
        {
            InitializeComponent();
            templateFile = new fileprocessor("Text Files (.txt)|*.txt|All Files(*.*)|*.*", false);
            csvFile = new fileprocessor("CSV Files (.csv)|*.csv|All Files(*.*)|*.*", false);
        }

        private void LoadTemplate_ButtonClick(object sender, EventArgs e)
        {

            if (templateFile.openfile_dialog())
            {
                templatepath.Text = templateFile.get_file_name();
                template_textBox.Text = templateFile.read_file();
            }

        }

        private void LoadCSV_ButtonClick(object sender, EventArgs e)
        {

            if (csvFile.openfile_dialog())
            {
                CSVpath.Text = csvFile.get_file_name();
                CSV_textBox.Text = csvFile.read_file();
            }

        }

        private void preview_button_Click(object sender, EventArgs e)
        {
                    //checks that we have a template and a key set
            if (CSV_textBox.Text.Length > 0 && template_textBox.Text.Length > 0)    
            {
                StringReader sr = new StringReader(CSV_textBox.Text);
                String header = sr.ReadLine();
                string[] tokens = header.Split(',');

                    // Read rest of file, building output string as we go
                StringBuilder sb = new StringBuilder();
                String output;
                String[] values;
                int inc = 1; // record #
                string value_line = sr.ReadLine();

                output = template_textBox.Text;

                if (itemnumbers_checkbox.Checked)
                    sb.AppendLine("// " + inc++);

                values = value_line.Split(',');
                
                try{
                for (int i = 0; i < tokens.Count(); i++)
                {
                    if (
                            tokens[i].Length > 0       //Not null
                                && 
                            !tokens[i].Equals("")         //Not Empty
                                && 
                            !tokens[i].Equals(" ")        //Not White space
                          
                        ) 

                    output = output.Replace(tokens[i], values[i]);
                }

                sb.AppendLine(output);
                sb.AppendLine();
                }
                catch (Exception ee)
                    {
                        MessageBox.Show("OH NO something went wrong during the conversation!!! \n" + ee);
                        return;
                    }

                MessageBox.Show("Using first set of values \n\n" + sb.ToString());


            }

            else
                MessageBox.Show("Nothing to show.");
        }

        private void produce_window_Click(object sender, EventArgs e)
        {
            if (CSV_textBox.Text.Length > 0 && template_textBox.Text.Length > 0)
            {
                StringReader sr = new StringReader(CSV_textBox.Text);
                String header = sr.ReadLine();
                string[] tokens = header.Split(',');

                // Read rest of file, building output string as we go
                StringBuilder sb = new StringBuilder();
                String output;
                String[] values;
                int inc = 1; // record #
                string value_line = sr.ReadLine();

                while ((value_line = sr.ReadLine()) != null)
                {
                    output = template_textBox.Text;

                    if (itemnumbers_checkbox.Checked)
                        sb.AppendLine("// " + inc++);

                    values = value_line.Split(',');
                    for (int i = 0; i < tokens.Count(); i++)
                    {
                        output = output.Replace(tokens[i], values[i]);
                    }

                    sb.AppendLine(output);
                    sb.AppendLine();
                }

                output_box.Text = sb.ToString();
            }

            else
                MessageBox.Show("Nothing to Build.");

        }

        private void produce_file_button_Click(object sender, EventArgs e)
        {



            if (CSV_textBox.Text.Length > 0 && template_textBox.Text.Length > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (save.ShowDialog() == DialogResult.OK)
                {

                    StringReader sr = new StringReader(CSV_textBox.Text);
                    String header = sr.ReadLine();
                    string[] tokens = header.Split(',');

                    // Read rest of file, building output string as we go
                    StringBuilder sb = new StringBuilder();
                    String output;
                    String[] values;
                    int inc = 1; // record #
                    string value_line = sr.ReadLine();

                    while ((value_line = sr.ReadLine()) != null)
                    {
                        output = template_textBox.Text;

                        if (itemnumbers_checkbox.Checked)
                            sb.AppendLine("// " + inc++);

                        values = value_line.Split(',');
                        for (int i = 0; i < tokens.Count(); i++)
                        {

                            output = output.Replace(tokens[i], values[i]);
                        }

                        sb.AppendLine(output);
                        sb.AppendLine();
                    }

                   using ( StreamWriter writer = new StreamWriter(save.FileName))
                    writer.Write(sb.ToString());


                }
            }

            else
                MessageBox.Show("Nothing to produece! \n Load a template and a CSV");
        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beta 1.1 \n\nCode/GUI\n -Adam Travis \n\nLogic Specialist: \n -Daniel Cotter \n\nProject Designer: \n -Steve Haggard");
        }
    }
}



  
