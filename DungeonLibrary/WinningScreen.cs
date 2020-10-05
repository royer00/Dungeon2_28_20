using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class WinningScreen
    {
        public static void YouveWon(Player player)
        {
            Console.WriteLine($"Congratulations!  You have eliminated the threat inside of the castle. You have liberated all 5 of the villagers' treasures.  They meet you at the entrance, clapping and shouting.  Huzzah.  The mayor addresses the crowd. 'You have made our town whole again, {player.Name} .  We owe a debt to you that we can never repay.' he shouts.  The darkness is clearing and the sun shines down on the land for the first time in years.");
            Console.WriteLine(@"
                                 o
                                                 _---|         _ _ _ _ _
                                              o   ---|     o   ]-I-I-I-[
                             _ _ _ _ _ _  _---|      | _---|    \ ` ' /
                             ]-I-I-I-I-[   ---|      |  ---|    |.   |
                              \ `   '_/       |     / \    |    | /^\|
                               [*]  __|       ^    / ^ \   ^    | |*||
                               |__   ,|      / \  /    `\ / \   | ===|
                            ___| ___ ,|__   /    /=_=_=_=\   \  |,  _|
                            I_I__I_I__I_I  (====(_________)___|_|____|____
                            \-\--|-|--/-/  |     I  [ ]__I I_I__|____I_I_|
                             |[]      '|   | []  |`__  . [  \-\--|-|--/-/
                             |.   | |' |___|_____I___|___I___|---------|
                            / \| []   .|_|-|_|-|-|_|-|_|-|_|-| []   [] |
                           <===>  |   .|-=-=-=-=-=-=-=-=-=-=-|   |    / \
                           ] []|`   [] ||.|.|.|.|.|.|.|.|.|.||-      <===>
                           ] []| ` |   |/////////\\\\\\\\\\.||__.  | |[] [
                           <===>     ' ||||| |   |   | ||||.||  []   <===>
                            \T/  | |-- ||||| | O | O | ||||.|| . |'   \T/
                             |      . _||||| |   |   | ||||.|| |     | |
                          ../|' v . | .|||||/____|____\|||| /|. . | . ./
                           |//\............/...........\........../../\\\
 

                      _____ _  _  ___   ___  _  _   __
                        |   |__| |__   |__   |\ |  |  \
                        |   |  | |___  |___  | \|  |__/
                  ");
        }
    }
}
