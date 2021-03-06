﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace BigHead.Sound
{
    /// <summary>
    /// 声音组接口。
    /// </summary>
    public interface ISoundGroup
    {
        /// <summary>
        /// 获取声音组名称。
        /// </summary>
        string Name
        {
            get;
        }

        /// <summary>
        /// 获取声音代理数。
        /// </summary>
        int SoundAgentCount
        {
            get;
        }

        /// <summary>
        /// 获取或设置声音组中的声音是否避免被同优先级声音替换。
        /// </summary>
        bool AvoidBeingReplacedBySamePriority
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置声音组静音。
        /// </summary>
        bool Mute
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设置声音组音量。
        /// </summary>
        float Volume
        {
            get;
            set;
        }

        /// <summary>
        /// 获取声音组辅助器。
        /// </summary>
        AudioMixerGroup MixerGroup
        {
            get;
        }
        /// <summary>
        /// 停止所有已加载的声音。
        /// </summary>
        void StopAllLoadedSounds();

        /// <summary>
        /// 停止所有已加载的声音。
        /// </summary>
        /// <param name="fadeOutSeconds">声音淡出时间，以秒为单位。</param>
        void StopAllLoadedSounds(float fadeOutSeconds);
        /// <summary>
        /// 停止所有已加载的声音。
        /// </summary>
        /// <param name="exceptId">排除在外的声音</param>
        void StopAllLoadedSounds(int exceptId);
        /// <summary>
        /// 释放所有声音资源
        /// </summary>
        void ReleaseAllSoundAssets();
        /// <summary>
        /// 释放所有声音资源
        /// </summary>
        /// <param name="exceptId">排除在外的音乐</param>
        void ReleaseAllSoundAssets(int exceptId);
    }
}
