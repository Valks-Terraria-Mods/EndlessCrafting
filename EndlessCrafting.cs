using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EndlessCrafting
{
    class EndlessCrafting : Mod
    {
        public EndlessCrafting()
        {
        }

        public override void AddRecipeGroups()
        {
            RecipeGroup shadowScales = new RecipeGroup(() => Lang.misc[37] + " Shadow Scale", new int[]
            {
                ItemID.ShadowScale,
                ItemID.TissueSample
            });
            RecipeGroup.RegisterGroup("EndlessCrafting:ShadowScales", shadowScales);

            RecipeGroup goldBars = new RecipeGroup(() => Lang.misc[37] + " Gold Bar", new int[]
            {
                ItemID.GoldBar,
                ItemID.PlatinumBar
            });
            RecipeGroup.RegisterGroup("EndlessCrafting:GoldBars", goldBars);

            RecipeGroup crimstoneBlocks = new RecipeGroup(() => Lang.misc[37] + " Crimstone Block", new int[]
            {
                ItemID.CrimstoneBlock,
                ItemID.EbonstoneBlock
            });
            RecipeGroup.RegisterGroup("EndlessCrafting:CrimstoneBlocks", crimstoneBlocks);
        }

        public override void AddRecipes()
        {
            addCraftingStations();
            addMounts();
            addPets();
            addBossSummons();

            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.LifeFruit);
            recipe.AddRecipe();
        }

        private void addBossSummons()
        {
            bossBrainOfCthulhu();
            bossDestroyer();
            bossDukeFishron();
            bossEaterOfWorlds();
            bossEyeOfCthulhu();
            bossGolem();
            bossMoonlord();
            bossPlantera();
            bossQueenBee();
            bossSkeletron();
            bossSkeletronPrime();
            bossSlimeKing();
            bossTwins();
            bossWallOfFlash();
        }

        private void addMounts()
        {
            addSlimeMount();
            addBeeMount();
            addTurtleMount();
            addBunnyMount();
            addBasiliskMount();
            addPigronMount();
            addCuteFishronMount();
            addRudolphMount();
            addUFOMount();
            addScutlixMount();
            addUnicornMount();
        }

        private void addCraftingStations()
        {
            addAlchemyTable();
            addAncientManipulator();
            addAutoHammer();
            addBlendOMatic();
            addBoneWelder();
            addCrystalBall();
            addDyeVat();
            addExtractinator();
            addFleshCloningVat();
            addHoneyDispender();
            addIceMachine();
            addImbuingStation();
            addLihzahrdFurnace();
            addLivingLoom();
            addMeatGrinder();
            addSkyMill();
            addSolidifier();
            addSteamPunkBoiler();
            addTinkerersWorkshop();
        }

        private void addPets()
        {
            addBunnyPet();
            addBlackCatPet();
            addCompanionPet();
            addCursedSaplingPet();
            addDinosaurPet();
            addEaterPet();
            addEyeballPet();
            addFaceMonsterPet();
            addGrinchPet();
            addHoardagronPet();
            addHornetPet();
            addLizardPet();
            addMinotaurPet();
            addParrotPet();
            addPenguinPet();
            addPropellerPet();
            addPuppyPet();
            addSaplingPet();
            addSkeletronPet();
            addSnowmanPet();
            addSpiderPet();
            addSquashlingPet();
            addTikiSpiritPet();
            addTrufflePet();
            addTurtlePet();
            addZephyrPet();
        }

        private void bossSlimeKing()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Gel, 30);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.SlimeCrown);
            recipe.AddRecipe();
        }

        private void bossEyeOfCthulhu()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Lens, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.SuspiciousLookingEye);
            recipe.AddRecipe();
        }

        private void bossEaterOfWorlds()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.RottenChunk, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.WormFood);
            recipe.AddRecipe();
        }

        private void bossBrainOfCthulhu()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Vertebrae, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BloodySpine);
            recipe.AddRecipe();
        }

        private void bossQueenBee()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.BottledHoney, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.Abeemination);
            recipe.AddRecipe();
        }

        private void bossSkeletron()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Bone, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ClothierVoodooDoll);
            recipe.AddRecipe();
        }

        private void bossWallOfFlash()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.AshBlock, 50);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.GuideVoodooDoll);
            recipe.AddRecipe();
        }

        private void bossTwins()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofNight, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.MechanicalEye);
            recipe.AddRecipe();
        }

        private void bossDestroyer()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofNight, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.MechanicalWorm);
            recipe.AddRecipe();
        }

        private void bossSkeletronPrime()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofNight, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.MechanicalSkull);
            recipe.AddRecipe();
        }

        private void bossPlantera()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofLight, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PlanteraMask);
            recipe.AddRecipe();
        }

        private void bossGolem()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofLight, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.LihzahrdPowerCell);
            recipe.AddRecipe();
        }

        private void bossDukeFishron()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofLight, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.TruffleWorm);
            recipe.AddRecipe();
        }

        private void bossMoonlord()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LihzahrdPowerCell, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.CelestialSigil);
            recipe.AddRecipe();
        }

        private void addBunnyPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.SnowBlock);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.Carrot);
            recipe.AddRecipe();
        }

        private void addDinosaurPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.DesertFossil);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.AmberMosquito);
            recipe.AddRecipe();
        }

        private void addPenguinPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.IceBlock);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.Fish);
            recipe.AddRecipe();
        }

        private void addFaceMonsterPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddRecipeGroup("EndlessCrafting:CrimstoneBlocks");
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BoneRattle);
            recipe.AddRecipe();
        }

        private void addSkeletronPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.Bone);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BoneKey);
            recipe.AddRecipe();
        }

        private void addParrotPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.Feather);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ParrotCracker);
            recipe.AddRecipe();
        }

        private void addTurtlePet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.Coral);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.Seaweed);
            recipe.AddRecipe();
        }

        private void addTrufflePet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.GlowingMushroom);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.StrangeGlowingMushroom);
            recipe.AddRecipe();
        }

        private void addSnowmanPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.Snowball);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ToySled);
            recipe.AddRecipe();
        }

        private void addEaterPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddRecipeGroup("EndlessCrafting:CrimstoneBlocks");
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.EatersBone);
            recipe.AddRecipe();
        }

        private void addHornetPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.BottledHoney);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.Nectar);
            recipe.AddRecipe();
        }

        private void addLizardPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.DirtBlock);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.LizardEgg);
            recipe.AddRecipe();
        }

        private void addSaplingPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.GrassSeeds);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.Seedling);
            recipe.AddRecipe();
        }

        private void addTikiSpiritPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.JungleSpores);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.TikiTorch);
            recipe.AddRecipe();
        }

        private void addEyeballPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.Lens);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.EyeSpring);
            recipe.AddRecipe();
        }

        private void addSquashlingPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.Pumpkin);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.MagicalPumpkinSeed);
            recipe.AddRecipe();
        }

        private void addBlackCatPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.Silk);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.UnluckyYarn);
            recipe.AddRecipe();
        }

        private void addCursedSaplingPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.SpookyWood);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.CursedSapling);
            recipe.AddRecipe();
        }

        private void addSpiderPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.Cobweb);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.SpiderEgg);
            recipe.AddRecipe();
        }

        private void addPuppyPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.Ruby);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.DogWhistle);
            recipe.AddRecipe();
        }

        private void addGrinchPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.Salmon);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BabyGrinchMischiefWhistle);
            recipe.AddRecipe();
        }

        private void addMinotaurPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.Cactus);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.TartarSauce);
            recipe.AddRecipe();
        }

        private void addZephyrPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.BottledWater);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ZephyrFish);
            recipe.AddRecipe();
        }

        private void addCompanionPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.Diamond);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.CompanionCube);
            recipe.AddRecipe();
        }

        private void addPropellerPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.SoulofFlight);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.DD2PetGato);
            recipe.AddRecipe();
        }

        private void addHoardagronPet()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.SoulofLight);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.DD2PetDragon);
            recipe.AddRecipe();
        }

        private void addBunnyMount()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Cloud, 25);
            recipe.AddRecipeGroup("EndlessCrafting:GoldBars", 5);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.FuzzyCarrot);
            recipe.AddRecipe();
        }

        private void addSlimeMount()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Gel, 50);
            recipe.AddRecipeGroup("EndlessCrafting:GoldBars", 10);
            recipe.AddIngredient(ItemID.ManaCrystal);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.SlimySaddle);
            recipe.AddRecipe();
        }

        private void addBeeMount()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.HoneyBlock, 25);
            recipe.AddRecipeGroup("EndlessCrafting:GoldBars", 15);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.HoneyedGoggles);
            recipe.AddRecipe();
        }

        private void addTurtleMount()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Starfish, 10);
            recipe.AddIngredient(ItemID.Coral, 10);
            recipe.AddRecipeGroup("EndlessCrafting:GoldBars", 15);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.HardySaddle);
            recipe.AddRecipe();
        }

        private void addBasiliskMount()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("EndlessCrafting:CrimstoneBlocks", 100);
            recipe.AddRecipeGroup("EndlessCrafting:GoldBars", 15);
            recipe.AddIngredient(ItemID.LifeCrystal, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.AncientHorn);
            recipe.AddRecipe();
        }

        private void addPigronMount()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.HallowedBar, 15);
            recipe.AddIngredient(ItemID.Coral, 3);
            recipe.AddRecipeGroup("EndlessCrafting:GoldBars", 15);
            recipe.AddIngredient(ItemID.SoulofFlight);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ScalyTruffle);
            recipe.AddRecipe();
        }

        private void addCuteFishronMount()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.HallowedBar, 25);
            recipe.AddIngredient(ItemID.Coral, 3);
            recipe.AddRecipeGroup("EndlessCrafting:GoldBars", 20);
            recipe.AddIngredient(ItemID.SoulofFlight);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ShrimpyTruffle);
            recipe.AddRecipe();
        }

        private void addRudolphMount()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.HallowedBar, 15);
            recipe.AddRecipeGroup("EndlessCrafting:GoldBars", 25);
            recipe.AddIngredient(ItemID.SoulofLight);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.ReindeerBells);
            recipe.AddRecipe();
        }

        private void addUFOMount()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.HallowedBar, 25);
            recipe.AddRecipeGroup("IronBar", 50);
            recipe.AddRecipeGroup("EndlessCrafting:GoldBars", 25);
            recipe.AddIngredient(ItemID.SoulofSight);
            recipe.AddIngredient(ItemID.LifeCrystal, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.CosmicCarKey);
            recipe.AddRecipe();
        }

        private void addScutlixMount()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.HallowedBar, 35);
            recipe.AddRecipeGroup("EndlessCrafting:GoldBars", 15);
            recipe.AddIngredient(ItemID.SoulofFright);
            recipe.AddIngredient(ItemID.SoulofMight);
            recipe.AddIngredient(ItemID.LifeCrystal, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BrainScrambler);
            recipe.AddRecipe();
        }

        private void addUnicornMount()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.CrystalShard, 30);
            recipe.AddRecipeGroup("EndlessCrafting:GoldBars", 15);
            recipe.AddIngredient(ItemID.SoulofLight);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BlessedApple);
            recipe.AddRecipe();
        }

        private void addAncientManipulator()
        {
            ModRecipe ancientManipulator = new ModRecipe(this);
            ancientManipulator.AddIngredient(ItemID.FragmentNebula, 1);
            ancientManipulator.AddIngredient(ItemID.FragmentSolar, 1);
            ancientManipulator.AddIngredient(ItemID.FragmentStardust, 1);
            ancientManipulator.AddIngredient(ItemID.FragmentVortex, 1);
            ancientManipulator.AddTile(TileID.WorkBenches);
            ancientManipulator.SetResult(ItemID.LunarCraftingStation);
            ancientManipulator.AddRecipe();
        }

        private void addAlchemyTable()
        {
            ModRecipe alchemyTable = new ModRecipe(this);
            alchemyTable.AddRecipeGroup("Wood", 25);
            alchemyTable.AddRecipeGroup("IronBar", 12);
            alchemyTable.AddIngredient(ItemID.Bottle, 3);
            alchemyTable.AddRecipeGroup("EndlessCrafting:ShadowScales");
            alchemyTable.AddTile(TileID.WorkBenches);
            alchemyTable.SetResult(ItemID.AlchemyTable);
            alchemyTable.AddRecipe();
        }

        private void addTinkerersWorkshop()
        {
            ModRecipe tinkerersWorkshop = new ModRecipe(this);
            tinkerersWorkshop.AddRecipeGroup("Wood", 25);
            tinkerersWorkshop.AddRecipeGroup("IronBar", 25);
            tinkerersWorkshop.AddIngredient(ItemID.Obsidian);
            tinkerersWorkshop.AddTile(TileID.WorkBenches);
            tinkerersWorkshop.SetResult(ItemID.TinkerersWorkshop);
            tinkerersWorkshop.AddRecipe();
        }

        private void addImbuingStation()
        {
            ModRecipe imbuingStation = new ModRecipe(this);
            imbuingStation.AddRecipeGroup("Wood", 25);
            imbuingStation.AddRecipeGroup("IronBar", 15);
            imbuingStation.AddIngredient(ItemID.Bottle, 3);
            imbuingStation.AddIngredient(ItemID.Hellstone);
            imbuingStation.AddTile(TileID.WorkBenches);
            imbuingStation.SetResult(ItemID.ImbuingStation);
            imbuingStation.AddRecipe();
        }

        private void addDyeVat()
        {
            ModRecipe dyeVat = new ModRecipe(this);
            dyeVat.AddRecipeGroup("Wood", 25);
            dyeVat.AddRecipeGroup("IronBar", 8);
            dyeVat.AddIngredient(ItemID.YellowMarigold, 3);
            dyeVat.AddTile(TileID.WorkBenches);
            dyeVat.SetResult(ItemID.DyeVat);
            dyeVat.AddRecipe();
        }

        private void addCrystalBall()
        {
            ModRecipe crystalBall = new ModRecipe(this);
            crystalBall.AddIngredient(ItemID.Glass, 30);
            crystalBall.AddIngredient(ItemID.ManaCrystal, 3);
            crystalBall.AddIngredient(ItemID.Obsidian, 10);
            crystalBall.AddTile(TileID.WorkBenches);
            crystalBall.SetResult(ItemID.CrystalBall);
            crystalBall.AddRecipe();
        }

        private void addAutoHammer()
        {
            ModRecipe autoHammer = new ModRecipe(this);
            autoHammer.AddRecipeGroup("Wood", 25);
            autoHammer.AddRecipeGroup("IronBar", 12);
            autoHammer.AddIngredient(ItemID.GlowingMushroom, 50);
            autoHammer.AddTile(TileID.WorkBenches);
            autoHammer.SetResult(ItemID.Autohammer);
            autoHammer.AddRecipe();
        }

        private void addBoneWelder()
        {
            ModRecipe boneWelder = new ModRecipe(this);
            boneWelder.AddRecipeGroup("Wood", 25);
            boneWelder.AddRecipeGroup("IronBar", 8);
            boneWelder.AddIngredient(ItemID.Bone, 50);
            boneWelder.AddTile(TileID.WorkBenches);
            boneWelder.SetResult(ItemID.BoneWelder);
            boneWelder.AddRecipe();
        }

        private void addHoneyDispender()
        {
            ModRecipe honeyDispenser = new ModRecipe(this);
            honeyDispenser.AddRecipeGroup("Wood", 25);
            honeyDispenser.AddRecipeGroup("IronBar", 8);
            honeyDispenser.AddIngredient(ItemID.HoneyBlock, 10);
            honeyDispenser.AddIngredient(ItemID.BottledHoney);
            honeyDispenser.AddTile(TileID.WorkBenches);
            honeyDispenser.SetResult(ItemID.HoneyDispenser);
            honeyDispenser.AddRecipe();
        }

        private void addIceMachine()
        {
            ModRecipe iceMachine = new ModRecipe(this);
            iceMachine.AddRecipeGroup("Wood", 25);
            iceMachine.AddRecipeGroup("IronBar", 8);
            iceMachine.AddIngredient(ItemID.IceBlock, 10);
            iceMachine.AddIngredient(ItemID.SnowBlock);
            iceMachine.AddTile(TileID.WorkBenches);
            iceMachine.SetResult(ItemID.IceMachine);
            iceMachine.AddRecipe();
        }

        private void addLivingLoom()
        {
            ModRecipe livingLoom = new ModRecipe(this);
            livingLoom.AddRecipeGroup("Wood", 25);
            livingLoom.AddRecipeGroup("IronBar", 8);
            livingLoom.AddTile(TileID.WorkBenches);
            livingLoom.SetResult(ItemID.LivingLoom);
            livingLoom.AddRecipe();
        }

        private void addSkyMill()
        {
            ModRecipe skyMill = new ModRecipe(this);
            skyMill.AddRecipeGroup("Wood", 25);
            skyMill.AddRecipeGroup("IronBar", 8);
            skyMill.AddIngredient(ItemID.SunplateBlock, 10);
            skyMill.AddTile(TileID.WorkBenches);
            skyMill.SetResult(ItemID.SkyMill);
            skyMill.AddRecipe();
        }

        private void addSolidifier()
        {
            ModRecipe solidifier = new ModRecipe(this);
            solidifier.AddRecipeGroup("Wood", 25);
            solidifier.AddRecipeGroup("IronBar", 8);
            solidifier.AddIngredient(ItemID.Gel, 50);
            solidifier.AddTile(TileID.WorkBenches);
            solidifier.SetResult(ItemID.Solidifier);
            solidifier.AddRecipe();
        }

        private void addBlendOMatic()
        {
            ModRecipe blendOMatic = new ModRecipe(this);
            blendOMatic.AddRecipeGroup("Wood", 25);
            blendOMatic.AddRecipeGroup("IronBar", 8);
            blendOMatic.AddIngredient(ItemID.StoneBlock, 50);
            blendOMatic.AddIngredient(ItemID.Gel, 25);
            blendOMatic.AddTile(TileID.WorkBenches);
            blendOMatic.SetResult(ItemID.BlendOMatic);
            blendOMatic.AddRecipe();
        }

        private void addMeatGrinder()
        {
            ModRecipe meatGrinder = new ModRecipe(this);
            meatGrinder.AddRecipeGroup("Wood", 25);
            meatGrinder.AddRecipeGroup("IronBar", 8);
            meatGrinder.AddIngredient(ItemID.CrimstoneBlock, 50);
            meatGrinder.AddTile(TileID.WorkBenches);
            meatGrinder.SetResult(ItemID.MeatGrinder);
            meatGrinder.AddRecipe();
        }

        private void addSteamPunkBoiler()
        {
            ModRecipe steamPunkBoiler = new ModRecipe(this);
            steamPunkBoiler.AddRecipeGroup("Wood", 25);
            steamPunkBoiler.AddRecipeGroup("IronBar", 8);
            steamPunkBoiler.AddIngredient(ItemID.Chain, 12);
            steamPunkBoiler.AddTile(TileID.WorkBenches);
            steamPunkBoiler.SetResult(ItemID.SteampunkBoiler);
            steamPunkBoiler.AddRecipe();
        }

        private void addFleshCloningVat()
        {
            ModRecipe fleshCloningVat = new ModRecipe(this);
            fleshCloningVat.AddRecipeGroup("Wood", 25);
            fleshCloningVat.AddRecipeGroup("IronBar", 8);
            fleshCloningVat.AddIngredient(ItemID.FleshBlock, 50);
            fleshCloningVat.AddTile(TileID.WorkBenches);
            fleshCloningVat.SetResult(ItemID.FleshCloningVaat);
            fleshCloningVat.AddRecipe();
        }

        private void addLihzahrdFurnace()
        {
            ModRecipe lihzahrdFurnace = new ModRecipe(this);
            lihzahrdFurnace.AddRecipeGroup("Wood", 25);
            lihzahrdFurnace.AddRecipeGroup("IronBar", 8);
            lihzahrdFurnace.AddIngredient(ItemID.LihzahrdTable);
            lihzahrdFurnace.AddTile(TileID.WorkBenches);
            lihzahrdFurnace.SetResult(ItemID.LihzahrdFurnace);
            lihzahrdFurnace.AddRecipe();
        }

        private void addExtractinator()
        {
            ModRecipe extractinator = new ModRecipe(this);
            extractinator.AddRecipeGroup("Wood", 25);
            extractinator.AddRecipeGroup("IronBar", 25);
            extractinator.AddIngredient(ItemID.SiltBlock, 50);
            extractinator.AddTile(TileID.WorkBenches);
            extractinator.SetResult(ItemID.Extractinator);
            extractinator.AddRecipe();
        }
    }
}
