namespace ValidicCSharp.Model
{
    using System;
    using Newtonsoft.Json;

    public class FitbitExpandedSleep : Sleep
    {
        [JsonProperty("is_main_sleep")]
        public bool? IsMainSleep { get; set; }

        [JsonProperty("start_time")]
       public DateTimeOffset? SleepStarttime { get; set; }

        [JsonProperty("minutes_to_fall_asleep")]
        public Double? MinutesToFallAsleep { get; set; }

        [JsonProperty("minutes_after_wakeup")]
        public Double? MinutesAfterWakeup { get; set; }

        [JsonProperty("efficiency")]
        public Double? Efficiency { get; set; }
    }
}
