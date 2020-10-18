The array is a string array of student ID's.

The student number lookup must use an Array to contain the student ID numbers. And the array must be used to lookup/verify if the student ID exists in the array.

Once an Student ID has been validated, it must not be allowed to be changed until the PIN process is completed and the Clear Student ID button is clicked.

Changing which button is the Accept button, in code when you move from Student ID Verification to PIN Verification and then when clearing back to Student ID verification

The Cancel button will remain the "Clear Student ID" button

The Groupbox contianing the PIN options should be hidden (not Visible) and disabled when the Student ID has not been validated.

Use Key Press/Key Down code for the Student ID TextBox and the PIN Number TextBox

Use a MessageBox in the Form Load event to display the instructions to the user on how to use this program

Use the LIKE operator to validate the users input to ensure they are in the correct format/type for both the Student ID and PIN.

Create a ClearAll() sub to be called by the "Clear Student ID" button that clears all of the input/output areas set focus back to the Student TextBox, clears and resets any other values/variables as needed or appropriate. The only entry that should be found in the "Clear Student ID" button click event should be a call to the ClearAll() sub which recieves NO paramters passed in.


