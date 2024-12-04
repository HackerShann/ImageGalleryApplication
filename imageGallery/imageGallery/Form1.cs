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

namespace imageGallery
{
    public partial class Form1 : Form
    {
        // List to store the images
        private List<ImageItem> imageList = new List<ImageItem>();

        // Dictionary to store images by their tags
        private Dictionary<string, List<ImageItem>> tagDictionary = new Dictionary<string, List<ImageItem>>();

        private int currentIndex = -1; // Index of the currently displayed image

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form1 has loaded.");
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Check if no file is selected
                if (string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    MessageBox.Show("No file selected. Please choose an image to upload.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    string filePath = openFileDialog.FileName;

                    // Verify the file is a valid image
                    using (Image image = Image.FromFile(filePath))
                    {
                        ImageItem newImage = new ImageItem(filePath);
                        imageList.Add(newImage);

                        // Update current index and display
                        currentIndex = imageList.Count - 1;
                        DisplayCurrentImage();
                    }
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("The selected file is not a valid image. Please try again.",
                        "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addTagButton_Click(object sender, EventArgs e)
        {
            string tagInput = tagTextBox.Text.Trim(); // Trim whitespace from the input

            // Check if the input is empty
            if (string.IsNullOrEmpty(tagInput))
            {
                MessageBox.Show("Please enter a tag before adding.",
                    "No Tag Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if no tag is entered
            }

            // Check if there's a valid image selected
            if (currentIndex < 0)
            {
                MessageBox.Show("No image selected to add a tag.",
                    "No Image Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit if no image is selected
            }

            // Add the tag to the currently selected image
            ImageItem currentImage = imageList[currentIndex];
            string[] tags = tagInput.Split(',');

            foreach (var tag in tags)
            {
                string trimmedTag = tag.Trim();
                currentImage.AddTag(trimmedTag);

                if (!tagDictionary.ContainsKey(trimmedTag))
                {
                    tagDictionary[trimmedTag] = new List<ImageItem>();
                }
                tagDictionary[trimmedTag].Add(currentImage);
            }

            tagTextBox.Clear();
            DisplayCurrentImage(); // Refresh the display to show updated tags
        }

        private void DisplayCurrentImage()
        {
            if (currentIndex >= 0 && currentIndex < imageList.Count)
            {
                ImageItem currentImage = imageList[currentIndex];

                try
                {
                    // Clear existing image
                    imageDisplayPanel.Controls.Clear();

                    // Load and display the image
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = Image.FromFile(currentImage.FilePath),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Width = imageDisplayPanel.Width,
                        Height = imageDisplayPanel.Height
                    };
                    imageDisplayPanel.Controls.Add(pictureBox);

                    // Display metadata
                    metadataLabel.Text = $"File Name: {currentImage.FileName}\n" +
                                         $"Date Uploaded: {currentImage.DateUploaded}\n" +
                                         $"Tags: {string.Join(", ", currentImage.Tags)}";
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show($"The file '{currentImage.FilePath}' could not be found. It may have been moved or deleted.",
                        "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Remove the missing image from the list
                    imageList.RemoveAt(currentIndex);
                    currentIndex = Math.Min(currentIndex, imageList.Count - 1); // Adjust index
                    DisplayCurrentImage(); // Refresh display
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while displaying the image: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {

            if (imageList.Count == 0)
            {
                MessageBox.Show("No images in the gallery. Please upload an image first.",
                    "No Images", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (currentIndex > 0)
            {
                currentIndex--; // Move to the previous image
                DisplayCurrentImage();
            }

        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            if (imageList.Count == 0)
            {
                MessageBox.Show("No images in the gallery. Please upload an image first.",
                    "No Images", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (currentIndex < imageList.Count - 1)
            {
                currentIndex++; // Move to the next image
                DisplayCurrentImage();
            }

        }

        private void searchTagButton_Click(object sender, EventArgs e)
        {
            string searchTag = searchTagTextBox.Text.Trim();

            if (string.IsNullOrEmpty(searchTag))
            {
                MessageBox.Show("Please enter a tag to search.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tagDictionary.ContainsKey(searchTag))
            {
                List<ImageItem> imagesWithTag = tagDictionary[searchTag];
                searchResultsListBox.Items.Clear();
                foreach (var image in imagesWithTag)
                {
                    searchResultsListBox.Items.Add(image.FileName);
                }
            }
            else
            {
                MessageBox.Show($"No images found with the tag '{searchTag}'",
                    "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchResultsListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (searchResultsListBox.SelectedItem != null)
            {
                string selectedFileName = searchResultsListBox.SelectedItem.ToString();

                // Find the corresponding ImageItem by FileName
                ImageItem selectedImage = imageList.FirstOrDefault(img => img.FileName == selectedFileName);

                if (selectedImage != null)
                {
                    currentIndex = imageList.IndexOf(selectedImage);
                    DisplayCurrentImage(); // Refresh the UI
                }
                else
                {
                    // Handle case where the image could not be found
                    MessageBox.Show("Selected image could not be found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    MessageBox.Show($"Selected Item: {searchResultsListBox.SelectedItem}", "Debug Info");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
