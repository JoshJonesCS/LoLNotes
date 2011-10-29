﻿/*
copyright (C) 2011 by high828@gmail.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
 */

using System;
using System.Diagnostics;
using LoLNotes.Flash;

namespace LoLNotes.GameStats.PlayerStats
{
    [DebuggerDisplay("{SummonerName}")]
    public class PlayerStatsSummary
    {
        protected readonly FlashObject Base;

        public PlayerStatsSummary()
        {
        }
        public PlayerStatsSummary(FlashObject body)
        {
            if (body == null)
                throw new ArgumentNullException("body");

            Base = body;

            FlashObject.SetFields(this, body);
        }

        [InternalName("botPlayer")]
        public bool BotPlayer { get; set; }

        [InternalName("elo")]
        public int Elo { get; set; }

        [InternalName("eloChange")]
        public int EloChange { get; set; }

        [InternalName("gameId")]
        public int GameId { get; set; }

        [InternalName("gameItems")]
        public GameItems Items { get; set; }

        [InternalName("inChat")]
        public bool InChat { get; set; }

        [InternalName("isMe")]
        public bool IsMe { get; set; }

        [InternalName("leaver")]
        public bool Leaver { get; set; }

        [InternalName("leaves")]
        public int Leaves { get; set; }

        [InternalName("level")]
        public int Level { get; set; }

        [InternalName("losses")]
        public int Losses { get; set; }

        [InternalName("profileIconId")]
        public int ProfileIconId { get; set; }

        [InternalName("skinName")]
        public string SkinName { get; set; }

        [InternalName("spell1Id")]
        public int Spell1Id { get; set; }

        [InternalName("spell2Id")]
        public int Spell2Id { get; set; }

        [InternalName("statistics")]
        public PlayerStatList Statistics { get; set; }

        [InternalName("summonerName")]
        public string SummonerName { get; set; }

        [InternalName("teamId")]
        public int TeamId { get; set; }

        [InternalName("userId")]
        public int UserId { get; set; }

        [InternalName("wins")]
        public int Wins { get; set; }


    }
}