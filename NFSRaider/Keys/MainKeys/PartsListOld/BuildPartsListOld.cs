using NFSRaider.Keys.MainKeys.PartsLists;
using NFSRaider.Keys.MainKeys.Cars;
using System.Collections.Generic;

namespace NFSRaider.Keys.MainKeys.PartsListOld
{
    public class BuildPartsListOld
    {
        private static readonly string Part = "PART";
        private static readonly string Wheel = "WHEEL";
        private static readonly string Roof = "ROOF";
        private static readonly string Spoiler = "SPOILER";
        private static readonly string SpoilerAS = "AUTOSCULPTSPOILER";
        private static readonly string Exhaust = "EXHAUST";
        private static readonly string Mirror = "MIRROR";
        private static readonly string Windshield = "WINDSHIELD_TINT";
        private static readonly string Headlight = "HEADLIGHT_TINT";
        private static readonly string Neon = "NEON";
        private static readonly string Decal = "DECAL";

        public HashSet<string> GetAllParts()
        {
            var parts = new HashSet<string>(
                GenericParts.List);

            foreach (var lod in Lods.List)
            {
                foreach (var manufacturer in Manufacturers.List)
                {
                    parts.Add(manufacturer);
                    foreach (var style in Styles.List)
                    {
                        foreach (var wheel in Wheels.List)
                        {
                            parts.Add(manufacturer + style + wheel + lod);
                            parts.Add(manufacturer + style + wheel + "_SPIN" + lod);
                        }
                        parts.Add(manufacturer + style);
                        parts.Add(manufacturer + style + "_WHEEL");
                        parts.Add(manufacturer + style + "_WHEEL_INNER_MASK");
                    }

                    if (lod == "")
                    {
                        for (int i = 0; i < 50; i++)
                        {
                            parts.Add(Part + "_" + Wheel + "_" + manufacturer + "_" + i);
                        }

                        foreach (var decal in Decals.List)
                        {
                            parts.Add(manufacturer + decal);
                            parts.Add(manufacturer + decal + "_" + Decal);
                        }
                    }
                }

                foreach (var cf in CarbonFiber.List)
                {
                    foreach (var roof in Roofs.List)
                    {
                        foreach (var style in Styles.List)
                        {
                            parts.Add(Roof + style + roof + cf + lod);
                        }
                    }

                    foreach (var spoiler in Spoilers.List)
                    {
                        foreach (var style in Styles.List)
                        {
                            parts.Add(Spoiler + style + spoiler + cf + lod);
                            parts.Add(Spoiler + style + spoiler + "_AUTOSCULPT" + cf + lod);
                            parts.Add(SpoilerAS + style + spoiler + cf + lod);
                        }
                    }

                    foreach (var mirror in Mirrors.List)
                    {
                        foreach (var style in Styles.List)
                        {
                            parts.Add(style.Substring(1) + "_" + Mirror + mirror + cf + lod);
                        }
                    }
                }

                foreach (var exhaust in Exhausts.List)
                {
                    foreach (var style in Styles.List)
                    {
                        foreach (var level in Exhausts.Levels)
                        {
                            parts.Add(Exhaust + style + exhaust + level + lod);
                        }
                    }
                }

                foreach (var item in Items.List)
                {
                    parts.Add(item + lod);
                }

            }

            foreach (var color in Colors.List)
            {
                parts.Add(color);
                foreach (var level in Colors.Levels)
                {
                    parts.Add(Windshield + level + "_" + color);
                    parts.Add(Windshield + level + "_PEARL" + " " + color);
                    parts.Add(Windshield + level + "_PEARL" + "_" + color);
                    parts.Add(Headlight + level + "_" + color);

                    foreach (var type in Colors.Types)
                    {
                        foreach (var prefix in Colors.Prefix)
                        {
                            parts.Add(type + level + prefix);
                            parts.Add(type + prefix);
                        }

                        for (int i = 0; i <= 30; i++)
                        {
                            parts.Add(type + i + "_PAINT");
                            parts.Add(type + i.ToString("D2") + "_PAINT");
                        }

                        parts.Add(type);
                    }
                }
                parts.Add(Neon + "_" + color);
                parts.Add(Neon + "_" + color + "_PULSE");
            }

            return parts;
        }
    }
}
