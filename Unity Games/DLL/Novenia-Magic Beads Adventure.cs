//Game: Novenia-Magic Beads Adventure
//Version: 1.5.1
//APK: https://www.apkmonk.com/app/com.enjoygame.nwnyen/

//Dump hidden dll from memory. Assembly name called scriptdll. Rename it to DOTween43.dll

//Calling Mod menu
//Class: UIRoot
public void OnGUI()
{
	ModMenu.ButtonMenu();
}

//Class: FighterInfo
//x10 dmg 
public int baseAtk
		{
			get
			{
				if (ModMenu.hack1 && this.isAteam())
				{
					return this.invariants.baseAtk * 15;
				}
				return this.invariants.baseAtk;
			}
		}
		
//High HP
public int baseHp
		{
			get
			{
				if (ModMenu.hack2 && this.isAteam())
				{
					return this.invariants.baseHp * 100;
				}
				return this.invariants.baseHp;
			}
		}
