﻿namespace Frame
{
    class ImageSettings
    {
        public ImageMagick.Channels displayChannel = ImageMagick.Channels.RGB;
        // Weird to have sort mode here?
        public SortMode CurrentSortMode { get; set; }
    }
}
