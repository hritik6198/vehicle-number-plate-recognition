
using System;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Dnn;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using ClosedXML.Excel;
namespace Car_NumerPlate
{
    public partial class Form1 : Form
    {
        private Net plateNet, charNet;
        private Mat frame;
        private string[] plateLabels, charLabels;
        private string connectionString = "Data Source=DESKTOP-4HSHC37\\SQLEXPRESS;Initial Catalog=CarNumberPlateDB;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
           // plateNet = CvDnn.ReadNet("numberplate_last (1).weights", "numberplate.cfg");
            plateNet = CvDnn.ReadNet("Number_last (10).weights", "numberplate.cfg");
            plateLabels = File.ReadAllLines("numberplate.names");
            charNet = CvDnn.ReadNet("croptext_last (10).weights", "croptext.cfg");
            charLabels = File.ReadAllLines("croptext.names");

            frame = new Mat();
        }
        // Convert Image to Byte Array
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png); // Save as PNG
                return ms.ToArray();
            }
        }
        // Process images one by one
        private void ProcessImages(string[] imageFiles)
        {
            foreach (var filePath in imageFiles)
            {
                frame = Cv2.ImRead(filePath);

                if (frame.Empty())
                {
                    MessageBox.Show("Error: Could not load image - " + filePath);
                    continue;
                }

                //  DetectNumberPlate(frame);
                DetectNumberPlate(frame, filePath);

                Bitmap imgBitmap = BitmapFromMat(frame);
                if (imgBitmap != null)
                {
                    pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = imgBitmap));
                }
                else
                {
                    MessageBox.Show("Error: Bitmap conversion failed for " + filePath);
                }
            }
        }
        // Convert Mat to Bitmap
        private Bitmap BitmapFromMat(Mat image)
        {
            if (image.Empty()) return null;

            try
            {
                return OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error converting Mat to Bitmap: " + ex.Message);
                return null;
            }
        }
        private void DetectNumberPlate(Mat inputFrame, string filePath)
        {
            textBox1.Clear();

            Mat blob = CvDnn.BlobFromImage(inputFrame, 1 / 255.0, new OpenCvSharp.Size(416, 416), new Scalar(), true, false);
            plateNet.SetInput(blob);

            var outputLayerNames = plateNet.GetUnconnectedOutLayersNames();
            Mat[] outputs = outputLayerNames.Select(_ => new Mat()).ToArray();
            plateNet.Forward(outputs, outputLayerNames);

            OpenCvSharp.Rect plateBox = new OpenCvSharp.Rect();
            float highestConfidence = 0.0f;

            foreach (var mat in outputs)
            {
                for (int i = 0; i < mat.Rows; i++)
                {
                    float confidence = mat.At<float>(i, 4);

                    if (confidence > 0.3f && confidence > highestConfidence)
                    {
                        highestConfidence = confidence;

                        float centerX = mat.At<float>(i, 0) * inputFrame.Width;
                        float centerY = mat.At<float>(i, 1) * inputFrame.Height;
                        float boxWidth = mat.At<float>(i, 2) * inputFrame.Width;
                        float boxHeight = mat.At<float>(i, 3) * inputFrame.Height;

                        float left = Math.Max(centerX - (boxWidth / 2), 0);
                        float top = Math.Max(centerY - (boxHeight / 2), 0);
                        float right = Math.Min(left + boxWidth, inputFrame.Width);
                        float bottom = Math.Min(top + boxHeight, inputFrame.Height);

                        plateBox = new OpenCvSharp.Rect((int)left, (int)top, (int)(right - left), (int)(bottom - top));
                    }
                }
            }

            if (plateBox.Width > 0 && plateBox.Height > 0)
            {
                Cv2.Rectangle(inputFrame, plateBox, Scalar.Red, 2);
                Mat croppedPlate = new Mat(inputFrame, plateBox);

                pictureBox3.Image = BitmapFromMat(croppedPlate);
                Bitmap plateBitmap = BitmapFromMat(croppedPlate);
                DetectCharacters(croppedPlate, plateBitmap, filePath);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
           // string folderPath = @"C:\Users\Hritik\OneDrive - ACS Private Limited\Desktop\Full"; // Set your folder path here
            string folderPath = @"C:\Users\Hritik\Downloads\Car";
            if (Directory.Exists(folderPath))
            {
                string[] imageFiles = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories)
                                               .Where(f => f.EndsWith(".jpg") || f.EndsWith(".jpeg") || f.EndsWith(".png") || f.EndsWith(".JPG") || f.EndsWith(".JPEG") || f.EndsWith(".PNG"))
                                               .OrderBy(f => int.Parse(Path.GetFileNameWithoutExtension(f)))
                                               .ToArray();

                if (imageFiles.Length > 0)
                {
                    ProcessImages(imageFiles);
                }
                else
                {
                    MessageBox.Show("No images found in the specified folder.");
                }
            }
            else
            {
                MessageBox.Show("Folder path does not exist.");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carNumberPlateDBDataSet3.DetectedPlates' table. You can move, or remove it, as needed.
            this.detectedPlatesTableAdapter3.Fill(this.carNumberPlateDBDataSet3.DetectedPlates);
            // TODO: This line of code loads data into the 'carNumberPlateDBDataSet2.DetectedPlates' table. You can move, or remove it, as needed.
          ///  this.detectedPlatesTableAdapter2.Fill(this.carNumberPlateDBDataSet2.DetectedPlates);
            // TODO: This line of code loads data into the 'carNumberPlateDBDataSet1.DetectedPlates' table. You can move, or remove it, as needed.
          //  this.detectedPlatesTableAdapter1.Fill(this.carNumberPlateDBDataSet1.DetectedPlates);
          //  this.detectedPlatesTableAdapter.Fill(this.carNumberPlateDBDataSet.DetectedPlates);
            button2_Click(null, EventArgs.Empty);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
        private void ExportToExcel()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // string query = "SELECT PlateNumber, FileName, DetectionTime FROM dbo.DetectedPlates";
                //string query = "SELECT PlateNumber, FileName FROM dbo.DetectedPlates";
                string query = "SELECT * FROM dbo.DetectedPlates";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("DetectedPlates");
                        worksheet.Cell(1, 1).Value = "Plate Number";
                        worksheet.Cell(1, 2).Value = "File Name";
                        worksheet.Cell(1, 3).Value = "Detection Time";
                        worksheet.Cell(1, 4).Value = "Plate Image";
                        int row = 2;
                        while (reader.Read())
                        {
                            worksheet.Cell(row, 1).Value = reader["PlateNumber"]?.ToString() ?? "";
                            worksheet.Cell(row, 2).Value = reader["FileName"]?.ToString() ?? "";
                            worksheet.Cell(row, 3).Value = reader["DetectionTime"]?.ToString() ?? "";
                            worksheet.Cell(row, 4).Value = reader["PlateImage"]?.ToString() ?? "";
                            row++;
                        }
                        // Save the Excel file
                        string filePath = @"C:\Users\Hritik\OneDrive - ACS Private Limited\Desktop\DetectedPlates.xlsx";
                        workbook.SaveAs(filePath);
                        MessageBox.Show("Data exported to Excel successfully!");
                    }
                }
            }
        }
        private void DetectCharacters(Mat croppedPlate, Bitmap plateBitmap, string filePath)
        {
            Mat blob = CvDnn.BlobFromImage(croppedPlate, 1 / 255.0, new OpenCvSharp.Size(416, 416), new Scalar(), true, false);
            charNet.SetInput(blob);

            var outputLayerNames = charNet.GetUnconnectedOutLayersNames();
            Mat[] outputs = outputLayerNames.Select(_ => new Mat()).ToArray();
            charNet.Forward(outputs, outputLayerNames);

            List<(OpenCvSharp.Rect boundingBox, string label)> detectedChars = new List<(OpenCvSharp.Rect, string)>();

            foreach (var mat in outputs)
            {
                for (int i = 0; i < mat.Rows; i++)
                {
                    float confidence = mat.At<float>(i, 4);

                    if (confidence > 0.3f)
                    {
                        float[] classScores = new float[charLabels.Length];
                        for (int j = 0; j < charLabels.Length; j++)
                        {
                            classScores[j] = mat.At<float>(i, 5 + j);
                        }
                        int classId = Array.IndexOf(classScores, classScores.Max());

                        float centerX = mat.At<float>(i, 0) * croppedPlate.Width;
                        float centerY = mat.At<float>(i, 1) * croppedPlate.Height;
                        float boxWidth = mat.At<float>(i, 2) * croppedPlate.Width;
                        float boxHeight = mat.At<float>(i, 3) * croppedPlate.Height;

                        float left = Math.Max(centerX - (boxWidth / 2), 0);
                        float top = Math.Max(centerY - (boxHeight / 2), 0);
                        float right = Math.Min(left + boxWidth, croppedPlate.Width);
                        float bottom = Math.Min(top + boxHeight, croppedPlate.Height);

                        var boundingBox = new OpenCvSharp.Rect((int)left, (int)top, (int)(right - left), (int)(bottom - top));
                        string label = charLabels[classId];

                        bool overlapping = detectedChars.Any(detected => (detected.boundingBox & boundingBox).Width > 0 && (detected.boundingBox & boundingBox).Height > 0);

                        if (!overlapping)
                        {
                            detectedChars.Add((boundingBox, label));
                        }
                    }
                }
            }

            detectedChars = detectedChars.OrderBy(c => c.boundingBox.Left).ToList();
            string detectedText = string.Join("", detectedChars.Select(c => c.label));

            if (string.IsNullOrEmpty(detectedText))
            {
                detectedText = "NULL"; // Set blank or NULL if no characters are detected
            }
            textBox1.Text = detectedText;

            string fileName = Path.GetFileName(filePath);
            // Save to database even if no text is detected
            SaveToDatabase(detectedText, fileName, plateBitmap);
        }
        private void SaveToDatabase(string text, string fileName, Image plateImage)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO dbo.DetectedPlates (PlateNumber, FileName, PlateImage) VALUES (@PlateNumber, @FileName, @PlateImage)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PlateNumber", text);
                    cmd.Parameters.AddWithValue("@FileName", fileName);
                    cmd.Parameters.AddWithValue("@PlateImage", ImageToByteArray(plateImage));
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
