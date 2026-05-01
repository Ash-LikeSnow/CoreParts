using static Scripts.Structure;
using static Scripts.Structure.UpgradeDefinition;
using static Scripts.Structure.UpgradeDefinition.ModelAssignmentsDef;
using static Scripts.Structure.UpgradeDefinition.HardPointDef;
using static Scripts.Structure.UpgradeDefinition.HardPointDef.HardwareDef.HardwareType;
namespace Scripts
{
    partial class Parts
    {
        // Don't edit above this line
        UpgradeDefinition Upgrade75b => new UpgradeDefinition
        {

            Assignments = new ModelAssignmentsDef
            {
                MountPoints = new[] {
                    new MountPointDef {
                        SubtypeId = "Upgrade75b",
                        DurabilityMod = 1f,
                        IconName = "",
                    },

                },
            },
            HardPoint = new HardPointDef
            {
                // If there are multiple definitions with the same part name & subtype ID (like say someone is adjusting stats of another's mod), then the definition with the highest priority will be loaded.
                // For people making their own mod, its recommended to leave this at zero.
                // For people MODIFYING other people's mod, its recommended to set this at anything greater than zero (ie. 1) so your changes override the original mod, and list that mod as a dependency.
                // This effectively allows mod adjuster-like behavior without relying on mod load order, although the entire definition must be copied for it to work properly
                //  - those modifying stats can just have the definitions in their place w/o copying any models, sbc files, or sounds to the modified mod.
                DefinitionPriority = 0,
                PartName = "Upgrade75b", // name of weapon in terminal

                Ui = new UiDef
                {
                },
                HardWare = new HardwareDef
                {
                    InventorySize = 1f,
                    IdlePower = 0.25f, // Power draw in MW. Defaults to 0.001
                    Type = Default, //Default
                    BlockDistance = 6,
                },
                Other = new OtherDef
                {
                    ConstructPartCap = 0,
                    EnergyPriority = 0,
                    Debug = false,
                    RestrictionRadius = 0, // Meters, radius of sphere disable this gun if another is present
                    CheckInflatedBox = false, // if true, the bounding box of the gun is expanded by the RestrictionRadius
                    CheckForAnySupport = false, // if true, the check will fail if ANY gun is present, false only looks for this subtype
                    StayCharged = false, // Will start recharging whenever power cap is not full
                },
            },
            Animations = Weapon75_Animation,
            Consumable = new[] {
                Consumable1,
                Consumable2
            },
            // Don't edit below this line
        };
    }
}