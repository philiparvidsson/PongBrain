﻿namespace PongBrain.Components.Input {
    
/*-------------------------------------
 * USINGS
 *-----------------------------------*/

using System;
using System.Collections.Generic;

using PongBrain.Input;

/*-------------------------------------
 * CLASSES
 *-----------------------------------*/

public sealed class InputComponent {
    /*-------------------------------------
     * PUBLIC PROPERTIES
     *-----------------------------------*/

    public Dictionary<Key, Action> KeyMap { get; } =
        new Dictionary<Key, Action>();

    public Action ResetControls { get; set; }
}

}
