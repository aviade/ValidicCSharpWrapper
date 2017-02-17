namespace ValidicCSharp.Utility
{
    using ValidicCSharp.Interfaces;
    using ValidicCSharp.Request;

    public class ExpandedFilter: ValueFilter
    {
        public ExpandedFilter()
        {
            Type = FilterType.Expanded;
            Label = "expanded";
        }
    }
}