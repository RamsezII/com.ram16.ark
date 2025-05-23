﻿using UnityEngine;

namespace _ARK_
{
    public abstract class OS : MonoBehaviour
    {
        protected virtual void Awake()
        {
            DontDestroyOnLoad(gameObject);
            OnLoadTexts(true);
        }

        //--------------------------------------------------------------------------------------------------------------

        protected virtual void OnApplicationFocus(bool focus)
        {
            if (focus)
                OnLoadTexts(false);
        }

#if UNITY_EDITOR
        [ContextMenu(nameof(SaveTexts))]
        void SaveTexts() => OnSaveTexts();

        [ContextMenu(nameof(LoadTexts))]
        void LoadTexts() => OnLoadTexts(true);
#endif
        protected virtual void OnSaveTexts()
        {
        }

        protected virtual void OnLoadTexts(in bool log)
        {
        }

        //--------------------------------------------------------------------------------------------------------------

        protected virtual void OnDestroy()
        {
        }
    }
}