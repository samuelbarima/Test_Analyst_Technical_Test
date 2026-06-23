Feature: Inventory and cart
    Adding products to the shopping cart

Background:
    Given the login page is open
    And I sign in as "standard_user" with password "secret_sauce"

Scenario: Add a single product to the cart
    When I add "Sauce Labs Backpack" to the cart
    Then the cart should contain 1 item
