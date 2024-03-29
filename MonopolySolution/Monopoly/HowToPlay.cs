﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class HowToPlay
    {
        //Source : https://www.ultraboardgames.com/monopoly/game-rules.php

        //Each player is given $1500 divided as follows:
        //2 x $500's, 2 x $100's, 2 x $50's, 6 x $20's, 5 x $10's, 5 x $5's, and 5 x $1's.
        //Select someone as banker.If this person also plays, then he must keep his personal funds separated from those of the bank.

        //The Bank holds:
        //The Bank pays salaries and bonuses. The Bank collects all taxes, fines, loans and interest, and the price of all properties which it sells and auctions.
        //The Bank can't go broken, if the Bank runs out of money, the Banker may issue as much as needed by writing on any ordinary paper.

        //Object of the Game:
        //Become the wealthiest player through buying, renting and selling of property and force other players into bankruptcy.

        //Game Play:
        //Starting with the Banker, each player throws the dice.The player with the highest total starts the play.
        //Then each player places his token on the corner marked "GO", and throw the dice and move his the number of spaces indicated by the dice.
        //The tokens remain on the spaces occupied and proceed from that point on the player's next turn.
        //Two or more tokens may rest on the same space at the same time.
        //If one or both dice roll off the board, or land on or lean against a card deck, the roll is invalid.Roll them again.
        //Depending on the space the token reaches, you may buy the property, or be obliged to pay rent, pay taxes, draw a Chance or Community Chest card, Go To Jail, or etc...
        //If you throw doubles, you move your token and are subject to any privileges or penalties pertaining to the space on which you land.Then you can throw again and move your token as before.
        //But watch out, if you ever throw doubles three times in succession, you have to go immediately to jail.


        //Go:
        //Each time a player's token lands on or passes over GO, whether by throw of the dice or by drawing a card, the Banker pays that player a $200 salary.
        //However, $200 is paid only once each time around the board.If a player, passing "GO" on the throw of the dice, lands 2 spaces beyond it on "Community Chest", or 7 spaces beyond it on "Chance", and draws the card "Advance to GO", he collects $200 for passing "GO" the first time and another $200 for reaching it the second time by instructions on the card.

        //Buying Property:
        //When you land on an unowned property you can buy that property from the Bank at its printed price.
        //You receive the Title Deed card showing ownership.
        //If you do not wish to buy the property, the Bank sells it at thru an auction to the highest bidder. The buyer pays to the Bank the amount of the bid in cash and receives the Title Deed card for that property.
        //Any player, including the one who declined the option to buy it at the printed price, may bid and bidding may start at any price.

        //Paying Rent:
        //When you land on a property that is owned by another player, the owner collects rent from you in accordance with the list printed on its Title Deed card.
        //If the property is mortgaged, its Title Deed card is placed face down in front of the owner and he can not collect a rent.
        //It is an advantage to hold all the Title Deed cards in a color-group because the owner may then charge double rent for unimproved properties in that color-group.This rule applies to unmortgaged properties even if another property in that color-group is mortgaged.
        //It is more advantageous to have houses or hotels on properties because then rents become much higher.
        //Note: The owner may not collect the rent if they fail to ask the rent before the next player throws his dice.

        //Chance And Community Chest:
        //When you land on either of these spaces, take the top card from the deck indicated, and follow the instructions on the card.
        //Return the card face down to the bottom of the deck.
        //The "Get Out of Jail Free" card is held until used and then returned to the bottom of the deck.
        //If the player who draws it does not wish to use it, then they may sell it to another player at a price agreeable to both.

        //Income Tax:
        //When you land on "Income Tax" you have two options:
        //JAIL:
        //You land in Jail when:
        //When you are sent to Jail, you must move directly into Jail and you can not collect $200 salary if you need to pass to Go.Also your turn ends when you are sent to Jail.
        //If you are not "sent to jail" but in the ordinary course of play lands on that space, you are "Just Visiting" and you move ahead in the usual manner on your next turn.
        //A player gets out of Jail by:
        //Even though you are in Jail, you may buy and sell property, houses and hotels and collect rents.
        //FREEPARKING:
        //This is just a "free" resting place, so the player landing on it doesn't receive money, property, reward or penalty of any kind.
        //Try to avoid to come here early in game, but later on the game it can be a great targe

        //Houses and Hotels:
        //When a player owns all the properties in a color-group, he or she may buy houses from the Bank.
        //You may buy as many houses as your judgment and financial standing will allow, but you cannot erect more than one house on any one property of any color-group until you have built one house on every property of that group.
        //The price you must pay the Bank for each house is shown on your Title Deed card for the property on which you erect the house.
        //The owner still collects double rent from an opponent who lands on the unimproved properties of his/her complete color-group.
        //When a player has four houses on each property of a complete color-group, they may buy a hotel from the Bank and erect it on any property of the color-group.Only one hotel may be erected on any one property.
        //As you build evenly, you must also break down evenly if you sell houses back to the Bank.

        //Building Shortages:
        //When the Bank has no houses to sell, players wishing to build must wait for some player to return or sell their houses to the Bank before building.
        //If there are a limited number of houses and hotels available and two or more players wish to buy more than the Bank has, the houses/hotels will be sold at auction to the highest bidder.

        //Selling Property:
        //Unimproved properties, railroads and utilities may be sold to any player as a private transaction for any amount the owner can get.
        //However, properties can not be sold to another player if buildings are standing on any properties of that color-group.
        //The buildings must be sold back to the Bank before the owner can sell any property of that color-group.
        //Houses and Hotels can be sold back to the bank at any time for one-half the price paid for them.

        //Mortgages:
        //Unimproved properties can be mortgaged through the Bank at any time.The mortgage value is printed on each Title Deed card.
        //When properties has buildings, then these must be sold back to the back at half price first.
        //No rent can be collected on mortgaged properties or utilities.
        //In order to lift the mortgage, the owner must pay the Bank the amount of mortgage plus 10% interest.
        //When all the properties of a color-group are no longer mortgaged, the owner may begin to buy back houses or hotels.
        //The player who mortgages property retains possession of it and no other player may secure it by lifting the mortgage from the Bank.
        //But the owner may sell this mortgaged property to another player at any agreed price and the new owner can lift the mortgage by paying off the mortgage plus 10% interest to the Bank.
        //When the mortgage if not lifted at once, you must pay the Bank 10% interest when you buy the property and if you lift the mortgage later you must pay the Bank an additional 10% interest.

        //Bankruptcy:
        //You are declared bankrupt if you owe more than you can pay to another player or to the Bank.
        //If your debt is to another player, you must turn over all that you have to that player.
        //If you own houses or hotels, you must return these to the Bank in exchange for money to the extent of one-half the amount paid for them and this cash is given to the creditor.
        //If you have mortgaged property you also turn this property over to your creditor but the new owner must at once pay the Bank the amount of interest on the loan, which is 10% of the value of the property.
        //Should you owe the Bank, instead of another player, more than you can pay, you must turn over all assets to the Bank.In this case, the Bank immediately sells by auction all property except buildings.
        //Money can be loaned to a player only by the Bank (by mortgaging property) and no other player may borrow from or lend money to another player.

        //End of Game:
        //Bankrupt players must retire from the game and the last player left in the game is the winner..
    }
}
