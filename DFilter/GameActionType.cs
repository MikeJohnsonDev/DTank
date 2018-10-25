namespace DFilter
{
	public enum GameActionType : int
	{
		SetSingleCharacterOption = 0x0005,

		SetAfkMessage = 0x0010,

		StoreItem = 0x0019,

		EquipItem = 0x001A,

		DropItem = 0x001B,

		UseItem = 0x0036,

		RaiseVital = 0x0044,

		RaiseAttribute = 0x0045,

		RaiseSkill = 0x0046,

		TrainSkill = 0x0047,

		CastSpell = 0x0048,

		CastSpellOnObject = 0x004A,

		Materialize = 0x00A1,

		GiveItem = 0x00CD,

		MakeShortcut = 0x019C,

		RemoveShortcut = 0x019D,

		SetCharacterOptions = 0x01A1,

		AddSpellToSpellBar = 0x01E3,

		RemoveSpellFromSpellBar = 0x01E4
	}
}