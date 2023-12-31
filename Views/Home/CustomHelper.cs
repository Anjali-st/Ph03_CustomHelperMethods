﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace Phase3Section2_.Views.Home
{
    public class CustomHelper
    {
        public static IHtmlString File(string id)
        {
            TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("type", "file");
            tb.Attributes.Add("id", id);
            return new MvcHtmlString(tb.ToString());

        }
    }
}