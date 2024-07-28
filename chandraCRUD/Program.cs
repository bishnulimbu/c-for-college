// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//add three button in the form named student record.
//register button = buttonRegister name.
//Edit
//Remove
//arrange the dimension of the buttons from format
//then create datagreedview from all windows forms.(right above the buttons.)
//then open sql then, 
//tools, connect to db then select the correct option then click ok.
//

using System;



namespace chandraCRUD
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
    }

}

//then goto regiter bock then eit there.
//project add new form then name if ("newstudentfrom").
//add texts and input fields from textbox.

//rigister block
{
    NewStudentForm form = new NewStudentForm();
    form.ShowDialog();
}
//also change the anchor for making the gridbox responsive
//button right and button only buttom only for the middle and so on
