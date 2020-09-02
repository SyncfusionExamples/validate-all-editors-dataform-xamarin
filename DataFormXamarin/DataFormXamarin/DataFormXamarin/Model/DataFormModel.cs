using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataFormXamarin
{
    public class DataFormModel
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string newPassword;
        private string confirmPassword;
        private string comments;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Value should not be empty")]
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Value should not be empty")]
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Value should not be empty")]
        public string NewPassword
        {
            get { return newPassword; }
            set { newPassword = value; }
        }

        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Value should not be empty")]
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set { confirmPassword = value; }
        }
    }
}
