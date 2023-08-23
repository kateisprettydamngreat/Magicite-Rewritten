internal sealed class Craft : GenericGenerator<WaitForSeconds>
{
  internal GameScript self_;

  public Craft(GameScript self_)
  {
    base.Ector();
    this.self_ = self_;
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
      this.self_ = self_;
    }

    public override bool MoveNext()
    {
      switch (this._state)
      {
        case 1:
          return false;
        case 2:
          this.craft = RuntimeServices.op_Addition(RuntimeServices.op_Addition((object) this.self_.firstItemSelected.id, "c"), (object) this.self_.secondItemSelected.id);
          this.c1 = this.self_.firstItemSelected.id;
          this.c2 = this.self_.secondItemSelected.id;
          this.newItem = (Item) null;
          this.newID = 0;
          this.newQ = new int();
          MonoBehaviour.print((object) RuntimeServices.op_Addition(RuntimeServices.op_Addition(RuntimeServices.op_Addition("crafting ", (object) this.c1), " "), (object) this.c2));

        Dictionary<Tuple<int, int>, int> craftToNewID = new Dictionary<Tuple<int, int>, int>
        {
          { Tuple.Create(1, 1), 2 }, //Wood+Wood=Wooden Plank
          { Tuple.Create(2, 2), 25 }, //Wooden Plank+Wooden Plank=Wooden Stick
          { Tuple.Create(2, 3), 24 }, //Wooden Plank+Wooden Stick=Sword Hilt
          { Tuple.Create(3, 3), 26 }, //Wooden Stick+Wooden Stick=Axe Handle
          { Tuple.Create(9, 9), 15 }, //Herb+Herb=HP Potion
          { Tuple.Create(25, 26), 501 },
          { Tuple.Create(26, 25), 501 },
          { Tuple.Create(24, 25), 500 },
          { Tuple.Create(25, 24), 500 },
          { Tuple.Create(3, 26), 27 },
          { Tuple.Create(26, 3), 27 },
          { Tuple.Create(27, 25), 502 },
          { Tuple.Create(25, 27), 502 },
          { Tuple.Create(38, 38), 39 },
          { Tuple.Create(39, 39), 40 },
          { Tuple.Create(24, 40), 512 },
          { Tuple.Create(40, 24), 512 },
          { Tuple.Create(40, 26), 513 },
          { Tuple.Create(26, 40), 513 },
          { Tuple.Create(40, 27), 514 },
          { Tuple.Create(27, 40), 514 },
          { Tuple.Create(18, 18), 51 },
          { Tuple.Create(71, 3), 602 },
          { Tuple.Create(3, 71), 602 },
          { Tuple.Create(18, 50), 517 },
          { Tuple.Create(50, 18), 517 },
          { Tuple.Create(19, 19), 82 },
          { Tuple.Create(20, 20), 94 },
          { Tuple.Create(81, 81), 71 },
          { Tuple.Create(2, 82), 77 },
          { Tuple.Create(82, 2), 77 },
          { Tuple.Create(77, 30), 78 },
          { Tuple.Create(30, 77), 78 },
          { Tuple.Create(77, 31), 79 },
          { Tuple.Create(31, 77), 79 },
          { Tuple.Create(77, 81), 80 },
          { Tuple.Create(81, 77), 80 },
          { Tuple.Create(69, 3), 600 },
          { Tuple.Create(3, 69), 600 },
          { Tuple.Create(70, 3), 601 },
          { Tuple.Create(3, 70), 601 },
          { Tuple.Create(30, 30), 69 },
          { Tuple.Create(31, 31), 70 },
          { Tuple.Create(26, 50), 517 },
          { Tuple.Create(50, 26), 517 },
          { Tuple.Create(24, 50), 516 },
          { Tuple.Create(50, 24), 516 },
          { Tuple.Create(60, 60), 61 },
          { Tuple.Create(51, 51), 50 },
          { Tuple.Create(27, 50), 518 },
          { Tuple.Create(50, 27), 518 },
          { Tuple.Create(29, 29), 68 },
          { Tuple.Create(27, 3), 28 },
          { Tuple.Create(3, 27), 28 },
          { Tuple.Create(28, 29), 515 },
          { Tuple.Create(29, 28), 515 },
          { Tuple.Create(12, 12), 32 },
          { Tuple.Create(13, 13), 33 },
          { Tuple.Create(14, 14), 34 },
          { Tuple.Create(39, 39), 40 },
          { Tuple.Create(32, 24), 503 },
          { Tuple.Create(24, 32), 503 },
          { Tuple.Create(32, 26), 504 },
          { Tuple.Create(26, 32), 504 },
          { Tuple.Create(32, 27), 505 },
          { Tuple.Create(27, 32), 505 },
          { Tuple.Create(24, 33), 506 },
          { Tuple.Create(33, 24), 506 },
          { Tuple.Create(33, 26), 507 },
          { Tuple.Create(26, 33), 507 },
          { Tuple.Create(33, 27), 508 },
          { Tuple.Create(27, 33), 508 },
          { Tuple.Create(24, 34), 509 },
          { Tuple.Create(34, 24), 509 },
          { Tuple.Create(34, 26), 510 },
          { Tuple.Create(26, 34), 510 },
          { Tuple.Create(34, 27), 511 },
          { Tuple.Create(27, 34), 511 },
          { Tuple.Create(26, 35), 560 },
          { Tuple.Create(35, 26), 560 },
          { Tuple.Create(26, 36), 561 },
          { Tuple.Create(36, 26), 561 },
          { Tuple.Create(26, 37), 562 },
          { Tuple.Create(37, 26), 562 },
          { Tuple.Create(26, 41), 563 },
          { Tuple.Create(41, 26), 563 },
          { Tuple.Create(567, 71), 568 },
          { Tuple.Create(71, 567), 568 },
          { Tuple.Create(567, 69), 569 },
          { Tuple.Create(69, 567), 569 },
          { Tuple.Create(567, 70), 570 },
          { Tuple.Create(70, 567), 570 },
          { Tuple.Create(32, 32), 35 },
          { Tuple.Create(33, 33), 36 },
          { Tuple.Create(34, 34), 37 },
          { Tuple.Create(40, 40), 41 },
          { Tuple.Create(68, 3), 529 },
          { Tuple.Create(3, 68), 529 },
          { Tuple.Create(15, 15), 42 },
          { Tuple.Create(16, 16), 43 },
          { Tuple.Create(44, 44), 45 },
          { Tuple.Create(10, 10), 16 },
          { Tuple.Create(23, 23), 29 },
          { Tuple.Create(39, 3), 53 },
          { Tuple.Create(3, 39), 53 },
          { Tuple.Create(12, 3), 54 },
          { Tuple.Create(3, 12), 54 },
          { Tuple.Create(13, 3), 55 },
          { Tuple.Create(3, 13), 55 },
          { Tuple.Create(51, 3), 52 },
          { Tuple.Create(3, 51), 52 },
          { Tuple.Create(3, 14), 56 },
          { Tuple.Create(14, 3), 56 },
          { Tuple.Create(44, 44), 45 },
          { Tuple.Create(47, 47), 48 },
          { Tuple.Create(38, 47), 48 },
          { Tuple.Create(9, 10), 44 },
          { Tuple.Create(9, 11), 44 },
          { Tuple.Create(10, 11), 44 },
        };

          else
            this.canCraft = false;
          if (this.newID >= 600 && this.newID <= 605)
            MenuScript.canUnlockHat[5] = 1;
          if (this.canCraft && this.newID == 568)
            GameScript.legendary[0] = 1;
          else if (this.canCraft && this.newID == 569)
            GameScript.legendary[1] = 1;
          else if (this.canCraft && this.newID == 570)
            GameScript.legendary[2] = 1;
          if (this.canCraft)
          {
            this.i = new int();
            this.pood = UnityEngine.Random.Range(0, 2);
            if (this.newID == 15 && (MenuScript.curTrait[1] == 4 || MenuScript.curTrait[2] == 4) && this.pood == 0)
              this.newID = 42;
            if (this.newID == 16 && (MenuScript.curTrait[1] == 4 || MenuScript.curTrait[2] == 4) && this.pood == 0)
              this.newID = 43;
            if (this.newID == 44 && (MenuScript.curTrait[1] == 4 || MenuScript.curTrait[2] == 4) && this.pood == 0)
              this.newID = 45;
            this.self_.GetComponent<AudioSource>().PlayOneShot(this.self_.audioCraftt);
            if (this.newID < 500)
            {
              this.lowestQ = new int();
              this.aTemp = 1;
              if (this.newID >= 52 && this.newID <= 56)
                this.aTemp = 5;
              if (this.self_.firstItemSelected.q == this.self_.secondItemSelected.q)
              {
                this.lowestQ = this.self_.firstItemSelected.q;
                this.newItem = new Item(this.newID, this.self_.firstItemSelected.q * this.aTemp, new int[4], 0.0f, (GameObject) null);
                GameScript.inventory[this.self_.secondItemSelectedSlot] = this.newItem;
                GameScript.inventory[this.self_.firstItemSelectedSlot] = this.self_.EmptyItem();
                this.self_.ResetCraft();
                this.self_.RefreshInventory();
                this.self_.RefreshActionBar();
              }
              else if (this.self_.secondItemSelected.q < this.self_.firstItemSelected.q)
              {
                this.lowestQ = this.self_.secondItemSelected.q;
                this.newItem = new Item(this.newID, this.self_.secondItemSelected.q * this.aTemp, new int[4], 0.0f, (GameObject) null);
                GameScript.inventory[this.self_.secondItemSelectedSlot] = this.newItem;
                GameScript.inventory[this.self_.firstItemSelectedSlot].q -= this.self_.secondItemSelected.q;
                this.self_.ResetCraft();
                this.self_.RefreshInventory();
                this.self_.RefreshActionBar();
              }
              else if (this.self_.firstItemSelected.q < this.self_.secondItemSelected.q)
              {
                this.lowestQ = this.self_.firstItemSelected.q;
                this.newItem = new Item(this.newID, this.self_.firstItemSelected.q * this.aTemp, new int[4], 0.0f, (GameObject) null);
                GameScript.inventory[this.self_.firstItemSelectedSlot] = this.newItem;
                GameScript.inventory[this.self_.secondItemSelectedSlot].q -= this.self_.firstItemSelected.q;
                this.self_.ResetCraft();
                this.self_.RefreshInventory();
                this.self_.RefreshActionBar();
              }
            }
            else
            {
              this.tempForge = 6f;
              if (MenuScript.curTrait[1] == 5 || MenuScript.curTrait[2] == 5)
              {
                MonoBehaviour.print((object) "+10 luck FORGING GEAR");
                this.tempForge = 12f;
              }
              this.newItem = new Item(this.newID, 1, this.self_.GetGearStats(this.newID), this.self_.GetMaxDurability(this.newID), (GameObject) null);
              this.luckCount = UnityEngine.Random.Range(0, 100);
              this.bonusStat = new int();
              this.num1 = new int();
              if ((double) this.luckCount < (double) this.tempForge * 0.5)
              {
                for (this.i = 0; this.i < 4; ++this.i)
                {
                  this.bonusStat = UnityEngine.Random.Range(0, 4);
                  this.num1 = UnityEngine.Random.Range(1, 3);
                  this.newItem.e[this.bonusStat] = this.newItem.e[this.bonusStat] + this.num1;
                  this.newItem.tier = 3;
                }
              }
              else if ((double) this.luckCount < (double) this.tempForge)
              {
                for (this.i = 0; this.i < 2; ++this.i)
                {
                  this.bonusStat = UnityEngine.Random.Range(0, 4);
                  this.num1 = UnityEngine.Random.Range(1, 3);
                  this.newItem.e[this.bonusStat] = this.newItem.e[this.bonusStat] + this.num1;
                  this.newItem.tier = 2;
                }
              }
              else if ((double) this.luckCount < (double) this.tempForge * 2.0)
              {
                for (this.i = 0; this.i < 1; ++this.i)
                {
                  this.bonusStat = UnityEngine.Random.Range(0, 4);
                  this.num1 = UnityEngine.Random.Range(1, 3);
                  this.newItem.e[this.bonusStat] = this.newItem.e[this.bonusStat] + this.num1;
                  this.newItem.tier = 1;
                }
              }
              this.self_.holdingItem = true;
              this.self_.itemSelected = this.newItem;
              --this.self_.firstItemSelected.q;
              --this.self_.secondItemSelected.q;
              if (this.self_.firstItemSelected.q < 1)
                GameScript.inventory[this.self_.firstItemSelectedSlot] = this.self_.EmptyItem();
              if (this.self_.secondItemSelected.q < 1)
                GameScript.inventory[this.self_.secondItemSelectedSlot] = this.self_.EmptyItem();
              this.self_.ResetCraft();
              this.self_.UpdateHoldingItem();
              this.self_.RefreshInventory();
              this.self_.RefreshActionBar();
            }
            GameScript.tempStats[4] = GameScript.tempStats[4] + 1;
          }
          else
            this.self_.ResetCraft();
          this.YieldDefault(1);
          goto case 1;
        default:
          this.canCraft = true;
          return this.Yield(2, new WaitForSeconds(0.1f));
      }
    }
  }
}
