#  Sub Zero

## Contents

* **Sub Zero**
  - An application used for First Tech Challenge Relic Recovery scouting by #10547 The Mortal Combots
  
* **Overview**
  - Created for FTC team #10547 The Mortal Combots (Davenport, IA)
  - Creates text documents that lists team scores and various things through matches
  - Ability to create Excel Spread Sheets
  
* **Example Usage:** Our FTC team at West Virginia State Competition used the app to help our alliance selections

* **Getting Started**
  - **Installation**
    - **To add teams!**
      - 1. Go to Data/Teams/TeamDirectory.txt
      - 2. Follow Previous formatting to edit
      - 3. Example text : 10547,5466,10030,
      - 4. To edit: add needed teams to end, and delete unneeded teams
      - 5. Example edit: 10547,10030,11742,
  - **Prerequisites**
    - .NET Framework: https://www.microsoft.com/net/download/dotnet-framework-runtime
    
* **Design Goals**
  - This program is programmed around features, at the sake of resources.
  - It can be ran on any Windows computer with .NET framework 3.5 and above
  
* **Detailed Usage**
  - Interface and better explanations down below
  - **Examples**
    - 1. Start Application
    - 2. Go to Text Export
    - 3. Fill out information as needed
    - 4. Repeat as many times as needed
    - 5. Exit text Exporter
    - 6. View files for teams
    
* **Developer Info**
  - Known Issues
    - None as of now

### Sorted by the forms themselves

* **Main Menu**
  - Main Menu for application
    - navigate whole program
    
![Main Menu](/Images/Menu.PNG?raw=true "mainMenu")

* **Excel Exporter**
  - Only works with Microsoft Office installed
    - Disabled for our scouting laptop
  - Exports data to an Excel SpreadSheet
    - Custom formatted for our team

* **Text Exporter**
  - Grabs all team numbers from teamDirectory.txt created in the data folder
    - allows for a long list of team numbers
  - Exports data to a text document
    - Custom format for our team
    - One document per team, separated by a spacer and match number
![Text Pad](/Images/textPad.PNG?raw=true "textPad")
  - When the export button is clicked it also adds the needed information to a text document
![Text Exporter](/Images/textExport.PNG?raw=true "textExport")

## Changelog
* January 27, 2018 (Version 1.5.1 Hotfix)
  - fixed all relic math
	- found at competition, and fixed there
* December 12, 2017 (Version 1.5.1)
  - fixed grammar issue 
* December 11, 2017 (Version 1.5b)
  - Added an add page when exiting the application
    - fixed it in a later update
* December 9, 2017 (Version 1.5a)
  - Fixed a small bug with excel
    - Disabled excel for now as current computer does not have office
  - Fixed "Ciper Math" for scores
* December 5, 2017 (Version 1.5)
  - Added team list sorted by value
  - Fixed small bugs
* November 20, 2017 (Version 1.1)
  - Added a new school version for school computers
    - Has an older version of .NET framework, and older Microsoft Office versions
* November 18, 2017 (Version 1.0)
  - Reworked text exporter to print per team, not per match
    - This will lead to being able to select alliance partners 
    - This is much better than the other way.
  - Big fixes
* November 14, 2017 (Version 0.5c)
  - Rewrote globalVariables so it is more appealing to the eyes.
* November 11, 2017 (Version 0.5b)
  - Remade UI for school computers. Switched from 1920 x 1080 to 1280 x 720.
* November 8, 2017 (Version 0.5a Hotfix)
  - added MIT license
* November 6, 2017 (Version 0.5a)
  - Added first school version with older packages
* November 4, 2017 (Version 0.5)
  - Reconfigured tab order
  - Update readme
  - Added Text exporter for computers without Excel
    - Added internal version number to program
    - Added notes section for during match notes
    - Added new saving method
    - Added reference picture for ciphers
    - Finished first GUI
    - Finished main math for application
* November 3, 2017 (Version 0.1)
  - Initial Commit
  - Added personalized .ico file
  - Added new saving method.
    - More efficient
  - Update to make red team 1 fill in the spreadsheet
## Contact
For questions, comments, concerns, or suggestions please email dbeehler00@gmail.com

## Extra Information
This is the _public_ version of Sub Zero. Along with the source code.
If used, or edited in any way please give proper credit, and link the main repository in your readme!
