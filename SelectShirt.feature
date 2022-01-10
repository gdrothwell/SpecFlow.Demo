Feature: Purchase items
	As a potential customer
	I want to purchase a t-shirt
	So that it is shipped to me.

Scenario: Add an item to shopping cart
	Given I select the item named <Name>
	And I select the color <Color>
	And I select size <Size>
	And I add the selected item to cart
	When I go to the shopping cart
	Then I see the item named <Name>
	And I see the item is of color <Color>
	And I see the item is of size <Size>



    Examples:
    | Name                                 | Color | Size |
    | PINK DROP SHOULDER OVERSIZED T SHIRT | Pink  | 36   |
    | BLACK LUX GRAPHIC T-SHIRT            | Black | 32   |