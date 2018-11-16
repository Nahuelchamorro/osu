// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

namespace osu.Game.Tournament.IPC
{
    public enum TourneyState
    {
        Initialising,
        Idle,
        WaitingForClients,
        Playing,
        Ranking
    }
}