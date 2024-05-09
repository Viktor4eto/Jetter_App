# Jetter_App
Jetters - Vehicle Rental Platform

Welcome to Jetters, your ultimate solution for renting vehicles hassle-free! This Windows Forms application is designed to provide a seamless experience for both vehicle owners and renters. Whether you need a car for a weekend getaway or want to earn extra income by renting out your vehicle, Jetters has got you covered.
DeleteBooking Application Readme

Overview:
The DeleteBooking application is a component of the Jetter_App, designed to facilitate the removal of bookings from a database system. This application is built using C# and utilizes Microsoft Visual Studio for development.

Functionality:
The main functionality of this application includes:
- Retrieving a list of booking IDs associated with a particular user.
- Displaying these booking IDs in a dropdown menu for selection.
- Confirming the deletion of a selected booking.
- Deleting the selected booking from the database, along with associated payment records.
- Updating the availability of bookings after deletion.

Requirements:
To run this application, you will need:
- Microsoft Visual Studio or any compatible C# development environment.
- Access to a SQL Server database where the booking and payment records are stored.

Setup:
1. Clone or download the Jetter_App repository to your local machine.
2. Open the solution file (.sln) in Microsoft Visual Studio.
3. Ensure that all necessary dependencies are installed and referenced correctly.
4. Connect the application to your SQL Server database by updating the connection string in the `Program.getDatabase()` method.
5. Build and run the application.

Usage:
1. Launch the DeleteBooking application.
2. Log in with valid user credentials.
3. The application will retrieve a list of booking IDs associated with the logged-in user and display them in a dropdown menu.
4. Select the booking ID you wish to delete.
5. Click the "Delete" button to initiate the deletion process.
6. A confirmation dialog will appear. Click "Yes" to proceed with the deletion or "No" to cancel.
7. After deletion, the application will update the availability of bookings.

Note:
- Ensure that proper error handling mechanisms are implemented, especially for database connectivity and query execution.
- Regularly backup your database to prevent accidental data loss.
- Customize the user interface and functionality according to specific project requirements.

Contributing:
Contributions to the DeleteBooking application or the Jetter_App project as a whole are welcome. Please follow the project's coding standards and guidelines when making changes.

License:
The DeleteBooking application is licensed under [insert license here]. Please refer to the LICENSE.md file for more details.

Contact:
For any inquiries or support regarding the DeleteBooking application or the Jetter_App project, please contact [insert contact information here].


# Edit Assets Form README

## Overview
The Edit Assets form allows vendors to manage and update their assets. Vendors can add new assets or modify existing ones, including changing the quantity available and rental locations. The form provides functionality to retrieve and display existing assets, update asset information, and add new assets to the system.

## Functionality
- **Update Assets**: Vendors can update the quantity available and rental locations of existing assets by selecting an asset type and entering new information.
- **Add New Assets**: Vendors can add new assets to the system by entering details such as asset type, name, description, manufacturer, model, year, hourly rate, daily rate, availability, and location.
- **Validation**: The form includes validation checks to ensure that valid data is entered for each asset attribute.
- **Data Display**: Displays existing assets in a DataGridView, allowing vendors to view and manage their assets easily.

## Methods
- **EditAssets_Load()**: Invoked when the form is loaded to populate the DataGridView with existing assets.
- **button1_Click()**: Handles the click event of the "Update" button, updating the quantity available and rental locations of existing assets.
- **UpdateGrid()**: Retrieves and displays existing assets in the DataGridView.
- **add_Click()**: Handles the click event of the "Add" button, allowing vendors to add new assets to the system.

## Dependencies
- **System.Data.SqlClient**: Provides classes for working with SQL Server databases.
- **System.Numerics**: Provides classes and methods for mathematical operations.

## Usage
1. **Update Assets**: Select an asset type, enter new quantity available and rental locations, and click the "Update" button to update existing assets.
2. **Add New Assets**: Enter details for the new asset, including type, name, description, manufacturer, model, year, hourly rate, daily rate, availability, and location, and click the "Add" button to add the asset to the system.
3. **Validation**: Ensure that valid data is entered for each asset attribute to prevent errors during asset updates and additions.
4. **Data Display**: View existing assets in the DataGridView to manage and update asset information easily.

## Note
- Customize the form's appearance and functionality based on specific project requirements and design guidelines.
- Ensure proper validation checks to maintain data integrity and prevent invalid data entry.
- This README provides an overview of the Edit Assets form, its functionality, methods, and usage instructions.


# Log In Form README

## Overview
The Log In form is a crucial component of the Jetter application, providing users with a way to authenticate and access their accounts. It allows users to enter their credentials (username and password) to log in and access their respective functionalities based on their roles (customer or admin).

## Functionality
- **Vendor Log In**: Clicking on the "Vendor" label navigates users to the Vendor Log In form, allowing vendors to log in to their accounts.
- **Registration**: Clicking on the "Register" button navigates users to the registration form to create a new account.
- **Log In**: Validates the entered credentials and grants access to the appropriate functionality based on the user's role.
- **Password Visibility**: Clicking on the eye icon toggles the visibility of the password.

## Methods
- **vendor_label_Click()**: Hides the current form and navigates users to the Vendor Log In form when the "Vendor" label is clicked.
- **registered_Click()**: Hides the current form and navigates users to the registration form when the "Register" button is clicked.
- **log_in_Click()**: Validates the entered credentials and grants access to the appropriate functionality based on the user's role when the "Log In" button is clicked.
- **password_state_Click()**: Toggles the visibility of the password when the eye icon is clicked.

## Dependencies
- **System.Windows.Forms**: Provides classes for creating Windows-based applications.

## Usage
1. **Initialization**: Instantiate the Log In form.
2. **Authentication**: Enter the username and password and click the "Log In" button to authenticate.
3. **Navigation**: Click the "Vendor" label to navigate to the Vendor Log In form or click the "Register" button to register a new account.
4. **Password Visibility**: Click the eye icon to toggle the visibility of the password.

## Note
- Ensure proper authentication logic and validation to secure user accounts and prevent unauthorized access.
- Customize the form's appearance and functionality based on specific project requirements and design guidelines.
- This README provides an overview of the Log In form, its functionality, methods, and usage instructions.



## Functionality
- **Load Pending Payments**: Upon initialization, the form loads pending payments associated with the current user.
- **Payment Method Selection**: Users can select a payment method from a dropdown menu. The UI dynamically adjusts based on the selected method.
- **Payment Validation**: Card numbers are validated using a custom CardValidator class.
- **Payment Processing**: Valid payments are processed, updating the payment status to 'successful' and confirming associated bookings.
- **UI Interaction**: The form provides feedback to users via message boxes indicating validation results and payment statuses.

## Dependencies
- **System**: Provides fundamental types and base classes for the application.
- **System.Data**: Enables access to data in relational databases.
- **System.Data.SqlClient**: Provides data access for Microsoft SQL Server.
- **System.Windows.Forms**: Provides classes for creating Windows-based applications with rich UI.

## Usage
1. **Initialization**: Instantiate the Payment form, passing the current user as a parameter.
2. **View Pending Payments**: The form will automatically display pending payments associated with the user.
3. **Process Payment**: Select a payment method, enter required information, and click the 'Pay' button to process the payment.
4. **Confirmation**: Upon successful payment, a message box confirms the payment status and updates the booking status to 'confirmed'.

## Customization
- **Payment Method**: Additional payment methods can be added to the dropdown menu by extending the options in the `method_Changed` method.
- **Card Validation**: Modify the `CardValidator` class or integrate with external validation services for more robust card validation.
- **UI Enhancement**: Customize the UI elements, styling, and error handling to improve user experience.

## Note
- Ensure that the `Program.getDatabase()` method returns the appropriate database connection string for the application to connect to the database.
- This code assumes a Microsoft SQL Server database and may require adjustments for compatibility with other database systems.

# Registration Form README

## Overview
The Registration form is a part of the Jetter application, allowing new users to create accounts. It provides validation for email addresses, usernames, passwords, and phone numbers to ensure data integrity and security.

## Functionality
- **Password Visibility**: Users can toggle password visibility to ensure correct entry.
- **Email Validation**: Validates the format of email addresses using a regular expression pattern.
- **Username Validation**: Checks for the availability of usernames in the database and ensures non-empty entries.
- **Password Validation**: Ensures passwords meet complexity requirements, including length, capitalization, and numeric characters.
- **Password Strength Indication**: Provides visual feedback on password strength based on length, capitalization, and numeric characters.
- **Re-enter Password Validation**: Ensures the re-entered password matches the original password.
- **Form Submission**: Inserts user data into the database upon successful validation and displays a confirmation message.
- **Phone Number Validation**: Validates the format of phone numbers using a regular expression pattern.
- **Navigation**: Allows users to return to the login form if needed.

## Dependencies
- **System.Data.SqlClient**: Provides data access for Microsoft SQL Server.
- **System.Text.RegularExpressions**: Enables the use of regular expressions for string pattern matching.

## Usage
1. **Enter User Information**: Fill in the required fields, including username, email, password, first name, last name, phone number, and address.
2. **Password Validation**: Ensure the password meets the required complexity criteria, including length, capitalization, and numeric characters.
3. **Submit Form**: Click the 'Register' button to submit the registration form.
4. **Confirmation**: Upon successful registration, a confirmation message is displayed, and users are redirected to the login form.

## Customization
- **Password Complexity**: Adjust the regular expression pattern in the `IsValidPassword` method to change password complexity requirements.
- **Database Integration**: Modify the SQL queries and connection strings to integrate with the appropriate database.
- **UI Enhancement**: Customize the UI elements, styling, and error messages to improve user experience.

## Note
- Ensure that the `Program.getDatabase()` method returns the appropriate database connection string for the application to connect to the database.
- This code assumes a Microsoft SQL Server database and may require adjustments for compatibility with other database systems.

# Vendor Registration Form README

## Overview
The Vendor Registration form is a component of the Jetter application, enabling vendors to register their accounts. It includes validation for email addresses, vendor names, passwords, contact persons, and phone numbers to maintain data integrity and security.

## Functionality
- **Password Visibility**: Users can toggle password visibility to ensure correct entry.
- **Email Validation**: Validates the format of email addresses using a regular expression pattern.
- **Vendor Name Validation**: Checks for the availability of vendor names in the database and ensures non-empty entries.
- **Password Validation**: Ensures passwords meet complexity requirements, including length, capitalization, and numeric characters.
- **Password Strength Indication**: Provides visual feedback on password strength based on length, capitalization, and numeric characters.
- **Re-enter Password Validation**: Ensures the re-entered password matches the original password.
- **Form Submission**: Inserts vendor data into the database upon successful validation and displays a confirmation message.
- **Phone Number Validation**: Validates the format of phone numbers using a regular expression pattern.
- **Navigation**: Allows vendors to return to the vendor login form if needed.

## Dependencies
- **System.Data.SqlClient**: Provides data access for Microsoft SQL Server.
- **System.Text.RegularExpressions**: Enables the use of regular expressions for string pattern matching.

## Usage
1. **Enter Vendor Information**: Fill in the required fields, including vendor name, contact person, email, password, phone number, and address.
2. **Password Validation**: Ensure the password meets the required complexity criteria, including length, capitalization, and numeric characters.
3. **Submit Form**: Click the 'Register' button to submit the vendor registration form.
4. **Confirmation**: Upon successful registration, a confirmation message is displayed, and vendors are redirected to the vendor login form.

## Customization
- **Password Complexity**: Adjust the regular expression pattern in the `IsValidPassword` method to change password complexity requirements.
- **Database Integration**: Modify the SQL queries and connection strings to integrate with the appropriate database.
- **UI Enhancement**: Customize the UI elements, styling, and error messages to improve user experience.

## Note
- Ensure that the `Program.getDatabase()` method returns the appropriate database connection string for the application to connect to the database.
- This code assumes a Microsoft SQL Server database and may require adjustments for compatibility with other database systems.

# User Class README

## Overview
The User class is a fundamental component of the Jetter application, representing user entities within the system. It encapsulates user data such as user ID, username, password, email, role, first name, last name, phone number, address, and payment details.

## Properties
1. **UserID**: Unique identifier for the user.
2. **Username**: User's chosen username for authentication.
3. **Password**: User's password for authentication.
4. **Email**: User's email address for communication and identification.
5. **Role**: User's role within the system, determining access rights and permissions.
6. **FirstName**: User's first name.
7. **LastName**: User's last name.
8. **PhoneNumber**: User's phone number for communication.
9. **Address**: User's physical address.
10. **PaymentDetails**: Additional details related to user payments.

## Usage
1. **Initialization**: Create instances of the User class to represent individual users within the application.
2. **Data Manipulation**: Access and manipulate user data through the properties provided by the User class.
3. **Integration**: Utilize User objects within other components of the application for user authentication, data retrieval, and user-specific operations.

## Customization
- **Additional Properties**: Extend the User class with additional properties as needed to accommodate new user data requirements.
- **Validation**: Implement validation logic within the User class to enforce data integrity and consistency.
- **Methods**: Add methods to the User class for specific user-related operations, such as password hashing or role-based authorization.

## Note
- The User class serves as a representation of user entities and does not directly interact with the database. Database interaction is typically handled through data access layers or ORM frameworks.

# Vendor Class README

## Overview
The Vendor class is a fundamental component of the Jetter application, representing vendor entities within the system. It encapsulates vendor data such as vendor ID, vendor name, contact person, email, phone number, address, and vendor password.

## Properties
1. **VendorID**: Unique identifier for the vendor.
2. **VendorName**: Name of the vendor or vendor organization.
3. **ContactPerson**: Name of the primary contact person for the vendor.
4. **Email**: Email address associated with the vendor for communication and identification.
5. **PhoneNumber**: Phone number associated with the vendor for communication.
6. **Address**: Physical address of the vendor.
7. **VendorPassword**: Password associated with the vendor for authentication and access control.

## Usage
1. **Initialization**: Create instances of the Vendor class to represent individual vendors within the application.
2. **Data Manipulation**: Access and manipulate vendor data through the properties provided by the Vendor class.
3. **Integration**: Utilize Vendor objects within other components of the application for vendor management, data retrieval, and vendor-specific operations.

## Customization
- **Additional Properties**: Extend the Vendor class with additional properties as needed to accommodate new vendor data requirements.
- **Validation**: Implement validation logic within the Vendor class to enforce data integrity and consistency.
- **Methods**: Add methods to the Vendor class for specific vendor-related operations, such as password hashing or authentication checks.

## Note
- The Vendor class serves as a representation of vendor entities and does not directly interact with the database. Database interaction is typically handled through data access layers or ORM frameworks.

# Vendor Login Form README

## Overview
The Vendor Login form is a part of the Jetter application, allowing registered vendors to log in to their accounts. It provides functionality for vendors to authenticate themselves using their vendor name, email, and password.

## Functionality
- **Registration Option**: Allows new vendors to navigate to the vendor registration form to create a new account.
- **Authentication**: Validates vendor credentials (vendor name, email, password) against stored data in the system.
- **Login Process**: Upon successful authentication, vendors are redirected to the vendor window to access vendor-specific functionalities.
- **Password Visibility**: Enables vendors to toggle password visibility for entering their password securely.
- **Navigation**: Provides options to return to the main login page or navigate to the vendor registration form.

## Dependencies
- **System.Windows.Forms**: Provides classes for creating Windows-based applications with rich UI.

## Usage
1. **Login**: Enter vendor name, email, and password in the respective fields.
2. **Toggle Password Visibility**: Click the eye icon to toggle password visibility for secure entry.
3. **Login Button**: Click the 'Log In' button to submit the login credentials for authentication.
4. **Registration Option**: Click the 'Register' button to navigate to the vendor registration form to create a new account.
5. **Back Button**: Click the 'Back' button to return to the main login page.

## Note
- The Vendor Login form interacts with the authentication module to verify vendor credentials against stored data in the system.
- Ensure proper integration with the authentication module to handle authentication logic securely.
- This README provides an overview of the Vendor Login form, its functionality, usage instructions, and navigation options.

# Vendor Payments Form README

## Overview
The Vendor Payments form is a part of the Jetter application, designed to display payment information specific to a vendor. It provides functionality to retrieve and display both pending and confirmed payments associated with the vendor.

## Functionality
- **Data Retrieval**: Retrieves payment information from the database based on the vendor's ID.
- **Display**: Populates a DataGridView with payment details, including payment ID, booking ID, amount, payment date, payment status, and payment method.
- **Pending Payments**: Displays the count and sum of pending payments for the vendor.
- **Confirmed Payments**: Displays the count and sum of confirmed payments for the vendor.

## Methods
1. **PopulateDataGridView()**: Retrieves payment information from the database and populates the DataGridView.
2. **GetPendingPaymentsInfoForVendor()**: Retrieves the count and sum of pending payments for the vendor from the database.
3. **GetConfirmedPaymentsInfoForVendor()**: Retrieves the count and sum of confirmed payments for the vendor from the database.

## Dependencies
- **System.Data.SqlClient**: Provides classes for accessing SQL Server databases.
- **System.Windows.Forms**: Provides classes for creating Windows-based applications with rich UI.

## Usage
1. **Initialization**: Instantiate the VendorPayments form with a Vendor object representing the logged-in vendor.
2. **Display**: View the pending and confirmed payments associated with the vendor.
3. **Data Analysis**: Use the displayed payment information for financial analysis and tracking.

## Note
- The Vendor Payments form interacts with the database to retrieve payment information specific to the logged-in vendor.
- Ensure proper database connectivity and permissions for accessing payment data.
- This README provides an overview of the Vendor Payments form, its functionality, methods, and usage instructions.

# Vendor Window Form README

## Overview
The Vendor Window form is a part of the Jetter application, providing a user interface for vendors to access various functionalities related to their vendor accounts. It allows vendors to view and manage their payments, assets, and perform actions such as deleting their vendor account or signing out.

## Functionality
- **Display**: Displays a welcome message with the vendor's name upon initialization.
- **Navigation**: Provides options to navigate to different functionalities:
  - **Payments**: Opens the Vendor Payments form to view payment details.
  - **Assets**: Opens the Edit Assets form to manage vendor assets.
  - **Delete**: Allows vendors to delete their vendor account after confirmation.
  - **Sign Out**: Logs the vendor out of their account and returns to the main login page.
- **Deletion Confirmation**: Prompts the vendor to confirm the deletion of their account before proceeding.
- **Database Interaction**: Deletes the vendor record from the database upon confirmation.

## Methods
- **payments_Click()**: Opens the Vendor Payments form when the "Payments" button is clicked.
- **assets_Click()**: Opens the Edit Assets form when the "Assets" button is clicked.
- **delete_Click()**: Deletes the vendor account upon confirmation when the "Delete" button is clicked.
- **sign_out_Click()**: Logs the vendor out of their account and returns to the main login page when the "Sign Out" button is clicked.

## Dependencies
- **System.Data.SqlClient**: Provides classes for accessing SQL Server databases.

## Usage
1. **Initialization**: Instantiate the VendorWindow form with a Vendor object representing the logged-in vendor.
2. **Navigation**: Click on the respective buttons to access payment details, manage assets, delete the vendor account, or sign out.

## Note
- Ensure proper database connectivity and permissions for accessing and modifying vendor data.
- Handle deletion of vendor accounts with caution as it is irreversible.
- This README provides an overview of the Vendor Window form, its functionality, methods, and usage instructions.

# Your Bookings Form README

## Overview
The Your Bookings form is a part of the Jetter application, providing a user interface for users to view their booked assets. It displays information about the assets the user has booked, including the booking ID, asset ID, type, location, daily rate, start date, end date, total amount, and booking status.

## Functionality
- **Display**: Retrieves and displays the user's bookings from the database upon initialization.
- **Back**: Allows users to navigate back to the main Bookings form.
- **Delete**: Opens the Delete Booking form, allowing users to delete a selected booking.

## Methods
- **Load(object sender, EventArgs e)**: Retrieves the user's bookings from the database and populates the DataGridView upon form initialization.
- **back_Click()**: Hides the current form and navigates back to the main Bookings form when the "Back" button is clicked.
- **delete_Click()**: Opens the Delete Booking form when the "Delete" button is clicked.

## Dependencies
- **System.Data.SqlClient**: Provides classes for accessing SQL Server databases.

## Usage
1. **Initialization**: Instantiate the YourBookings form with a User object representing the logged-in user.
2. **Display**: Upon initialization, the form retrieves and displays the user's bookings.
3. **Navigation**: Click the "Back" button to return to the main Bookings form.
4. **Delete Booking**: Click the "Delete" button to open the Delete Booking form, allowing users to delete a selected booking.

## Note
- Ensure proper database connectivity and permissions for accessing user booking data.
- Handle deletion of bookings with caution as it may impact the user's records and bookings.
- This README provides an overview of the Your Bookings form, its functionality, methods, and usage instructions.

