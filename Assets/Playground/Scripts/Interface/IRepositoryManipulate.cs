using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeyCodeReserve
{
    interface IRepositoryManipulate
    {
        void Reserve(List<ReservedKeyEvent> targetKeyEvents);
        List<ReservedKeyEvent> GetAllKeyEvents();
        List<ReservedKeyEvent> GetByKeyCode(KeyCode keyCode);
        ReservedKeyEvent GetByIndex(int index);
    }
}

