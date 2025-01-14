﻿namespace Survivalistic
{
    public class Config
    {
        // MULTIPLIERS
        public float thirst_multiplier { get; set; } = 0.5f;
        public float hunger_multiplier { get; set; } = 1f;

        // BARS PIVOT
        public string bars_position { get; set; } = "bottom-right";

        // CUSTOM BARS AXIS (use "custom" in the pivot to use this)
        public int bars_custom_x { get; set; } = 0;
        public int bars_custom_y { get; set; } = 0;
    }
}
