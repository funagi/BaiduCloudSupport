﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduCloudSupport.API
{
    public struct SimpleUserInfoStruct
    {
        public ulong uid;
        public string uname;
        public string portrait;
    }

    public struct FileMetaStruct
    {
        public ulong fs_id;
        public string path;
        public UInt32 ctime;
        public UInt32 mtime;
        public string block_list;
        public ulong size;
        public UInt32 isdir;
        public UInt32 ifhassubdir;
        public UInt32 filenum;
    }

    public struct FileListStruct
    {
        public ulong fs_id;
        public string path;
        public UInt32 ctime;
        public UInt32 mtime;
        public string md5;
        public ulong size;
        public UInt32 isdir;
    }
}
