internal sealed class Craft : GenericGenerator<WaitForSeconds>
{
  internal GameScript self_;

  public Craft(GameScript self_)
  {
    base.Ector();
    this.self_ = self_;
  }

  // Method GetEnumerator with token 060003D8
  public override IEnumerator<WaitForSeconds> GetEnumerator()
  {
    return (IEnumerator<WaitForSeconds>) new GameScript.Craft.(this.self_);
  }

  [Serializable]
  internal sealed class \u0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
  {
    // Field $canCraft$1577 with token 040003B3
    internal bool canCraft;
    // Field $craft$1578 with token 040003B4
    internal string craft;
    // Field $c1$1579 with token 040003B5
    internal int c1;
    // Field $c2$1580 with token 040003B6
    internal int c2;
    // Field $newItem$1581 with token 040003B7
    internal Item newItem;
    // Field $newID$1582 with token 040003B8
    internal int newID;
    // Field $newQ$1583 with token 040003B9
    internal int newQ;
    // Field $i$1584 with token 040003BA
    internal int i;
    // Field $pood$1585 with token 040003BB
    internal int pood;
    // Field $lowestQ$1586 with token 040003BC
    internal int lowestQ;
    // Field $aTemp$1587 with token 040003BD
    internal int aTemp;
    // Field $tempForge$1588 with token 040003BE
    internal float tempForge;
    // Field $luckCount$1589 with token 040003BF
    internal int luckCount;
    // Field $bonusStat$1590 with token 040003C0
    internal int bonusStat;
    // Field $num1$1591 with token 040003C1
    internal int num1;
    // Field $self_$1592 with token 040003C2
    internal GameScript self_;

    // Method .ctor with token 060003D9
    public \u0024(/*Parameter with token 08000195*/GameScript self_)
    {
      base.\u002Ector();
      this.self_ = self_;
    }

    // Method MoveNext with token 060003DA
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
          if (this.c1 == 1 && this.c2 == 1)
            this.newID = 2;
          else if (this.c1 == 2 && this.c2 == 2)
            this.newID = 25;
          else if (this.c1 == 2 && this.c2 == 3)
            this.newID = 24;
          else if (this.c1 == 3 && this.c2 == 2)
            this.newID = 24;
          else if (this.c1 == 3 && this.c2 == 3)
            this.newID = 26;
          else if (this.c1 == 9 && this.c2 == 9)
            this.newID = 15;
          else if (this.c1 == 25 && this.c2 == 26)
            this.newID = 501;
          else if (this.c1 == 26 && this.c2 == 25)
            this.newID = 501;
          else if (this.c1 == 24 && this.c2 == 25)
            this.newID = 500;
          else if (this.c1 == 25 && this.c2 == 24)
            this.newID = 500;
          else if (this.c1 == 3 && this.c2 == 26)
            this.newID = 27;
          else if (this.c1 == 26 && this.c2 == 3)
            this.newID = 27;
          else if (this.c1 == 27 && this.c2 == 25)
            this.newID = 502;
          else if (this.c1 == 25 && this.c2 == 27)
            this.newID = 502;
          else if (this.c1 == 38 && this.c2 == 38)
            this.newID = 39;
          else if (this.c1 == 39 && this.c2 == 39)
            this.newID = 40;
          else if (this.c1 == 24 && this.c2 == 40)
            this.newID = 512;
          else if (this.c1 == 40 && this.c2 == 24)
            this.newID = 512;
          else if (this.c1 == 40 && this.c2 == 26)
            this.newID = 513;
          else if (this.c1 == 26 && this.c2 == 40)
            this.newID = 513;
          else if (this.c1 == 40 && this.c2 == 27)
            this.newID = 514;
          else if (this.c1 == 27 && this.c2 == 40)
            this.newID = 514;
          else if (this.c1 == 18 && this.c2 == 18)
            this.newID = 51;
          else if (this.c1 == 71 && this.c2 == 3)
            this.newID = 602;
          else if (this.c1 == 3 && this.c2 == 71)
            this.newID = 602;
          else if (this.c1 == 18 && this.c2 == 50)
            this.newID = 517;
          else if (this.c1 == 50 && this.c2 == 18)
            this.newID = 517;
          else if (this.c1 == 19 && this.c2 == 19)
            this.newID = 82;
          else if (this.c1 == 20 && this.c2 == 20)
            this.newID = 94;
          else if (this.c1 == 81 && this.c2 == 81)
            this.newID = 71;
          else if (this.c1 == 2 && this.c2 == 82)
            this.newID = 77;
          else if (this.c1 == 82 && this.c2 == 2)
            this.newID = 77;
          else if (this.c1 == 77 && this.c2 == 30)
            this.newID = 78;
          else if (this.c1 == 30 && this.c2 == 77)
            this.newID = 78;
          else if (this.c1 == 77 && this.c2 == 31)
            this.newID = 79;
          else if (this.c1 == 31 && this.c2 == 77)
            this.newID = 79;
          else if (this.c1 == 77 && this.c2 == 81)
            this.newID = 80;
          else if (this.c1 == 81 && this.c2 == 77)
            this.newID = 80;
          else if (this.c1 == 69 && this.c2 == 3)
            this.newID = 600;
          else if (this.c1 == 3 && this.c2 == 69)
            this.newID = 600;
          else if (this.c1 == 70 && this.c2 == 3)
            this.newID = 601;
          else if (this.c1 == 3 && this.c2 == 70)
            this.newID = 601;
          else if (this.c1 == 30 && this.c2 == 30)
            this.newID = 69;
          else if (this.c1 == 31 && this.c2 == 31)
            this.newID = 70;
          else if (this.c1 == 26 && this.c2 == 50)
            this.newID = 517;
          else if (this.c1 == 50 && this.c2 == 26)
            this.newID = 517;
          else if (this.c1 == 24 && this.c2 == 50)
            this.newID = 516;
          else if (this.c1 == 50 && this.c2 == 24)
            this.newID = 516;
          else if (this.c1 == 60 && this.c2 == 60)
            this.newID = 61;
          else if (this.c1 == 51 && this.c2 == 51)
            this.newID = 50;
          else if (this.c1 == 27 && this.c2 == 50)
            this.newID = 518;
          else if (this.c1 == 50 && this.c2 == 27)
            this.newID = 518;
          else if (this.c1 == 29 && this.c2 == 29)
            this.newID = 68;
          else if (this.c1 == 27 && this.c2 == 3)
            this.newID = 28;
          else if (this.c1 == 3 && this.c2 == 27)
            this.newID = 28;
          else if (this.c1 == 28 && this.c2 == 29)
            this.newID = 515;
          else if (this.c1 == 29 && this.c2 == 28)
            this.newID = 515;
          else if (this.c1 == 12 && this.c2 == 12)
            this.newID = 32;
          else if (this.c1 == 13 && this.c2 == 13)
            this.newID = 33;
          else if (this.c1 == 14 && this.c2 == 14)
            this.newID = 34;
          else if (this.c1 == 39 && this.c2 == 39)
            this.newID = 40;
          else if (this.c1 == 32 && this.c2 == 24)
            this.newID = 503;
          else if (this.c1 == 24 && this.c2 == 32)
            this.newID = 503;
          else if (this.c1 == 32 && this.c2 == 26)
            this.newID = 504;
          else if (this.c1 == 26 && this.c2 == 32)
            this.newID = 504;
          else if (this.c1 == 32 && this.c2 == 27)
            this.newID = 505;
          else if (this.c1 == 27 && this.c2 == 32)
            this.newID = 505;
          else if (this.c1 == 24 && this.c2 == 33)
            this.newID = 506;
          else if (this.c1 == 33 && this.c2 == 24)
            this.newID = 506;
          else if (this.c1 == 33 && this.c2 == 26)
            this.newID = 507;
          else if (this.c1 == 26 && this.c2 == 33)
            this.newID = 507;
          else if (this.c1 == 33 && this.c2 == 27)
            this.newID = 508;
          else if (this.c1 == 27 && this.c2 == 33)
            this.newID = 508;
          else if (this.c1 == 24 && this.c2 == 34)
            this.newID = 509;
          else if (this.c1 == 34 && this.c2 == 24)
            this.newID = 509;
          else if (this.c1 == 34 && this.c2 == 26)
            this.newID = 510;
          else if (this.c1 == 26 && this.c2 == 34)
            this.newID = 510;
          else if (this.c1 == 34 && this.c2 == 27)
            this.newID = 511;
          else if (this.c1 == 27 && this.c2 == 34)
            this.newID = 511;
          else if (this.c1 == 26 && this.c2 == 35)
            this.newID = 560;
          else if (this.c1 == 35 && this.c2 == 26)
            this.newID = 560;
          else if (this.c1 == 26 && this.c2 == 36)
            this.newID = 561;
          else if (this.c1 == 36 && this.c2 == 26)
            this.newID = 561;
          else if (this.c1 == 26 && this.c2 == 37)
            this.newID = 562;
          else if (this.c1 == 37 && this.c2 == 26)
            this.newID = 562;
          else if (this.c1 == 26 && this.c2 == 41)
            this.newID = 563;
          else if (this.c1 == 41 && this.c2 == 26)
            this.newID = 563;
          else if (this.c1 == 567 && this.c2 == 71)
            this.newID = 568;
          else if (this.c1 == 71 && this.c2 == 567)
            this.newID = 568;
          else if (this.c1 == 567 && this.c2 == 69)
            this.newID = 569;
          else if (this.c1 == 69 && this.c2 == 567)
            this.newID = 569;
          else if (this.c1 == 567 && this.c2 == 70)
            this.newID = 570;
          else if (this.c1 == 70 && this.c2 == 567)
            this.newID = 570;
          else if (this.c1 == 32 && this.c2 == 32)
            this.newID = 35;
          else if (this.c1 == 33 && this.c2 == 33)
            this.newID = 36;
          else if (this.c1 == 34 && this.c2 == 34)
            this.newID = 37;
          else if (this.c1 == 40 && this.c2 == 40)
            this.newID = 41;
          else if (this.c1 == 68 && this.c2 == 3)
            this.newID = 529;
          else if (this.c1 == 3 && this.c2 == 68)
            this.newID = 529;
          else if (this.c1 == 15 && this.c2 == 15)
            this.newID = 42;
          else if (this.c1 == 16 && this.c2 == 16)
            this.newID = 43;
          else if (this.c1 == 44 && this.c2 == 44)
            this.newID = 45;
          else if (this.c1 == 10 && this.c2 == 10)
            this.newID = 16;
          else if (this.c1 == 23 && this.c2 == 23)
            this.newID = 29;
          else if (this.c1 == 39 && this.c2 == 3)
            this.newID = 53;
          else if (this.c1 == 3 && this.c2 == 39)
            this.newID = 53;
          else if (this.c1 == 12 && this.c2 == 3)
            this.newID = 54;
          else if (this.c1 == 3 && this.c2 == 12)
            this.newID = 54;
          else if (this.c1 == 13 && this.c2 == 3)
            this.newID = 55;
          else if (this.c1 == 3 && this.c2 == 13)
            this.newID = 55;
          else if (this.c1 == 51 && this.c2 == 3)
            this.newID = 52;
          else if (this.c1 == 3 && this.c2 == 51)
            this.newID = 52;
          else if (this.c1 == 3 && this.c2 == 14)
            this.newID = 56;
          else if (this.c1 == 14 && this.c2 == 3)
            this.newID = 56;
          else if (this.c1 == 47 && this.c2 == 47 || this.c1 == 38 && this.c2 == 47 || this.c1 == 47 && this.c2 == 38)
            this.newID = 48;
          else if (this.c1 == 9 && this.c2 == 10 || this.c1 == 10 && this.c2 == 9 || this.c1 == 9 && this.c2 == 11 || this.c1 == 11 && this.c2 == 9 || this.c1 == 10 && this.c2 == 11 || this.c1 == 11 && this.c2 == 10)
            this.newID = 44;
          else if (this.c1 == 44 && this.c2 == 44)
            this.newID = 45;
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
