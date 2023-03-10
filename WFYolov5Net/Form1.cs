using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yolov5Net.Scorer;
using Yolov5Net.Scorer.Models;


namespace WFYolov5Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_detect.Enabled = false;
            btn_save.Enabled = false;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                pictureBox1.WaitOnLoad = false;
                dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                dlg.Filter = "Filter Images (*.jpg; *.bmp; *.jpeg; *.png) | *.jpg; *.bmp; *.jpeg; *.png | All files (*.*) | *.*";
                dlg.FilterIndex = 2;
                dlg.RestoreDirectory = true;

                
                pictureBox2.Image = null; //reset picturebox result

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(dlg.FileName);
                }
            }
            btn_detect.Enabled = true;
            btn_load.Enabled = false;
            btn_save.Enabled=false;
        }

        private void btn_detect_Click(object sender, EventArgs e)
        {

            int p_ok = 0, p_invert = 0;
            try
            {
                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Please select image");
                    btn_load.Enabled = true;
                }
                
                Stopwatch watch = Stopwatch.StartNew();

                Bitmap bmp = null;
                bmp = (Bitmap)pictureBox1.Image.Clone();

                var scorer = new YoloScorer<YoloCustomP6Model>("Assets/Weights/exp_model.onnx", null);

               // var scorer = new YoloScorer<YoloCocoP6Model>("Assets/Weights/yolov5n6.onnx", null);

                List<YoloPrediction> predictions = scorer.Predict(bmp);

                if (predictions.Count == 0)
                {
                    btn_save.Enabled = false;
                    lbl_alert.Text = "No object detected!";
                    lbl_alert.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    var graphics = Graphics.FromImage(bmp);

                    foreach (var prediction in predictions) // iterate predictions to draw results
                    {
                        double score = Math.Round(prediction.Score, 2);

                        graphics.DrawRectangles(new Pen(prediction.Label.Color, 2),
                            new[] { prediction.Rectangle });

                        // count object per class
                        switch (prediction.Label.Name)
                        {
                            case "p_ok":
                                p_ok++;
                                break;

                            case "p_invert":
                                p_invert++;
                                break;

                            default:
                                break;
                        }

                        var (x, y) = (prediction.Rectangle.X, prediction.Rectangle.Y - 19);

                        string name;

                        name = prediction.Label.Name + " " + (prediction.Score * 100).ToString("0.#") + "%";
                        graphics.FillRectangle(new SolidBrush(Color.Green), new RectangleF(x, y, prediction.Rectangle.Width, 20));
                        graphics.DrawString(name, new Font("Consolas", 16, GraphicsUnit.Pixel), new SolidBrush(Color.GreenYellow), new PointF(x, y));
                    }
                    btn_save.Enabled = true;
                }
                pictureBox2.Image = bmp;
                watch.Stop();
                lbl_pOk.Text = "p_ok: " + p_ok;
                lbl_pInvert.Text = "p_invert: " + p_invert;
                lbl_totalObj.Text = "Total Object(s): " + predictions.Count.ToString();
                label1.Text = "Process Time: " + watch.ElapsedMilliseconds.ToString() + " ms";
                btn_load.Enabled = true;
                btn_detect.Enabled = false;

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                saveFileDialog.Filter = "Image (*.jpg) | *.jpg";
                saveFileDialog.DefaultExt = ".jpg";
                saveFileDialog.RestoreDirectory = true;

                string fileName = saveFileDialog.FileName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image.Save(saveFileDialog.FileName);
                    lbl_alert.Text = "Saved Successfully!";
                    lbl_alert.ForeColor = Color.Green;
                }
            } catch (Exception ex) { 
                MessageBox.Show(ex.Message); 
            }
            btn_save.Enabled = false;
        }
    }
}
