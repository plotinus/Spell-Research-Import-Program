using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Spell_Research_Import_Program
{
    public partial class SpellResearchImport : Form
    {
        readonly string[] ArchetypeNames = { "Casting - Concentration",
                                    "Casting - Fire and Forget",
                                    "Element - Acid",
                                    "Element - Air",
                                    "Element - Apparitions",
                                    "Element - Arcane Energy",
                                    "Element - Armor",
                                    "Element - Magical Constructs",
                                    "Element - Creatures",
                                    "Element - Daedra",
                                    "Element - Disease",
                                    "Element - Earth",
                                    "Element - Fire",
                                    "Element - Flesh",
                                    "Element - Magical Force",
                                    "Element - Frost",
                                    "Element - Health",
                                    "Element - Mortals",
                                    "Element - Life",
                                    "Element - Light",
                                    "Element - Magicka",
                                    "Element - Metal",
                                    "Element - Nature",
                                    "Element - Poison",
                                    "Element - Resistance",
                                    "Element - Shadows",
                                    "Element - Shields",
                                    "Element - Shock",
                                    "Element - Souls",
                                    "Element - Stamina",
                                    "Element - The Sun",
                                    "Element - Time",
                                    "Element - Magical Traps",
                                    "Element - Undead",
                                    "Element - Water",
                                    "Element - Weapons",
                                    "Skill - Alteration",
                                    "Skill - Conjuration",
                                    "Skill - Destruction",
                                    "Skill - Illusion",
                                    "Skill - Restoration",
                                    "Targeting - Aimed",
                                    "Targeting - Area of Effect",
                                    "Targeting - Location",
                                    "Targeting - Self",
                                    "Technique - Cloaking",
                                    "Technique - Controlling",
                                    "Technique - Courage",
                                    "Technique - Curing",
                                    "Technique - Cursing",
                                    "Technique - Fear",
                                    "Technique - Frenzy",
                                    "Technique - Infusing",
                                    "Technique - Pacifying",
                                    "Technique - Sensing",
                                    "Technique - Siphoning",
                                    "Technique - Strengthening",
                                    "Technique - Summoning",
                                    "Technique - Telekinesis",
                                    "Technique - Transforming"};
        readonly string[] PluginExtension = { ".esp", ".esm", ".esl" };

        readonly string[] SpellArchetypes = {"000D67", //Concentration Casting
                                             "000D68", //Fire and Forget
                                             "000D7C", //Acid
                                             "000D7D", //Air
                                             "000D7E", //Apparition
                                             "000D7F", //Arcane
                                             "000D80", //Armor
                                             "000D81", //Construct
                                             "000D82", //Creature
                                             "000D83", //Daedra
                                             "000D84", //Disease
                                             "000D85", //Earth
                                             "000D86", //Fire
                                             "000D87", //Flesh
                                             "000D88", //Force
                                             "000D89", //Frost
                                             "000D8A", //Health
                                             "000D8A", //Human
                                             "000D8C", //Life
                                             "000D8D", //Light
                                             "000D8E", //Magicka
                                             "000D8F", //Metal
                                             "000D90", //Nature
                                             "000D91", //Poison
                                             "000D92", //Resistance
                                             "000D93", //Shadow
                                             "000D94", //Shield
                                             "000D95", //Shock
                                             "000D96", //Soul
                                             "000D97", //Stamina
                                             "000D98", //Sun
                                             "000D99", //Time
                                             "000D9A", //Trap
                                             "000D9B", //Undead
                                             "000D9C", //Water
                                             "000D9D", //Weapon
                                             "000D62", //Alteration
                                             "000D63", //Conjuration
                                             "000D64", //Destruction
                                             "000D65", //Illusion
                                             "000D66", //Restoration
                                             "000D69", //Target Actor
                                             "000D6A", //Target AOE
                                             "000D6B", //Target Location
                                             "000D6C", //Target Self
                                             "000D6D", //Cloak
                                             "000D6E", //Control
                                             "000D6F", //Courage
                                             "000D70", //Curing
                                             "000D71", //Curse
                                             "000D72", //Fear
                                             "000D73", //Frenzy
                                             "000D74", //Infuse
                                             "000D75", //Pacify
                                             "000D76", //Sense
                                             "000D77", //Siphon
                                             "000D78", //Strengthen
                                             "000D79", //Stengthen
                                             "000D7A", //Telekinesis
                                             "000D7B"}; //Transform
        readonly string[] ArtifactArchetypes = {"00BB2A", //Concentration
                                                "00BB2B", //Fire Forget
                                                "00BB2C", //Acid
                                                "00BB2D", //Air
                                                "00BB2E", //Apparition
                                                "00BB2F", //Arcane
                                                "00BB30", //Armor
                                                "00BB31", //Construct
                                                "00BB32", //Creature
                                                "00BB33", //Daedra
                                                "00BB34", //Disease
                                                "00BB35", //Earth
                                                "00BB36", //Fire
                                                "00BB37", //Flesh
                                                "00BB38", //Force
                                                "00BB39", //Frost
                                                "00BB3A", //Health
                                                "00BB3B", //Human
                                                "00BB3C", //Life
                                                "00BB3D", //Light
                                                "00BB3E", //Magicka
                                                "00BB3F", //Metal
                                                "00BB40", //Nature
                                                "00BB41", //Poison
                                                "00BB42", //Resistance
                                                "00BB43", //Shadow
                                                "00BB44", //Shield
                                                "00BB45", //Shock
                                                "00BB46", //Soul
                                                "00BB47", //Stamina
                                                "00BB48", //Sun
                                                "00BB49", //Time
                                                "00BB4A", //Trap
                                                "00BB4B", //Undead
                                                "00BB4C", //Water
                                                "00BB4D", //Weapon
                                                "00BB4E", //Alteration
                                                "00BB4F", //Conjuration
                                                "00BB50", //Destruction
                                                "00BB51", //Illusion
                                                "00BB52", //Restoration
                                                "00BB53", //Target Actor
                                                "00BB54", //Target AOE
                                                "00BB55", //Target Location
                                                "00BB56", //Target Self
                                                "00BB57", //Cloak
                                                "00BB58", //Control
                                                "00BB59", //Courage
                                                "00BB5A", //Curing
                                                "00BB5B", //Curse
                                                "00BB5C", //Fear
                                                "00BB5D", //Frenzy
                                                "00BB5E", //Infuse
                                                "00BB5F", //Pacify
                                                "00BB60", //Sense
                                                "00BB61", //Siphon
                                                "00BB62", //Stengthen
                                                "00BB63", //Summoning
                                                "00BB64", //Telekinesis
                                                "00BB65"}; //Transform
        readonly string[] EffectArchetypes = { "041BF8", //Concentration
                                                "041BF9", //Fire and Forget
                                                "041BFA", //Acid
                                                "041C32", //Air
                                                "041BFB", //Apparition
                                                "041BFC", //Arcane
                                                "041BFD", //Armor
                                                "041BFE", //Construct
                                                "041BFF", //Creature
                                                "041C00", //Daedra
                                                "041C01", //Disease
                                                "041C02", //Earth
                                                "041C03", //Fire
                                                "041C04", //Flesh
                                                "041C05", //Force
                                                "041C06", //Frost
                                                "041C07", //Health
                                                "041C08", //Human
                                                "041C09", //Life
                                                "041C0A", //Light
                                                "041C0B", //Magicka
                                                "041C0C", //Metal
                                                "041C0D", //Nature
                                                "041C0E", //Poison
                                                "041C0F", //Resistance
                                                "041C10", //Shadow
                                                "041C11", //Shield
                                                "041C12", //Shock
                                                "041C13", //Soul
                                                "041C14", //Stamina
                                                "041C15", //Sun
                                                "041C16", //Time
                                                "041C17", //Trap
                                                "041C18", //Undead
                                                "041C19", //Water
                                                "041C1A", //Weapon
                                                "041C1B", //Alteration
                                                "041C1C", //Conjuration
                                                "041C1D", //Destruction
                                                "041C1E", //Illusion
                                                "041C1F", //Restoration
                                                "041C20", //Target Actor
                                                "041C21", //Target AOE
                                                "041C22", //Target Location
                                                "041C23", //Target Self
                                                "041C24", //Cloak
                                                "041C25", //Control
                                                "041C26", //Courage
                                                "041C27", //Curing
                                                "041C28", //Curse
                                                "041C29", //Fear
                                                "041C2A", //Frenzy
                                                "041C2B", //Infuse
                                                "041C2C", //Pacify
                                                "041C2D", //Sense
                                                "041C2E", //Siphon
                                                "041C2F", //Strengthen
                                                "041C30", //Summoning
                                                "041C31", //Telekinesis
                                                "041BF7"}; //Transform

        readonly string[] SpellArchetypeNames = {"_SR_ListSpellsCastingConcentration",
                                                 "_SR_ListSpellsCastingFireForget",
                                                 "_SR_ListSpellsElementAcid",
                                                 "_SR_ListSpellsElementAir",
                                                 "_SR_ListSpellsElementApparition",
                                                 "_SR_ListSpellsElementArcane",
                                                 "_SR_ListSpellsElementArmor",
                                                 "_SR_ListSpellsElementConstruct",
                                                 "_SR_ListSpellsElementCreature",
                                                 "_SR_ListSpellsElementDaedra",
                                                 "_SR_ListSpellsElementDisease",
                                                 "_SR_ListSpellsElementEarth",
                                                 "_SR_ListSpellsElementFire",
                                                 "_SR_ListSpellsElementFlesh",
                                                 "_SR_ListSpellsElementForce",
                                                 "_SR_ListSpellsElementFrost",
                                                 "_SR_ListSpellsElementHealth",
                                                 "_SR_ListSpellsElementHuman",
                                                 "_SR_ListSpellsElementLife",
                                                 "_SR_ListSpellsElementLight",
                                                 "_SR_ListSpellsElementMagicka",
                                                 "_SR_ListSpellsElementMetal",
                                                 "_SR_ListSpellsElementNature",
                                                 "_SR_ListSpellsElementPoison",
                                                 "_SR_ListSpellsElementResistance",
                                                 "_SR_ListSpellsElementShadow",
                                                 "_SR_ListSpellsElementShield",
                                                 "_SR_ListSpellsElementShock",
                                                 "_SR_ListSpellsElementSoul",
                                                 "_SR_ListSpellsElementStamina",
                                                 "_SR_ListSpellsElementSun",
                                                 "_SR_ListSpellsElementTime",
                                                 "_SR_ListSpellsElementTrap",
                                                 "_SR_ListSpellsElementUndead",
                                                 "_SR_ListSpellsElementWater",
                                                 "_SR_ListSpellsElementWeapon",
                                                 "_SR_ListSpellsSkillAlteration",
                                                 "_SR_ListSpellsSkillConjuration",
                                                 "_SR_ListSpellsSkillDestruction",
                                                 "_SR_ListSpellsSkillIllusion",
                                                 "_SR_ListSpellsSkillRestoration",
                                                 "_SR_ListSpellsTargetActor",
                                                 "_SR_ListSpellsTargetAOE",
                                                 "_SR_ListSpellsTargetLocation",
                                                 "_SR_ListSpellsTargetSelf",
                                                 "_SR_ListSpellsTechniqueCloak",
                                                 "_SR_ListSpellsTechniqueControl",
                                                 "_SR_ListSpellsTechniqueCourage",
                                                 "_SR_ListSpellsTechniqueCuring",
                                                 "_SR_ListSpellsTechniqueCurse",
                                                 "_SR_ListSpellsTechniqueFear",
                                                 "_SR_ListSpellsTechniqueFrenzy",
                                                 "_SR_ListSpellsTechniqueInfuse",
                                                 "_SR_ListSpellsTechniquePacify",
                                                 "_SR_ListSpellsTechniqueSense",
                                                 "_SR_ListSpellsTechniqueSiphon",
                                                 "_SR_ListSpellsTechniqueStrengthen",
                                                 "_SR_ListSpellsTechniqueSummoning",
                                                 "_SR_ListSpellsTechniqueTelekinesis",
                                                 "_SR_ListSpellsTechniqueTransform"};
        readonly string[] ArtifactArchetypeNames = {"_SR_ListArtifactsBaseCastingConcentration",
                                                    "_SR_ListArtifactsBaseCastingFireForget",
                                                    "_SR_ListArtifactsBaseElementAcid",
                                                    "_SR_ListArtifactsBaseElementAir",
                                                    "_SR_ListArtifactsBaseElementApparition",
                                                    "_SR_ListArtifactsBaseElementArcane",
                                                    "_SR_ListArtifactsBaseElementArmor",
                                                    "_SR_ListArtifactsBaseElementConstruct",
                                                    "_SR_ListArtifactsBaseElementCreature",
                                                    "_SR_ListArtifactsBaseElementDaedra",
                                                    "_SR_ListArtifactsBaseElementDisease",
                                                    "_SR_ListArtifactsBaseElementEarth",
                                                    "_SR_ListArtifactsBaseElementFire",
                                                    "_SR_ListArtifactsBaseElementFlesh",
                                                    "_SR_ListArtifactsBaseElementForce",
                                                    "_SR_ListArtifactsBaseElementFrost",
                                                    "_SR_ListArtifactsBaseElementHealth",
                                                    "_SR_ListArtifactsBaseElementHuman",
                                                    "_SR_ListArtifactsBaseElementLife",
                                                    "_SR_ListArtifactsBaseElementLight",
                                                    "_SR_ListArtifactsBaseElementMagicka",
                                                    "_SR_ListArtifactsBaseElementMetal",
                                                    "_SR_ListArtifactsBaseElementNature",
                                                    "_SR_ListArtifactsBaseElementPoison",
                                                    "_SR_ListArtifactsBaseElementResistance",
                                                    "_SR_ListArtifactsBaseElementShadow",
                                                    "_SR_ListArtifactsBaseElementShield",
                                                    "_SR_ListArtifactsBaseElementShock",
                                                    "_SR_ListArtifactsBaseElementSoul",
                                                    "_SR_ListArtifactsBaseElementStamina",
                                                    "_SR_ListArtifactsBaseElementSun",
                                                    "_SR_ListArtifactsBaseElementTime",
                                                    "_SR_ListArtifactsBaseElementTrap",
                                                    "_SR_ListArtifactsBaseElementUndead",
                                                    "_SR_ListArtifactsBaseElementWater",
                                                    "_SR_ListArtifactsBaseElementWeapon",
                                                    "_SR_ListArtifactsBaseSkillAlteration",
                                                    "_SR_ListArtifactsBaseSkillConjuration",
                                                    "_SR_ListArtifactsBaseSkillDestruction",
                                                    "_SR_ListArtifactsBaseSkillIllusion",
                                                    "_SR_ListArtifactsBaseSkillRestoration",
                                                    "_SR_ListArtifactsBaseTargetActor",
                                                    "_SR_ListArtifactsBaseTargetAOE",
                                                    "_SR_ListArtifactsBaseTargetLocation",
                                                    "_SR_ListArtifactsBaseTargetSelf",
                                                    "_SR_ListArtifactsBaseTechniqueCloak",
                                                    "_SR_ListArtifactsBaseTechniqueControl",
                                                    "_SR_ListArtifactsBaseTechniqueCourage",
                                                    "_SR_ListArtifactsBaseTechniqueCuring",
                                                    "_SR_ListArtifactsBaseTechniqueCurse",
                                                    "_SR_ListArtifactsBaseTechniqueFear",
                                                    "_SR_ListArtifactsBaseTechniqueFrenzy",
                                                    "_SR_ListArtifactsBaseTechniqueInfuse",
                                                    "_SR_ListArtifactsBaseTechniquePacify",
                                                    "_SR_ListArtifactsBaseTechniqueSense",
                                                    "_SR_ListArtifactsBaseTechniqueSiphon",
                                                    "_SR_ListArtifactsBaseTechniqueStrengthen",
                                                    "_SR_ListArtifactsBaseTechniqueSummoning",
                                                    "_SR_ListArtifactsBaseTechniqueTelekinesis",
                                                    "_SR_ListArtifactsBaseTechniqueTransform"};
        readonly string[] EffectArchetypeNames = {"_SR_ListAlchEffectsCastingConcentration",
                                                   "_SR_ListAlchEffectsCastingFireForget",
                                                   "_SR_ListAlchEffectsElementAcid",
                                                   "_SR_ListAlchEffectsElementAir",
                                                   "_SR_ListAlchEffectsElementApparition",
                                                   "_SR_ListAlchEffectsElementArcane",
                                                   "_SR_ListAlchEffectsElementArmor",
                                                   "_SR_ListAlchEffectsElementConstruct",
                                                   "_SR_ListAlchEffectsElementCreature",
                                                   "_SR_ListAlchEffectsElementDaedra",
                                                   "_SR_ListAlchEffectsElementDisease",
                                                   "_SR_ListAlchEffectsElementEarth",
                                                   "_SR_ListAlchEffectsElementFire",
                                                   "_SR_ListAlchEffectsElementFlesh",
                                                   "_SR_ListAlchEffectsElementForce",
                                                   "_SR_ListAlchEffectsElementFrost",
                                                   "_SR_ListAlchEffectsElementHealth",
                                                   "_SR_ListAlchEffectsElementHuman",
                                                   "_SR_ListAlchEffectsElementLife",
                                                   "_SR_ListAlchEffectsElementLight",
                                                   "_SR_ListAlchEffectsElementMagicka",
                                                   "_SR_ListAlchEffectsElementMetal",
                                                   "_SR_ListAlchEffectsElementNature",
                                                   "_SR_ListAlchEffectsElementPoison",
                                                   "_SR_ListAlchEffectsElementResistance",
                                                   "_SR_ListAlchEffectsElementShadow",
                                                   "_SR_ListAlchEffectsElementShield",
                                                   "_SR_ListAlchEffectsElementShock",
                                                   "_SR_ListAlchEffectsElementSoul",
                                                   "_SR_ListAlchEffectsElementStamina",
                                                   "_SR_ListAlchEffectsElementSun",
                                                   "_SR_ListAlchEffectsElementTime",
                                                   "_SR_ListAlchEffectsElementTrap",
                                                   "_SR_ListAlchEffectsElementUndead",
                                                   "_SR_ListAlchEffectsElementWater",
                                                   "_SR_ListAlchEffectsElementWeapon",
                                                   "_SR_ListAlchEffectsSkillAlteration",
                                                   "_SR_ListAlchEffectsSkillConjuration",
                                                   "_SR_ListAlchEffectsSkillDestruction",
                                                   "_SR_ListAlchEffectsSkillIllusion",
                                                   "_SR_ListAlchEffectsSkillRestoration",
                                                   "_SR_ListAlchEffectsTargetActor",
                                                   "_SR_ListAlchEffectsTargetAOE",
                                                   "_SR_ListAlchEffectsTargetLocation",
                                                   "_SR_ListAlchEffectsTargetSelf",
                                                   "_SR_ListAlchEffectsTechniqueCloak",
                                                   "_SR_ListAlchEffectsTechniqueControl",
                                                   "_SR_ListAlchEffectsTechniqueCourage",
                                                   "_SR_ListAlchEffectsTechniqueCuring",
                                                   "_SR_ListAlchEffectsTechniqueCurse",
                                                   "_SR_ListAlchEffectsTechniqueFear",
                                                   "_SR_ListAlchEffectsTechniqueFrenzy",
                                                   "_SR_ListAlchEffectsTechniqueInfuse",
                                                   "_SR_ListAlchEffectsTechniquePacify",
                                                   "_SR_ListAlchEffectsTechniqueSense",
                                                   "_SR_ListAlchEffectsTechniqueSiphon",
                                                   "_SR_ListAlchEffectsTechniqueStrengthen",
                                                   "_SR_ListAlchEffectsTechniqueSummoning",
                                                   "_SR_ListAlchEffectsTechniqueTelekinesis",
                                                   "_SR_ListAlchEffectsTechniqueTransform"};

        readonly string[] SpellRanks = {"00133E",
                                        "00133F",
                                        "001340",
                                        "001341",
                                        "001342",
                                        "001342"};
        readonly string[] BookRanks = {"001344",
                                       "001345",
                                       "001346",
                                       "001347",
                                       "001348",
                                       "001348"};
        readonly string[] BookSpellRanks = {"00134A",
                                            "00134B",
                                            "00134C",
                                            "00134D",
                                            "00134E",
                                            "00134E"};
        readonly string[] ScrollRanks = {"001350",
                                         "001351",
                                         "001352",
                                         "001353",
                                         "001354",
                                         "001354"};
        readonly string[] ScrollSpellRanks = {"0051F8",
                                              "0051F9",
                                              "0051FA",
                                              "0051FB",
                                              "0051FC",
                                              "0051FC"};
        readonly string[] ArtifactRanks = {"00BB23",
                                           "00BB24",
                                           "00BB25",
                                           "00BB26",
                                           "00BB27",
                                           "00BB28"};

        readonly string[] SpellRankNames = {"_SR_ListAllSpells1Novice",
                                            "_SR_ListAllSpells2Apprentice",
                                            "_SR_ListAllSpells3Adept",
                                            "_SR_ListAllSpells4Expert",
                                            "_SR_ListAllSpells5Master",
                                            "_SR_ListAllSpells5Master"};
        readonly string[] BookRankNames = {"_SR_ListTomes1Novice",
                                           "_SR_ListTomes2Apprentice",
                                           "_SR_ListTomes3Adept",
                                           "_SR_ListTomes4Expert",
                                           "_SR_ListTomes5Master",
                                           "_SR_ListTomes5Master"};
        readonly string[] BookSpellRankNames = {"_SR_ListTomeSpells1Novice",
                                                "_SR_ListTomeSpells2Apprentice",
                                                "_SR_ListTomeSpells3Adept",
                                                "_SR_ListTomeSpells4Expert",
                                                "_SR_ListTomeSpells5Master",
                                                "_SR_ListTomeSpells5Master"};
        readonly string[] ScrollRankNames = {"_SR_ListScrolls1Novice",
                                             "_SR_ListScrolls2Apprentice",
                                             "_SR_ListScrolls3Adept",
                                             "_SR_ListScrolls4Expert",
                                             "_SR_ListScrolls5Master",
                                             "_SR_ListScrolls5Master"};
        readonly string[] ScrollSpellRankNames = {"_SR_ListScrollSpells1Novice",
                                                  "_SR_ListScrollSpells2Apprentice",
                                                  "_SR_ListScrollSpells3Adept",
                                                  "_SR_ListScrollSpells4Expert",
                                                  "_SR_ListScrollSpells5Master",
                                                  "_SR_ListScrollSpells5Master"};
        readonly string[] ArtifactRankNames = {"_SR_ListArtifactsAllBase0",
                                               "_SR_ListArtifactsAllBase1",
                                               "_SR_ListArtifactsAllBase2",
                                               "_SR_ListArtifactsAllBase3",
                                               "_SR_ListArtifactsAllBase4",
                                               "_SR_ListArtifactsAllBase5"};

        readonly string BreakableArtifacts = "04A035";
        readonly string BreakableArtifactName = "_SR_ListBreakableArtifacts";
        readonly string UndiscoverableSpells = "05ADF0";
        readonly string UndiscoverableSpellName = "_SR_ListUndiscoverableSpells";
        readonly string EquippableItems = "03BAA3";
        readonly string EquippableItemName = "_SR_ListEquippableAll";
        readonly string EquippableArtifacts = "03C570";
        readonly string EquippableArtifactName = "_SR_ListEquippableArtifacts";

        Dictionary<string, string> DictionaryNames = new Dictionary<string, string>();
        Dictionary<string, int> DictionaryTypes = new Dictionary<string, int>();
        Dictionary<string, int> DictionaryRanks = new Dictionary<string, int>();
        Dictionary<string, string> DictionaryBookFormIDs = new Dictionary<string, string>();
        Dictionary<string, string> DictionaryScrollFormIDs = new Dictionary<string, string>();
        Dictionary<string, List<int>> DictionaryArchetypes = new Dictionary<string, List<int>>();

        public SpellResearchImport()
        {
            InitializeComponent();

            lbArchetypesAvailable.Items.AddRange(ArchetypeNames);
            cbPluginExtension.SelectedIndex = 0;
            cbItemType.SelectedIndex = 0;
            cbRank.SelectedIndex = 0;
        }

        public void UpdateForms()
        {
            lbForms.Items.Clear();
            foreach(KeyValuePair<string,string> FormName in DictionaryNames)
            {
                lbForms.Items.Add(FormName.Key + ":" + FormName.Value);
            }
        }

        public void UpdateArchetypes(string FormID)
        {
            lbArchetypesAssigned.Items.Clear();
            lbArchetypesAvailable.Items.Clear();
            if (DictionaryArchetypes.ContainsKey(FormID))
            {
                List<int> Archetypes = DictionaryArchetypes[FormID];
                for(int i = 0; i < ArchetypeNames.Length; i++)
                {
                    if (Archetypes.Contains(i))
                    {
                        lbArchetypesAssigned.Items.Add(ArchetypeNames[i]);
                    }
                    else
                    {
                        lbArchetypesAvailable.Items.Add(ArchetypeNames[i]);
                    }
                }
            }
        }

        public List<int> GetArchetypes()
        {
            List<int> Archetypes = new List<int>();
            foreach(Object Arc in lbArchetypesAssigned.Items)
            {
                bool Found = false;
                string Archetype = Arc.ToString();
                for(int i = 0; i < ArchetypeNames.Length && !Found; i++)
                {
                    if(ArchetypeNames[i] == Archetype)
                    {
                        Archetypes.Add(i);
                        Found = true;
                    }
                }
            }
            Archetypes.Sort();
            return Archetypes;
        }

        public bool CheckFormID(string ID)
        {
            if(ID.Length < 6)
            {
                return false;
            }
            for(int i = ID.Length - 1; i >= ID.Length - 6; i--)
            {
                if (!(ID[i] >= '0' && ID[i] <= '9') && !(ID[i] >= 'a' && ID[i] <= 'f') && !(ID[i] >= 'A' && ID[i] <= 'F'))
                {
                    return false;
                }
            }
            return true;
        }

        public string GetFormID(string ID)
        {
            if (ID.Length < 6 || !CheckFormID(ID))
                return "";
            else
                return ID.Substring(ID.Length - 6, 6);
        }

        public void ClearScreen()
        {
            tbFormID.Text = "";
            tbFormName.Text = "";
            tbFormScroll.Text = "";
            tbFormTome.Text = "";
            lbArchetypesAssigned.Items.Clear();
            lbArchetypesAvailable.Items.Clear();
            foreach(string Arc in ArchetypeNames)
            {
                lbArchetypesAvailable.Items.Add(Arc);
            }
        }

        private void LbArchetypesAvailable_DoubleClick(object sender, EventArgs e)
        {
            if(lbArchetypesAvailable.SelectedIndex >= 0)
            {
                string ArchetypeName = lbArchetypesAvailable.SelectedItem.ToString();
                lbArchetypesAvailable.Items.Remove(ArchetypeName);
                lbArchetypesAssigned.Items.Add(ArchetypeName);
            }
        }

        private void LbArchetypesAssigned_DoubleClick(object sender, EventArgs e)
        {
            if (lbArchetypesAssigned.SelectedIndex >= 0)
            {
                string ArchetypeName = lbArchetypesAssigned.SelectedItem.ToString();
                lbArchetypesAssigned.Items.Remove(ArchetypeName);
                lbArchetypesAvailable.Items.Add(ArchetypeName);
            }
        }

        private void MsItemSave_Click(object sender, EventArgs e)
        {
            if (tbFormID.Text == "")
            {
                MessageBox.Show(this, "No Form ID Given!", "", MessageBoxButtons.OK);
            }
            else if (!CheckFormID(tbFormID.Text))
            {
                MessageBox.Show(this, "Form ID Not Hexadecimal!", "", MessageBoxButtons.OK);
            }
            else if(tbFormName.Text == "")
            {
                MessageBox.Show(this, "No Name Given!", "", MessageBoxButtons.OK);
            }
            else if(lbArchetypesAssigned.Items.Count == 0)
            {
                MessageBox.Show(this, "No Archetypes Assigned!", "", MessageBoxButtons.OK);
            }
            else
            {
                string FormID = GetFormID(tbFormID.Text);
                if (DictionaryNames.ContainsKey(FormID))
                    DictionaryNames[FormID] = tbFormName.Text;
                else
                    DictionaryNames.Add(FormID, tbFormName.Text);

                if (DictionaryTypes.ContainsKey(FormID))
                    DictionaryTypes[FormID] = cbItemType.SelectedIndex;
                else
                    DictionaryTypes.Add(FormID, cbItemType.SelectedIndex);

                if (DictionaryRanks.ContainsKey(FormID))
                    DictionaryRanks[FormID] = cbRank.SelectedIndex;
                else
                    DictionaryRanks.Add(FormID, cbRank.SelectedIndex);

                string TomeID = GetFormID(tbFormTome.Text);
                if(TomeID != "")
                {
                    if (DictionaryBookFormIDs.ContainsKey(FormID))
                        DictionaryBookFormIDs[FormID] = TomeID;
                    else
                        DictionaryBookFormIDs.Add(FormID, TomeID);
                }

                string ScrollID = GetFormID(tbFormScroll.Text);
                if(ScrollID != "")
                {
                    if (DictionaryScrollFormIDs.ContainsKey(FormID))
                        DictionaryScrollFormIDs[FormID] = ScrollID;
                    else
                        DictionaryScrollFormIDs.Add(FormID, ScrollID);
                }

                if (DictionaryArchetypes.ContainsKey(FormID))
                    DictionaryArchetypes[FormID] = GetArchetypes();
                else
                    DictionaryArchetypes.Add(FormID, GetArchetypes());

                ClearScreen();
                UpdateForms();
            }
        }

        private void MsItemEdit_Click(object sender, EventArgs e)
        {
            if(lbForms.SelectedIndex >= 0)
            {
                string FormID = lbForms.SelectedItem.ToString().Substring(0, 6);
                if (DictionaryNames.ContainsKey(FormID))
                {
                    ClearScreen();
                    tbFormID.Text = FormID;
                    tbFormName.Text = DictionaryNames[FormID];
                    cbItemType.SelectedIndex = DictionaryTypes[FormID];
                    cbRank.SelectedIndex = DictionaryRanks[FormID];
                    UpdateArchetypes(FormID);

                    if (DictionaryBookFormIDs.ContainsKey(FormID))
                    {
                        tbFormTome.Text = DictionaryBookFormIDs[FormID];
                    }

                    if (DictionaryScrollFormIDs.ContainsKey(FormID))
                    {
                        tbFormScroll.Text = DictionaryScrollFormIDs[FormID];
                    }
                }
            }
        }

        private void MsItemDelete_Click(object sender, EventArgs e)
        {
            if (lbForms.SelectedIndex >= 0)
            {
                string FormID = lbForms.SelectedItem.ToString().Substring(0, 6);
                if (DictionaryNames.ContainsKey(FormID))
                {
                    DictionaryNames.Remove(FormID);
                    DictionaryArchetypes.Remove(FormID);
                    DictionaryRanks.Remove(FormID);
                    DictionaryTypes.Remove(FormID);

                    if (DictionaryBookFormIDs.ContainsKey(FormID))
                    {
                        DictionaryBookFormIDs.Remove(FormID);
                    }

                    if (DictionaryScrollFormIDs.ContainsKey(FormID))
                    {
                        DictionaryScrollFormIDs.Remove(FormID);
                    }

                    UpdateForms();
                }
            }
        }

        private void MsItemClear_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void LbForms_DoubleClick(object sender, EventArgs e)
        {
            if (lbForms.SelectedIndex >= 0)
            {
                string FormID = lbForms.SelectedItem.ToString().Substring(0, 6);
                if (DictionaryNames.ContainsKey(FormID))
                {
                    ClearScreen();
                    tbFormID.Text = FormID;
                    tbFormName.Text = DictionaryNames[FormID];
                    cbItemType.SelectedIndex = DictionaryTypes[FormID];
                    cbRank.SelectedIndex = DictionaryRanks[FormID];
                    UpdateArchetypes(FormID);

                    if (DictionaryBookFormIDs.ContainsKey(FormID))
                    {
                        tbFormTome.Text = DictionaryBookFormIDs[FormID];
                    }

                    if (DictionaryScrollFormIDs.ContainsKey(FormID))
                    {
                        tbFormScroll.Text = DictionaryScrollFormIDs[FormID];
                    }
                }
            }
        }

        private void MsFileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void MsFileSave_Click(object sender, EventArgs e)
        {
            if(tbPluginName.Text == "")
            {
                MessageBox.Show(this, "No Plugin Name Given!", "", MessageBoxButtons.OK);
            }
            else
            {
                saveFileDialog1.ShowDialog();
            }
        }

        private void MsFileExport_Click(object sender, EventArgs e)
        {
            if (tbPluginName.Text == "")
            {
                MessageBox.Show(this, "No Plugin Name Given!", "", MessageBoxButtons.OK);
            }
            else
            {
                exportFileDialog1.ShowDialog();
            }
        }

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            DictionaryNames.Clear();
            DictionaryTypes.Clear();
            DictionaryRanks.Clear();
            DictionaryBookFormIDs.Clear();
            DictionaryScrollFormIDs.Clear();
            DictionaryArchetypes.Clear();

            string line;
            string[] parsedLine;
            string[] arcString;
            using (StreamReader file = new StreamReader(openFileDialog1.FileName))
            {
                line = file.ReadLine();
                parsedLine = line.Split(',');
                tbPluginName.Text = parsedLine[0];
                cbPluginExtension.SelectedIndex = Convert.ToInt32(parsedLine[1]);
                while ((line = file.ReadLine()) != null)
                {
                    parsedLine = line.Split(',');
                    string FormID = parsedLine[0];
                    DictionaryNames.Add(FormID, parsedLine[1]);
                    DictionaryTypes.Add(FormID, Convert.ToInt32(parsedLine[2]));
                    DictionaryRanks.Add(FormID, Convert.ToInt32(parsedLine[3]));
                    if (parsedLine[4] != "")
                    {
                        DictionaryBookFormIDs.Add(FormID, parsedLine[4]);
                    }
                    if (parsedLine[5] != "")
                    {
                        DictionaryScrollFormIDs.Add(FormID, parsedLine[5]);
                    }
                    if (parsedLine[6] != "")
                    {
                        arcString = parsedLine[6].Split(';');
                        List<int> Archetypes = new List<int>();
                        foreach(string arch in arcString)
                        {
                            if(arch != "")
                            {
                                Archetypes.Add(Convert.ToInt32(arch));
                            }
                        }
                        DictionaryArchetypes.Add(FormID, Archetypes);
                    }
                }
            }
            UpdateForms();
        }

        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            using (StreamWriter file = new StreamWriter(saveFileDialog1.FileName))
            {
                file.WriteLine(tbPluginName.Text + "," + cbPluginExtension.SelectedIndex);
                foreach(KeyValuePair<string,string> Item in DictionaryNames)
                {
                    string FormID = Item.Key;
                    StringBuilder ItemString = new StringBuilder();
                    ItemString.Append(FormID + "," + Item.Value);

                    if (DictionaryTypes.ContainsKey(FormID))
                    {
                        ItemString.Append("," + DictionaryTypes[FormID]);
                    }
                    else
                    {
                        ItemString.Append(",0");
                    }

                    if (DictionaryRanks.ContainsKey(FormID))
                    {
                        ItemString.Append("," + DictionaryRanks[FormID]);
                    }
                    else
                    {
                        ItemString.Append(",0");
                    }

                    if (DictionaryBookFormIDs.ContainsKey(FormID))
                    {
                        ItemString.Append("," + DictionaryBookFormIDs[FormID]);
                    }
                    else
                    {
                        ItemString.Append(",");
                    }

                    if (DictionaryScrollFormIDs.ContainsKey(FormID))
                    {
                        ItemString.Append("," + DictionaryScrollFormIDs[FormID]);
                    }
                    else
                    {
                        ItemString.Append(",");
                    }

                    if (DictionaryArchetypes.ContainsKey(FormID))
                    {
                        List<int> Archetypes = DictionaryArchetypes[FormID];
                        ItemString.Append(",");
                        foreach (int Archetype in Archetypes)
                        {
                            ItemString.Append(Archetype + ";");
                        }
                    }
                    else
                    {
                        ItemString.Append(",");
                    }

                    file.WriteLine(ItemString.ToString());
                }
            }
        }

        private void ExportFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            bool SpellsImported = false;
            bool UndiscoverableSpellsImported = false;
            bool IngredientsImported = false;
            bool ArtifactsImported = false;
            bool BreakableArtifactsImported = false;

            bool[] SpellArchetypesUsed = new bool[60];
            bool[] ArtifactArchetypesUsed = new bool[60];
            bool[] EffectArchetypesUsed = new bool[60];
            foreach(KeyValuePair<string, List<int>> ArchetypesPair in DictionaryArchetypes)
            {
                foreach(int Archetype in ArchetypesPair.Value)
                {
                    if (DictionaryTypes.ContainsKey(ArchetypesPair.Key))
                    {
                        switch (DictionaryTypes[ArchetypesPair.Key])
                        {
                            case 0: //Spell
                                SpellsImported = true;
                                SpellArchetypesUsed[Archetype] = true;
                                break;
                            case 1: //Undiscoverable Spell
                                SpellsImported = true;
                                UndiscoverableSpellsImported = true;
                                SpellArchetypesUsed[Archetype] = true;
                                break;
                            case 2: //Ingredient
                                IngredientsImported = true;
                                ArtifactArchetypesUsed[Archetype] = true;
                                break;
                            case 3: //Unique Artifact
                                ArtifactsImported = true;
                                ArtifactArchetypesUsed[Archetype] = true;
                                break;
                            case 4: //Breakable Artifact
                                BreakableArtifactsImported = true;
                                ArtifactArchetypesUsed[Archetype] = true;
                                break;
                            case 5: //Mundane Artifact
                                BreakableArtifactsImported = true;
                                ArtifactArchetypesUsed[Archetype] = true;
                                break;
                            case 6: //Effect
                                EffectArchetypesUsed[Archetype] = true;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(exportFileDialog1.FileName))
            {
                file.WriteLine("Message Property _AskMessage Auto");
                if (SpellsImported)
                {
                    for(int i = 0; i < 5; i++)
                    {
                        file.WriteLine("FormList Property " + SpellRankNames[i] + " Auto");
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        file.WriteLine("FormList Property " + BookRankNames[i] + " Auto");
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        file.WriteLine("FormList Property " + BookSpellRankNames[i] + " Auto");
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        file.WriteLine("FormList Property " + ScrollRankNames[i] + " Auto");
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        file.WriteLine("FormList Property " + ScrollSpellRankNames[i] + " Auto");
                    }
                }
                if (UndiscoverableSpellsImported)
                {
                    file.WriteLine("FormList Property " + UndiscoverableSpellName + " Auto");
                }
                if (IngredientsImported || ArtifactsImported || BreakableArtifactsImported)
                {
                    foreach (string FormList in ArtifactRankNames)
                    {
                        file.WriteLine("FormList Property " + FormList + " Auto");
                    }
                }
                if(ArtifactsImported || BreakableArtifactsImported)
                {
                    file.WriteLine("FormList Property " + EquippableItemName + " Auto");
                    file.WriteLine("FormList Property " + EquippableArtifactName + " Auto");
                }
                if (BreakableArtifactsImported)
                {
                    file.WriteLine("FormList Property " + BreakableArtifactName + " Auto");
                }

                for(int i = 0; i < SpellArchetypesUsed.Length; i++)
                {
                    if (SpellArchetypesUsed[i])
                    {
                        file.WriteLine("FormList Property " + SpellArchetypeNames[i] + " Auto");
                    }
                }
                for (int i = 0; i < ArtifactArchetypesUsed.Length; i++)
                {
                    if (ArtifactArchetypesUsed[i])
                    {
                        file.WriteLine("FormList Property " + ArtifactArchetypeNames[i] + " Auto");
                    }
                }
                for (int i = 0; i < EffectArchetypesUsed.Length; i++)
                {
                    if (EffectArchetypesUsed[i])
                    {
                        file.WriteLine("FormList Property " + EffectArchetypeNames[i] + " Auto");
                    }
                }

                file.WriteLine("\n\nEvent OnUpdate()");
                file.WriteLine("\tif(Game.GetModByName(\"SpellResearch.esp\") != 255 && Game.GetModByName(\"" + tbPluginName.Text + PluginExtension[cbPluginExtension.SelectedIndex] + "\") != 255 && _AskMessage.Show() == 0)");

                file.WriteLine("\t\tSpell TempSpell");
                file.WriteLine("\t\tBook TempTome");
                file.WriteLine("\t\tScroll TempScroll");
                file.WriteLine("\t\tIngredient TempIngredient");
                file.WriteLine("\t\tForm TempArtifact");
                file.WriteLine("\t\tMagicEffect TempEffect");

                if (SpellsImported)
                {
                    for(int i = 0; i < 5; i++)
                    {
                        file.WriteLine("\t\t" + SpellRankNames[i] + " = Game.GetFormFromFile(0x" + SpellRanks[i] + ", \"SpellResearch.esp\") as FormList");
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        file.WriteLine("\t\t" + BookRankNames[i] + " = Game.GetFormFromFile(0x" + BookRanks[i] + ", \"SpellResearch.esp\") as FormList");
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        file.WriteLine("\t\t" + BookSpellRankNames[i] + " = Game.GetFormFromFile(0x" + BookSpellRanks[i] + ", \"SpellResearch.esp\") as FormList");
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        file.WriteLine("\t\t" + ScrollRankNames[i] + " = Game.GetFormFromFile(0x" + ScrollRanks[i] + ", \"SpellResearch.esp\") as FormList");
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        file.WriteLine("\t\t" + ScrollSpellRankNames[i] + " = Game.GetFormFromFile(0x" + ScrollSpellRanks[i] + ", \"SpellResearch.esp\") as FormList");
                    }
                }
                if (UndiscoverableSpellsImported)
                {
                    file.WriteLine("\t\t" + UndiscoverableSpellName + " = Game.GetFormFromFile(0x" + UndiscoverableSpells + ", \"SpellResearch.esp\") as FormList");
                }
                if (IngredientsImported || ArtifactsImported || BreakableArtifactsImported)
                {
                    for (int i = 0; i < ArtifactRankNames.Length; i++)
                    {
                        file.WriteLine("\t\t" + ArtifactRankNames[i] + " = Game.GetFormFromFile(0x" + ArtifactRanks[i] + ", \"SpellResearch.esp\") as FormList");
                    }
                }
                if(ArtifactsImported || BreakableArtifactsImported)
                {
                    file.WriteLine("\t\t" + EquippableItemName + " = Game.GetFormFromFile(0x" + EquippableItems + ", \"SpellResearch.esp\") as FormList");
                    file.WriteLine("\t\t" + EquippableArtifactName + " = Game.GetFormFromFile(0x" + EquippableArtifacts + ", \"SpellResearch.esp\") as FormList");
                }
                if (BreakableArtifactsImported)
                {
                    file.WriteLine("\t\t" + BreakableArtifactName + " = Game.GetFormFromFile(0x" + BreakableArtifacts + ", \"SpellResearch.esp\") as FormList");
                }
                for (int i = 0; i < SpellArchetypesUsed.Length; i++)
                {
                    if (SpellArchetypesUsed[i])
                    {
                        file.WriteLine("\t\t" + SpellArchetypeNames[i] + " = Game.GetFormFromFile(0x" + SpellArchetypes[i] + ", \"SpellResearch.esp\") as FormList");
                    }
                }
                for (int i = 0; i < ArtifactArchetypesUsed.Length; i++)
                {
                    if (ArtifactArchetypesUsed[i])
                    {
                        file.WriteLine("\t\t" + ArtifactArchetypeNames[i] + " = Game.GetFormFromFile(0x" + ArtifactArchetypes[i] + ", \"SpellResearch.esp\") as FormList");
                    }
                }
                for (int i = 0; i < EffectArchetypesUsed.Length; i++)
                {
                    if (EffectArchetypesUsed[i])
                    {
                        file.WriteLine("\t\t" + EffectArchetypeNames[i] + " = Game.GetFormFromFile(0x" + EffectArchetypes[i] + ", \"SpellResearch.esp\") as FormList");
                    }
                }
                file.WriteLine("\n");

                int ItemCount = 0;

                file.WriteLine("\t\tDebug.Notification(\"Importing " + DictionaryNames.Count + " Forms from " + tbPluginName.Text + "\")");
                foreach(KeyValuePair<string, string> Item in DictionaryNames)
                {
                    file.WriteLine(";" + Item.Value + ";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;");
                    switch (DictionaryTypes[Item.Key])
                    {
                        case 0: //Spell
                            file.WriteLine("\t\tTempSpell = Game.GetFormFromFile(0x" + Item.Key + ", \"" + tbPluginName.Text + PluginExtension[cbPluginExtension.SelectedIndex] + "\") as Spell");
                            file.WriteLine("\t\tif(TempSpell)");
                            file.WriteLine("\t\t\t" + SpellRankNames[DictionaryRanks[Item.Key]] + ".AddForm(TempSpell)");
                            foreach(int i in DictionaryArchetypes[Item.Key])
                            {
                                file.WriteLine("\t\t\t" + SpellArchetypeNames[i] + ".AddForm(TempSpell)");
                            }
                            if (DictionaryBookFormIDs.ContainsKey(Item.Key))
                            {
                                file.WriteLine("\t\t\tTempTome = Game.GetFormFromFile(0x" + DictionaryBookFormIDs[Item.Key] + ", \"" + tbPluginName.Text + PluginExtension[cbPluginExtension.SelectedIndex] + "\") as Book");
                                file.WriteLine("\t\t\tif(TempTome && !" + BookRankNames[DictionaryRanks[Item.Key]] + ".HasForm(TempTome) && !" + BookSpellRankNames[DictionaryRanks[Item.Key]] + ".HasForm(TempSpell))");
                                file.WriteLine("\t\t\t\t" + BookRankNames[DictionaryRanks[Item.Key]] + ".AddForm(TempTome)");
                                file.WriteLine("\t\t\t\t" + BookSpellRankNames[DictionaryRanks[Item.Key]] + ".AddForm(TempSpell)");
                                file.WriteLine("\t\t\tendIf");
                            }
                            if (DictionaryScrollFormIDs.ContainsKey(Item.Key))
                            {
                                file.WriteLine("\t\t\tTempScroll = Game.GetFormFromFile(0x" + DictionaryScrollFormIDs[Item.Key] + ", \"" + tbPluginName.Text + PluginExtension[cbPluginExtension.SelectedIndex] + "\") as Scroll");
                                file.WriteLine("\t\t\tif(TempScroll && !" + ScrollRankNames[DictionaryRanks[Item.Key]] + ".HasForm(TempScroll) && !" + ScrollSpellRankNames[DictionaryRanks[Item.Key]] + ".HasForm(TempSpell))");
                                file.WriteLine("\t\t\t\t" + ScrollRankNames[DictionaryRanks[Item.Key]] + ".AddForm(TempScroll)");
                                file.WriteLine("\t\t\t\t" + ScrollSpellRankNames[DictionaryRanks[Item.Key]] + ".AddForm(TempSpell)");
                                file.WriteLine("\t\t\tendIf");
                            }
                            file.WriteLine("\t\tendIf");
                            break;
                        case 1: //Undiscoverable Spell
                            file.WriteLine("\t\tTempSpell = Game.GetFormFromFile(0x" + Item.Key + ", \"" + tbPluginName.Text + PluginExtension[cbPluginExtension.SelectedIndex] + "\") as Spell");
                            file.WriteLine("\t\tif(TempSpell)");
                            file.WriteLine("\t\t\t" + UndiscoverableSpellName + ".AddForm(TempSpell)");
                            file.WriteLine("\t\t\t" + SpellRankNames[DictionaryRanks[Item.Key]] + ".AddForm(TempSpell)");
                            foreach (int i in DictionaryArchetypes[Item.Key])
                            {
                                file.WriteLine("\t\t\t" + SpellArchetypeNames[i] + ".AddForm(TempSpell)");
                            }
                            if (DictionaryBookFormIDs.ContainsKey(Item.Key))
                            {
                                file.WriteLine("\t\t\tTempTome = Game.GetFormFromFile(0x" + DictionaryBookFormIDs[Item.Key] + ", \"" + tbPluginName.Text + PluginExtension[cbPluginExtension.SelectedIndex] + "\") as Book");
                                file.WriteLine("\t\t\tif(TempTome && !" + BookRankNames[DictionaryRanks[Item.Key]] + ".HasForm(TempTome) && !" + BookSpellRankNames[DictionaryRanks[Item.Key]] + ".HasForm(TempSpell))");
                                file.WriteLine("\t\t\t\t" + BookRankNames[DictionaryRanks[Item.Key]] + ".AddForm(TempTome)");
                                file.WriteLine("\t\t\t\t" + BookSpellRankNames[DictionaryRanks[Item.Key]] + ".AddForm(TempSpell)");
                                file.WriteLine("\t\t\tendIf");
                            }
                            if (DictionaryScrollFormIDs.ContainsKey(Item.Key))
                            {
                                file.WriteLine("\t\t\tTempScroll = Game.GetFormFromFile(0x" + DictionaryScrollFormIDs[Item.Key] + ", \"" + tbPluginName.Text + PluginExtension[cbPluginExtension.SelectedIndex] + "\") as Scroll");
                                file.WriteLine("\t\t\tif(TempScroll && !" + ScrollRankNames[DictionaryRanks[Item.Key]] + ".HasForm(TempScroll) && !" + ScrollSpellRankNames[DictionaryRanks[Item.Key]] + ".HasForm(TempSpell))");
                                file.WriteLine("\t\t\t\t" + ScrollRankNames[DictionaryRanks[Item.Key]] + ".AddForm(TempScroll)");
                                file.WriteLine("\t\t\t\t" + ScrollSpellRankNames[DictionaryRanks[Item.Key]] + ".AddForm(TempSpell)");
                                file.WriteLine("\t\t\tendIf");
                            }
                            file.WriteLine("\t\tendIf");
                            break;
                        case 2: //Ingredient
                            file.WriteLine("\t\tTempIngredient = Game.GetFormFromFile(0x" + Item.Key + ", \"" + tbPluginName.Text + PluginExtension[cbPluginExtension.SelectedIndex] + "\") as Ingredient");
                            file.WriteLine("\t\tif(TempIngredient)");
                            file.WriteLine("\t\t\t" + ArtifactRankNames[DictionaryRanks[Item.Key]] + ".AddForm(TempIngredient)");
                            foreach (int i in DictionaryArchetypes[Item.Key])
                            {
                                file.WriteLine("\t\t\t" + ArtifactArchetypeNames[i] + ".AddForm(TempIngredient)");
                            }
                            file.WriteLine("\t\tendIf");
                            break;
                        case 3: //Unique Artifact
                            file.WriteLine("\t\tTempArtifact = Game.GetFormFromFile(0x" + Item.Key + ", \"" + tbPluginName.Text + PluginExtension[cbPluginExtension.SelectedIndex] + "\")");
                            file.WriteLine("\t\tif(TempArtifact)");
                            file.WriteLine("\t\t\t" + ArtifactRankNames[DictionaryRanks[Item.Key]] + ".AddForm(TempArtifact)");
                            file.WriteLine("\t\t\t" + EquippableItemName + ".AddForm(TempArtifact)");
                            file.WriteLine("\t\t\t" + EquippableArtifactName + ".AddForm(TempArtifact)");
                            foreach (int i in DictionaryArchetypes[Item.Key])
                            {
                                file.WriteLine("\t\t\t" + ArtifactArchetypeNames[i] + ".AddForm(TempArtifact)");
                            }
                            file.WriteLine("\t\tendIf");
                            break;
                        case 4: //Breakable Artifact
                            file.WriteLine("\t\tTempArtifact = Game.GetFormFromFile(0x" + Item.Key + ", \"" + tbPluginName.Text + PluginExtension[cbPluginExtension.SelectedIndex] + "\")");
                            file.WriteLine("\t\tif(TempArtifact)");
                            file.WriteLine("\t\t\t" + ArtifactRankNames[DictionaryRanks[Item.Key]] + ".AddForm(TempArtifact)");
                            file.WriteLine("\t\t\t" + EquippableItemName + ".AddForm(TempArtifact)");
                            file.WriteLine("\t\t\t" + EquippableArtifactName + ".AddForm(TempArtifact)");
                            file.WriteLine("\t\t\t" + BreakableArtifactName + ".AddForm(TempArtifact)");
                            foreach (int i in DictionaryArchetypes[Item.Key])
                            {
                                file.WriteLine("\t\t\t" + ArtifactArchetypeNames[i] + ".AddForm(TempArtifact)");
                            }
                            file.WriteLine("\t\tendIf");
                            break;
                        case 5: //Mundane Artifact
                            file.WriteLine("\t\tTempArtifact = Game.GetFormFromFile(0x" + Item.Key + ", \"" + tbPluginName.Text + PluginExtension[cbPluginExtension.SelectedIndex] + "\")");
                            file.WriteLine("\t\tif(TempArtifact)");
                            file.WriteLine("\t\t\t" + ArtifactRankNames[DictionaryRanks[Item.Key]] + ".AddForm(TempArtifact)");
                            file.WriteLine("\t\t\t" + BreakableArtifactName + ".AddForm(TempArtifact)");
                            foreach (int i in DictionaryArchetypes[Item.Key])
                            {
                                file.WriteLine("\t\t\t" + ArtifactArchetypeNames[i] + ".AddForm(TempArtifact)");
                            }
                            file.WriteLine("\t\tendIf");
                            break;
                        case 6: //Effect
                            file.WriteLine("\t\tTempEffect = Game.GetFormFromFile(0x" + Item.Key + ", \"" + tbPluginName.Text + PluginExtension[cbPluginExtension.SelectedIndex] + "\") as MagicEffect");
                            file.WriteLine("\t\tif(TempEffect)");
                            foreach (int i in DictionaryArchetypes[Item.Key])
                            {
                                file.WriteLine("\t\t\t" + EffectArchetypeNames[i] + ".AddForm(TempEffect)");
                            }
                            file.WriteLine("\t\tendIf");
                            break;
                        default:
                            break;
                    }
                    ItemCount++;
                    if(ItemCount % 50 == 0)
                    {
                        file.WriteLine("\t\tDebug.Notification(\"Imported " + ItemCount + "/" + DictionaryNames.Count + " Forms from " + tbPluginName.Text + "\")");
                    }
                }
                file.WriteLine("\t\tDebug.Notification(\"Finished Importing Forms from " + tbPluginName.Text + "\")");

                file.WriteLine("\tendIf");
                file.WriteLine("\t(Game.GetFormFromFile(0x05ADF1, \"SpellResearch.esp\") as Quest).RegisterForSingleUpdate(0.5)");
                file.WriteLine("endEvent");
            }
        }
    }
}
