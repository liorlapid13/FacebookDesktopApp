using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public interface IPostConfigurationStrategy
    {
        string GeneratePostConfiguration(Post i_PostToConfigure);
    }
}
