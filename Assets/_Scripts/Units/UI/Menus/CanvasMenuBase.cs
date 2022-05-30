﻿using UnityEngine;
using UnityEngine.EventSystems;

namespace Metroidvania.UI.Menus
{
    public abstract class CanvasMenuBase : MonoBehaviour
    {
        [SerializeField] protected GameObject firstSelected;

        public bool menuEnabled { get; protected set; }

        public void SetFirstSelected()
        {
            EventSystem.current.SetSelectedGameObject(firstSelected);
        }
    }
}