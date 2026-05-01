using static Scripts.Structure;
using static Scripts.Structure.SupportDefinition;
using static Scripts.Structure.SupportDefinition.ModelAssignmentsDef;
using static Scripts.Structure.SupportDefinition.HardPointDef;
using static Scripts.Structure.SupportDefinition.SupportEffect.AffectedBlocks;
using static Scripts.Structure.SupportDefinition.SupportEffect.Protections;

namespace Scripts {   
    partial class Parts {
        // Don't edit above this line
        SupportDefinition ArmorEnhancer1A => new SupportDefinition
        {

            Assignments = new ModelAssignmentsDef
            {
                MountPoints = new[] {
                    new MountPointDef {
                        SubtypeId = "ArmorSupport1a",
                        DurabilityMod = 5f,
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
                PartName = "ArmorSupport1a", // name of weapon in terminal, should be unique for each weapon definition that shares a SubtypeId (i.e. multiweapons)

                Ui = new UiDef
                {
                    ProtectionControl = true,
                },
                HardWare = new HardwareDef
                {
                    InventorySize = 1f,
                    IdlePower = 0.25f, // Power draw in MW. Defaults to 0.001
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
            Effect = new SupportEffect
            {
                Protection = GenericProt, //type of protection
                Affected = ArmorPlus, // type of blocks protected
                BlockRange = 3, //protection range (in block units)
                MaxPoints = 10000, //Max protection pool size
                PointsPerCharge = 100, // Number of points per "charge/inventory item"
                UsablePerSecond = 1000, //Max consumed points per second
                UsablePerMinute = 20000, //Max consumed points per minute
                Overflow = 0.01f,//Portion of the damage overflowed on to the support block
                Effectiveness = 0.85f, // What portion of the effect is applied to the block/damage.
                ProtectionMin = 0.5f, // The min level of protection the user can set, values 0 or smaller default to 1
                ProtectionMax = 2.5f, // the max level of protection the user can set, values 0 or smaller default to 1
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