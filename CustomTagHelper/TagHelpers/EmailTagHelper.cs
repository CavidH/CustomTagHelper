using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper.TagHelpers
{
    public class EmailTagHelper:TagHelper
    {
        public string Mail { get; set; }
        public string Display { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.Add("href",$"mailto:{Mail}");
            output.Content.Append(Display);

           // base.Process(context, output);
        }
    }

    //public class SecondCustomTagHelper : TagHelper
    //{

    //}
}
