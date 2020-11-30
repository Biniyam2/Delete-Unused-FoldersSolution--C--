using System;
using System.Windows.Forms;
using System.IO;

namespace DeleteUnusedFolders
{
    public partial class Form1 : Form
    {
        bool isEmpity = true;
        string path;
        int date;
        string[] selectedFolderPath;
        int selectedFolderPathNums;
        int index=0;
        bool isSearchBTclicked = false;
        int unUsedDays = 0;
        public Form1()
        {
            InitializeComponent();
            DateTypeMethod();
            if (isEmpity)
            {
                scanBT.Enabled = false;
                selectAllBT.Enabled = false;
                unSelectAllBT.Enabled = false;
                deleteBT.Enabled = false;
            }
        }
        private void searchBT_Click(object sender, EventArgs e)
        {
            try
            {
                isSearchBTclicked = true;
                checkedListBox1.Items.Clear();
                folderBrowserDialog1.ShowDialog();
                pathTtextBox.Text = folderBrowserDialog1.SelectedPath;
                ListingItems(); // Listing the folders in the path to checkedListBox1
                selectAllBT.Enabled = true;
                unSelectAllBT.Enabled = true;
                scanBT.Enabled = true;
            }
            catch
            {
                pathTtextBox.Text = "";
            } 
        }
        public void ListingItems() // To list Folders in checkedListBox1
        {
            path = pathTtextBox.Text;
            // Folders
            string[] folders = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
            foreach (var folder in folders)
            {
                var dircInfo = new DirectoryInfo(folder);
                checkedListBox1.Items.Add(dircInfo.Name);
            }
            // Files
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);
            foreach (var file in files)
            {
                var fileInfo = new DirectoryInfo(file);
                checkedListBox1.Items.Add(fileInfo.Name);
            }
        }
        private void scanBT_Click(object sender, EventArgs e)
        {
            int checkBoxLenght;
            if(dateTypeDetail.Text != "")
            {
                if(isSearchBTclicked)// to keep the the checkedListBox1.Items.Count from being cleaned until search button is clicked
                {
                    checkBoxLenght = checkedListBox1.Items.Count;
                    selectedFolderPathNums = checkBoxLenght;
                    isSearchBTclicked = false;
                }
                checkedListBox1.Items.Clear();
                index = 0;
                CheckifUsedFolders();
                CheckifUsedFile();
                deleteBT.Enabled = true;// Enable Delete Button}
                }
            else
            {
                MessageBox.Show("Please select a specific date");
            }
        }
        private void dateType_SelectedIndexChanged(object sender, EventArgs e) // to assign the late day
        {
            DateTypeMethod();
        }
        private void DateTypeMethod() 
        {
            dateTypeDetail.Items.Clear();
            if (dateType.Text == "Year")
            {
                date = 11;
            }
            else if (dateType.Text == "Month")
            {
                date = 13;
            }
            else if (dateType.Text == "Day")
            {
                date = 32;
            }
            for (int i = 1; i < date; i++)
            {
                dateTypeDetail.Items.Add(i.ToString());
            }
        }
        public void CheckifUsedFolders()
        {
            DateTime today = DateTime.Today;
            string[] folders = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
            selectedFolderPath = new string[selectedFolderPathNums]; // To assign the length of the array
        
            foreach (var folder in folders)
            {
              
                var direcInfo = new DirectoryInfo(folder);
                DateTime lastUsedTime = direcInfo.LastWriteTime;
                int dateGap = (today.Date - lastUsedTime.Date).Days;

                if (dateType.Text == "Year") // to mulitply the year (1-10) by 365 to get the day
                    unUsedDays = 365 * int.Parse(dateTypeDetail.Text);
                else if (dateType.Text == "Month")// to mulitply the year (1-12) by 30 to get the day
                    unUsedDays = Convert.ToInt32(dateTypeDetail.Text) * 30;
                else if (dateType.Text == "Day")// to assigen the day
                    unUsedDays = Convert.ToInt32(dateTypeDetail.Text);

                if (dateGap >= unUsedDays && folders.Length != 0) // comparing assign (late date) with (date Gap)
                {
                    MessageBox.Show(" dateGap " + dateGap + "...." + unUsedDays);
                    checkedListBox1.Items.Add($"{direcInfo.Name}");
                    selectedFolderPath[index] = direcInfo.FullName; //To save the path to be transferred too delete button
                    index++;
                }
            }
        }
        private void CheckifUsedFile() 
        {
            DateTime today = DateTime.Today;
            string[] files = Directory.GetFiles(path,"*", SearchOption.TopDirectoryOnly);
            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                DateTime lastUsedTime = fileInfo.LastAccessTime;
                int dateGap = (today.Date - lastUsedTime.Date).Days;

                if (dateType.Text == "Year") // to mulitply the year (1-10) by 365 to get the day
                    unUsedDays = 365 * int.Parse(dateTypeDetail.Text);
                else if (dateType.Text == "Month")// to mulitply the year (1-12) by 30 to get the day
                    unUsedDays = int.Parse(dateTypeDetail.Text) * 30;
                else if (dateType.Text == "Day")// to assigen the day
                    unUsedDays = Convert.ToInt32(dateTypeDetail.Text);
               
                if (dateGap >= unUsedDays && files.Length != 0) // comparing assign (late date) with (date Gap)
                {
                    MessageBox.Show(" dateGap " + dateGap + "...." + unUsedDays);
                  checkedListBox1.Items.Add($"{fileInfo.Name}");
                  selectedFolderPath[index] = fileInfo.FullName; //To save the path to be transferred too delete button
                  index++;
                  
                }
                
            }
        }      
        private void deleteBT_Click(object sender, EventArgs e)
        {
            for (int i =0; i<checkedListBox1.CheckedItems.Count; i++)
            {
                for(int f =0; f< checkedListBox1.Items.Count; f++)
                {
                    if (checkedListBox1.Items[f] == checkedListBox1.CheckedItems[i])// Conferming if the item is selected
                  {
                        try
                        {
                            Directory.Delete(selectedFolderPath[f], true);
                        }
                        catch
                        {
                            File.Delete(selectedFolderPath[f]);
                        }
                    }
                }
            }
        }
        private void selectAllBT_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }
        private void unSelectAllBT_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Biniyam Yemane");
        }
    }
}
