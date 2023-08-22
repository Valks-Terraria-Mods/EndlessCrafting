using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EndlessCrafting;

public class EndlessCrafting : ModSystem
{
    public override void AddRecipeGroups()
    {
        RecipeGroup shadowScales = new(() => Lang.misc[37] + " Shadow Scale", new int[]
        {
            ItemID.ShadowScale,
            ItemID.TissueSample
        });
        RecipeGroup.RegisterGroup("EndlessCrafting:ShadowScales", shadowScales);

        RecipeGroup goldBars = new(() => Lang.misc[37] + " Gold Bar", new int[]
        {
            ItemID.GoldBar,
            ItemID.PlatinumBar
        });
        RecipeGroup.RegisterGroup("EndlessCrafting:GoldBars", goldBars);

        RecipeGroup crimstoneBlocks = new(() => Lang.misc[37] + " Crimstone Block", new int[]
        {
            ItemID.CrimstoneBlock,
            ItemID.EbonstoneBlock
        });
        RecipeGroup.RegisterGroup("EndlessCrafting:CrimstoneBlocks", crimstoneBlocks);
    }

    public override void AddRecipes()
    {
        AddCraftingStations();
        AddMounts();
        AddPets();
        AddBossSummons();

        Recipe.Create(ItemID.LifeFruit)
            .AddIngredient(ItemID.ChlorophyteBar, 1)
            .AddTile(TileID.WorkBenches)
            .Register();
    }

    private void AddBossSummons()
    {
        SimpleRecipe(ItemID.BloodySpine, ItemID.Vertebrae, 2);
        SimpleRecipe(ItemID.MechanicalWorm, ItemID.SoulofNight, 2);
        SimpleRecipe(ItemID.TruffleWorm, ItemID.SoulofLight, 2);
        SimpleRecipe(ItemID.WormFood, ItemID.RottenChunk, 2);
        SimpleRecipe(ItemID.SuspiciousLookingEye, ItemID.Lens, 2);
        SimpleRecipe(ItemID.LihzahrdPowerCell, ItemID.SoulofLight, 2);
        SimpleRecipe(ItemID.CelestialSigil, ItemID.LihzahrdPowerCell, 3);
        SimpleRecipe(ItemID.PlanteraMask, ItemID.SoulofLight, 2);
        SimpleRecipe(ItemID.Abeemination, ItemID.BottledHoney, 2);
        SimpleRecipe(ItemID.ClothierVoodooDoll, ItemID.Bone, 10);
        SimpleRecipe(ItemID.MechanicalSkull, ItemID.SoulofNight, 2);
        SimpleRecipe(ItemID.SlimeCrown, ItemID.Gel, 30);
        SimpleRecipe(ItemID.MechanicalEye, ItemID.SoulofNight, 2);
        SimpleRecipe(ItemID.GuideVoodooDoll, ItemID.AshBlock, 50);
    }

    private void AddPets()
    {
        RecipeWithLifeCrystal(ItemID.Carrot, ItemID.SnowBlock);
        RecipeWithLifeCrystal(ItemID.UnluckyYarn, ItemID.Silk);
        RecipeWithLifeCrystal(ItemID.CompanionCube, ItemID.Diamond);
        RecipeWithLifeCrystal(ItemID.CursedSapling, ItemID.SpookyWood);
        RecipeWithLifeCrystal(ItemID.AmberMosquito, ItemID.DesertFossil);
        RecipeWithLifeCrystal(ItemID.EatersBone);
        RecipeWithLifeCrystal(ItemID.EyeSpring, ItemID.Lens);
        RecipeWithLifeCrystal(ItemID.BoneRattle);
        RecipeWithLifeCrystal(ItemID.BabyGrinchMischiefWhistle, ItemID.Salmon);
        RecipeWithLifeCrystal(ItemID.DD2PetDragon, ItemID.SoulofLight);
        RecipeWithLifeCrystal(ItemID.Nectar, ItemID.BottledHoney);
        RecipeWithLifeCrystal(ItemID.LizardEgg, ItemID.DirtBlock);
        RecipeWithLifeCrystal(ItemID.TartarSauce, ItemID.Cactus);
        RecipeWithLifeCrystal(ItemID.ParrotCracker, ItemID.Feather);
        RecipeWithLifeCrystal(ItemID.Fish, ItemID.IceBlock);
        RecipeWithLifeCrystal(ItemID.DD2PetGato, ItemID.SoulofFlight);
        RecipeWithLifeCrystal(ItemID.DogWhistle, ItemID.Ruby);
        RecipeWithLifeCrystal(ItemID.Seedling, ItemID.GrassSeeds);
        RecipeWithLifeCrystal(ItemID.BoneKey, ItemID.Bone);
        RecipeWithLifeCrystal(ItemID.ToySled, ItemID.Snowball);
        RecipeWithLifeCrystal(ItemID.SpiderEgg, ItemID.Cobweb);
        RecipeWithLifeCrystal(ItemID.MagicalPumpkinSeed, ItemID.Pumpkin);
        RecipeWithLifeCrystal(ItemID.TikiTorch, ItemID.JungleSpores);
        RecipeWithLifeCrystal(ItemID.StrangeGlowingMushroom, ItemID.GlowingMushroom);
        RecipeWithLifeCrystal(ItemID.Seaweed, ItemID.Coral);
        RecipeWithLifeCrystal(ItemID.ZephyrFish, ItemID.BottledWater);
    }

    private void AddMounts()
    {
        RecipeWithLifeCrystal(ItemID.SlimySaddle, ItemID.Gel, 50);
        RecipeWithLifeCrystal(ItemID.HoneyedGoggles, ItemID.HoneyBlock, 25);
        RecipeWithLifeCrystal(ItemID.HardySaddle, ItemID.Starfish, 20);
        RecipeWithLifeCrystal(ItemID.FuzzyCarrot, ItemID.Cloud, 25);
        RecipeWithLifeCrystal(ItemID.AncientHorn, ItemID.HallowedBar, 3);
        RecipeWithLifeCrystal(ItemID.ScalyTruffle, ItemID.HallowedBar, 20);
        RecipeWithLifeCrystal(ItemID.ShrimpyTruffle, ItemID.HallowedBar, 20);
        RecipeWithLifeCrystal(ItemID.ReindeerAntlers, ItemID.HallowedBar, 20);
        RecipeWithLifeCrystal(ItemID.CosmicCarKey, ItemID.HallowedBar, 40);
        RecipeWithLifeCrystal(ItemID.BrainScrambler, ItemID.HallowedBar, 35);
        RecipeWithLifeCrystal(ItemID.BlessedApple, ItemID.CrystalShard, 30);
    }

    private void AddCraftingStations()
    {
        RecipeMultipleIngredients(ItemID.AlchemyTable, 
            new Item(ItemID.Wood, 25),
            new Item(RecipeGroupID.IronBar, 12, true),
            new Item(ItemID.Bottle, 3));

        RecipeMultipleIngredients(ItemID.LunarCraftingStation, 
            ItemID.FragmentNebula, 
            ItemID.FragmentSolar, 
            ItemID.FragmentStardust, 
            ItemID.FragmentVortex);

        RecipeMultipleIngredients(ItemID.Autohammer,
            new Item(ItemID.Wood, 25),
            new Item(ItemID.GlowingMushroom, 50),
            new Item(RecipeGroupID.IronBar, 12, true));

        RecipeMultipleIngredients(ItemID.BlendOMatic,
            new Item(ItemID.Wood, 25),
            new Item(ItemID.StoneBlock, 50),
            new Item(ItemID.Gel, 25),
            new Item(RecipeGroupID.IronBar, 8, true));

        RecipeMultipleIngredients(ItemID.BoneWelder,
            new Item(ItemID.Wood, 25),
            new Item(RecipeGroupID.IronBar, 8, true),
            new Item(ItemID.Bone, 50));

        RecipeMultipleIngredients(ItemID.CrystalBall,
            new Item(ItemID.Glass, 30),
            new Item(ItemID.ManaCrystal, 3),
            new Item(ItemID.Obsidian, 10));

        RecipeMultipleIngredients(ItemID.DyeVat,
            new Item(ItemID.Wood, 25),
            new Item(ItemID.YellowMarigold, 3),
            new Item(RecipeGroupID.IronBar, 8, true));

        RecipeMultipleIngredients(ItemID.HoneyDispenser,
            new Item(ItemID.Wood, 25),
            new Item(RecipeGroupID.IronBar, 8, true),
            new Item(ItemID.HoneyBlock, 10),
            new Item(ItemID.BottledHoney));

        RecipeMultipleIngredients(ItemID.IceMachine,
            new Item(ItemID.Wood, 25),
            new Item(RecipeGroupID.IronBar, 8, true),
            new Item(ItemID.IceBlock, 10),
            new Item(ItemID.SnowBlock));

        RecipeMultipleIngredients(ItemID.ImbuingStation,
            new Item(ItemID.Wood, 25),
            new Item(ItemID.Bottle, 3),
            new Item(ItemID.Hellstone),
            new Item(RecipeGroupID.IronBar, 15, true));

        RecipeMultipleIngredients(ItemID.LivingLoom,
            new Item(ItemID.Wood, 25),
            new Item(RecipeGroupID.IronBar, 8, true));

        RecipeMultipleIngredients(ItemID.MeatGrinder,
            new Item(ItemID.Wood, 25),
            new Item(ItemID.CrimstoneBlock, 50),
            new Item(RecipeGroupID.IronBar, 8, true));

        RecipeMultipleIngredients(ItemID.SkyMill,
            new Item(ItemID.Wood, 25),
            new Item(RecipeGroupID.IronBar, 8, true),
            new Item(ItemID.SunplateBlock, 10));

        RecipeMultipleIngredients(ItemID.Solidifier,
            new Item(ItemID.Wood, 25),
            new Item(ItemID.Gel, 50),
            new Item(RecipeGroupID.IronBar, 8, true));

        RecipeMultipleIngredients(ItemID.SteampunkBoiler,
            new Item(ItemID.Wood, 25),
            new Item(RecipeGroupID.IronBar, 8, true),
            new Item(ItemID.Chain, 12));

        RecipeMultipleIngredients(ItemID.TinkerersWorkshop,
            new Item(ItemID.Wood, 25),
            new Item(ItemID.Obsidian),
            new Item(RecipeGroupID.IronBar, 25, true));

        RecipeMultipleIngredients(ItemID.FleshCloningVaat,
            new Item(ItemID.Wood, 25),
            new Item(RecipeGroupID.IronBar, 8, true),
            new Item(ItemID.FleshBlock, 50));

        RecipeMultipleIngredients(ItemID.LihzahrdFurnace,
            new Item(ItemID.Wood, 25),
            new Item(RecipeGroupID.IronBar, 8, true),
            new Item(ItemID.LihzahrdTable));

        RecipeMultipleIngredients(ItemID.Extractinator,
            new Item(ItemID.Wood, 25),
            new Item(RecipeGroupID.IronBar, 8, true),
            new Item(ItemID.SiltBlock, 50));
    }

    private void SimpleRecipe(int result, int ingredient, int ingredientAmount = 1) =>
        Recipe.Create(result)
            .AddIngredient(ingredient, ingredientAmount)
            .AddTile(TileID.WorkBenches)
            .Register();

    private void RecipeMultipleIngredients(int result, params int[] ingredients) 
    {
        var recipe = Recipe.Create(result);

        foreach (var ingredient in ingredients)
            recipe.AddIngredient(ingredient);

        recipe.AddTile(TileID.WorkBenches);
        recipe.Register();
    }

    private void RecipeMultipleIngredients(int result, params Item[] ingredients)
    {
        var recipe = Recipe.Create(result);

        foreach (var ingredient in ingredients)
            if (ingredient.IsGroup)
                recipe.AddRecipeGroup(ingredient.Id, ingredient.Amount);
            else
                recipe.AddIngredient(ingredient.Id, ingredient.Amount);

        recipe.AddTile(TileID.WorkBenches);
        recipe.Register();
    }

    private void RecipeWithLifeCrystal(int result, params int[] ingredients) 
    {
        var recipe = Recipe.Create(result);
        recipe.AddIngredient(ItemID.LifeCrystal);
        foreach (var ingredient in ingredients)
            recipe.AddIngredient(ingredient);
        recipe.AddTile(TileID.WorkBenches);
        recipe.Register();
    }
}

public class Item 
{
    public int Id { get; set; }
    public int Amount { get; set; }
    public bool IsGroup { get; set; }

    public Item(int id, int amount = 1, bool isGroup = false) 
    {
        Id = id;
        Amount = amount;
        IsGroup = isGroup;
    }
}
