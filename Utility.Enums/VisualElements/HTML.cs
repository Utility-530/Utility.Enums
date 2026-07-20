using System.Linq;
using System.Reflection;

namespace Utility.Enums.VisualElements
{
    public class HtmlAttribute : Attribute
    {
        public HtmlAttribute(string element) 
        { 
            this.Element = element; 
        }

        public string Element { get; set; }
    }

    public enum HTML
    {
        div, span, p, h1, h2, h3, h4, h5, h6, ul, ol, li, table, tr, td, th,

        [HtmlAttribute("input[type='text']")]
        inputtext,

        [HtmlAttribute("input[type='password']")]
        inputpassword,

        [HtmlAttribute("input[type='checkbox']")]
        checkbox,

        [HtmlAttribute("input[type='radio']")]
        radio,

        textarea,

        button, select,
        img, audio, video, canvas, svg, label, progress, section, article,
        aside, figure, figcaption, details, summary, footer, header, nav,
        hr,
    }

    public static class HtmlEnumExtensions
    {
        public static string GetSelector(this HTML html)
        {
            var member = typeof(HTML)
                .GetMember(html.ToString())
                .FirstOrDefault();

            if (member == null)
                return html.ToString();

            var attr = member
                .GetCustomAttribute<HtmlAttribute>();

            // If there's an attribute, return it
            if (attr != null)
                return attr.Element;

            // Otherwise return lowercase HTML tag name
            return html.ToString();
        }
    }
}
