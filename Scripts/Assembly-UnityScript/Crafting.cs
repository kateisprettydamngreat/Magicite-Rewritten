internal sealed class Craft : GenericGenerator<WaitForSeconds>
{
  internal GameScript self_;

  public Craft(GameScript self_)
  {
    base.Ector();
    this.self_=self_;
  }

  public override IEnumerator<WaitForSeconds> GetEnumerator()
  {
    return (IEnumerator<WaitForSeconds>) new GameScript.Craft.(this.self_);
  }

  [Serializable]
  internal sealed class \u0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
  {
    internal bool canCraft;
    internal string craft;
    internal int c1;
    internal int c2;
    internal Item newItem;
    internal int newID;
    internal int newQ;
    internal int i;
    internal int pood;
    internal int lowestQ;
    internal int aTemp;
    internal float tempForge;
    internal int luckCount;
    internal int bonusStat;
    internal int num1;
    internal GameScript self_;

    public \u0024(/*Parameter with token 08000195*/GameScript self_)
    {
      base.\u002Ector();
      this.self_=self_;
    }

    public override bool MoveNext()
    {
      switch (this._state)
      {
        case 1:
          return false;
        case 2:
          this.craft=RuntimeServices.op_Addition(RuntimeServices.op_Addition((object) this.self_.firstItemSelected.id, "c"), (object) this.self_.secondItemSelected.id);
          this.c1=this.self_.firstItemSelected.id;
          this.c2=this.self_.secondItemSelected.id;
          this.newItem=(Item) null;
          this.newID=0;
          this.newQ=new int();
          MonoBehaviour.print((object) RuntimeServices.op_Addition(RuntimeServices.op_Addition(RuntimeServices.op_Addition("crafting ", (object) this.c1), " "), (object) this.c2));

        Dictionary<Tuple<int, int>, int> craftToNewID=new Dictionary<Tuple<int, int>, int>
        {
          { Tuple.Create(1, 1), 2 }, //Wood + Wood = Wooden Plank
          { Tuple.Create(2, 2), 25 }, //Wooden Plank + Wooden Plank = Wooden Stick
          { Tuple.Create(2, 3), 24 }, //Wooden Plank + Wooden Stick = Sword Hilt
          { Tuple.Create(3, 3), 26 }, //Wooden Stick + Wooden Stick = Axe Handle
          { Tuple.Create(9, 9), 15 }, //Herb + Herb = HP Potion
          { Tuple.Create(25, 26), 501 }, //Wooden Blade + Axe Handle = Wooden Axe
          { Tuple.Create(24, 25), 500 }, //Sword Hilt + Wooden Blade = Wooden Sword
          { Tuple.Create(3, 26), 27 }, //Wooden Stick + Axe Handle = Pick Handle
          { Tuple.Create(25, 27), 502 }, //Wooden Blade + Pick Handle = Wooden Pick
          { Tuple.Create(38, 38), 39 }, //Stone + Stone = Refined Stone
          { Tuple.Create(39, 39), 40 }, //Refined Stone + Refined Stone = Stone Blade
          { Tuple.Create(24, 40), 512 }, //Sword Hilt + Stone Blade = Stone Sword
          { Tuple.Create(26, 40), 513 }, //Axe Handle + Stone Blade = Stone Axe
          { Tuple.Create(27, 40), 514 }, // Pick Handle + Stone Blade = Stone Pick
          { Tuple.Create(18, 18), 51 }, // Monster Bone + Monster Bone = Refined Bone
          { Tuple.Create(71, 3), 602 }, // Ice Gem I + Wooden Stick = Frostshard
          { Tuple.Create(18, 50), 517 }, // Monster Bone + Bone Blade = Bone Axe
          { Tuple.Create(19, 19), 82 }, // Monster Hide + Monster Hide = Rugged Leather
          { Tuple.Create(20, 20), 94 }, // Monster Pelt + Monster Pelt = Tribal Leather
          { Tuple.Create(81, 81), 71 }, // Ice Bug + Ice Bug = Ice Gem I
          { Tuple.Create(2, 82), 77 }, // Wooden Plank + Rugged Leather = Tribal Drum
          { Tuple.Create(77, 30), 78 }, // Tribal Drum + Fire Bug = Drum of Strength
          { Tuple.Create(77, 31), 79 }, // Tribal Drum + Thunder Bug = Drum of Dexterity
          { Tuple.Create(77, 81), 80 }, // Tribal Drum + Ice Gem I = Drum of Wisdom
          { Tuple.Create(69, 3), 600 }, // Fire Gem I + Wooden Stick = Fireball
          { Tuple.Create(70, 3), 601 }, // Thunder Gem I + Wooden Stick = Bolt
          { Tuple.Create(30, 30), 69 }, // Fire Bug + Fire Bug = Fire Gem I
          { Tuple.Create(31, 31), 70 }, // Thunder Bug + Thunder Bug = Thunder Gem I
          { Tuple.Create(26, 50), 517 }, // Axe Handle + Bone Blade = Bone Axe
          { Tuple.Create(24, 50), 516 }, // Sword Hilt + Bone Blade = Bone Sword
          { Tuple.Create(60, 60), 61 }, // Crystalite Fragment + Crystalite Fragment = Crystalite Shard
          { Tuple.Create(51, 51), 50 }, // Refined Bone + Refined Bone = Bone Blade
          { Tuple.Create(27, 50), 518 }, // Pick Handle + Bone Blade = Bone Pick
          { Tuple.Create(29, 29), 68 }, // String + String = Net
          { Tuple.Create(27, 3), 28 }, // Wooden Blade + Wooden Stick = Unstrung Bow
          { Tuple.Create(28, 29), 515 }, // Unstrung Bow + String = Wooden Bow
          { Tuple.Create(12, 12), 32 }, // Ironite Bar + Ironite Bar = Ironite Blade
          { Tuple.Create(13, 13), 33 }, // Goldium Bar + Goldium Bar = Goldium Blade
          { Tuple.Create(14, 14), 34 }, // Diamonite Bar + Diamonite Bar = Diamonite Blade
          { Tuple.Create(39, 39), 40 }, // Refined Stone + Refined Stone = Stone Blade
          { Tuple.Create(24, 32), 503 }, // Sword Hilt + Ironite Blade = Ironite Sword
          { Tuple.Create(32, 26), 504 }, // Ironite Blade + Axe Handle = Ironite Axe
          { Tuple.Create(26, 32), 504 }, // Axe Handle + Ironite Blade = Ironite Axe
          { Tuple.Create(27, 32), 505 }, // Pick Handle + Ironite Blade = Ironite Pick
          { Tuple.Create(33, 24), 506 }, // Goldium Blade + Sword Hilt = Goldium Sword
          { Tuple.Create(26, 33), 507 }, // Axe Handle + Goldium Blade = Goldium Axe
          { Tuple.Create(27, 33), 508 }, // Pick Handle + Goldium Blade = Goldium Pick
          { Tuple.Create(34, 24), 509 }, // Diamonite Blade + Sword Hilt = Diamonite Sword
          { Tuple.Create(26, 34), 510 }, // Axe Handle + Diamonite Blade = Diamonite Axe
          { Tuple.Create(27, 34), 511 }, // Pick Handle + Diamonite Blade = Diamonite Pick
          { Tuple.Create(35, 26), 560 }, // Ironite Great Blade + Axe Handle = Ironite Great Axe
          { Tuple.Create(36, 26), 561 }, // Goldium Great Blade + Axe Handle = Goldium Great Axe
          { Tuple.Create(37, 26), 562 }, // Diamonite Great Blade + Axe Handle = Diamonite Great Axe
          { Tuple.Create(26, 41), 563 }, // Axe Handle + Obsidian Blade = Obsidian Axe
          { Tuple.Create(41, 26), 563 }, // Obsidian Blade + Axe Handle = Obsidian Axe
          { Tuple.Create(567, 71), 568 }, // Zweihander + Ice Gem I = Icebrand
          { Tuple.Create(567, 69), 569 }, // Zweihander + Fire Gem I = Firebrand
          { Tuple.Create(567, 70), 570 }, // Zweihander + Thunder Gem I = Thunderbrand
          { Tuple.Create(32, 32), 35 }, // Ironite Blade + Ironite Blade = Ironite Great Blade
          { Tuple.Create(33, 33), 36 }, // Goldium Blade + Goldium Blade = Goldium Great Blade
          { Tuple.Create(34, 34), 37 }, // Diamonite Blade + Diamonite Blade = Diamonite Great Blade
          { Tuple.Create(40, 40), 41 }, // Stone Blade + Stone Blade = Stone Great Blade
          { Tuple.Create(68, 3), 529 }, // Net + Wooden Stick = Bug Net
          { Tuple.Create(15, 15), 42 }, // HP Potion + HP Potion = Big HP Potion
          { Tuple.Create(16, 16), 43 }, // Mana Potion + Mana Potion = Big Mana Potion
          { Tuple.Create(44, 44), 45 }, // Mysterious Potion + Mysterious Potion = Big Mysterious Potion
          { Tuple.Create(10, 10), 16 }, // Shroom + Shroom = Mana Potion
          { Tuple.Create(23, 23), 29 }, // Spider Web + Spider Web = String
          { Tuple.Create(39, 3), 53 }, // Refined Stone + Wooden Stick = Stone Arrow
          { Tuple.Create(12, 3), 54 }, // Ironite Bar + Wooden Stick = Ironite Arrow
          { Tuple.Create(13, 3), 55 }, // Goldium Bar + Wooden Stick = Goldium Arrow
          { Tuple.Create(51, 3), 52 }, // Refined Bone + Wooden Stick = Bone Arrow
          { Tuple.Create(3, 14), 56 }, // Wooden Stick + Diamonite Bar = Diamonite Arrow
          { Tuple.Create(44, 44), 45 }, // Mysterious Potion + Mysterious Potion = Big Mysterious Potion
          { Tuple.Create(47, 47), 48 }, // Coal + Coal = Firestarter
          { Tuple.Create(38, 47), 48 }, // Stone + Coal = Firestarter
          { Tuple.Create(9, 10), 44 }, // Herb + Shroom = Mysterious Potion
          { Tuple.Create(9, 11), 44 }, // Herb + Root = Mysterious Potion
          { Tuple.Create(10, 11), 44 }, // Shroom + Root = Mysterious Potion
        };

          else
            this.canCraft=false;
          if (this.newID >= 600 && this.newID <= 605)
            MenuScript.canUnlockHat[5]=1;
          if (this.canCraft && this.newID == 568)
            GameScript.legendary[0]=1;
          else if (this.canCraft && this.newID == 569)
            GameScript.legendary[1]=1;
          else if (this.canCraft && this.newID == 570)
            GameScript.legendary[2]=1;
          if (this.canCraft)
          {
            this.i=new int();
            this.pood=UnityEngine.Random.Range(0, 2);
            if (this.newID == 15 && (MenuScript.curTrait[1] == 4 || MenuScript.curTrait[2] == 4) && this.pood == 0)
              this.newID=42;
            if (this.newID == 16 && (MenuScript.curTrait[1] == 4 || MenuScript.curTrait[2] == 4) && this.pood == 0)
              this.newID=43;
            if (this.newID == 44 && (MenuScript.curTrait[1] == 4 || MenuScript.curTrait[2] == 4) && this.pood == 0)
              this.newID=45;
            this.self_.GetComponent<AudioSource>().PlayOneShot(this.self_.audioCraftt);
            if (this.newID < 500)
            {
              this.lowestQ=new int();
              this.aTemp=1;
              if (this.newID >= 52 && this.newID <= 56)
                this.aTemp=5;
              if (this.self_.firstItemSelected.q == this.self_.secondItemSelected.q)
              {
                this.lowestQ=this.self_.firstItemSelected.q;
                this.newItem=new Item(this.newID, this.self_.firstItemSelected.q * this.aTemp, new int[4], 0.0f, (GameObject) null);
                GameScript.inventory[this.self_.secondItemSelectedSlot]=this.newItem;
                GameScript.inventory[this.self_.firstItemSelectedSlot]=this.self_.EmptyItem();
                this.self_.ResetCraft();
                this.self_.RefreshInventory();
                this.self_.RefreshActionBar();
              }
              else if (this.self_.secondItemSelected.q < this.self_.firstItemSelected.q)
              {
                this.lowestQ=this.self_.secondItemSelected.q;
                this.newItem=new Item(this.newID, this.self_.secondItemSelected.q * this.aTemp, new int[4], 0.0f, (GameObject) null);
                GameScript.inventory[this.self_.secondItemSelectedSlot]=this.newItem;
                GameScript.inventory[this.self_.firstItemSelectedSlot].q -= this.self_.secondItemSelected.q;
                this.self_.ResetCraft();
                this.self_.RefreshInventory();
                this.self_.RefreshActionBar();
              }
              else if (this.self_.firstItemSelected.q < this.self_.secondItemSelected.q)
              {
                this.lowestQ=this.self_.firstItemSelected.q;
                this.newItem=new Item(this.newID, this.self_.firstItemSelected.q * this.aTemp, new int[4], 0.0f, (GameObject) null);
                GameScript.inventory[this.self_.firstItemSelectedSlot]=this.newItem;
                GameScript.inventory[this.self_.secondItemSelectedSlot].q -= this.self_.firstItemSelected.q;
                this.self_.ResetCraft();
                this.self_.RefreshInventory();
                this.self_.RefreshActionBar();
              }
            }
            else
            {
              this.tempForge=6f;
              if (MenuScript.curTrait[1] == 5 || MenuScript.curTrait[2] == 5)
              {
                MonoBehaviour.print((object) " + 10 luck FORGING GEAR");
                this.tempForge=12f;
              }
              this.newItem=new Item(this.newID, 1, this.self_.GetGearStats(this.newID), this.self_.GetMaxDurability(this.newID), (GameObject) null);
              this.luckCount=UnityEngine.Random.Range(0, 100);
              this.bonusStat=new int();
              this.num1=new int();
              if ((double) this.luckCount < (double) this.tempForge * 0.5)
              {
                for (this.i=0; this.i < 4; + + this.i)
                {
                  this.bonusStat=UnityEngine.Random.Range(0, 4);
                  this.num1=UnityEngine.Random.Range(1, 3);
                  this.newItem.e[this.bonusStat]=this.newItem.e[this.bonusStat] + this.num1;
                  this.newItem.tier=3;
                }
              }
              else if ((double) this.luckCount < (double) this.tempForge)
              {
                for (this.i=0; this.i < 2; + + this.i)
                {
                  this.bonusStat=UnityEngine.Random.Range(0, 4);
                  this.num1=UnityEngine.Random.Range(1, 3);
                  this.newItem.e[this.bonusStat]=this.newItem.e[this.bonusStat] + this.num1;
                  this.newItem.tier=2;
                }
              }
              else if ((double) this.luckCount < (double) this.tempForge * 2.0)
              {
                for (this.i=0; this.i < 1; + + this.i)
                {
                  this.bonusStat=UnityEngine.Random.Range(0, 4);
                  this.num1=UnityEngine.Random.Range(1, 3);
                  this.newItem.e[this.bonusStat]=this.newItem.e[this.bonusStat] + this.num1;
                  this.newItem.tier=1;
                }
              }
              this.self_.holdingItem=true;
              this.self_.itemSelected=this.newItem;
              --this.self_.firstItemSelected.q;
              --this.self_.secondItemSelected.q;
              if (this.self_.firstItemSelected.q < 1)
                GameScript.inventory[this.self_.firstItemSelectedSlot]=this.self_.EmptyItem();
              if (this.self_.secondItemSelected.q < 1)
                GameScript.inventory[this.self_.secondItemSelectedSlot]=this.self_.EmptyItem();
              this.self_.ResetCraft();
              this.self_.UpdateHoldingItem();
              this.self_.RefreshInventory();
              this.self_.RefreshActionBar();
            }
            GameScript.tempStats[4]=GameScript.tempStats[4] + 1;
          }
          else
            this.self_.ResetCraft();
          this.YieldDefault(1);
          goto case 1;
        default:
          this.canCraft=true;
          return this.Yield(2, new WaitForSeconds(0.1f));
      }
    }
  }
}
