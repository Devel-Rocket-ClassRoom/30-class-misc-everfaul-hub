using System;

class Money
{
    private readonly int Gold;
    private readonly int Silver;

    public Money(int Gold, int Silver)
    {
        this.Gold = Gold;
        this.Silver = Silver;
       

    }
    public Money Add(int gold, int silver)
    {
        return new Money(this.Gold + gold, this.Silver + silver);
    }
    public Money Subtract(int gold, int silver)
    {
        int newGold = Math.Max(0, this.Gold - gold);
        int newSilaver = Math.Max(0, this.Silver - silver);
        return new Money(newGold, newSilaver);
          
    }
    public override string ToString()
    {
       return($"{Gold}골드 {Silver}실버");
    }
}