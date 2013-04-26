using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using System.Threading;

namespace DelFile
{
    public delegate void EventHandler_SendMessageToUI(string i_s_text);

    public class CWork
    {
        private int m_i_count = 0;
        /// <summary>
        /// 通知UI
        /// </summary>
        public event EventHandler_SendMessageToUI Event_SendMessageToUI;

        /// <summary>
        /// 需要删除的文件夹地址
        /// </summary>
        private string m_s_delfolderpath = "";

        /// <summary>
        /// 需要删除的文件类型列表
        /// </summary>
        private List<string> m_deletefiletypelist = new List<string>( );

        /// <summary>
        /// 需要删除的文件夹类型列表
        /// </summary>
        private List<string> m_deletefoldertypelist = new List<string>( );

        public CWork ( string i_s_workpath,List<string> i_deletefoldertypelist ,List<string> i_deletefiletypelist )
        {
            this.m_s_delfolderpath = i_s_workpath;
            this.m_deletefiletypelist = i_deletefiletypelist;
            this.m_deletefoldertypelist = i_deletefoldertypelist;
        }

        public void BeginDeleteWork ( )
        {
            SetMessage( "begin" );
            m_i_count = 1;
            //删除文件夹
            foreach (string t_folder in m_deletefoldertypelist)
            {
                this.DeleFolder( m_s_delfolderpath, t_folder );
            }
            //删除文件
            this.DelFile( m_s_delfolderpath);
            SetMessage( "end,count:" + (m_i_count-1).ToString() );
        }

        private void DeleFolder ( string i_s_workpath, string key )
        {

            bool t_isDelete = false;
            int t_i_svnindex = 0;
            t_i_svnindex = i_s_workpath.IndexOf( key );
            if (t_i_svnindex > 0)
            {
                t_isDelete = true;
            }
            if (t_isDelete)
            {
                if (Directory.Exists( i_s_workpath ))
                {
                    foreach (string ff in Directory.GetFiles( i_s_workpath ))
                    {
                        FileInfo fi = new FileInfo( ff );
                        fi.Attributes = FileAttributes.Normal;
                        fi.Delete( );
                        SetMessage( ff );
                    }
                }
            }
            foreach (string dd in Directory.GetDirectories( i_s_workpath ))
            {
                this.DeleFolder( dd, key );
                if (Directory.Exists( dd ))
                {
                    if (t_isDelete && Directory.GetDirectories( dd ).Length <= 0)
                    {
                        Directory.Delete( dd );
                        SetMessage( dd );
                    }
                }
            }
            if (t_isDelete)
            {
                Directory.Delete( i_s_workpath );
                SetMessage( i_s_workpath );
            }
            return;
        }

        private void SetMessage (string i_s_message )
        {
            if (this.Event_SendMessageToUI != null)
            {
                Event_SendMessageToUI( "deleted:"+i_s_message );
                m_i_count++;
            }
        }

        private void DelFile ( string i_s_path )
        {
            string[] t_array_filelist = Directory.GetFiles( i_s_path );
            string[] t_array_folderlist = Directory.GetDirectories( i_s_path );

            foreach (string ff in t_array_filelist)
            {
                string t_s_file = ff.ToLower( );
                FileInfo t_fileinfo = new FileInfo( t_s_file );

                t_s_file = t_fileinfo.Name;

                foreach (string t_type in m_deletefiletypelist)
                {
                    if (t_s_file.IndexOf( t_type ) > 0)
                    {
                        try
                        {
                            File.Delete( ff );
                            SetMessage( ff );
                        }
                        catch
                        {
                            ;
                        }
                        break;
                    }
                }
            }
            foreach (string dd in t_array_folderlist)
            {
                DelFile( dd );
            }
            ;
        }

    }
}
