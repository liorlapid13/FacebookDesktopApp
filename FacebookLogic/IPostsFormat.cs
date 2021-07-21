using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic
{
    public interface IPostsFormat
    {
        List<string> GeneratePostsFormat();
    }
}
