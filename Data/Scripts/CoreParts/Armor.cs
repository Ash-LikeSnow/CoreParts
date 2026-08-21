using static Scripts.Structure;
using static Scripts.Structure.ArmorDefinition.ArmorType;
namespace Scripts {   
    partial class Parts {
        // Don't edit above this line
        ArmorDefinition Armor1 => new ArmorDefinition
        {
            // If there are multiple definitions with the same armor subtype ID (like say someone is adjusting stats of another's mod), then the definition with the highest priority will be loaded.
            // For people making their own mod, its recommended to leave this at zero.
            // For people MODIFYING other people's mod, its recommended to set this at anything greater than zero (ie. 1) so your changes override the original mod, and list that mod as a dependency.
            // This effectively allows mod adjuster-like behavior without relying on mod load order, although the entire definition must be copied for it to work properly
            //  - those modifying stats can just have the definitions in their place w/o copying any models, sbc files, or sounds to the modified mod.
            DefinitionPriority = 0,
            SubtypeIds = new[] {
                "Durasteel",
                "DurasteelSlope",
                "DurasteelCorner"
            },
            EnergeticResistance = 0.95f, //Resistance to Energy damage. 0.5f = 200% damage, 2f = 50% damage
            KineticResistance = 0.82f, //Resistance to Kinetic damage. Leave these as 1 for no effect
            Kind = Heavy, //Heavy, Light, NonArmor - which ammo damage multipliers to apply
            MinDamage = 1, //Minimum damage for a block to actually take damage. Damage events below this value will deduct from the projectiles damage pool but do nothing to the block. Respects all damage modifiers
            IsSacrificialArmor = false, //If true, armor will be destroyed by a single projectile hit and stop all further primary damage, regardless of BaseDamage or block integrity. Optionally gated by MinDamageSacrificial and SacrificialIntegrityThreshold.
            MinDamageSacrificial = 1, //Minimum amount of damage to invoke the sacrificial effect. Keeps low damage events from triggering sacrifice. Respects all damage modifiers
            SacrificialIntegrityThreshold = 0.5f, //Threshold for the minimum block integrity for the sacrificial effect to occur
        };
        ArmorDefinition Armor2 => new ArmorDefinition
        {
            SubtypeIds = new[] {
                "Beskar"
            },
            EnergeticResistance = 1f,
            KineticResistance = 0.96f,
            Kind = Light,
        };
    }
}
