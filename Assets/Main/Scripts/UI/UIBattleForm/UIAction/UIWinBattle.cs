﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class UIAction
{
    public class UIWinBattle : UIAction
    {
        public static UIActionType ActionType { get { return UIActionType.WinBattle; } }

        public List<int> RewardIds { private set; get; }
        public UIWinBattle(List<int> rewardIds) : base()
        {
            RewardIds = rewardIds;
        }

        public override IEnumerator Excute()
        {
            yield return null;
            BattleForm.WinBattle();
            UIModule.Instance.OpenForm<WND_Reward>(RewardIds);
        }
    }
}
