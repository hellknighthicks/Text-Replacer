using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Text_Replacer
{
    class fileprocessor
    {
       string fileTypeFilter;
       bool multiSelect,filegood=false;
       int filesizeLimit=0;
       FileInfo working_file;
       OpenFileDialog open_dialog;


        public fileprocessor(string droppedFilter, bool droppedMultiSelect,int droppedfilesizeLimit)
        {
            //sets everything

            fileTypeFilter = droppedFilter;
            multiSelect = droppedMultiSelect;
            filesizeLimit = droppedfilesizeLimit;
        }

        public fileprocessor(string droppedFilter, bool droppedMultiSelect)
        {
            //File size is optional  If its not passed we prolly dont care

            fileTypeFilter = droppedFilter;
            multiSelect = droppedMultiSelect;
            //filesizeLimit = 0;
        }

        public bool openfile_dialog()
        {
            open_dialog = new OpenFileDialog()
            {
                Filter = fileTypeFilter,
                FilterIndex = 1,
                Multiselect = multiSelect
            };

            open_dialog.ShowDialog();

            //  Real File?                 Path Good?                 Name good?
            if (open_dialog.CheckFileExists && open_dialog.CheckPathExists && open_dialog.FileName != "")
            {
                //opens file
                working_file = new FileInfo(open_dialog.FileName);

                //if file size specified check it
                if (filesizeLimit != 0 & working_file.Length > filesizeLimit)
                {
                    // alert user of size limitation
                    MessageBox.Show("The file you selected was over the size limit (" + filesizeLimit + "characters).");
                    //set our value
                    filegood = false;
                    //tell the calling
                    return false;
                }

                filegood = true;
                return true;
            }

            else
                return false;
        }

        public string get_file_name()
        {
            if (filegood && working_file != null)
                return working_file.FullName;
            else
                return "";
        }

        public string read_file()
        {
            if (filegood)
            {
                try
                {

                    using (Stream fileStream = open_dialog.OpenFile())
                    {
                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            string templateText = reader.ReadToEnd();
                            return templateText;
                        }
                    }

                }
                catch (IOException e)
                    {
                        MessageBox.Show("Uh Oh!!! \n The file was locked or something.  Maybe this info will help. \n"+e.ToString());
                        return "";
                    }

                
            }
            else
                return "";
        }
    }
}
