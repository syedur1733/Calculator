Feature: User Registration
User Story (Optionla): As an user, i want to register myself as a patient so that i can add family members and medical records

Scenario: Register with valid email address
Given i am on the registration page
And shows "Name" 
And also shows "Email"
And and "Password"
When click on "Submit"
Then i see a success message

#Background: 
#Given i am on the registration page

#@WorkInProgress
#Scenario: Register with invalid email address
#Given i am on the registration page
#And shows "Name" 
#And also shows "Email"
#And and "Password"
#When click on "Submit"
#Then i see a failure message stating that invalid Email
 
#
#Scenario: Register with duplicate email address
#
#Given i am on the registration page
#And i see Name 
#And i see Email 
#And i see Password
#And i see Submit Button
#
#When i enter Name
#And i enter duplicate Email
#And i enter Password
#And i click on Submit Button
#
#Then i see a failure message stating that Email already exists
#And highlight the email field
