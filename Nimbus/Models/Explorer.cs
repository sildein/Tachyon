﻿/*
 * Explorer.cs
 * This file is a part of Nimbus. Copyright (c) 2017-present Jesse Jones.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nimbus.Models
{
    public class Explorer
    {
        public List<string> Files;
        public List<string> Folders;
        public string CurrentDirectory;

        public Explorer(string Folder)
        {
            this.Files = new List<string>();
            this.Folders = new List<string>();

            this.CurrentDirectory = Folder;

            string[] Files = Directory.GetFiles(Shared.Prefix + "/Files" + Folder);
            foreach (string file in Files) this.Files.Add(file.Split('/', '\\').Last());

            string[] Folders = Directory.GetDirectories(Shared.Prefix + "/Files" + Folder);
            foreach (string folder in Folders) this.Folders.Add(folder.Split('/', '\\').Last());
            Directory.GetCurrentDirectory();
        }
    }
}
