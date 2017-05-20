using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xRay.Toolkit.Utilities;

namespace MemeFryer
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        Image meme = Properties.Resources.b;
        Bitmap memebmp = Properties.Resources.b;
        Color oldColor = new Color();
        Color newColor = new Color();
        RGBHSL rgbhsl = new RGBHSL();

        private void btn_load_Click(object sender, EventArgs e)
        {
            ofd_main.ShowDialog();
            try
            {
                meme = Image.FromFile(ofd_main.FileName);
                pbx_maymay.Image = meme;
                memebmp = new Bitmap(meme);
                lbl_memename.Text = ofd_main.SafeFileName.ToString();
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Out of memory: Your meme is way to thicc", "oh shit ni🅱️🅱️a");
            }
            
        }

        private void btn_fry_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < meme.Height; j++)
            {
                for (int i = 0; i < meme.Width; i++)
                {
                    oldColor = memebmp.GetPixel(i, j);
                    newColor = RGBHSL.ModifySaturation(oldColor, Convert.ToDouble(tbr_temperature.Value));
                    memebmp.SetPixel(i, j, newColor);

                }
            }
            pbx_maymay.Image = memebmp;
        }

        private void btn_savememe_Click(object sender, EventArgs e)
        {
            try
            {
                sfd_main.ShowDialog();
                pbx_maymay.Image.Save(sfd_main.FileName, ImageFormat.Png);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "oh shit ni🅱️🅱️a");
            }

        }
    }
}
