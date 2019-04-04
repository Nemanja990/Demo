# Demo
Demo assignment

The app starts with Product controller which shows data from JSON file. At top of the page there is option to switch between page that
works with JSON file and page that works with Database records.

First part of the application reads data from JSON file which can be found in App_Data folder. It shows the data, with options to edit it,
but the edit and add new options is limited because the data is not permamently stored in database. So it can only edit one record at the
time and add one record at the time, every next reload of the page will set the records on default value set in JSON file.

For the second part of the application you can find SQL script in App_Data folder in order to create corresponding Database, table and
initial records.
This part of the application uses Entity Framework to retreive, add, or update the data from database.
