# MultiThread Text Search C# 

C# Windows application that searches for all the occurences of a string in a text file and display line number and the line in which the string is found. 

**Application User Interface**

  - Textbox for the name of a text file. Browse button  that will let you browse for the file in which you want to search the string.
  - Textbox to accept the string you want to search for.
  - Listview control displays the entire line on which the text was found and the line number within the document.
  - Search button will cause the document to be searched.
  - Search button text changes to “Cancel” once the search starts, and cancel the operation when pressed.
  - Timer to show how much time taken to find and display all the occurence of the string in the text file.
  - Progress bar to display how much of the file is parsed/searched.
  
Main thread: Read file line by line

Child thread: search of text in the line, if present add to the list along with the line number.
Progress: bytes read / total size of file.
