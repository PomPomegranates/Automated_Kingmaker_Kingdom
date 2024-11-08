using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kingmaker
{
    internal class Building
       {
        public string BuildingName { get; set; }
        public int BuildingCost { get; set; }
        public int BuildingLots { get; set; }
        public int Discount { get; set; }
        public int LimitPerSettlement { get; set; }

        public Kingdom KingdomModifiers { get; set; }

        //Building Name: The type of buildings contained in this lot.In most cases, each lot represents numerous buildings of that type,
        //rather than a single edifice.
        //Cost: The cost in BP to construct the building.
        //Lots: How many lots the building fills.

        //Kingdom: Building modifiers to Economy, Loyalty, and Stability stack, affect your entire kingdom, and are ongoing from turn to turn.
        //Modifiers to Unrest occur once when the building is completed.
        //This category also lists any bonuses to Fame (see Fame and Infamy) from having the building.

        //Discount: Some buildings halve the cost of constructing a related type of building in the same settlement.
        //This cost reduction applies only to the first constructed building of the types listed in this line.
        //For example, an Academy halves the cost of your next Library in that settlement; if you build a second Library in that settlement,
        //you pay the normal cost for it. If 2 buildings give the same discount,only one discount applies per new building,
        //but you may construct 2 buildings at the discounted cost.For example, Market and Theater both halve the cost of an Inn;
        //if your settlement has a Market and a Theater,
        //you may construct 2 Inns at half cost(the Market discounts one, and the Theater discounts the other).

        //Limit: This lists limitations on the number of buildings of this type, special requirements for adjacent buildings,
        //or prohibitions against certain buildings being adjacent.
        //For most buildings, you can construct as many of them as you want in a settlement,
        //but some are limited in the number that can be built per settlement or district.
        //For example, you can only construct 1 Arena per settlement.

        //Some buildings require that you construct them adjacent to at least 1 or 2 of a specific kind of building
        //or feature of the settlement.For example, a Shop or Tavern must be adjacent to a House or Mansion.
        //The required adjacent building can only count toward 1 building that requires it. For example, if you have a House and a Shop,
        //that House can't be used to meet the requirement for another Shop or a Tavern;
        //you have to construct a new House and use it to meet the requirement of the new Shop or Tavern.
        //For example, you can't construct a Tannery next to a House, Mansion, Noble Villa, or Tenement.
        //If you want to use a lot for this type of building, you must demolish all prohibited adjacent structures first (see Demolition).

        //If you get overzealous in constructing a particular type of building in a settlement, the GM should feel free to add events
        //to discourage this practice. For example, a settlement with too many Dumps is prone to otyugh and wererat attacks,
        //and a settlement with too many Graveyards tends to have frequent undead attacks. This should not occur, however, if you build
        //too many Houses, Parks, Tenements, or Waterways.

        //Upgrade To/From: Some buildings can be converted into a more advanced form of the existing building,
        //such as converting a Shrine into a Temple. To upgrade a building, pay the BP cost difference between the current building and the new building.
        //Remove the modifiers from the old building and apply the modifiers from the new building.
        //Upgrading counts as constructing a building for the purpose of the maximum number of buildings you can construct on your turn.
        //You can't upgrade a building to a larger one if there isn't space in the District Grid for the building's new size.

        //Special: This lists any other effect the building has, such as increasing Defense, the settlement's base value, or the output of a nearby Mine.

        //Magic Items: This lists any magic item slot the building creates, which may be filled in the Upkeep phase
        //(see Magic Items in Settlements on page 213). If a building lists multiple options within a category (such as “1 minor potion or wondrous item”),
        //it has an equal chance for each option.

        //Settlement: This lists settlement modifiers that affect specific skills within the settlement.
        //These modifiers are ongoing from turn to turn, but apply only to skill checks within that settlement
        //(not other settlements in the hex or anywhere else in your kingdom). Note that the GameMastery Guide also uses a settlement statistic called Economy;
        //to avoid confusion with the Economy kingdom score, this book renames the Economy settlement statistic “Productivity.”
    }
}
