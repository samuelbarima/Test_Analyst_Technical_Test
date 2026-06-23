Feature: Checkout
    Completing a purchase end to end

Background:
    Given the login page is open
    And I sign in as "standard_user" with password "secret_sauce"

@extension
Scenario: Complete a purchase
    Given I have added "Sauce Labs Backpack" to the cart
    When I check out with first name "Ada", last name "Lovelace" and postal code "M1 1AA"
    Then I should see the order confirmation "Thank you for your order!"
