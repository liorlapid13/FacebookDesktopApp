using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class DetailedPostConfiguration : IPostConfigurationStrategy
    {
        public string GeneratePostConfiguration(Post i_PostToConfigure)
        {
            try
            {
                StringBuilder newPostFormat = new StringBuilder();

                newPostFormat.AppendLine(string.Format("Post Type: {0}", i_PostToConfigure.Type.ToString()));
                newPostFormat.AppendLine(string.Format("Post Description: {0}\n", i_PostToConfigure.Description));
                newPostFormat.AppendLine(string.Format("Date Created: {0}", i_PostToConfigure.CreatedTime.ToString()));
                newPostFormat.Append(string.Format("Comments: {0}", i_PostToConfigure.Comments.Count));

                return newPostFormat.ToString();
            }
            catch(Exception exception)
            {
                throw new Exception("Failed to access post data");
            }
        }
    }
}
