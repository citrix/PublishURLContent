﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishContent.Classes.Helpers
{
    class ImageConverter
    {
        /* input image with width = height is suggested to get the best result */
        /* png support in icon was introduced in Windows Vista */
        public static bool ConvertToIco(System.IO.Stream input_stream, System.IO.Stream output_stream, int size, bool keep_aspect_ratio = false)
        {
            System.Drawing.Bitmap input_bit = (System.Drawing.Bitmap)System.Drawing.Bitmap.FromStream(input_stream);
            if (input_bit != null)
            {
                int width, height;
                if (keep_aspect_ratio)
                {
                    width = size;
                    height = input_bit.Height / input_bit.Width * size;
                }
                else
                {
                    width = height = size;
                }
                System.Drawing.Bitmap new_bit = new System.Drawing.Bitmap(input_bit, new System.Drawing.Size(width, height));
                if (new_bit != null)
                {
                    // save the resized png into a memory stream for future use
                    System.IO.MemoryStream mem_data = new System.IO.MemoryStream();
                    new_bit.Save(mem_data, System.Drawing.Imaging.ImageFormat.Png);

                    System.IO.BinaryWriter icon_writer = new System.IO.BinaryWriter(output_stream);
                    if (output_stream != null && icon_writer != null)
                    {
                        // 0-1 reserved, 0
                        icon_writer.Write((byte)0);
                        icon_writer.Write((byte)0);

                        // 2-3 image type, 1 = icon, 2 = cursor
                        icon_writer.Write((short)1);

                        // 4-5 number of images
                        icon_writer.Write((short)1);

                        // image entry 1
                        // 0 image width
                        icon_writer.Write((byte)width);
                        // 1 image height
                        icon_writer.Write((byte)height);

                        // 2 number of colors
                        icon_writer.Write((byte)0);

                        // 3 reserved
                        icon_writer.Write((byte)0);

                        // 4-5 color planes
                        icon_writer.Write((short)0);

                        // 6-7 bits per pixel
                        icon_writer.Write((short)32);

                        // 8-11 size of image data
                        icon_writer.Write((int)mem_data.Length);

                        // 12-15 offset of image data
                        icon_writer.Write((int)(6 + 16));

                        // write image data
                        // png data must contain the whole png data file
                        icon_writer.Write(mem_data.ToArray());

                        icon_writer.Flush();

                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        public static bool ConvertToIco(string input_image, string output_icon, int size, bool keep_aspect_ratio = false)
        {
            System.IO.FileStream input_stream = new System.IO.FileStream(input_image, System.IO.FileMode.Open);
            System.IO.FileStream output_stream = new System.IO.FileStream(output_icon, System.IO.FileMode.OpenOrCreate);

            bool result = ConvertToIco(input_stream, output_stream, size, keep_aspect_ratio);

            input_stream.Close();
            output_stream.Close();

            return result;
        }
        //public void ConvertToPng(string IconB64)
        //{

        //    using (Stream iconStream = new FileStream(iconFileName, FileMode.Open))
        //    {
        //        IconBitmapDecoder bitmapDecoder = new IconBitmapDecoder(iconStream,
        //                            BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.None);

        //        foreach (BitmapFrame bitmapFrame in bitmapDecoder.Frames)
        //        {
        //            int iconSize = bitmapFrame.PixelHeight;
        //            int bitDepth = bitmapFrame.Thumbnail.Format.BitsPerPixel;
        //            string pngFileName = Path.GetDirectoryName(iconFileName) +
        //                                 Path.DirectorySeparatorChar +
        //                                 Path.GetFileNameWithoutExtension(iconFileName) + "-" +
        //                                 iconSize + "x" + iconSize + "-" + bitDepth + ".png";
        //            using (Stream saveStream = new FileStream(pngFileName, FileMode.Create))
        //            {
        //                BitmapEncoder bitmapEncoder = new PngBitmapEncoder();
        //                bitmapEncoder.Frames.Add(bitmapFrame);
        //                bitmapEncoder.Save(saveStream);
        //            }
        //        }
        //    }
        //}
    }
}
