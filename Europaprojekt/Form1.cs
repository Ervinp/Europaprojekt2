using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Svg;

namespace Europaprojekt
{


    public partial class Form1 : Form
    {
        private Svg.SvgDocument svgDocument;
        private string selectedPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
                    }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Hide();
            bool Texteingabe = false;
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult selectResult = filePicker.ShowDialog();
            if (selectResult == System.Windows.Forms.DialogResult.OK)
            {
                Svg.SVGParser.MaximumSize = new Size(pictConvertedImage.Width, pictConvertedImage.Height);

                selectedPath = filePicker.FileName;

                svgDocument = Svg.SVGParser.GetSvgDocument(selectedPath);

                pictConvertedImage.Image = Svg.SVGParser.GetBitmapFromSVG(selectedPath);
           }
        }
    }
}
