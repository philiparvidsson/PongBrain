﻿namespace PongBrain {

/*-------------------------------------
 * USINGS
 *-----------------------------------*/

using System;
using System.Windows.Forms;

using Base.Core;
using Base.Graphics.GdiPlus;
using Pong.Scenes;

/*-------------------------------------
 * CLASSES
 *-----------------------------------*/

internal static class Program {
    /*-------------------------------------
     * PRIVATE METHODS
     *-----------------------------------*/

    [STAThread]
    private static void Main(string[] args) {
        Application.EnableVisualStyles();

        var game = Game.Inst;

        game.Init(new GdiPlusGraphicsImpl(), "PongBrain", 640, 480);
        game.Run(new MainScene());
    }
}

}
