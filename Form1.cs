using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using MediaFileProcessor.Models.Common;
using MediaFileProcessor.Models.Enums;
using MediaFileProcessor.Models.Settings;
using MediaFileProcessor.Processors;
using System;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CoVid2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int framesPerSecond = 16;
        private string filePath = "";
        private bool isInverted = false;
        static bool IsInitialized;
        private Bitmap src = null;
        private bool canPlay = true;
        private static StringBuilder output = new StringBuilder();
        private void îòêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = System.Drawing.Color.White;
            richTextBox1.ForeColor = System.Drawing.Color.Black;

            comboBox1.SelectedIndex = 0;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "image files All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    src = new Bitmap(filePath);

                    string outputFrame = processImage(src);
                    richTextBox1.Text = outputFrame;

                    isInverted = false;
                }
            }
        }
        private void èíâåðñèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = System.Drawing.Color.White;
            richTextBox1.ForeColor = System.Drawing.Color.Black;

            Bitmap src = new Bitmap(filePath);

            string outputFrame = "";

            if (!isInverted)
            {
                outputFrame = processInvertedImage(src);

                isInverted = true;
            }
            else
            {
                outputFrame = processImage(src);

                isInverted = false;
            }

            richTextBox1.Text = outputFrame;
        }
        private void ìàòðèöàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = System.Drawing.Color.Black;
            richTextBox1.ForeColor = System.Drawing.Color.Green;
        }
        private string processImage(Bitmap src)
        {
            string outputFrame = "";
            for (int i = 0; i < src.Height; i++)
            {
                for (int j = 0; j < src.Width; j++)
                {
                    if (src.GetPixel(j, i).GetBrightness() < 0.1)
                        outputFrame += "...";
                    else if (src.GetPixel(j, i).GetBrightness() < 0.2)
                        outputFrame += ",,,";
                    else if (src.GetPixel(j, i).GetBrightness() < 0.3)
                        outputFrame += "___";
                    else if (src.GetPixel(j, i).GetBrightness() < 0.4)
                        outputFrame += "+++";
                    else if (src.GetPixel(j, i).GetBrightness() < 0.5)
                        outputFrame += "ooo";
                    else if (src.GetPixel(j, i).GetBrightness() < 0.6)
                        outputFrame += "XXX";
                    else if (src.GetPixel(j, i).GetBrightness() < 0.7)
                        outputFrame += "SSS";
                    else if (src.GetPixel(j, i).GetBrightness() < 0.8)
                        outputFrame += "BBB";
                    else if (src.GetPixel(j, i).GetBrightness() < 0.9)
                        outputFrame += "%%%";
                    else
                        outputFrame += "@@@";
                }
                outputFrame += "\n";
            }
            return outputFrame;
        }
        private string processInvertedImage(Bitmap src)
        {
            string outputFrame = "";
            for (int i = 0; i < src.Height; i++)
            {
                for (int j = 0; j < src.Width; j++)
                {
                    if (src.GetPixel(j, i).GetBrightness() < 0.1)
                        outputFrame += "@@@";
                    else if (src.GetPixel(j, i).GetBrightness() < 0.2)
                        outputFrame += "%%%";
                    else if (src.GetPixel(j, i).GetBrightness() < 0.3)
                        outputFrame += "BBB";
                    else if (src.GetPixel(j, i).GetBrightness() < 0.4)
                        outputFrame += "SSS";
                    else if (src.GetPixel(j, i).GetBrightness() < 0.5)
                        outputFrame += "XXX";
                    else if (src.GetPixel(j, i).GetBrightness() < 0.6)
                        outputFrame += "ooo";
                    else if (src.GetPixel(j, i).GetBrightness() < 0.7)
                        outputFrame += "+++";
                    else if (src.GetPixel(j, i).GetBrightness() < 0.8)
                        outputFrame += "___";
                    else if (src.GetPixel(j, i).GetBrightness() < 0.9)
                        outputFrame += ",,,";
                    else
                        outputFrame += "...";
                }
                outputFrame += "\n";
            }
            return outputFrame;
        }
        private void draw(object x)
        {
            output = new StringBuilder();
            FileInfo filePath = (FileInfo)(x);

            Bitmap src = new Bitmap(filePath.FullName);

            for (int h = 0; h < src.Height; h++)
            {
                for (int w = 0; w < src.Width; w++)
                {
                    var pixel = src.GetPixel(w, h);
                    var brightness = pixel.GetBrightness();

                    if (brightness > 0.5)
                    {
                        output.Append("@@@");
                    }
                    else
                    {
                        output.Append("...");
                    }
                }
                output.AppendLine();
            }
            try
            {
                this.Invoke(new Action(() =>
                {
                    try
                    {
                        richTextBox1.Text = output.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Äîæäèòåñü îêîí÷àíèÿ!");
                    }
                }));
            }
            catch
            {
                MessageBox.Show("Äîæäèòåñü îêîí÷àíèÿ!");
            }            
        }
        private async void ïóñêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ffmpegPath = "D:\\ffmpeg\\bin\\ffmpeg.exe"; // Replace with the actual path to FFmpeg executable

            OpenFileDialog videoDialog = new OpenFileDialog();
            videoDialog.ShowDialog();
            string inputVideoPath = videoDialog.FileName;      // Replace with the path of your input video file

            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.ShowDialog();
            string outputDirectory = fb.SelectedPath;  // Replace with the directory where you want to save frames

            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

            string frameOutputPath = Path.Combine(outputDirectory, "frame_%04d.png");

            // Use FFmpeg to extract frames from the video
            ProcessStartInfo processStartInfo = new ProcessStartInfo(ffmpegPath)
            {
                Arguments = $"-i \"{inputVideoPath}\" -vf fps=\"{framesPerSecond}\" \"{frameOutputPath}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
                UseShellExecute = false
            };

            Process process = new Process
            {
                StartInfo = processStartInfo
            };

            process.Start();
            process.WaitForExitAsync();

            // Load each saved frame into Bitmap
            string[] framePaths = Directory.GetFiles(outputDirectory, "frame_*.png");
            foreach (string framePath in framePaths)
            {
                using (Bitmap frameBitmap = new Bitmap(framePath))
                {
                    // Process each frame here (e.g., display, analyze, etc.)
                    // TODO: Your frame processing logic

                    // For demonstration, let's save the processed frame with "_processed" suffix
                    string processedFramePath = framePath.Replace("frame_", "frame_processed_");
                    frameBitmap.Save(processedFramePath, System.Drawing.Imaging.ImageFormat.Png);
                }
            }

            MessageBox.Show("Frame extraction and processing complete.");
        }

        private void ñîõðàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word Document (*.doc)|*.doc";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                SaveToDocx(fileName);
                MessageBox.Show("Ñîõðàíåíèå óñïåøíî!");
            }
            else
                MessageBox.Show("ÎØÈÁÊÀ! Íå óäàëîñü ñîõðàíèòü ôàéë!!!");
        }

        private void SaveToDocx(string fileName)
        {
            using (WordprocessingDocument doc = WordprocessingDocument.Create(fileName, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = doc.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());

                // Set Margins
                SectionProperties sectionProps = new SectionProperties();
                PageMargin pageMargin = new PageMargin() { Top = 720, Right = 720, Bottom = 720, Left = 720, Header = 0, Footer = 0, Gutter = 0 };
                sectionProps.Append(pageMargin);
                body.Append(sectionProps);

                Paragraph paragraph = new Paragraph();
                Run run = new Run();
                var font = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                // Set Font Properties
                RunProperties runProperties = new RunProperties(
                    new RunFonts() { Ascii = font, HighAnsi = font },
                    new FontSize() { Val = "2" }); // Set font size here (in half points)

                Text text = new Text(richTextBox1.Text);

                run.Append(runProperties);
                run.Append(text);
                paragraph.Append(run);

                // Set Line Spacing
                ParagraphProperties paragraphProperties = new ParagraphProperties(
                    new SpacingBetweenLines() { Line = "240", LineRule = LineSpacingRuleValues.Auto });

                paragraph.Append(paragraphProperties);

                body.Append(paragraph);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        richTextBox1.Font = new System.Drawing.Font("Courier", richTextBox1.Font.Size);
                        break;
                    }
                case 1:
                    {
                        richTextBox1.Font = new System.Drawing.Font("Andale Mono", richTextBox1.Font.Size);
                        break;
                    }
                case 2:
                    {
                        richTextBox1.Font = new System.Drawing.Font("Monaco", richTextBox1.Font.Size);
                        break;
                    }
                case 3:
                    {
                        richTextBox1.Font = new System.Drawing.Font("Profont", richTextBox1.Font.Size);
                        break;
                    }
                case 4:
                    {
                        richTextBox1.Font = new System.Drawing.Font("Monofur", richTextBox1.Font.Size);
                        break;
                    }
                case 5:
                    {
                        richTextBox1.Font = new System.Drawing.Font("Proggy", richTextBox1.Font.Size);
                        break;
                    }
                case 6:
                    {
                        richTextBox1.Font = new System.Drawing.Font("Droid Sans Mono", richTextBox1.Font.Size);
                        break;
                    }
                case 7:
                    {
                        richTextBox1.Font = new System.Drawing.Font("Deja Vu Sans Mono", richTextBox1.Font.Size);
                        break;
                    }
                case 8:
                    {
                        richTextBox1.Font = new System.Drawing.Font("Consolas", richTextBox1.Font.Size);
                        break;
                    }
                case 9:
                    {
                        richTextBox1.Font = new System.Drawing.Font("Inconsolata", richTextBox1.Font.Size);
                        break;
                    }
            }
        }

        private async void âîñïðîèçâåñòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fb = new FolderBrowserDialog();

                fb.ShowDialog();

                var fullPath = fb.SelectedPath;

                DirectoryInfo dir = new DirectoryInfo(fullPath);
                int i = 0;
                int len = dir.GetFiles().Length;
                for (i = 0; i < len; i++)                
                {
                    await Task.Run(() =>
                    {
                        while (!canPlay)
                        {
                            Task.Delay(200);
                        }

                        draw(dir.GetFiles()[i]);
                        Thread.Sleep(10);
                    });
                }
            }
            catch
            {
                MessageBox.Show("Äîæäèòåñü îêîí÷àíèÿ!");
            }
        }

        private void ïàóçàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canPlay = false;
        }

        private void ïóñêToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            canPlay = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            framesPerSecond = Convert.ToInt16(textBox1.Text);
        }
    }
}