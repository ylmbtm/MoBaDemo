﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// 所有主动技能类的基类,包含了主动技能的基本特性:
///     1.消耗的mp
///     2.造成的基本伤害
///     3.附加伤害
///     4.释放键位
/// 同时,该技能类有一个通用的用来计算伤害的方法,
/// 该方法将会产生一个Damage类,用于给Character类计算伤害
/// </summary>
[System.Serializable]
public class ActiveSkill : BaseSkill{
    private int mp;
    private int baseDamage;
    private int plusDamage;
    private KeyCode keyCode;

    // 施法距离，等于0时是原地释放技能
    private float spellDistance;

    // 技能CD时间
    private float cooldown;

    // 最后一次释放技能的时间
    private float finalSpellTime;

    public int Mp {
        get {
            return mp;
        }

        set {
            mp = value;
        }
    }

    public int BaseDamage {
        get {
            return baseDamage;
        }

        set {
            baseDamage = value;
        }
    }

    public int PlusDamage {
        get {
            return plusDamage;
        }

        set {
            plusDamage = value;
        }
    }

    public KeyCode KeyCode {
        get {
            return keyCode;
        }

        set {
            keyCode = value;
        }
    }

    public float SpellDistance {
        get {
            return spellDistance;
        }

        set {
            spellDistance = value;
        }
    }

    public float CD {
        get {
            return cooldown;
        }

        set {
            cooldown = value;
        }
    }

    public float FinalSpellTime {
        get {
            return finalSpellTime;
        }

        set {
            finalSpellTime = value;
        }
    }


    /// <summary>
    /// 用来计算伤害的虚方法,返回一个伤害类
    /// </summary>
    /// <returns></returns>
    public virtual Damage Execute() {
        Damage damage = new Damage { BaseDamage = baseDamage, PlusDamge = plusDamage };
        return damage;
    }
}
