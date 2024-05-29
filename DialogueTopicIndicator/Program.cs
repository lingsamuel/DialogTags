using System.Text.Json;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.Skyrim;

namespace DialogueTopicIndicator {
    public class Config {
        public bool UsePostfix = false;

        public Dictionary<string, string> RenameMap = new Dictionary<string, string>() {
            { "Skyrim.esm", "" },
            { "Update.esm", "" },
            { "Dawnguard.esm", "" },
            { "Hearthfires.esm", "" },
            { "Dragonborn.esm", "" },
            { "ccBGSSSE001-Fish.esm", "ccFish" },
            { "ccbgssse025-AdvDSGS.esm", "ccAdvDSGS" },
            { "ccafdsse001-dwesanctuary.esm", "ccDweSanctuary" },
            { "ccasvsse001-almsivi.esm", "ccAlmsivi" },
            { "ccbgssse031-advcyrus.esm", "ccAdvCyrus" },
            { "cceejsse001-hstead.esm", "ccHomestead" },
            { "cceejsse005-cave.esm", "ccCave" },

            { "nwsFollowerFramework.esp", "" },
            { "Unofficial Skyrim Special Edition Patch.esp", "USSEP" },
            { "Unofficial Skyrim Modders Patch", "USMP" },
            { "Alternate Start - Live Another Life.esp", "Alt Start" },

            { "LegacyoftheDragonborn.esm", "LotD" },
            { "summersetisles.esp", "Summerset Isles" },
            { "arnima.esm", "Beyond Reach" },
            { "BSHeartland.esm", "Bruma" },
            { "Dwarfsphere.esp", "AHO" },
            { "moonpath.esp", "Moonpath" },
            { "TheBawbsShire.esp", "Shire" },
            { "ForgottenCity.esp", "Forgotten City" },
            { "CollegeOfWinterholdImmersive.esp", "CoW" },
            { "WindhelmSSE.esp", "Capital Windhelm" },
            { "MoonAndStar_MAS.esp", "Moon and Star" },

            { "ACatsLife.esp", "Cats Life" },
            { "ADogsLife.esp", "Dogs Life" },
            { "SofiaFollower.esp", "Sofia" },
            { "BPUFXelzazFollower.esp", "Xelzaz" },
            { "HLIORemi.esp", "Remi" },
            { "018Auri.esp", "Auri" },
            { "Khash The Argonian.esp", "Khash" },
            { "0Kaidan.esp", "Kaidan" },
            { "BWB - Kaidan 2 Extra Dialogue.esp", "Kaidan Ex" },
            { "ImprovedCompanionsBoogaloo.esp", "exLydia" },
            { "SeranaDialogAddon.esp", "exSerana" },
            { "LKS_CR.esp", "Ciri" },

            { "ElysiumEstate.esp", "Elysium Estate" },
            { "ETaC - Complete.esp", "ETaC" },
            { "BluePalaceTerrace.esp", "BPT" },
            { "Palaces Castles Enhanced.esp", "PCE" },

            // { "SummersetFixes", "" },
            // { "ESOimports", "" },
            // { "YourMarketStall", "" },
            // { "ksws03_quest", "" },
            // { "PaarthurnaxQuestExpansion", "" },
            // { "College Of Winterhold - Quest Expansion", "" },
            // { "The Whispering Door - Quest Expansion", "" },
            // { "TheOnlyCureQuestExpansion", "" },
            // { "Innocence Lost - Quest Expansion", "" },
            // { "Caught Red Handed - Quest Expansion", "" },
            // { "HouseOfHorrorsQuestExpansion", "" },
            // { "Missives", "" },
            // { "Missives - Solstheim", "" },
            // { "Missives - Beyond Reach", "" },
            // { "Missives - Heartland", "" },
            // { "Missives - Gray Cowl Patch", "" },
            // { "Missives - Midwood Isle", "" },
            // { "Missives - Wyrmstooth", "" },
            // { "ezPG", "" },
            // { "ezPG - Emberveil", "" },
            // { "ezPG - Update", "" },
            // { "Finding_Helgi_and_Laelette", "" },
            // { "BenDoonSSE", "" },
            // { "Lucien-AnniversaryEdition-Patch", "" },
            // { "FDE Mjoll", "" },
            // { "FDE Mjoll - Auri", "" },
            // { "DialogueExpansion - Brelyna", "" },
            // { "FDE Brelyna Lucien", "" },
            // { "FDE Aela", "" },
            // { "guardencounters", "" },
            // { "moretodo", "" },
            // { "moretosaycityguards", "" },
            // { "moretosayfalkreath", "" },
            // { "moretosaygeneric", "" },
            // { "moretosaykarthwasten", "" },
            // { "moretosayriften", "" },
            // { "moretosayriverwood", "" },
            // { "moretosayrorikstead", "" },
            // { "moretosayshorsstone", "" },
            // { "moretosaywhiterun", "" },
            // { "moretosaywinterhold", "" },
            // { "priestsgrantblessings", "" },
            // { "secretofrorikstead", "" },
            // { "sisselbookquest", "" },
            // { "LydiaPatchForBSCyrodiil", "" },
            // { "LydiaPatchForWyrmstooth", "" },
            // { "DBM_ForgottenCity_Patch", "" },
            // { "DBM_Clockwork_Patch", "" },
            // { "DBM_Moonpath_Patch", "" },
            // { "DBM_TheGrayCowlofNocturnal_Patch", "" },
            // { "DBM_WheelsofLull_Patch", "" },
            // { "DBM_Wyrmstooth_Patch", "" },
            // { "DBM_RelicNotifications", "" },
            // { "DBM_RelicHunter", "" },
            // { "NPCs React To Necromancy", "" },
            // { "SkyrimsGotTalent-Bards", "" },
            // { "BecomeABard", "" },
            // { "BardsRebornStudentofSong", "" },
            // { "Wintersun - Faiths of Skyrim", "" },
            // { "DBM_HelgenReborn_Patch", "" },
            // { "SDA House of Horrors Expansion Patch", "" },
            // { "Convenient Carriages", "" },
            // { "CACO Farm Overhaul", "" },
            // { "Resources - The Great Cities", "" },
            // { "The Great City of Winterhold v4", "" },
            // { "The Great City of Solitude", "" },
            // { "The Great Town of Shor\u0027s Stone", "" },
            // { "The Great Village of Kynesgrove", "" },
            // { "Cracked Tusk Stronghold", "" },
            // { "RiftenExtension", "" },
            // { "RiverwoodBandits", "" },
            // { "ImperialMail", "" },
            // { "ShireLALPatch", "" },
            // { "BUVARP SE RE", "" },
            // { "BUVARP SE RE - Chronicles of the College", "" },
            // { "CC_Ferry_Patch", "" },
            // { "Environs - Abandoned Abodes", "" },
            // { "Environs - Hroggars House", "" },
            // { "Environs - Riften Warehouse", "" },
            // { "ccPuzzled", "" },
            // { "ccZombies", "" },
            // { "BSAssets", "" },
            // { "ETaC - RESOURCES", "" },
            // { "MorePainfulNPCDeathSounds", "" },
            // { "Sleeping Expanded", "" },
            // { "Immersive Rejections", "" },
            // { "Vigilant Voiced", "" },
            // { "ClockworkInterestingInhabitants", "" },
            // { "Stendarr Rising", "" },
            // { "HothFollower", "" },
            // { "018InigoBanterPatch", "" },
            // { "mtsfollowerbanter", "" },
            // { "LydiaPatchForLOTD", "" },
            // { "LKS_CR - NFF", "" },
            // { "ImTalkinHere", "" },
            // { "Bandit Lines Expansion", "" },
            // { "NPCs_Wear_Amulets_Of_Mara", "" },
            // { "Civil War Lines Expansion", "" },
            // { "CarriageAndStableDialogues", "" },
            // { "Forsworn and Thalmor Lines Expansion", "" },
            // { "Vampire Lines Expansion", "" },
            // { "The Great Town of Ivarstead", "" },
            // { "The Great Town of Karthwasten", "" },
            // { "The Great Village of Mixwater Mill", "" },
            // { "The Great Village of Old Hroldan", "" },
            // { "Populated Lands Roads Paths", "" },
            // { "Environs - Greenwood Shack", "" },
            // { "Environs - Kolskeggr", "" },
            // { "Environs - Tundra Farmhouse", "" },
        };
    }

    public class Program {
        protected static Lazy<Config> Config = null!;

        public static async Task<int> Main(string[] args) {
            Console.WriteLine(args);
            return await SynthesisPipeline.Instance
                .AddPatch<ISkyrimMod, ISkyrimModGetter>(RunPatch, new PatcherPreferences() {
                })
                .SetAutogeneratedSettings("settings", "settings.json", out Config)
                .SetTypicalOpen(GameRelease.SkyrimSE, "DialogTags.esp")
                .Run(args);
        }

        public static Dictionary<string, string> Unamed = new Dictionary<string, string>();

        public static void RunPatch(IPatcherState<ISkyrimMod, ISkyrimModGetter> state) {
            foreach (var key in Config.Value.RenameMap.Keys.ToList()) {
                Config.Value.RenameMap[key.ToLower()] = Config.Value.RenameMap[key];
            }

            var counter = 0;

            var dialogTopics = state.LoadOrder.ListedOrder.DialogTopic().WinningOverrides().ToList();
            foreach (var dialogTopic in dialogTopics) {
                if (counter % 1000 == 0) {
                    Console.WriteLine($"Summary: Processed {counter}/{dialogTopics.Count} records");
                }

                counter++;

                var name = dialogTopic.FormKey.ModKey.ToString();
                var key = name.ToLower();
                if (Config.Value.RenameMap.ContainsKey(key)) {
                    name = Config.Value.RenameMap[key];
                    if (name == "") {
                        continue;
                    }
                } else {
                    if (name.EndsWith(".esm") || name.EndsWith(".esp") || name.EndsWith(".esl")) {
                        name = name.Remove(name.Length - 4);
                    }

                    Config.Value.RenameMap[key] = name;
                }

                if (dialogTopic.Name != null && dialogTopic.Name.String != null && dialogTopic.Name.String != "") {
                    Unamed[name] = "";
                    var patchedRecord = state.PatchMod.DialogTopics.GetOrAddAsOverride(dialogTopic);
                    if (Config.Value.UsePostfix) {
                        patchedRecord.Name += $" [{name}]";
                    } else {
                        patchedRecord.Name = $"[{name}] " + patchedRecord.Name;
                    }
                }
            }

            counter = 0;
            var dialogResponses = state.LoadOrder.ListedOrder.DialogResponses().WinningContextOverrides(state.LinkCache).ToList();
            foreach (var dialogResponse in dialogResponses) {
                if (counter % 1000 == 0) {
                    Console.WriteLine($"Summary: Processed {counter}/{dialogResponses.Count} records");
                }

                counter++;

                var name = dialogResponse.Record.FormKey.ModKey.ToString();
                var key = name.ToLower();
                if (Config.Value.RenameMap.ContainsKey(key)) {
                    name = Config.Value.RenameMap[key];
                    if (name == "") {
                        continue;
                    }
                } else {
                    if (name.EndsWith(".esm") || name.EndsWith(".esp") || name.EndsWith(".esl")) {
                        name = name.Remove(name.Length - 4);
                    }

                    Config.Value.RenameMap[key] = name;
                }

                var created = false;
                IDialogResponses patchedRecord = null!;
                for (int i = 0; i < dialogResponse.Record.Responses.Count; i++) {
                    if (!string.IsNullOrEmpty(dialogResponse.Record.Responses[i].Text.String)) {
                        if (!created) {
                            patchedRecord = dialogResponse.GetOrAddAsOverride(state.PatchMod);
                            created = true;
                        }

                        Unamed[name] = "";
                        if (Config.Value.UsePostfix) {
                            patchedRecord.Responses[i].Text += $" [{name}]";
                        } else {
                            patchedRecord.Responses[i].Text = $"[{name}] " + patchedRecord.Responses[i].Text;
                        }
                    }
                }
            }

            foreach (var key in Config.Value.RenameMap.Keys) {
                Unamed.Remove(key);
            }

            foreach (var key in Config.Value.RenameMap.Values) {
                Unamed.Remove(key);
            }

            state.PatchMod.ModHeader.Flags |= SkyrimModHeader.HeaderFlag.Light;

            Console.WriteLine("=================================");
            Console.WriteLine("Unamed mods:");
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(Unamed, new JsonSerializerOptions() {
                WriteIndented = true,
            }));
            Console.WriteLine("=================================");
        }
    }
}