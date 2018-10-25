using Decal.Adapter;
using System;
using System.Reflection;

namespace DFilter
{
	[FriendlyName("DFilter")]
	public sealed class FilterCore : FilterBase
	{
		#region Public Fields + Events

		public event EventHandler GameEventLoginCharacter;

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

				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		private void DispatchGameEvent(Message message)
		{
			GameEventType gameEventType = (GameEventType)message["event"];

			switch (gameEventType)
			{
				case GameEventType.MessageBox:
					break;

				case GameEventType.LoginCharacter:
					DispatchGameEventLoginCharacter(message);
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

				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		private void DispatchGameEventLoginCharacter(Message message)
		{
			// NOT COMPLETE
			Host.Actions.AddChatText(string.Format("[DFilter v{0}] Initialized", Assembly.GetExecutingAssembly().GetName().Version),
									1, 1);

			GameEventLoginCharacter?.Invoke(this, EventArgs.Empty);
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

				default:
					throw new ArgumentOutOfRangeException();
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

				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		#endregion Private Methods
	}
}