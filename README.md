# Dental360App
Windows Froms app using ADO.Net, Entity Framework and Sql Server Database

Description
	Business service – Appointment Booking and Staff Management software for a dental clinic “Dental360”.
	Deliverables – 1. Booking appointment
2. Patient Registration
3. Staff Management
4. Search patient or staff from the database.
5. Check schedule of appointments.
6. Administrative controls such as changing appointment, staff, services and patient information.
7. Ability to back up database to xml.

	Scope – The scope of the project is to deliver a fully functioning appointment booking and staff management software with administrative controls for a dental clinic before the deadline. Our goal is to stay on schedule and deliver all the proposed features.

	Requirements – Visual studio 2019, C#, windows forms, Entity Framework, sqlserver, ADO.Net.

Process Model
 
Actors – Patient, staff, admin.

Database Model

ER Diagram
 

User Interface

Number of screens – 9


Start Screen

 

This is the first screen user interacts with. It has 5 buttons-
1.	Search Patient or Staff – This takes the user to the Search Patient or Staff screen.
2.	Check Appointment Schedule – This takes the user to the Check Appointment Schedule Screen.
3.	Admin Controls – This takes the user to the Admin Controls Screen
4.	Book Appointment / New Patient – This takes the user to the Book Appointment / New Patient Screen.
5.	Exit – This button exits the form.
Functions – 
•	SeedData() – This function seeds the data into the database tables.

Search Patient or Staff Screen
 

This screen allows user to search patient or staff. User can search Patient by phone number or last name. User can also search staff by entering their last name and then clicking on the search button. The results are displayed in the DataGridView.

Functions –
•	SearchPatient() – It gets the patient phone number or last name from the user and looks it up and matches it in the database and then displays the results in the DataGridView.
•	SearchStaff() – It gets the staff last name from the user and then looks it up and matches it in the database and then displays the results in the DataGridVIew.
•	Validation() – It validates the user input.

Check Appointment Schedule Screen

 

This screen allows the user to check appointment schedule by entering Staff Id and selecting the date. Check Schedule button displays the schedule in the DataGridView and displays the total appointments in the textbox. The rows in DatagridView are also color coded – red for finished, skyblue for ongoing, green for upcoming appointments

Functions – 
•	CheckSchedule() – It gets the user input and then performs a query to find the schedule for that staff id and displays it in the DataGridView.
•	InitializeFormControls() – It initialized all the form controls.




Admin Login Screen

 

This screen has all the administrative controls. It also shows tool tips for every button when the user hovers their cursor on it.

Buttons – 
1.	All Appointments – It shows all the appointments in the DataGridView.
2.	All Staff – It shoes all the staff in the DataGridView.
3.	New Staff - It takes the user to the New Staff screen.
4.	Update Staff – User can update the staff by double clicking on a field in the DataGridView and then clicking on the Update Staff button to update it in the database.
5.	Delete Staff – Delete staff deletes the selected row in the DataGridView.
6.	All Patients – It displays all the patients in the DataGridView.
7.	New Patient – It take the user to the new patient screen.
8.	Update Patient – User can update the patient by double clicking on a field in the DataGridView and then clicking on the Update Patient button to update it in the database.
9.	Delete Patient – Delete patient deletes the selected row in the DataGridView. 
10.	All Services – It displays all services in the DataGridView.
11.	New Service – It takes the patient to the New Service screen.
12.	Update Service - User can update the service by double clicking on a field in the DataGridView and then clicking on the Update Service button to update it in the database.
13.	Delete Service - Delete service deletes the selected row in the DataGridView.
14.	BackUp to Xml – It backs up the data to an xml file that can be found in Inside the project directory (bin\debug\..).
15.	Sales Report – It takes the user to the sales report screen.

Functions – 
•	ShowAllAppointments() – This function runs a query to select all appointments in the database and then displays it in the DataGridView.
•	ShowAllStaff() - This function runs a query to select all staff in the database and then displays it in the DataGridView.
•	ShowAllPatients() - This function runs a query to select all patients in the database and then displays it in the DataGridView.
•	ShowAllServices() - This function runs a query to select all services in the database and then displays it in the DataGridView.
•	CreateXMLBackup() – This function saves all the tables into different xml files.
•	InitalizeFormControls() – This initializes all the form controls.

New Staff Screen

 

This screen allows the user to enter the information of the new staff member and validation is done when the user clicks on the add staff button before adding it to the database.






New Patient Screen

 

This screen allows the user to enter the information of a new patient and validation is done when the user clicks on the add patient button before adding it to the database.

New Service Screen

 

This screen allows the user to enter the information of a new service and validation is done when the user clicks on the add service button before adding it to the database.

Sales Report Screen

 

This screen shows the sales report of the current year or the previous year. The x axis of the graph is months and the y axis is the sales. 

Functions – 
•	SalesReport(int year) – This function takes the year as a parameter. It assigns the x and y axis of the chart. It performs a query to select the months and the sum of all the sales and then displays it on the chart.

Book Appointment Screen

 

This screen allows the user to select a service, dentist and enter date and time. If it’s a new patient, then user has to fill the details in the text boxes and then click on the new patient button. In case it’s a retuning patient, when the user starts to enter the phone number of the patient, it will give you suggestions. With the down key, the user can select the phone number and all the other details will be automatically filled. Book appointment button books the appointment and then displays the details in the DataGridView.

Functions -
•	AddNewPatient() – This get the user input and after validation, adds the new patient into the database.
•	InitializeFormControls() – It initializes all the lisboxes and datagridview controls.
•	AutoCompletePhoneNumber() – It auto completes the phone number when the user starts typing the phone number in the text box.
•	AutoFillDetails(string phoneNumber) – It takes the phone number as a parameter and fetches the patient details associated with that phone number.
•	Validation() – This validates the user input.

