using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GXRGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool ret = Program.gen.Init(this.Handle);
            System.Console.WriteLine(ret);
            APRSourceData data = new APRSourceData();
            data.enumAECField = AECField.enumAECFieldCenter;
            data.enumAECFilm = AECFilm.enumAECFilmHigh;
            data.enumAuxiliary = AuxiliaryType.enumAuxiliaryDigital;
            data.enumFocus = global::Focus.enumFocusLarge;
            data.enumTechnique = Technique.enumTechniqueAEC;
            data.fMA = 42;
            data.fMAS = 20;
            data.fMS = 20;
            data.nAECDensity = 20;
            data.nKV = 20;
            Program.gen.SetGenParam(data);
        }
    }
}
