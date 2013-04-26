using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DelFile
{
    [Serializable]
    public class ConfigInfo
    {
        private List<string> m_del_folderlist = new List<string>( );

        public List<string> DelFolderList
        {
            get { return m_del_folderlist; }
            set { m_del_folderlist = value; }
        }
        private List<string> m_del_filelist = new List<string>( );

        public List<string> DelFileList
        {
            get { return m_del_filelist; }
            set { m_del_filelist = value; }
        }
    }
}
