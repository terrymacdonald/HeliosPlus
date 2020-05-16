﻿using Manina.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeliosPlus.UIForms
{

    #region Shortcut Adaptor
    /// <summary>
    /// A custom item adaptor for ImageListView that reads from a Profile.
    /// </summary>
    class ShortcutAdaptor : ImageListView.ImageListViewItemAdaptor
    {

        private bool disposed;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSystemAdaptor"/> class.
        /// </summary>
        public ShortcutAdaptor()
        {
            disposed = false;
        }

        /// <summary>
        /// Returns the thumbnail image for the given item.
        /// </summary>
        /// <param name="key">Item key.</param>
        /// <param name="size">Requested image size.</param>
        /// <param name="useEmbeddedThumbnails">Embedded thumbnail usage.</param>
        /// <param name="useExifOrientation">true to automatically rotate images based on Exif orientation; otherwise false.</param>
        /// <returns>The thumbnail image from the given item or null if an error occurs.</returns>
        public override Image GetThumbnail(object key, Size size, UseEmbeddedThumbnails useEmbeddedThumbnails, bool useExifOrientation)
        {
            if (disposed)
                return null;

            try
            {
                string shortcutName = key.ToString();

                Shortcut shortcutToUse = null;

                foreach (Shortcut shortcutToTest in Shortcut.AllSavedShortcuts)
                {
                    if (shortcutToTest.Name == shortcutName)
                    {
                        shortcutToUse = shortcutToTest;
                    }

                }

                if (shortcutToUse == null)
                {
                    Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(() => { return false; });
                    return shortcutToUse.ShortcutBitmap.GetThumbnailImage(size.Width, size.Height, myCallback, IntPtr.Zero);
                }
                else 
                    return null;
            }
            catch {
                // If we have a problem with converting the submitted key to a profile
                // Then we return null
                return null;
            }


            return null;
        }

        /// <summary>
        /// Returns a unique identifier for this thumbnail to be used in persistent
        /// caching.
        /// </summary>
        /// <param name="key">Item key.</param>
        /// <param name="size">Requested image size.</param>
        /// <param name="useEmbeddedThumbnails">Embedded thumbnail usage.</param>
        /// <param name="useExifOrientation">true to automatically rotate images based on Exif orientation; otherwise false.</param>
        /// <returns>A unique identifier string for the thumnail.</returns>
        public override string GetUniqueIdentifier(object key, Size size, UseEmbeddedThumbnails useEmbeddedThumbnails, bool useExifOrientation)
        {
            if (disposed)
                return null;

            try
            {
                string shortcutName = (string)key;
                return shortcutName;
            }
            catch
            {
                // If we have a problem with converting the submitted key to a profile
                // Then we return null
                return null;
            }
        }

        /// <summary>
        /// Returns the path to the source image for use in drag operations.
        /// </summary>
        /// <param name="key">Item key.</param>
        /// <returns>The path to the source image.</returns>
        public override string GetSourceImage(object key)
        {
            if (disposed)
                return null;

            try
            {
                string shortcutName = (string)key;
                return shortcutName;
            }
            catch
            {
                // If we have a problem with converting the submitted key to a profile
                // Then we return null
                return null;
            }
        }

        /// <summary>
        /// Returns the details for the given item.
        /// </summary>
        /// <param name="key">Item key.</param>
        /// <returns>An array of tuples containing item details or null if an error occurs.</returns>
        public override Utility.Tuple<ColumnType, string, object>[] GetDetails(object key)
        {
            if (disposed)
                return null;

            List<Utility.Tuple<ColumnType, string, object>> details = new List<Utility.Tuple<ColumnType, string, object>>();

            try
            {
                string shortcutName = (string)key;
                Shortcut shortcutToUse = null;

                foreach (Shortcut shortcutToTest in Shortcut.AllSavedShortcuts)
                {
                    if (shortcutToTest.Name == shortcutName)
                    {
                        shortcutToUse = shortcutToTest;
                    }

                }

                // Get file info
                if (shortcutToUse.ShortcutBitmap is Bitmap)
                {
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.FileName, string.Empty, shortcutToUse.Name));
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.DateCreated, string.Empty, ""));
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.DateAccessed, string.Empty, ""));
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.DateModified, string.Empty, ""));
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.FileSize, string.Empty, ""));
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.FilePath, string.Empty, ""));
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.FolderName, string.Empty, ""));
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.Dimensions, string.Empty, new Size(shortcutToUse.ShortcutBitmap.Width, shortcutToUse.ShortcutBitmap.Height)));
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.Resolution, string.Empty, new SizeF((float)shortcutToUse.ShortcutBitmap.Width, (float)shortcutToUse.ShortcutBitmap.Height)));
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.ImageDescription, string.Empty, shortcutToUse.Name));
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.EquipmentModel, string.Empty, ""));
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.DateTaken, string.Empty, ""));
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.Artist, string.Empty, ""));
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.Copyright, string.Empty, ""));
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.ExposureTime, string.Empty, (float)0));
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.FNumber, string.Empty, (float)0));
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.ISOSpeed, string.Empty, (ushort)0));
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.UserComment, string.Empty, ""));
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.Rating, string.Empty, (ushort)0));
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.Software, string.Empty, ""));
                    details.Add(new Utility.Tuple<ColumnType, string, object>(ColumnType.FocalLength, string.Empty, (float)0));
                }
            
                return details.ToArray();
            }
            catch
            {
                // If we have a problem with converting the submitted key to a profile
                // Then we return null
                return null;
            }
        }

        public override void Dispose()
        {
            disposed = true;
        }
    }
    #endregion
    
}