using static Scripts.Structure;
using static Scripts.Structure.ProjectileTagDefinition;
using static Scripts.Structure.ProjectileTagAssignment;

namespace Scripts
{
    partial class Parts
    {
        // Don't edit above this line
        ProjectileTagDefinition ExampleTag1Def => new ProjectileTagDefinition
        {
            // This is where you define any projectile tags for your mod.
            // They are defined in two steps, a namespace which is the first part of the tag and is consistent for every tag defined,
            // and the ID itself. Think of this like a type ID and subtype ID pair, except you also have full reign over your type ID, it just needs to be consistent across your mod.

            Namespace = new Tag
            {
                ID = "examplecoreparts", // What will actually be used in definitions
                PublicName = "Your Mod Name Here", // Public facing name for UI
            },
            // If there are multiple definitions with the same namespace & subtype ID (like say someone is adjusting stats of another's mod), then the definition with the highest priority will be loaded.
            // For people making their own weapon mod, its recommended to leave this at zero.
            // For people MODIFYING other people's mod, its recommended to set this at anything greater than zero (ie. 1) so your changes override the original mod, and list that mod as a dependency.
            // This effectively allows mod adjuster-like behavior without relying on mod load order, although the entire definition must be copied for it to work properly
            //  - those modifying stats can just have the definitions in their place w/o copying any models, sbc files, or sounds to the modified mod.
            DefinitionPriority = 0,
            Tags = new[]
            {
                new Tag 
                {
                    ID = "cannon", // What will actually be used in definitions
                    PublicName = "Cannon" // Public facing name for UI
                },
                new Tag 
                {
                    ID = "stealth", // What will actually be used in definitions
                    PublicName = "Stealth Projectile" // Public facing name for UI
                },
                new Tag 
                {
                    ID = "small", // What will actually be used in definitions
                    PublicName = "Small" // Public facing name for UI
                },
                new Tag 
                {
                    ID = "large", // What will actually be used in definitions
                    PublicName = "Large" // Public facing name for UI
                },
            },
        };

        ProjectileTagAssignment[] TagAssignments => new[]
        {
            // This is where you can assign tags to any ammo type. Neither tag nor ammo type needs to be from your mod.
            // Tags here take the form of `namespace:tag`, so something like `wc:smart` or `coreparts:ammo1`

            // 
            new ProjectileTagAssignment
            {
                Tag = "yourmodhere:stealth", // Tag in the form of `namespace:tag`, and will be applied to all ammo names with the an AmmoRound name listed below
                ProjectileAmmoNames = new[]
                {
                    "Ammo 1", // name of the ammo you want to apply the above tag too. Uses the AmmoRound field
                },
            },
            new ProjectileTagAssignment
            {
                Tag = "yourmodhere:small", // Tag in the form of `namespace:tag`, and will be applied to all ammo names with the an AmmoRound name listed below
                ProjectileAmmoNames = new[]
                {
                    "Ammo 1", // name of the ammo you want to apply the above tag too. Uses the AmmoRound field
                },
            }
        };
    }
}
