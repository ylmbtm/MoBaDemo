﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.UI;
using UnityEngine;
using uMVVM;
using UnityEngine.EventSystems;

/// <summary>
/// 用来管理单个技能的技能面板,负责显示、变化其中图标、技能名、mp、热键。
/// </summary>
[RequireComponent(typeof(EventTrigger))]
public class SkillPanelView : UnityGuiView<SkillPanelViewModel>{

    //====================================
    // 此View管理的UI控件
    public Image skillIcon;
    public Text skillNameText;
    public Text mpText;
    public Text hotKeyText;

    public EventTrigger eventTrigger;


    protected override void OnInitialize() {
        base.OnInitialize();

        //========================================
        // 绑定监听UI控件数据变化的函数
        binder.Add<string>("mp",OnMpValueChanged);
        binder.Add<string>("hotKey", OnHotKeyTextChanged);
        binder.Add<string>("skillName",OnSkillNameChanged);
        binder.Add<string>("imagePath",OnSkillIconChanged);

    }

    // 当mp改变时，控件变化的函数
    public void OnMpValueChanged(string oldMp,string newMp) {
        mpText.text = newMp;
    }

    // 当热键变化时，变化的函数
    public void OnHotKeyTextChanged(string oldHotKey,string newHotKey) {
        hotKeyText.text = newHotKey;
    }

    // 技能名称
    public void OnSkillNameChanged(string oldSkillName,string newSkillName) {
        skillNameText.text = newSkillName;
    }

    // 技能图标
    public void OnSkillIconChanged(string oldSkillIconPath,string newSkillIconPath) {
        skillIcon.sprite = Resources.Load("UIImage/"+newSkillIconPath,typeof(Sprite)) as Sprite;
    }

}

