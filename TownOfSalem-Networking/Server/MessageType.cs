﻿namespace TownOfSalem_Networking.Server
{
    public enum MessageType
    {
        LoadHomePage = 0x1,
        CreateLobby = 0x2,
        SetHost = 0x3,
        UserJoinedGame = 0x4,
        UserLeftGame = 0x5,
        ChatBoxMessage = 0x6,
        HostClickedCatalog = 0x7,
        HostClickedPossibleRoles = 0x8,
        HostClickedAdd = 0x9,
        HostClickedRemove = 0xA,
        HostClickedStart = 0xB,
        CancelStart = 0xC,
        AssignNewHost = 0xD,
        VotedRepickHost = 0xE,
        NoLongerHost = 0xF,
        DoNotSpam = 0x10,
        HowManyPlayersAndGames = 0x11,
        SystemMessage = 0x12,
        StringTableMessage = 0x13,
        FriendList = 0x14,
        FriendRequestNotification = 0x15,
        AddFriendRequest = 0x16,
        ConfirmFriendRequest = 0x17,
        RemoveFriend = 0x18,
        DeclinedFriendRequest = 0x19,
        FriendUpdate = 0x1A,
        FriendMessage = 0x1B,
        UserInformation = 0x1C,
        CreatePartyLobby = 0x1D,
        PartyInviteFailed = 0x1E,
        PartyInviteNotification = 0x1F,
        AcceptedPartyInvite = 0x20,
        PendingPartyInviteStatus = 0x21,
        LeaveParty = 0x22,
        PartyChatMessage = 0x23,
        PartyMemberLeft = 0x24,
        SettingsInformation = 0x25,
        AddFriend = 0x26,
        _UNUSED_FORCED_LOGOUT = 0x27,
        ReturnToHome = 0x28,
        _UNUSED_SHOP_PURCHASE_ERROR = 0x29,
        _UNUSED_SHOP_PURCHASE_SUCCESS = 0x2A,
        PurchasedCharacters = 0x2B,
        PurchasedHouses = 0x2C,
        PurchasedBackgrounds = 0x2D,
        SelectionSettings = 0x2E,
        RedeemMessage = 0x2F,
        UpdateTownPoints = 0x30,
        PurchasedPacks = 0x31,
        PurchasedPets = 0x32,
        LastBonusWinTime = 0x33,
        EarnedAchievements = 0x34,
        PurchasedLobbyIcons = 0x35,
        PurchasedDeathAnimations = 0x36,
        _UNUSED_FACEBOOK_INVITE_FRIENDS = 0x37,
        PurchasedScrolls = 0x38,
        _UNUSED_SCROLL_PERCENTAGE = 0x39,
        NewPartyHostNotification = 0x3A,
        YouArePartyHost = 0x3B,
        PartyMemberKicked = 0x3C,
        KickedMeFromParty = 0x3D,
        PartyInvitePowerNotification = 0x3E,
        YouHavePartyInvitePower = 0x3F,
        SteamFirstLogin = 0x40,
        RegistrationFailure = 0x41,
        FriendsNewUsername = 0x42,
        EnableShopButtons = 0x43,
        SteamPopup = 0x44,
        SteamLoginAccountNotLinked = 0x45,
        SteamLoginAccountLinked = 0x46,
        StartRankedQueue = 0x47,
        LeaveRankedQueue = 0x48,
        AcceptRankedPopup = 0x49,
        UserStatistics = 0x4A,
        RankedTimeoutDuration = 0x4B,
        SuccessfulAccountCreation = 0x4C,
        ModeratorMessage = 0x4D,
        ReferAFriendUpdate = 0x4E,
        PlayerStatistics = 0x4F,
        ScrollConsumed = 0x50,
        _UNUSED_AD_VIEW_RESPONSE = 0x51,
        UserJoinTooFast = 0x52,
        PresentPromotion = 0x53,
        _UNUSED_KICKSTARTER_SHARE = 0x54,
        MobilePlayAdMessage = 0x55,
        TutorialStatus = 0x56,
        PurchasedTaunts = 0x57,
        CurrencyMultiplier = 0x58,
        PickNames = 0x5A,
        NamesAndPositions = 0x5B,
        RoleAndPosition = 0x5C,
        StartNight = 0x5D,
        StartDay = 0x5E,
        WhoDiedAndHow = 0x5F,
        StartDiscussion = 0x60,
        StartVoting = 0x61,
        StartDefenseTransition = 0x62,
        StartJudgement = 0x63,
        TrialGuilty = 0x64,
        TrialNotGuilty = 0x65,
        LookoutNightAbilityMessage = 0x66,
        UserVoted = 0x67,
        UserCanceledVote = 0x68,
        UserChangedVote = 0x69,
        UserDied = 0x6A,
        Resurrection = 0x6B,
        RoleList = 0x6C,
        UserChosenName = 0x6D,
        OtherMafia = 0x6E,
        TellTownAmnesiacChangedRole = 0x6F,
        AmnesiacChangedRole = 0x70,
        BroughtBackToLife = 0x71,
        StartFirstDay = 0x72,
        BeingJailed = 0x73,
        JailedTarget = 0x74,
        JudgementVoted = 0x75,
        ChangedJudgementVote = 0x76,
        CanceledJudgementVote = 0x77,
        TellJudgementVotes = 0x78,
        ExecutionerCompletedGoal = 0x79,
        JesterCompletedGoal = 0x7A,
        MayorRevealed = 0x7B,
        MayorRevealedAndAlreadyVoted = 0x7C,
        _UNUSED_DisguiserStoleYourIdentity = 0x7D,
        _UNUSED_DisguiserChangedIdentity = 0x7E,
        _UNUSED_DisguiserChangedUpdateMafia = 0x7F,
        MediumTalkingToUs = 0x80,
        MediumCommunicating = 0x81,
        TellLastWill = 0x82,
        HowManyAbilitiesLeft = 0x83,
        MafiaTargeting = 0x84,
        TellJanitorTargetsRole = 0x85,
        TellJanitorTargetsWill = 0x86,
        SomeoneHasWon = 0x87,
        MafiosoPromoted = 0x88,
        MafiosoPromotedTellMafia = 0x89,
        MafiaPromoted = 0x8A,
        MafiaPromotedTellMafia = 0x8B,
        ExecutionerConverted = 0x8C,
        AmnesiacConvertedToMafiaOrWitch = 0x8D,
        UserDisconnected = 0x8E,
        MafiaWasJailed = 0x8F,
        InvalidName = 0x90,
        StartNightTransition = 0x91,
        StartDayTransition = 0x92,
        LynchUser = 0x93,
        DeathNote = 0x94,
        _UNUSED_PICK_HOUSES = 0x95,
        HousesChosen = 0x96,
        FirstDayTransition = 0x97,
        CharactersChosen = 0x99,
        ResurrectionSetAlive = 0x9A,
        StartDefense = 0x9B,
        UserLeftDuringSelection = 0x9D,
        VigilanteKilledTown = 0x9E,
        NotifyPrivateMessage = 0x9F,
        PrivateMessage = 0xA0,
        EarnedAchievement = 0xA1,
        ConnectionStatus = 0xA2,
        SpyNightAbility = 0xA3,
        OneDayBeforeStalemate = 0xA4,
        PetsChosen = 0xA5,
        FacebookShareAchievement = 0xA6,
        FacebookShareWin = 0xA7,
        DeathAnimationsChosen = 0xA8,
        FullMoonNight = 0xA9,
        IdentifyMessage = 0xAA,
        AfterGameScreenData = 0xAB,
        AfterGameScreenChat = 0xAC,
        AfterGameScreenUserInfo = 0xAD,
        _UNUSED_DISGUISER_PREVIOUS_NAMES = 0xAE,
        RoleLotsInfo = 0xAF,
        ExternalPurchase = 0xB0,
        _UNUSED_PayPalSaleFailed = 0xB1,
        _UNUSED_PayPalCCSaleComplete = 0xB2,
        _UNUSED_PaypalCCSaleFailed = 0xB3,
        VampirePromoted = 0xB4,
        OtherVampires = 0xB5,
        AddVampire = 0xB6,
        VampiresCanConvert = 0xB7,
        VampireDied = 0xB8,
        VampireHunterPromoted = 0xB9,
        VampireVisitedMessage = 0xBA,
        CheckUsernameResult = 0xBB,
        NameChangeResult = 0xBC,
        NameChangeRequired = 0xBD,
        PurchasedAccountItems = 0xBE,
        AccountItemConsumed = 0xBF,
        _UNUSED_TRANSPORTER_NOTIFICATION = 0xC0,
        ProductPurchaseResult = 0xC1,
        UpdateMeritPoints = 0xC2,
        ActiveSpecialEvents = 0xC3,
        CauldronStatus = 0xC4,
        TauntResult = 0xC5,
        TauntActivated = 0xC6,
        TauntConsumed = 0xC7,
        TrackerNightAbility = 0xC8,
        AmbusherNightAbility = 0xC9,
        GuardianAngelProtection = 0xCA,
        PirateDuel = 0xCB,
        DuelTarget = 0xCC,
        PotionMasterPotions = 0xCD,
        HasNecronomicon = 0xCE,
        OtherWitches = 0xCF,
        PsychicNightAbility = 0xD0,
        TrapperNightAbility = 0xD1,
        TrapperTrapReady = 0xD2,
        PestilenceConversion = 0xD3,
        JuggernautKills = 0xD4,
        CovenGotNecronomicon = 0xD5,
        GuardianAngelPromoted = 0xD6,
        VIPPlayer = 0xD7,
        PirateDuelOutcome = 0xD8,
        HostSetPartyConfigs = 0xD9,
        ActiveGameModes = 0xDA,
        AccountFlags = 0xDB,
        GhoulRotted = 0xDC,
        LoverTarget = 0xDD,
        PlaugeSpread = 0xDE,
        RivalTarget = 0xDF,
        RankedInfo = 0xE0,
        JailorDeathNote = 0xE1,
        Disconnected = 0xE2,
        SpyNightInfo = 0xE3,
        ServerFlags = 0xE4,
        RegistrationResult = 0xE5,
        LoginResult = 0xE6,
        CaptchaQuestion = 0xE7,
        CaptchaResult = 0xE8,
    }
}