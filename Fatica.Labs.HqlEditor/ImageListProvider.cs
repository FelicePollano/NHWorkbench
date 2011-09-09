using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fatica.Labs.HqlEditor
{
    public partial class ImageListProvider : UserControl
    {
        public ImageListProvider()
        {
            InitializeComponent();
        }
        public ImageList GetImageList()
        {
            return imageListCompletion;
        }
    }
}
