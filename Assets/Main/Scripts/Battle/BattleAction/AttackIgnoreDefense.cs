using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public partial class BattleAction
{
    public class AttackIgnoreDefense : BattleAction
    {
        public static BattleActionType ActionType { get { return BattleActionType.AttackIgnoreDefense; } }
        public override void Excute()
        {
            for (int i = 0; i < target.Data.BuffList.Count; i++)
            {
                BattleBuffData buff = target.Data.BuffList[i];
                for (int j = 0; j < buff.Data.ActionTypes.Count; j++)
                {
                    switch ((BattleActionType)buff.Data.ActionTypes[j])
                    {
                        case BattleActionType.DodgeDamage:
                            //�������ܶ���
                            buff.Layer--;
                            if (buff.Layer == 0)
                            {
                                target.Data.BuffList.RemoveAt(i);
                            }
                            battleMgr.AddUIAction(new UIAction.UIDodgeDamage());
                            return;
                        default:
                            break;
                    }
                }
            }
            for (int i = 0; i < target.Data.EquipList.Count; i++)
            {
                BattleEquipData equip = target.Data.EquipList[i];
                for (int j = 0; j < equip.Data.ActionTypes.Count; j++)
                {
                    switch ((BattleActionType)equip.Data.ActionTypes[j])
                    {
                        case BattleActionType.DodgeDamage:
                            //�������ܶ���
                            battleMgr.AddUIAction(new UIAction.UIDodgeDamage());
                            return;
                        default:
                            break;
                    }
                }
            }
            target.Data.HP -= actionArg;
            battleMgr.AddUIAction(new UIAction.UIHpDamage(target, actionArg));
        }
        public override int Excute(int damage)
        {
            throw new NotImplementedException();
        }
    }
}
