using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic
{
    public class MyPosts
    {
        private readonly MyPostsManager r_MyPostsManager;

        public MyPosts()
        {
            r_MyPostsManager = new MyPostsManager();
        }

        public IEnumerator<string> GeneratePostsAndEnumerator(MyPostsManager.ePostsConfiguration i_PostsConfiguration)
        {
            try
            {
                r_MyPostsManager.GeneratePosts(i_PostsConfiguration);

                return fetchPostEnumerator();
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private IEnumerator<string> fetchPostEnumerator()
        {
            return r_MyPostsManager.GetEnumerator();
        }
    }
}
