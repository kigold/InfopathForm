# Load an Infopath form from a sharepoint Form Library using C#

This project is a set up for anyone who wants to perform basic automated activities on items in a sharepoint Form Library Using C#.Net.

This code can only be run on a windows Server that has installed Sharepoint (Any sharepoint server connected to the sharepoint farm)

### Installation
* Ensure that reference to Microsoft.Sharepoint is correctly added to the project
* Edit the ReadSP files as required, that is , changed the string varible "site" to the url of yiur site
* Also changed the string variable "list" to the name of your sharepoint library

### Edit the Code
Currently the code just loads each item in the list and prints out the Name of the file in the standard output.
You can edit the code to do much like like update fields and save the changes to the sharepoint library file item.
To achieve this, you uncomment the required code... the comments the in the code are self explanatory.
