using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookLogic;

namespace FacebookDesktopUI
{
    public partial class MyPostsForm : Form
    {
        private readonly MyPosts r_MyPosts;
        private IEnumerator<string> m_PostEnumerator;

        public MyPostsManager.ePostsConfiguration PostsConfiguration { get; set; }

        public MyPostsForm()
        {
            InitializeComponent();
            r_MyPosts = new MyPosts();
            new PostsConfigurationForm(this).ShowDialog();
            loadPosts();
        }

        private void loadPosts()
        {
            try
            {
                m_PostEnumerator = r_MyPosts.GeneratePostsAndEnumerator(PostsConfiguration);
                if (string.IsNullOrEmpty(m_PostEnumerator.Current))
                {
                    buttonNext.Enabled = false;
                    MessageBox.Show("No Posts Available");
                }
                else
                {
                    textBoxPostData.Text = m_PostEnumerator.Current;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if(!m_PostEnumerator.MoveNext())
            {
                m_PostEnumerator.Reset();
            }

            textBoxPostData.Text = m_PostEnumerator.Current;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
