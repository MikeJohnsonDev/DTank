using Decal.Adapter;
using System;
using System.Reflection;

namespace DFilter
{
	[FriendlyName("DFilter")]
	public sealed class FilterCore : FilterBase
	{
		#region Public Fields + Events

		public event EventHandler GameEvent_AcceptTrade;

		public event EventHandler GameEvent_AddCharacterEnchantment;

		public event EventHandler GameEvent_AddEnchantment;

		public event EventHandler GameEvent_AddFellowshipMember;

		public event EventHandler GameEvent_AddSpellToSpellBook;

		public event EventHandler GameEvent_AddSpellToSpellBookCastSpell;

		public event EventHandler GameEvent_AddTradeItem;

		public event EventHandler GameEvent_AgeCommandResult;

		public event EventHandler GameEvent_AllegianceInformation;

		public event EventHandler GameEvent_AllegianceMemberLoginOut;

		public event EventHandler GameEvent_ApproachVendor;

		public event EventHandler GameEvent_AttackCompleted;

		public event EventHandler GameEvent_CloseAssessPanel;

		public event EventHandler GameEvent_CloseContainer;

		public event EventHandler GameEvent_ConfirmationPanel;

		public event EventHandler GameEvent_ConfirmationPanelClosed;

		public event EventHandler GameEvent_CreateFellowship;

		public event EventHandler GameEvent_CreateFellowshipObsolete;

		public event EventHandler GameEvent_DeleteSpellFromSpellBook;

		public event EventHandler GameEvent_DeleteSpellFromSpellBookObsolete;

		public event EventHandler GameEvent_DirectChat;

		public event EventHandler GameEvent_DisbandFellowship;

		public event EventHandler GameEvent_DisbandFellowshipObsolete;

		public event EventHandler GameEvent_DismissMember;

		public event EventHandler GameEvent_DisplayDwellingPurchaseMaintenancePanel;

		public event EventHandler GameEvent_DisplayParameterizedStatusMessage;

		public event EventHandler GameEvent_DisplayStatusMessage;

		public event EventHandler GameEvent_DropFromInventory;

		public event EventHandler GameEvent_EndPortalStorm;

		public event EventHandler GameEvent_EndPortalStormObsolete;

		public event EventHandler GameEvent_EndTrade;

		public event EventHandler GameEvent_EnterTrade;

		public event EventHandler GameEvent_FailureToAddATradeItem;

		public event EventHandler GameEvent_FailureToCompleteATrade;

		public event EventHandler GameEvent_FailureToGiveItem;

		public event EventHandler GameEvent_FellowshipMemberDismissed;

		public event EventHandler GameEvent_FellowshipMemberQuit;

		public event EventHandler GameEvent_FriendsListUpdate;

		public event EventHandler GameEvent_GroupChat;

		public event EventHandler GameEvent_GroupChatObsolete;

		public event EventHandler GameEvent_HeavyPortalStorm;

		public event EventHandler GameEvent_HeavyPortalStormObsolete;

		public event EventHandler GameEvent_HouseGuestList;

		public event EventHandler GameEvent_HouseInformationForNonOwners;

		public event EventHandler GameEvent_HouseInformationForOwners;

		public event EventHandler GameEvent_HousesAvailable;

		public event EventHandler GameEvent_IdentifyObject;

		public event EventHandler GameEvent_InflictMeleeDamage;

		public event EventHandler GameEvent_InsertInventoryItem;

		public event EventHandler GameEvent_KillDeathMessage;

		public event EventHandler GameEvent_LoginCharacter;

		public event EventHandler GameEvent_MessageBox;

		public event EventHandler GameEvent_MildPortalStorm;

		public event EventHandler GameEvent_MildPortalStormObsolete;

		public event EventHandler GameEvent_OtherMeleeEvade;

		public event EventHandler GameEvent_PingReply;

		public event EventHandler GameEvent_PortalStormed;

		public event EventHandler GameEvent_PortalStormedObsolete;

		public event EventHandler GameEvent_QuitFellowship;

		public event EventHandler GameEvent_ReadPage;

		public event EventHandler GameEvent_ReadTableOfContents;

		public event EventHandler GameEvent_ReadyPreviousActionComplete;

		public event EventHandler GameEvent_ReceiveMeleeDamage;

		public event EventHandler GameEvent_RecruitMember;

		public event EventHandler GameEvent_RemoveAllCharacterEnchantmentsSilent;

		public event EventHandler GameEvent_RemoveCharacterEnchantment;

		public event EventHandler GameEvent_RemoveCharacterEnchantmentSilent;

		public event EventHandler GameEvent_RemoveEnchantment;

		public event EventHandler GameEvent_RemoveEnchantmentSilent;

		public event EventHandler GameEvent_RemoveMultipleCharacterEnchantments;

		public event EventHandler GameEvent_RemoveMultipleCharacterEnchantmentsSilent;

		public event EventHandler GameEvent_RemoveMultipleEnchantmentsObsolete;

		public event EventHandler GameEvent_RemoveMultipleEnchantmentsObsolete2;

		public event EventHandler GameEvent_ResetTrade;

		public event EventHandler GameEvent_SelfMeleeEvade;

		public event EventHandler GameEvent_SetPackContents;

		public event EventHandler GameEvent_SetTitle;

		public event EventHandler GameEvent_SetTurbineChatChannels;

		public event EventHandler GameEvent_SquelchedUsersList;

		public event EventHandler GameEvent_StartMeleeAttack;

		public event EventHandler GameEvent_StatusMessage;

		public event EventHandler GameEvent_Tell;

		public event EventHandler GameEvent_TitleList;

		public event EventHandler GameEvent_TransactionMessage;

		public event EventHandler GameEvent_UnAcceptTrade;

		public event EventHandler GameEvent_UpdateAllegianceInfo;

		public event EventHandler GameEvent_UpdateHealth;

		public event EventHandler GameEvent_UpdateItemManaBar;

		public event EventHandler GameEvent_WearItem;

		public event EventHandler GameEvent_YourDeath;

		#endregion Public Fields + Events

		#region Protected Methods

		protected override void Shutdown()
		{
		}

		protected override void Startup()
		{
			ClientDispatch += OnClientDispatch;
			ServerDispatch += OnServerDispatch;
		}

		#endregion Protected Methods

		#region Private Methods

		private void DispatchGameAction(Message message)
		{
			GameActionType gameActionType = (GameActionType)message["action"];

			switch (gameActionType)
			{
				case GameActionType.SetSingleCharacterOption:
					break;

				case GameActionType.SetAfkMessage:
					break;

				case GameActionType.StoreItem:
					break;

				case GameActionType.EquipItem:
					break;

				case GameActionType.DropItem:
					break;

				case GameActionType.UseItem:
					break;

				case GameActionType.RaiseVital:
					break;

				case GameActionType.RaiseAttribute:
					break;

				case GameActionType.RaiseSkill:
					break;

				case GameActionType.TrainSkill:
					break;

				case GameActionType.CastSpell:
					break;

				case GameActionType.CastSpellOnObject:
					break;

				case GameActionType.Materialize:
					break;

				case GameActionType.GiveItem:
					break;

				case GameActionType.MakeShortcut:
					break;

				case GameActionType.RemoveShortcut:
					break;

				case GameActionType.SetCharacterOptions:
					break;

				case GameActionType.AddSpellToSpellBar:
					break;

				case GameActionType.RemoveSpellFromSpellBar:
					break;
			}
		}

		private void DispatchGameEvent(Message message)
		{
			GameEventType gameEventType = (GameEventType)message["event"];

			switch (gameEventType)
			{
				case GameEventType.MessageBox:
					DispatchGameEvent_MessageBox(message);
					break;

				case GameEventType.LoginCharacter:
					DispatchGameEvent_LoginCharacter(message);
					break;

				case GameEventType.TransactionMessage:
					break;

				case GameEventType.AllegianceInformation:
					break;

				case GameEventType.FriendsListUpdate:
					break;

				case GameEventType.InsertInventoryItem:
					break;

				case GameEventType.WearItem:
					break;

				case GameEventType.TitleList:
					break;

				case GameEventType.SetTitle:
					break;

				case GameEventType.DirectChat:
					break;

				case GameEventType.AddSpellToSpellBookCastSpell:
					break;

				case GameEventType.DeleteSpellFromSpellBookObsolete:
					break;

				case GameEventType.AddEnchantment:
					break;

				case GameEventType.RemoveEnchantment:
					break;

				case GameEventType.CloseContainer:
					break;

				case GameEventType.ApproachVendor:
					break;

				case GameEventType.EndPortalStormObsolete:
					break;

				case GameEventType.MildPortalStormObsolete:
					break;

				case GameEventType.HeavyPortalStormObsolete:
					break;

				case GameEventType.PortalStormedObsolete:
					break;

				case GameEventType.FailureToGiveItem:
					break;

				case GameEventType.FellowshipMemberQuit:
					break;

				case GameEventType.FellowshipMemberDismissed:
					break;

				case GameEventType.QuitFellowship:
					break;

				case GameEventType.CreateFellowshipObsolete:
					break;

				case GameEventType.RecruitMember:
					break;

				case GameEventType.DismissMember:
					break;

				case GameEventType.DisbandFellowshipObsolete:
					break;

				case GameEventType.ReadTableOfContents:
					break;

				case GameEventType.ReadPage:
					break;

				case GameEventType.IdentifyObject:
					break;

				case GameEventType.GroupChat:
					break;

				case GameEventType.GroupChatObsolete:
					break;

				case GameEventType.SetPackContents:
					break;

				case GameEventType.DropFromInventory:
					break;

				case GameEventType.RemoveEnchantmentSilent:
					break;

				case GameEventType.RemoveMultipleEnchantmentsObsolete:
					break;

				case GameEventType.AttackCompleted:
					break;

				case GameEventType.DeleteSpellFromSpellBook:
					break;

				case GameEventType.YourDeath:
					break;

				case GameEventType.KillDeathMessage:
					break;

				case GameEventType.RemoveMultipleEnchantmentsObsolete2:
					break;

				case GameEventType.InflictMeleeDamage:
					break;

				case GameEventType.ReceiveMeleeDamage:
					break;

				case GameEventType.OtherMeleeEvade:
					break;

				case GameEventType.SelfMeleeEvade:
					break;

				case GameEventType.StartMeleeAttack:
					break;

				case GameEventType.UpdateHealth:
					break;

				case GameEventType.AgeCommandResult:
					break;

				case GameEventType.ReadyPreviousActionComplete:
					break;

				case GameEventType.UpdateAllegianceInfo:
					break;

				case GameEventType.CloseAssessPanel:
					break;

				case GameEventType.PingReply:
					break;

				case GameEventType.SquelchedUsersList:
					break;

				case GameEventType.EnterTrade:
					break;

				case GameEventType.EndTrade:
					break;

				case GameEventType.AddTradeItem:
					break;

				case GameEventType.AcceptTrade:
					break;

				case GameEventType.UnAcceptTrade:
					break;

				case GameEventType.ResetTrade:
					break;

				case GameEventType.FailureToAddATradeItem:
					break;

				case GameEventType.FailureToCompleteATrade:
					break;

				case GameEventType.DisplayDwellingPurchaseMaintenancePanel:
					break;

				case GameEventType.HouseInformationForOwners:
					break;

				case GameEventType.HouseInformationForNonOwners:
					break;

				case GameEventType.HouseGuestList:
					break;

				case GameEventType.UpdateItemManaBar:
					break;

				case GameEventType.HousesAvailable:
					break;

				case GameEventType.ConfirmationPanel:
					break;

				case GameEventType.ConfirmationPanelClosed:
					break;

				case GameEventType.AllegianceMemberLoginOut:
					break;

				case GameEventType.DisplayStatusMessage:
					break;

				case GameEventType.DisplayParameterizedStatusMessage:
					break;

				case GameEventType.SetTurbineChatChannels:
					break;

				case GameEventType.Tell:
					break;

				case GameEventType.CreateFellowship:
					break;

				case GameEventType.DisbandFellowship:
					break;

				case GameEventType.AddFellowshipMember:
					break;

				case GameEventType.AddSpellToSpellBook:
					break;

				case GameEventType.AddCharacterEnchantment:
					break;

				case GameEventType.RemoveCharacterEnchantment:
					break;

				case GameEventType.RemoveMultipleCharacterEnchantments:
					break;

				case GameEventType.RemoveAllCharacterEnchantmentsSilent:
					break;

				case GameEventType.RemoveCharacterEnchantmentSilent:
					break;

				case GameEventType.RemoveMultipleCharacterEnchantmentsSilent:
					break;

				case GameEventType.MildPortalStorm:
					break;

				case GameEventType.HeavyPortalStorm:
					break;

				case GameEventType.PortalStormed:
					break;

				case GameEventType.EndPortalStorm:
					break;

				case GameEventType.StatusMessage:
					break;
			}
		}

		private void DispatchGameEvent_AcceptTrade(Message message)
		{
			// NOT COMPLETE
			GameEvent_AcceptTrade?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_AddCharacterEnchantment(Message message)
		{
			// NOT COMPLETE
			GameEvent_AddCharacterEnchantment?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_AddEnchantment(Message message)
		{
			// NOT COMPLETE
			GameEvent_AddEnchantment?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_AddFellowshipMember(Message message)
		{
			// NOT COMPLETE
			GameEvent_AddFellowshipMember?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_AddSpellToSpellBook(Message message)
		{
			// NOT COMPLETE
			GameEvent_AddSpellToSpellBook?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_AddSpellToSpellBookCastSpell(Message message)
		{
			// NOT COMPLETE
			GameEvent_AddSpellToSpellBookCastSpell?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_AddTradeItem(Message message)
		{
			// NOT COMPLETE
			GameEvent_AddTradeItem?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_AgeCommandResult(Message message)
		{
			// NOT COMPLETE
			GameEvent_AgeCommandResult?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_AllegianceInformation(Message message)
		{
			// NOT COMPLETE
			GameEvent_AllegianceInformation?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_AllegianceMemberLoginOut(Message message)
		{
			// NOT COMPLETE
			GameEvent_AllegianceMemberLoginOut?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_ApproachVendor(Message message)
		{
			// NOT COMPLETE
			GameEvent_ApproachVendor?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_AttackCompleted(Message message)
		{
			// NOT COMPLETE
			GameEvent_AttackCompleted?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_CloseAssessPanel(Message message)
		{
			// NOT COMPLETE
			GameEvent_CloseAssessPanel?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_CloseContainer(Message message)
		{
			// NOT COMPLETE
			GameEvent_CloseContainer?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_ConfirmationPanel(Message message)
		{
			// NOT COMPLETE
			GameEvent_ConfirmationPanel?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_ConfirmationPanelClosed(Message message)
		{
			// NOT COMPLETE
			GameEvent_ConfirmationPanelClosed?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_CreateFellowship(Message message)
		{
			// NOT COMPLETE
			GameEvent_CreateFellowship?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_CreateFellowshipObsolete(Message message)
		{
			// NOT COMPLETE
			GameEvent_CreateFellowshipObsolete?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_DeleteSpellFromSpellBook(Message message)
		{
			// NOT COMPLETE
			GameEvent_DeleteSpellFromSpellBook?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_DeleteSpellFromSpellBookObsolete(Message message)
		{
			// NOT COMPLETE
			GameEvent_DeleteSpellFromSpellBookObsolete?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_DirectChat(Message message)
		{
			// NOT COMPLETE
			GameEvent_DirectChat?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_DisbandFellowship(Message message)
		{
			// NOT COMPLETE
			GameEvent_DisbandFellowship?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_DisbandFellowshipObsolete(Message message)
		{
			// NOT COMPLETE
			GameEvent_DisbandFellowshipObsolete?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_DismissMember(Message message)
		{
			// NOT COMPLETE
			GameEvent_DismissMember?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_DisplayDwellingPurchaseMaintenancePanel(Message message)
		{
			// NOT COMPLETE
			GameEvent_DisplayDwellingPurchaseMaintenancePanel?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_DisplayParameterizedStatusMessage(Message message)
		{
			// NOT COMPLETE
			GameEvent_DisplayParameterizedStatusMessage?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_DisplayStatusMessage(Message message)
		{
			// NOT COMPLETE
			GameEvent_DisplayStatusMessage?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_DropFromInventory(Message message)
		{
			// NOT COMPLETE
			GameEvent_DropFromInventory?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_EndPortalStorm(Message message)
		{
			// NOT COMPLETE
			GameEvent_EndPortalStorm?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_EndPortalStormObsolete(Message message)
		{
			// NOT COMPLETE
			GameEvent_EndPortalStormObsolete?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_EndTrade(Message message)
		{
			// NOT COMPLETE
			GameEvent_EndTrade?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_EnterTrade(Message message)
		{
			// NOT COMPLETE
			GameEvent_EnterTrade?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_FailureToAddATradeItem(Message message)
		{
			// NOT COMPLETE
			GameEvent_FailureToAddATradeItem?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_FailureToCompleteATrade(Message message)
		{
			// NOT COMPLETE
			GameEvent_FailureToCompleteATrade?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_FailureToGiveItem(Message message)
		{
			// NOT COMPLETE
			GameEvent_FailureToGiveItem?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_FellowshipMemberDismissed(Message message)
		{
			// NOT COMPLETE
			GameEvent_FellowshipMemberDismissed?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_FellowshipMemberQuit(Message message)
		{
			// NOT COMPLETE
			GameEvent_FellowshipMemberQuit?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_FriendsListUpdate(Message message)
		{
			// NOT COMPLETE
			GameEvent_FriendsListUpdate?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_GroupChat(Message message)
		{
			// NOT COMPLETE
			GameEvent_GroupChat?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_GroupChatObsolete(Message message)
		{
			// NOT COMPLETE
			GameEvent_GroupChatObsolete?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_HeavyPortalStorm(Message message)
		{
			// NOT COMPLETE
			GameEvent_HeavyPortalStorm?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_HeavyPortalStormObsolete(Message message)
		{
			// NOT COMPLETE
			GameEvent_HeavyPortalStormObsolete?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_HouseGuestList(Message message)
		{
			// NOT COMPLETE
			GameEvent_HouseGuestList?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_HouseInformationForNonOwners(Message message)
		{
			// NOT COMPLETE
			GameEvent_HouseInformationForNonOwners?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_HouseInformationForOwners(Message message)
		{
			// NOT COMPLETE
			GameEvent_HouseInformationForOwners?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_HousesAvailable(Message message)
		{
			// NOT COMPLETE
			GameEvent_HousesAvailable?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_IdentifyObject(Message message)
		{
			// NOT COMPLETE
			GameEvent_IdentifyObject?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_InflictMeleeDamage(Message message)
		{
			// NOT COMPLETE
			GameEvent_InflictMeleeDamage?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_InsertInventoryItem(Message message)
		{
			// NOT COMPLETE
			GameEvent_InsertInventoryItem?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_KillDeathMessage(Message message)
		{
			// NOT COMPLETE
			GameEvent_KillDeathMessage?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_LoginCharacter(Message message)
		{
			// NOT COMPLETE
			Host.Actions.AddChatText(string.Format("[DFilter v{0}] Initialized", Assembly.GetExecutingAssembly().GetName().Version),
									1, 1);

			GameEvent_LoginCharacter?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_MessageBox(Message message)
		{
			// NOT COMPLETE
			GameEvent_MessageBox?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_MildPortalStorm(Message message)
		{
			// NOT COMPLETE
			GameEvent_MildPortalStorm?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_MildPortalStormObsolete(Message message)
		{
			// NOT COMPLETE
			GameEvent_MildPortalStormObsolete?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_OtherMeleeEvade(Message message)
		{
			// NOT COMPLETE
			GameEvent_OtherMeleeEvade?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_PingReply(Message message)
		{
			// NOT COMPLETE
			GameEvent_PingReply?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_PortalStormed(Message message)
		{
			// NOT COMPLETE
			GameEvent_PortalStormed?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_PortalStormedObsolete(Message message)
		{
			// NOT COMPLETE
			GameEvent_PortalStormedObsolete?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_QuitFellowship(Message message)
		{
			// NOT COMPLETE
			GameEvent_QuitFellowship?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_ReadPage(Message message)
		{
			// NOT COMPLETE
			GameEvent_ReadPage?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_ReadTableOfContents(Message message)
		{
			// NOT COMPLETE
			GameEvent_ReadTableOfContents?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_ReadyPreviousActionComplete(Message message)
		{
			// NOT COMPLETE
			GameEvent_ReadyPreviousActionComplete?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_ReceiveMeleeDamage(Message message)
		{
			// NOT COMPLETE
			GameEvent_ReceiveMeleeDamage?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_RecruitMember(Message message)
		{
			// NOT COMPLETE
			GameEvent_RecruitMember?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_RemoveAllCharacterEnchantmentsSilent(Message message)
		{
			// NOT COMPLETE
			GameEvent_RemoveAllCharacterEnchantmentsSilent?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_RemoveCharacterEnchantment(Message message)
		{
			// NOT COMPLETE
			GameEvent_RemoveCharacterEnchantment?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_RemoveCharacterEnchantmentSilent(Message message)
		{
			// NOT COMPLETE
			GameEvent_RemoveCharacterEnchantmentSilent?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_RemoveEnchantment(Message message)
		{
			// NOT COMPLETE
			GameEvent_RemoveEnchantment?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_RemoveEnchantmentSilent(Message message)
		{
			// NOT COMPLETE
			GameEvent_RemoveEnchantmentSilent?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_RemoveMultipleCharacterEnchantments(Message message)
		{
			// NOT COMPLETE
			GameEvent_RemoveMultipleCharacterEnchantments?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_RemoveMultipleCharacterEnchantmentsSilent(Message message)
		{
			// NOT COMPLETE
			GameEvent_RemoveMultipleCharacterEnchantmentsSilent?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_RemoveMultipleEnchantmentsObsolete(Message message)
		{
			// NOT COMPLETE
			GameEvent_RemoveMultipleEnchantmentsObsolete?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_RemoveMultipleEnchantmentsObsolete2(Message message)
		{
			// NOT COMPLETE
			GameEvent_RemoveMultipleEnchantmentsObsolete2?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_ResetTrade(Message message)
		{
			// NOT COMPLETE
			GameEvent_ResetTrade?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_SelfMeleeEvade(Message message)
		{
			// NOT COMPLETE
			GameEvent_SelfMeleeEvade?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_SetPackContents(Message message)
		{
			// NOT COMPLETE
			GameEvent_SetPackContents?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_SetTitle(Message message)
		{
			// NOT COMPLETE
			GameEvent_SetTitle?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_SetTurbineChatChannels(Message message)
		{
			// NOT COMPLETE
			GameEvent_SetTurbineChatChannels?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_SquelchedUsersList(Message message)
		{
			// NOT COMPLETE
			GameEvent_SquelchedUsersList?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_StartMeleeAttack(Message message)
		{
			// NOT COMPLETE
			GameEvent_StartMeleeAttack?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_StatusMessage(Message message)
		{
			// NOT COMPLETE
			GameEvent_StatusMessage?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_Tell(Message message)
		{
			// NOT COMPLETE
			GameEvent_Tell?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_TitleList(Message message)
		{
			// NOT COMPLETE
			GameEvent_TitleList?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_TransactionMessage(Message message)
		{
			// NOT COMPLETE
			GameEvent_TransactionMessage?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_UnAcceptTrade(Message message)
		{
			// NOT COMPLETE
			GameEvent_UnAcceptTrade?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_UpdateAllegianceInfo(Message message)
		{
			// NOT COMPLETE
			GameEvent_UpdateAllegianceInfo?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_UpdateHealth(Message message)
		{
			// NOT COMPLETE
			GameEvent_UpdateHealth?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_UpdateItemManaBar(Message message)
		{
			// NOT COMPLETE
			GameEvent_UpdateItemManaBar?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_WearItem(Message message)
		{
			// NOT COMPLETE
			GameEvent_WearItem?.Invoke(this, EventArgs.Empty);
		}

		private void DispatchGameEvent_YourDeath(Message message)
		{
			// NOT COMPLETE
			GameEvent_YourDeath?.Invoke(this, EventArgs.Empty);
		}

		/// <summary>
		/// Messages from client to server.
		/// </summary>
		/// <param name="message"></param>
		private void OnClientDispatch(object sender, NetworkMessageEventArgs e)
		{
			ClientMessageType clientMessageType = (ClientMessageType)e.Message.Type;

			switch (clientMessageType)
			{
				case ClientMessageType.GameAction:
					DispatchGameAction(e.Message);
					break;
			}
		}

		/// <summary>
		/// Messages from server to client.
		/// </summary>
		/// <param name="message"></param>
		private void OnServerDispatch(object sender, NetworkMessageEventArgs e)
		{
			ServerMessageType serverMessageType = (ServerMessageType)e.Message.Type;

			switch (serverMessageType)
			{
				case ServerMessageType.DestroyObject:
					break;

				case ServerMessageType.LocalChat:
					break;

				case ServerMessageType.Attack:
					break;

				case ServerMessageType.AdjustStackSize:
					break;

				case ServerMessageType.PlayerKilled:
					break;

				case ServerMessageType.BroadcastText:
					break;

				case ServerMessageType.IndirectText:
					break;

				case ServerMessageType.EmoteText:
					break;

				case ServerMessageType.SetCoverage:
					break;

				case ServerMessageType.SetCharacterFlag:
					break;

				case ServerMessageType.SetWielderContainer:
					break;

				case ServerMessageType.SetObjectResourceObsolete:
					break;

				case ServerMessageType.UpdateStatistic:
					break;

				case ServerMessageType.UpdateLastAttacker:
					break;

				case ServerMessageType.UpdateLastCorpseLocation:
					break;

				case ServerMessageType.SkillExperience:
					break;

				case ServerMessageType.TrainSkill:
					break;

				case ServerMessageType.UpdateAttribute:
					break;

				case ServerMessageType.UpdateSecondaryAttribute:
					break;

				case ServerMessageType.VitalStatisticUpdate:
					break;

				case ServerMessageType.CreatureMessage:
					break;

				case ServerMessageType.CreatureMessageRanged:
					break;

				case ServerMessageType.SetCharacterDWord:
					break;

				case ServerMessageType.SetObjectDWord:
					break;

				case ServerMessageType.SetCharacterQWord:
					break;

				case ServerMessageType.SetCharacterBoolean:
					break;

				case ServerMessageType.SetObjectBoolean:
					break;

				case ServerMessageType.SetObjectString:
					break;

				case ServerMessageType.SetObjectResource:
					break;

				case ServerMessageType.SetCharacterLink:
					break;

				case ServerMessageType.SetObjectLink:
					break;

				case ServerMessageType.SetCharacterPosition:
					break;

				case ServerMessageType.SetCharacterSkillLevel:
					break;

				case ServerMessageType.SetCharacterSkillState:
					break;

				case ServerMessageType.SetCharacterAttribute:
					break;

				case ServerMessageType.SetCharacterVital:
					break;

				case ServerMessageType.SetCharacterCurrentVital:
					break;

				case ServerMessageType.LifestoneMaterialize:
					break;

				case ServerMessageType.ChangeModel:
					break;

				case ServerMessageType.ServerText:
					break;

				case ServerMessageType.CharacterCreationInitialization:
					break;

				case ServerMessageType.End3DMode:
					break;

				case ServerMessageType.CharacterDeletion:
					break;

				case ServerMessageType.RequestLogin:
					break;

				case ServerMessageType.CharacterList:
					break;

				case ServerMessageType.CharacterListFailure:
					break;

				case ServerMessageType.MessageOfTheDay:
					break;

				case ServerMessageType.CreateObject:
					break;

				case ServerMessageType.LoginCharacter:
					break;

				case ServerMessageType.RemoveItem:
					break;

				case ServerMessageType.SetPositionAndMotion:
					break;

				case ServerMessageType.WieldObject:
					break;

				case ServerMessageType.MoveObjectIntoInventory:
					break;

				case ServerMessageType.ToggleObjectVisibility:
					break;

				case ServerMessageType.Animation:
					break;

				case ServerMessageType.Jumping:
					break;

				case ServerMessageType.ApplySoundEffect:
					break;

				case ServerMessageType.EnterPortalMode:
					break;

				case ServerMessageType.ApplyVisualSoundEffect:
					break;

				case ServerMessageType.GameEvent:
					DispatchGameEvent(e.Message);
					break;

				case ServerMessageType.Start3DModeObsolete:
					break;

				case ServerMessageType.EnterGame:
					break;

				case ServerMessageType.UpdateObject:
					break;

				case ServerMessageType.TurbineChat:
					break;

				case ServerMessageType.Start3DMode:
					break;

				case ServerMessageType.ServerMessage:
					break;

				case ServerMessageType.ServerName:
					break;

				case ServerMessageType.UpdateResource:
					break;

				case ServerMessageType.DatFilePatchList:
					break;
			}
		}

		#endregion Private Methods
	}
}