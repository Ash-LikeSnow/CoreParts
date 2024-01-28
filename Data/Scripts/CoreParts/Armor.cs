using static Scripts.Structure;
using static Scripts.Structure.ArmorDefinition.ArmorType;
namespace Scripts {   
    partial class Parts {
        // Don't edit above this line
        ArmorDefinition Armor1 => new ArmorDefinition
        {
            SubtypeIds = new[] {
                "Durasteel",
                "DurasteelSlope",
                "DurasteelCorner"
            },
            EnergeticResistance = 0.95f, //Resistance to Energy damage. 0.5f = 200% damage, 2f = 50% damage
            KineticResistance = 0.82f, //Resistance to Kinetic damage. Leave these as 1 for no effect
            Kind = Heavy, //Heavy, Light, NonArmor - which ammo damage multipliers to apply
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
