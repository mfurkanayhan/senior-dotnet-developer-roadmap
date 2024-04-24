namespace MyFirstDesktopApp
{
    public partial class Form1 : Form
    {
        // Index to keep track of the selected item in the list
        public int index = 0;

        public Form1()
        {
            InitializeComponent();

            // Set the initial visibility of buttons
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
        }

        // Event handler for the "Save" button click
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if the text box is not empty before adding a new item
            if (txtWork.Text != "")
            {
                lstTodos.Items.Add(txtWork.Text);
                txtWork.Text = "";
            }
        }

        // Event handler for double-clicking an item in the list
        private void lstTodos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Confirm if the user wants to delete the selected item
            if (MessageBox.Show("Are you sure you want to delete the record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Remove the selected item from the list
                lstTodos.Items.Remove(lstTodos.SelectedItem);

                // Reset UI elements after deletion
                txtWork.Text = "";
                btnCancel.Visible = false;
                btnUpdate.Visible = false;
                btnSave.Visible = true;
                lstTodos.Height = 229;
                lstTodos.Location = new Point(43, 141);
            }
        }

        // Event handler for clicking an item in the list
        private void lstTodos_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if an item is selected in the list
            if (lstTodos.SelectedItems != null)
            {
                // Display the selected item in the text box
                txtWork.Text = lstTodos.SelectedItem.ToString();

                // Save the index of the selected item
                index = lstTodos.SelectedIndex;

                // Adjust the visibility of buttons and list position
                btnUpdate.Visible = true;
                btnCancel.Visible = true;
                btnSave.Visible = false;
                lstTodos.Height = 184;
                lstTodos.Location = new Point(43, 186);
            }
        }

        // Event handler for the "Update" button click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Update the selected item with the text in the text box
            lstTodos.Items[index] = txtWork.Text;

            // Reset UI elements after the update
            txtWork.Text = "";
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
            btnSave.Visible = true;
            lstTodos.Height = 229;
            lstTodos.Location = new Point(43, 141);
        }

        // Event handler for the "Cancel" button click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Reset UI elements after cancellation
            btnCancel.Visible = false;
            btnUpdate.Visible = false;
            btnSave.Visible = true;
            txtWork.Text = "";
            lstTodos.Height = 229;
            lstTodos.Location = new Point(43, 141);
        }
    }
}
