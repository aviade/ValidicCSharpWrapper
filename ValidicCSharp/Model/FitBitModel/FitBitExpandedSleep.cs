namespace ValidicCSharp.Model
{
    using System;
    using Newtonsoft.Json;

    public class FitBitExpandedSleep : Sleep
    {
        [JsonProperty("is_main_sleep")]
        public bool? is_main_sleep { get; set; }

        [JsonProperty("start_time")]
       public DateTimeOffset? Sleep_Start_time { get; set; }

        [JsonProperty("minutes_to_fall_asleep")]
        public Double? minutes_to_fall_asleep { get; set; }

        [JsonProperty("minutes_after_wakeup")]
        public Double? minutes_after_wakeup { get; set; }

        [JsonProperty("efficiency")]
        public Double? efficiency { get; set; }
    }
}
