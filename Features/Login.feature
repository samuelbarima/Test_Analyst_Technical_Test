Feature: Login
    As a store user
    I want to sign in
    So that I can browse and buy products

Scenario: A standard user can sign in
    Given the login page is open
    When I sign in as "standard_user" with password "secret_sauce"
    Then the products page is displayed
