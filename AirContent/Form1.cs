using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class mainWindow : Form
    {
        Bitmap image;
        double air = 0, phase = 0, airSum = 0, phaseSum = 0;
        double airPhaseRatio = 1, airPhaseRatioAverage = 1;
        byte r, g, b;
        Color pixel;

        string airString, phaseString, airPhaseRatioString;

        public mainWindow()
        {
            InitializeComponent();
            this.Text = "Air Content v.1.3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            air = 0;
            phase = 0;
            airSum = 0;
            phaseSum = 0;
            airPhaseRatio = 1;
            airPhaseRatioAverage = 1;
            airString = "";
            phaseString = "";
            airPhaseRatioString = "";
            airText.Text = "";
            phaseText.Text = "";
            airPhaseText.Text = "";
            airPhaseAll.Text = "";

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.ShowDialog();
            
            if (dlg.FileNames != null)
            {
                foreach (string path in dlg.FileNames)
                {
                    image = new Bitmap(path);

                    //for (int i = 0; i < image.Height; i++)
                    //{
                        int x = -1, y = image.Width;
                        int i = image.Height / 2;
                        do
                        {
                            x++;
                            pixel = image.GetPixel(x, i);
                            r = pixel.R;
                            g = pixel.G;
                            b = pixel.B;
                        } while (r == 255 && g == 255 && b == 0);
                        
                        do
                        {
                            y--;
                            pixel = image.GetPixel(y, i);
                            r = pixel.R;
                            g = pixel.G;
                            b = pixel.B;

                        } while (r == 255 && g == 255 && b == 0);

                        if (x > y)
                        {
                            y = x + 1;
                        }

                        for (int j = x; j < y; j++)
                        {
                            pixel = image.GetPixel(j, i);
                            r = pixel.R;
                            g = pixel.G;
                            b = pixel.B;

                            if (r == 255 && g == 255 && b == 0)
                            {
                                air++;
                            }
                            else
                            {
                                phase++;
                            }
                        }
                    //}

                    if (phase != 0)
                    {
                        airPhaseRatio = air / phase * 100;
                        airPhaseRatio = Math.Round(airPhaseRatio, 2);
                    }

                    airString += air.ToString() + ", ";
                    phaseString += phase.ToString() + ", ";
                    airPhaseRatioString += airPhaseRatio.ToString() + " %, ";

                    if (airPhaseRatio > 1)
                    {
                        airSum += air;
                        phaseSum += phase;
                    }

                    air = 0;
                    phase = 0;
                    airPhaseRatio = 1;
                }

                if (phaseSum != 0)
                {
                    airPhaseRatioAverage = airSum / phaseSum * 100;
                    airPhaseRatioAverage = Math.Round(airPhaseRatioAverage, 2);
                }

                airText.Text = airString;
                phaseText.Text = phaseString;
                airPhaseText.Text = airPhaseRatioString;
                airPhaseAll.Text = airPhaseRatioAverage.ToString() + " %";
            }
        }
    }
}
