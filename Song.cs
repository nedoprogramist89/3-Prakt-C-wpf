using System;
using System.IO;
using TagLib;

namespace PracticalWork3
{
    internal class Song
    {
        public string path { get; set; }
        public TagLib.File file { get; set; }
        public string songName { get; set; }

        public Song(string path)
        {
            this.path = path;
            file = TagLib.File.Create(path);
            songName = file.Tag.Title ?? Path.GetFileNameWithoutExtension(path);
        }
    }
}
