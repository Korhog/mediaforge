﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Windows.UI.Xaml.Controls;

using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace Sequence
{
    public class SequenceImage : SequenceBaseItem
    {
        protected BitmapSource m_source;
        public BitmapSource Source { get { return m_source; } }

        protected Image m_image;
        public Image Image { get { return m_image; } }

        public SequenceImage(BitmapSource source) : base()
        {
            m_source = source;
            
            var image = new Image() // Thumbnail
            {
                Height = 100,
                Source = m_source
            };          
            
            m_image = new Image() {                
                Source = m_source
            };

            Template.Content = image;
        }
    };
}
