Feature: Dove Web Page 
  Automating the given Web Page 

Scenario: Search Verification
Given Load the given Dove web page 
When we click on search and type Shampoo
And click on search button
Then page opens and we verify the text Shampoo

Scenario:Discover More
Given Load the  Dove web page
When we click on Discover more in home page 
Then page should open and verify the text “The Real Women behind"

Scenario: Terms of use
Given Load webpage 
When we click on Terms of use 
Then page should open and verify Prohibited User text