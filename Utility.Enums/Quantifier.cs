namespace Utility.Enums
{
    // Selector/quanitifier
    public enum Quantifier
    {
        [Description("Every-one")]
        All,

        [Description("At least one (could be all)")]
        Any,

        [Description("Exactly one element")]
        One,

        [Description("Zero elements")]
        None,

        [Description("The first element in a sequence")]
        First,

        [Description("The last element in a sequence")]
        Last,

        [Description("More than one and less than all")]
        Some,

        [Description("More than one less than half")]
        Few,

        [Description("More than a few")]
        Many,

        //[Description("Every individual item, considered separately")]
        //Each,

        //[Description("All items, considered collectively")]
        //Every,

        [Description("More than half, but not all")]
        Most,

        [Description("2, 3, or 4")]
        Several,
    }

    public enum NSelector
    {
        [Description("A fixed number of elements (e.g., 'exactly 3')")]
        Exactly,

        [Description("No more than N items")]
        AtMost,

        [Description("N or more items")]
        AtLeast,

        [Description("The specific numbered item in a list (e.g., 3rd, 5th)")]
        At
    }

    public enum OptionSelector
    {
        [Description("One of two options")]
        Either,

        [Description("Zero of two options")]
        Neither,

        [Description("Each of the two options")]
        Both,
    }
}
