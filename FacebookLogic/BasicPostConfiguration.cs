using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class BasicPostConfiguration : IPostConfigurationStrategy
    {
        public string GeneratePostConfiguration(Post i_PostToConfigure)
        {
            try
            {
                return i_PostToConfigure.Description;
            }
            catch(Exception exception)
            {
                throw new Exception("Failed to access post data");
            }
        }
    }
}
