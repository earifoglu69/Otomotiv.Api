namespace Otomotiv.Api.Common.Settings
{
    public class OtomotivWebSetting
    {
        public ConnectionStrings ConnectionStrings { get; set; }
        public TurkuazClientSetting TurkuazClientSetting { get; set; }
    }
    public class ConnectionStrings
    {
        public string OtomotivConnection { get; set; }
        public string TimeOut { get; set; }
    }
    public class TurkuazClientSetting
    {
        public string BaseAddress { get; set; }
        public int TimeOut { get; set; }
    }
}
