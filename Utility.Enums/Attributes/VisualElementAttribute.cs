using System.Linq;
using Utility.Enums.VisualElements;

namespace Utility.Enums.Attributes
{


    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class VisualElementAttribute : Attribute
    {
        public string Description { get; }
        public UIElementCategory Category { get; }
        public UISubCategory SubCategory { get; }
        public HTML HTMLMapping { get; set; }
        public ReactNative ReactNativeMapping { get; set; }
        public XAML XAMLMapping { get; set; }
        public Flutter FlutterMapping { get; set; }
        public Qt QtMapping { get; set; }
        public Swing SwingMapping { get; set; }
        public JavaFX JavaFXMapping { get; set; }
        public GTK GTKMapping { get; set; }
        public Markup MarkupMapping { get; set; }

        public VisualElementAttribute(
            string description,
            UIElementCategory category,
            UISubCategory subCategory,
            HTML htmlMapping,
            ReactNative reactNativeMapping,
            XAML xamlMapping,
            Flutter flutterMapping,
            Qt qtMapping,
            Swing swingMapping,
            JavaFX javaFXMapping,
            GTK gtkMapping,
            Markup markupMapping)
        {
            Description = description;
            Category = category;
            SubCategory = subCategory;
            HTMLMapping = htmlMapping;
            ReactNativeMapping = reactNativeMapping;
            XAMLMapping = xamlMapping;
            FlutterMapping = flutterMapping;
            QtMapping = qtMapping;
            SwingMapping = swingMapping;
            JavaFXMapping = javaFXMapping;
            GTKMapping = gtkMapping;
            MarkupMapping = markupMapping;
        }
    }

    public enum UIElementCategory
    {
        Structural,
        Input,
        Output,
        Media,
        Collection,
        Interactive,
        Status,
        Numeric,
        Navigation,
        Display,
        Dialogs,
        Advanced,
        MicroInteraction,
        DataPresentation,
        Action
    }

    public enum UISubCategory
    {
        Container,
        Text,
        Selection,
        Action,
        Media,
        Collection,
        Status,
        Numeric
    }






    // ==================== FRAMEWORK-SPECIFIC ENUMS ====================
    // (same as previous code)

    public static class UIElementExtensions
    {
        public static TAttribute? Attribute<TAttribute, TEnum>(this TEnum e)
        {
            var enumType = typeof(TEnum);

            var enumValueMemberInfo = enumType.GetMember(e.ToString())
                .FirstOrDefault(m => m.DeclaringType == enumType) ?? throw new Exception("SDF£Ff222fvvr");

            return enumValueMemberInfo
                             .GetCustomAttributes(typeof(TAttribute), false)
                             .OfType<TAttribute>()
                             .FirstOrDefault();
        }

        public static T? Map<T>(this Visual element)
        {
            var attribute = Attribute<VisualElementAttribute, Visual>(element);
            if (attribute == null)
                return default;
            return (T)map(typeof(T), attribute);
        }

        public static T? Map<T>(this VisualLayout element)
        {
            var attribute = Attribute<VisualElementAttribute, VisualLayout>(element);
            if (attribute == null)
                return default;
            return (T)map(typeof(T), attribute);      
        }

        static object map(Type type, VisualElementAttribute attribute)
        {
            switch (type)
            {
                case Type t when t == typeof(HTML):
                    return attribute.HTMLMapping;
                case Type t when t == typeof(ReactNative):
                    return attribute.ReactNativeMapping;
                case Type t when t == typeof(XAML):
                    return (object)attribute.XAMLMapping;
                case Type t when t == typeof(Flutter):
                    return (object)attribute.FlutterMapping;
                case Type t when t == typeof(Qt):
                    return (object)attribute.QtMapping;
                case Type t when t == typeof(Swing):
                    return (object)attribute.SwingMapping;
                case Type t when t == typeof(JavaFX):
                    return (object)attribute.JavaFXMapping;
                case Type t when t == typeof(GTK):
                    return (object)attribute.GTKMapping;
                case Type t when t == typeof(Markup):
                    return (object)attribute.MarkupMapping;
                default:
                    throw new NotSupportedException($"Mapping for type {type.Name} is not supported.");
            }
        }
    }
}
