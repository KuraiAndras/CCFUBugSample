namespace CCFUBugSample
{
    public sealed class SampleService
    {
        public string TestSwitch(int value) =>
            value switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                _ => "A lot",
            };
    }
}
