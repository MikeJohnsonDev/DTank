using System;

namespace DFilter
{
	public enum ServerMessageType : int
	{
		DestroyObject = 0x0024,

		[Obsolete]
		LocalChat = 0x0037,

		[Obsolete]
		Attack = 0x005E,

		AdjustStackSize = 0x0197,

		PlayerKilled = 0x019E,

		[Obsolete]
		BroadcastText = 0x01B5,

		IndirectText = 0x01E0,

		EmoteText = 0x01E2,

		[Obsolete]
		SetCoverage = 0x0229,

		[Obsolete]
		SetCharacterFlag = 0x022C,

		[Obsolete]
		SetWielderContainer = 0x022D,

		[Obsolete]
		SetObjectResourceObsolete = 0x022E,

		[Obsolete]
		UpdateStatistic = 0x0237,

		[Obsolete]
		UpdateLastAttacker = 0x023B,

		[Obsolete]
		UpdateLastCorpseLocation = 0x023D,

		[Obsolete]
		SkillExperience = 0x023E,

		[Obsolete]
		TrainSkill = 0x0240,

		[Obsolete]
		UpdateAttribute = 0x0241,

		[Obsolete]
		UpdateSecondaryAttribute = 0x0243,

		[Obsolete]
		VitalStatisticUpdate = 0x0244,

		CreatureMessage = 0x02BB,

		CreatureMessageRanged = 0x02BC,

		SetCharacterDWord = 0x02CD,

		SetObjectDWord = 0x02CE,

		SetCharacterQWord = 0x02CF,

		SetCharacterBoolean = 0x02D1,

		SetObjectBoolean = 0x02D2,

		SetObjectString = 0x02D6,

		SetObjectResource = 0x02D8,

		SetCharacterLink = 0x02D9,

		SetObjectLink = 0x02DA,

		SetCharacterPosition = 0x02DB,

		SetCharacterSkillLevel = 0x02DD,

		SetCharacterSkillState = 0x02E1,

		SetCharacterAttribute = 0x02E3,

		SetCharacterVital = 0x02E7,

		SetCharacterCurrentVital = 0x02E9,

		LifestoneMaterialize = 0xF619,

		ChangeModel = 0xF625,

		[Obsolete]
		ServerText = 0xF62C,

		CharacterCreationInitialization = 0xF643,

		End3DMode = 0xF653,

		CharacterDeletion = 0xF655,

		RequestLogin = 0xF657,

		CharacterList = 0xF658,

		CharacterListFailure = 0xF659,

		[Obsolete]
		MessageOfTheDay = 0xF65A,

		CreateObject = 0xF745,

		LoginCharacter = 0xF746,

		RemoveItem = 0xF747,

		SetPositionAndMotion = 0xF748,

		WieldObject = 0xF749,

		MoveObjectIntoInventory = 0xF74A,

		ToggleObjectVisibility = 0xF74B,

		Animation = 0xF74C,

		Jumping = 0xF74E,

		ApplySoundEffect = 0xF750,

		EnterPortalMode = 0xF751,

		ApplyVisualSoundEffect = 0xF755,

		GameEvent = 0xF7B0,

		[Obsolete]
		Start3DModeObsolete = 0xF7C7,

		EnterGame = 0xF7C8,

		UpdateObject = 0xF7DB,

		TurbineChat = 0xF7DE,

		Start3DMode = 0xF7DF,

		ServerMessage = 0xF7E0,

		ServerName = 0xF7E1,

		UpdateResource = 0xF7E2,

		DatFilePatchList = 0xF7E7
	}
}