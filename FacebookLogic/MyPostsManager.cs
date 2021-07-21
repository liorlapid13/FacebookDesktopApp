using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class MyPostsManager : IEnumerable<string>
    {
        private readonly FacebookDataManager r_FacebookDataManager;
        private readonly FacebookObjectCollection<Post> r_Posts;
        private List<string> m_FormattedPosts;

        public enum ePostsConfiguration
        {
            BasicPosts = 0,
            DetailedPosts
        }

        public MyPostsManager()
        {
            r_FacebookDataManager = FacebookDataManager.Instance;
            r_Posts = FetchPosts();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach(string formattedPost in m_FormattedPosts)
            {
                yield return formattedPost;
            }
        }

        public void GeneratePosts(ePostsConfiguration i_PostsConfiguration)
        {
            try
            {
                IPostsFormat iPostsFormat = new PostsFormatAdapter(r_Posts, i_PostsConfiguration);

                m_FormattedPosts = iPostsFormat.GeneratePostsFormat();
            }

            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public FacebookObjectCollection<Post> FetchPosts()
        {
            try
            {
                return r_FacebookDataManager.FetchPosts();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
