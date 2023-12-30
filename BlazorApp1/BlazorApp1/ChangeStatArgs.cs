namespace BlazorApp1 
{
    public class ChangeStatArgs : EventArgs
    {
        public string? StatName { get; set; }
        public string? StatValue { get; set; }
    }
}