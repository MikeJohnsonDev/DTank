using System;

namespace DFilter
{
	public enum GameEventType : int
	{
		MessageBox = 0x0004,

		LoginCharacter = 0x0013,

		[Obsolete]
		TransactionMessage = 0x0016,

		AllegianceInformation = 0x0020,

		FriendsListUpdate = 0x0021,

		InsertInventoryItem = 0x0022,

		WearItem = 0x0023,

		TitleList = 0x0029,

		SetTitle = 0x002B,

		[Obsolete]
		DirectChat = 0x0038,

		[Obsolete]
		AddSpellToSpellBookCastSpell = 0x004C,

		[Obsolete]
		DeleteSpellFromSpellBookObsolete = 0x004D,

		[Obsolete]
		AddEnchantment = 0x004E,

		[Obsolete]
		RemoveEnchantment = 0x004F,

		CloseContainer = 0x0052,

		ApproachVendor = 0x0062,

		[Obsolete]
		EndPortalStormObsolete = 0x009C,

		[Obsolete]
		MildPortalStormObsolete = 0x009D,

		[Obsolete]
		HeavyPortalStormObsolete = 0x009E,

		[Obsolete]
		PortalStormedObsolete = 0x009F,

		FailureToGiveItem = 0x00A0,

		FellowshipMemberQuit = 0x00A3,

		FellowshipMemberDismissed = 0x00A4,

		[Obsolete]
		QuitFellowship = 0x00A7,

		[Obsolete]
		CreateFellowshipObsolete = 0x00AF,

		[Obsolete]
		RecruitMember = 0x00B0,

		[Obsolete]
		DismissMember = 0x00B1,

		[Obsolete]
		DisbandFellowshipObsolete = 0x00B3,

		ReadTableOfContents = 0x00B4,

		ReadPage = 0x00B8,

		IdentifyObject = 0x00C9,

		GroupChat = 0x0147,

		[Obsolete]
		GroupChatObsolete = 0x014A,

		SetPackContents = 0x0196,

		DropFromInventory = 0x019A,

		[Obsolete]
		RemoveEnchantmentSilent = 0x01A4,

		[Obsolete]
		RemoveMultipleEnchantmentsObsolete = 0x01A6,

		AttackCompleted = 0x01A7,

		DeleteSpellFromSpellBook = 0x01A8,

		YourDeath = 0x01AC,

		KillDeathMessage = 0x01AD,

		[Obsolete]
		RemoveMultipleEnchantmentsObsolete2 = 0x01AE,

		InflictMeleeDamage = 0x01B1,

		ReceiveMeleeDamage = 0x01B2,

		OtherMeleeEvade = 0x01B3,

		SelfMeleeEvade = 0x01B4,

		StartMeleeAttack = 0x01B8,

		UpdateHealth = 0x01C0,

		AgeCommandResult = 0x01C3,

		ReadyPreviousActionComplete = 0x01C7,

		UpdateAllegianceInfo = 0x01C8,

		CloseAssessPanel = 0x01CB,

		PingReply = 0x01EA,

		SquelchedUsersList = 0x01F4,

		EnterTrade = 0x01FD,

		EndTrade = 0x01FF,

		AddTradeItem = 0x0200,

		AcceptTrade = 0x0202,

		UnAcceptTrade = 0x0203,

		ResetTrade = 0x0205,

		FailureToAddATradeItem = 0x0207,

		FailureToCompleteATrade = 0x0208,

		DisplayDwellingPurchaseMaintenancePanel = 0x021D,

		HouseInformationForOwners = 0x0225,

		HouseInformationForNonOwners = 0x0226,

		HouseGuestList = 0x0257,

		UpdateItemManaBar = 0x0264,

		HousesAvailable = 0x0271,

		ConfirmationPanel = 0x0274,

		ConfirmationPanelClosed = 0x0276,

		AllegianceMemberLoginOut = 0x027A,

		DisplayStatusMessage = 0x028A,

		DisplayParameterizedStatusMessage = 0x028B,

		SetTurbineChatChannels = 0x0295,

		Tell = 0x02BD,

		CreateFellowship = 0x02BE,

		DisbandFellowship = 0x02BF,

		AddFellowshipMember = 0x02C0,

		AddSpellToSpellBook = 0x02C1,

		AddCharacterEnchantment = 0x02C2,

		RemoveCharacterEnchantment = 0x02C3,

		RemoveMultipleCharacterEnchantments = 0x02C5,

		RemoveAllCharacterEnchantmentsSilent = 0x02C6,

		RemoveCharacterEnchantmentSilent = 0x02C7,

		RemoveMultipleCharacterEnchantmentsSilent = 0x02C8,

		MildPortalStorm = 0x02C9,

		HeavyPortalStorm = 0x02CA,

		PortalStormed = 0x02CB,

		EndPortalStorm = 0x02CC,

		StatusMessage = 0x02EB
	}
}