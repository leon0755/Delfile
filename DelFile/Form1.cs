using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Threading;

namespace DelFile
{
    public partial class Form1 : Form
    {

        private delegate void ShowMessage (string i_message );
        private delegate void End ( );

        CWork m_work;
        ConfigInfo m_config = null;
        private string m_s_delfolder = "";

        public Form1()
        {
            InitializeComponent();
        }

        private ArrayList m_folder_list=new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadConfig( );
            foreach (string t_value in m_config.DelFolderList)
            {
                textBox2.Text += t_value + ";";
            }
            foreach (string t_value in m_config.DelFileList)
            {
                textBox3.Text += t_value + ";";
            }
        }

        private void LoadConfig ()
        {
            if (File.Exists( "config.bin" ))
            {
                using (FileStream fs = new FileStream( "config.bin", FileMode.Open ))
                {
                    BinaryFormatter formatter = new BinaryFormatter( );
                    m_config = (ConfigInfo)formatter.Deserialize( fs );
                }
            }
            else
            {
                m_config = new ConfigInfo( );
            }
        }

        private void SaveConfig ()
        {
            using (FileStream fs = new FileStream( "config.bin", FileMode.Create ))
            {
                BinaryFormatter formatter = new BinaryFormatter( );
                formatter.Serialize( fs, m_config );
            }
        }

        void m_work_Event_SendMessageToUI ( string i_s_text )
        {
            SetMessage( i_s_text );
        }
        private void SetMessage (string i_message )
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke( new ShowMessage( SetMessage ), i_message );
                }
                else
                {
                    this.lbl_message.Text = i_message;
                }
            }
            catch
            {
                ;
            }
        }

        private void buttonWork_Click(object sender, EventArgs e)
        {
            if (m_work != null)
            {
                m_work.Event_SendMessageToUI -= new EventHandler_SendMessageToUI( m_work_Event_SendMessageToUI );
            }

            string t_s_path = textBox1.Text.Trim( );
            List<string> t_folderlist=new List<string>();
            List<string> t_filelist=new List<string>();

            t_folderlist.Add("svn");
            t_folderlist.Add("Ñ¹Ëõ");
            t_folderlist.Add("·ÇÑ¹Ëõ");
            t_folderlist.Add("LOG");
            t_folderlist.Add( "log" );
             
            t_filelist.Add( ".bak" );
            t_filelist.Add( ".pdb" );
            t_filelist.Add( ".vshost.exe" );
            t_filelist.Add( ".rar" );
            t_filelist.Add( "ÐÂ½¨" );
            t_filelist.Add( ".xls" );
            t_filelist.Add( ".psd" );
            t_filelist.Add( "thumbs.db" );
            t_filelist.Add( ".7z" );
            t_filelist.Add( ".zip" );

            m_work = new CWork( t_s_path, m_config.DelFolderList, m_config.DelFileList );
            m_work.Event_SendMessageToUI += new EventHandler_SendMessageToUI( m_work_Event_SendMessageToUI );

            Thread t_thread = new Thread( new ThreadStart( Work ) );
            t_thread.IsBackground = true;
            t_thread.Start( );
        }

        private void Work ( )
        {
            m_work.BeginDeleteWork( );
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            string[] t_folders = textBox2.Text.Split( ';' );
            string[] t_files = textBox3.Text.Split( ';' );

            List<string> t_folder_list = new List<string>( );
            List<string> t_file_list = new List<string>( );

            t_folder_list.AddRange( t_folders );
            t_file_list.AddRange( t_files );

            if (m_config == null)
            {
                m_config = new ConfigInfo( );
            }
            m_config.DelFolderList = t_folder_list;
            m_config.DelFileList = t_file_list;

            this.SaveConfig( );
        }
    }
}